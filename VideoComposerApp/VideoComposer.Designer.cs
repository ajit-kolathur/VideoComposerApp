namespace VideoComposerApp
{
    partial class VideoComposer
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VideoComposer));
            songNameLabel = new Label();
            singerImagesLabel = new Label();
            posterLabel = new Label();
            additionalDetailsLabel = new Label();
            songNameText = new TextBox();
            additionalDetailsText = new TextBox();
            outputFolderLabel = new Label();
            outputFolderBrowser = new FolderBrowserDialog();
            singerImagesFileDialog = new OpenFileDialog();
            singerImagesButton = new Button();
            posterButton = new Button();
            outputFolderButton = new Button();
            postImageFileDialog = new OpenFileDialog();
            composeButton = new Button();
            songLabel = new Label();
            songButton = new Button();
            songFileDialog = new OpenFileDialog();
            progressBar = new ProgressBar();
            SuspendLayout();
            // 
            // songNameLabel
            // 
            songNameLabel.AutoSize = true;
            songNameLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songNameLabel.Location = new Point(17, 15);
            songNameLabel.Name = "songNameLabel";
            songNameLabel.Size = new Size(145, 32);
            songNameLabel.TabIndex = 0;
            songNameLabel.Text = "Song Name:";
            // 
            // singerImagesLabel
            // 
            singerImagesLabel.AutoSize = true;
            singerImagesLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            singerImagesLabel.Location = new Point(17, 120);
            singerImagesLabel.Name = "singerImagesLabel";
            singerImagesLabel.Size = new Size(170, 32);
            singerImagesLabel.TabIndex = 0;
            singerImagesLabel.Text = "Singer Images:";
            // 
            // posterLabel
            // 
            posterLabel.AutoSize = true;
            posterLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posterLabel.Location = new Point(17, 168);
            posterLabel.Name = "posterLabel";
            posterLabel.Size = new Size(84, 32);
            posterLabel.TabIndex = 0;
            posterLabel.Text = "Poster:";
            // 
            // additionalDetailsLabel
            // 
            additionalDetailsLabel.AutoSize = true;
            additionalDetailsLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            additionalDetailsLabel.Location = new Point(17, 211);
            additionalDetailsLabel.Name = "additionalDetailsLabel";
            additionalDetailsLabel.Size = new Size(207, 32);
            additionalDetailsLabel.TabIndex = 0;
            additionalDetailsLabel.Text = "Additional Details:";
            // 
            // songNameText
            // 
            songNameText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songNameText.Location = new Point(168, 12);
            songNameText.Name = "songNameText";
            songNameText.Size = new Size(620, 39);
            songNameText.TabIndex = 1;
            // 
            // additionalDetailsText
            // 
            additionalDetailsText.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            additionalDetailsText.Location = new Point(17, 258);
            additionalDetailsText.Multiline = true;
            additionalDetailsText.Name = "additionalDetailsText";
            additionalDetailsText.Size = new Size(771, 243);
            additionalDetailsText.TabIndex = 2;
            // 
            // outputFolderLabel
            // 
            outputFolderLabel.AutoSize = true;
            outputFolderLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputFolderLabel.Location = new Point(17, 579);
            outputFolderLabel.Name = "outputFolderLabel";
            outputFolderLabel.Size = new Size(169, 32);
            outputFolderLabel.TabIndex = 3;
            outputFolderLabel.Text = "Output Folder:";
            // 
            // singerImagesFileDialog
            // 
            singerImagesFileDialog.FileName = "openFileDialog1";
            // 
            // singerImagesButton
            // 
            singerImagesButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            singerImagesButton.Location = new Point(193, 115);
            singerImagesButton.Name = "singerImagesButton";
            singerImagesButton.Size = new Size(141, 42);
            singerImagesButton.TabIndex = 4;
            singerImagesButton.Text = "select";
            singerImagesButton.UseVisualStyleBackColor = true;
            singerImagesButton.Click += singerImagesButton_Click;
            // 
            // posterButton
            // 
            posterButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            posterButton.Location = new Point(107, 163);
            posterButton.Name = "posterButton";
            posterButton.Size = new Size(151, 42);
            posterButton.TabIndex = 4;
            posterButton.Text = "select";
            posterButton.UseVisualStyleBackColor = true;
            posterButton.Click += posterButton_Click;
            // 
            // outputFolderButton
            // 
            outputFolderButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            outputFolderButton.Location = new Point(192, 574);
            outputFolderButton.Name = "outputFolderButton";
            outputFolderButton.Size = new Size(142, 42);
            outputFolderButton.TabIndex = 4;
            outputFolderButton.Text = "select";
            outputFolderButton.UseVisualStyleBackColor = true;
            outputFolderButton.Click += outputFolderButton_Click;
            // 
            // postImageFileDialog
            // 
            postImageFileDialog.FileName = "openFileDialog1";
            // 
            // composeButton
            // 
            composeButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            composeButton.Location = new Point(566, 574);
            composeButton.Name = "composeButton";
            composeButton.Size = new Size(222, 42);
            composeButton.TabIndex = 4;
            composeButton.Text = "compose";
            composeButton.UseVisualStyleBackColor = true;
            composeButton.Click += composeButton_Click;
            // 
            // songLabel
            // 
            songLabel.AutoSize = true;
            songLabel.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songLabel.Location = new Point(17, 74);
            songLabel.Name = "songLabel";
            songLabel.Size = new Size(74, 32);
            songLabel.TabIndex = 0;
            songLabel.Text = "Song:";
            // 
            // songButton
            // 
            songButton.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            songButton.Location = new Point(88, 69);
            songButton.Name = "songButton";
            songButton.Size = new Size(144, 42);
            songButton.TabIndex = 4;
            songButton.Text = "select";
            songButton.UseVisualStyleBackColor = true;
            songButton.Click += songButton_Click;
            // 
            // songFileDialog
            // 
            songFileDialog.FileName = "openFileDialog1";
            // 
            // progressBar
            // 
            progressBar.Location = new Point(17, 520);
            progressBar.Name = "progressBar";
            progressBar.Size = new Size(771, 37);
            progressBar.TabIndex = 5;
            progressBar.Visible = false;
            // 
            // VideoComposer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 628);
            Controls.Add(progressBar);
            Controls.Add(composeButton);
            Controls.Add(outputFolderButton);
            Controls.Add(posterButton);
            Controls.Add(songButton);
            Controls.Add(singerImagesButton);
            Controls.Add(outputFolderLabel);
            Controls.Add(additionalDetailsText);
            Controls.Add(songNameText);
            Controls.Add(additionalDetailsLabel);
            Controls.Add(posterLabel);
            Controls.Add(singerImagesLabel);
            Controls.Add(songLabel);
            Controls.Add(songNameLabel);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "VideoComposer";
            Text = "VideoComposer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label songNameLabel;
        private Label singerImagesLabel;
        private Label posterLabel;
        private Label additionalDetailsLabel;
        private TextBox songNameText;
        private TextBox additionalDetailsText;
        private Label outputFolderLabel;
        private FolderBrowserDialog outputFolderBrowser;
        private OpenFileDialog singerImagesFileDialog;
        private Button singerImagesButton;
        private Button posterButton;
        private Button outputFolderButton;
        private OpenFileDialog postImageFileDialog;
        private Button composeButton;
        private Label songLabel;
        private Button songButton;
        private OpenFileDialog songFileDialog;
        private ProgressBar progressBar;
    }
}
