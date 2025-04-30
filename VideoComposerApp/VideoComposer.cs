using System.Diagnostics;
using System.Text;
using FFMpegCore;

namespace VideoComposerApp
{
    public partial class VideoComposer : Form
    {
        // Fields
        private string songFilePath = string.Empty;
        private string[] singerImagesPaths = Array.Empty<string>();
        private string posterImagePath = string.Empty;
        private string outputFolderPath = string.Empty;


        public VideoComposer()
        {
            InitializeComponent();
        }

        private void songButton_Click(object sender, EventArgs e)
        {
            using (var openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Audio/Video Files|*.mp3;*.mp4";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    songFilePath = openFileDialog.FileName;
                    songButton.Text = "Selected";
                    MessageBox.Show($"Song selected: {Path.GetFileName(songFilePath)}");
                }
            }
        }

        private void singerImagesButton_Click(object sender, EventArgs e)
        {
            singerImagesFileDialog.Multiselect = true;
            singerImagesFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (singerImagesFileDialog.ShowDialog() == DialogResult.OK)
            {
                singerImagesPaths = singerImagesFileDialog.FileNames;
                singerImagesButton.Text = "Selected";
                MessageBox.Show($"Selected {singerImagesPaths.Length} singer image(s).");
            }
        }

        private void posterButton_Click(object sender, EventArgs e)
        {
            postImageFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

            if (postImageFileDialog.ShowDialog() == DialogResult.OK)
            {
                posterImagePath = postImageFileDialog.FileName;
                posterButton.Text = "Selected";
                MessageBox.Show($"Poster selected: {Path.GetFileName(posterImagePath)}");
            }
        }

        private void outputFolderButton_Click(object sender, EventArgs e)
        {
            if (outputFolderBrowser.ShowDialog() == DialogResult.OK)
            {
                outputFolderPath = outputFolderBrowser.SelectedPath;
                outputFolderButton.Text = "Selected";
                MessageBox.Show($"Output folder selected: {outputFolderPath}");
            }
        }

        private async void composeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Validate
                if (string.IsNullOrWhiteSpace(songNameText.Text) ||
                    string.IsNullOrWhiteSpace(songFilePath) ||
                    singerImagesPaths.Length == 0 ||
                    string.IsNullOrWhiteSpace(posterImagePath) ||
                    string.IsNullOrWhiteSpace(outputFolderPath))
                {
                    MessageBox.Show("Please fill in all fields and select all required files.");
                    return;
                }

                // 1. Write template file
                string templateFilePath = Path.Combine(outputFolderPath, $"{songNameText.Text}_template.txt");
                using (StreamWriter sw = new StreamWriter(templateFilePath, false, Encoding.UTF8))
                {
                    sw.WriteLine($"Song: {songNameText.Text}");

                    var imageNames = singerImagesPaths.Select(path => path.Replace("\\", "/")); // use forward slashes
                    sw.WriteLine("Singers Images: " + string.Join(", ", imageNames));

                    sw.WriteLine("Poster Image: " + posterImagePath.Replace("\\", "/"));

                    if (!string.IsNullOrWhiteSpace(additionalDetailsText.Text))
                    {
                        sw.WriteLine();
                        sw.WriteLine("# Additional Details");
                        sw.WriteLine(additionalDetailsText.Text.Trim());
                    }
                }

                // 2. Launch SlideShowGenerator.exe
                string exePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "SlideShowGenerator.exe");

                if (!File.Exists(exePath))
                {
                    MessageBox.Show($"Cannot find SlideShowGenerator.exe at: {exePath}");
                    return;
                }

                string arguments = $"--song_file \"{songFilePath}\" --song_template \"{templateFilePath}\" --output_path \"{outputFolderPath}\"";

                var process = new Process
                {
                    StartInfo = new ProcessStartInfo
                    {
                        FileName = exePath,
                        Arguments = arguments,
                        UseShellExecute = false,
                        RedirectStandardOutput = true,
                        RedirectStandardError = true,
                        CreateNoWindow = true
                    }
                };

                // Show progress (optional)
                composeButton.Enabled = false;
                composeButton.Text = "Composing...";

                process.OutputDataReceived += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(ev.Data))
                    {
                        Console.WriteLine("[stdout] " + ev.Data);

                        if (ev.Data.Contains('%'))
                        {
                            // Try to extract a percentage like "25%" from line
                            var percentMatch = System.Text.RegularExpressions.Regex.Match(ev.Data, @"(\d{1,3})%");
                            if (percentMatch.Success && int.TryParse(percentMatch.Groups[1].Value, out int percent))
                            {
                                progressBar.Invoke(() => progressBar.Value = Math.Min(percent, 100));
                            }
                        }
                    }
                };
                process.ErrorDataReceived += (s, ev) =>
                {
                    if (!string.IsNullOrEmpty(ev.Data))
                    {
                        Console.WriteLine("[stderr] " + ev.Data);

                        if (ev.Data.Contains('%'))
                        {
                            // Try to extract a percentage like "25%" from line
                            var percentMatch = System.Text.RegularExpressions.Regex.Match(ev.Data, @"(\d{1,3})%");
                            if (percentMatch.Success && int.TryParse(percentMatch.Groups[1].Value, out int percent))
                            {
                                progressBar.Invoke(() => progressBar.Value = Math.Min(percent, 100));
                            }
                        }
                    }
                };

                progressBar.Visible = true;
                progressBar.Value = 0;

                process.Start();
                process.BeginOutputReadLine();
                process.BeginErrorReadLine();
                await Task.Run(() => process.WaitForExit());

                progressBar.Value = 100;
                await Task.Delay(300); // show 100% momentarily
                progressBar.Visible = false;

                composeButton.Enabled = true;
                composeButton.Text = "Compose";

                if (process.ExitCode == 0)
                {
                    MessageBox.Show("🎉 Slideshow video created successfully!", "Success");

                    // Open the output folder
                    Process.Start("explorer.exe", outputFolderPath);
                }
                else
                {
                    MessageBox.Show($"❌ SlideShowGenerator.exe exited with code {process.ExitCode}", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred:\n" + ex.Message, "Error");
            }
        }
    }
}
