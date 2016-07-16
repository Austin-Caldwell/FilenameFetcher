namespace FilenameFetcher
{
    partial class FilenameFetcherGUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ListFilenames = new System.Windows.Forms.ListBox();
            this.BtnListFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveListAsTextFile = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ListFilenames
            // 
            this.ListFilenames.AccessibleDescription = "List of filenames";
            this.ListFilenames.AccessibleName = "Filename List";
            this.ListFilenames.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.ListFilenames.Dock = System.Windows.Forms.DockStyle.Right;
            this.ListFilenames.FormattingEnabled = true;
            this.ListFilenames.Location = new System.Drawing.Point(300, 0);
            this.ListFilenames.Name = "ListFilenames";
            this.ListFilenames.Size = new System.Drawing.Size(284, 561);
            this.ListFilenames.TabIndex = 0;
            // 
            // BtnListFiles
            // 
            this.BtnListFiles.AccessibleDescription = "Click to fetch filenames from given Windows directory.";
            this.BtnListFiles.AccessibleName = "Fetch Filenames Button";
            this.BtnListFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnListFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListFiles.Location = new System.Drawing.Point(76, 300);
            this.BtnListFiles.Name = "BtnListFiles";
            this.BtnListFiles.Size = new System.Drawing.Size(150, 23);
            this.BtnListFiles.TabIndex = 1;
            this.BtnListFiles.Text = "Fetch Filename List";
            this.BtnListFiles.UseVisualStyleBackColor = true;
            // 
            // btnSaveListAsTextFile
            // 
            this.btnSaveListAsTextFile.AccessibleDescription = "Save the list of filenames as a text document.";
            this.btnSaveListAsTextFile.AccessibleName = "Save List As Text Document";
            this.btnSaveListAsTextFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveListAsTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveListAsTextFile.Location = new System.Drawing.Point(76, 372);
            this.btnSaveListAsTextFile.Name = "btnSaveListAsTextFile";
            this.btnSaveListAsTextFile.Size = new System.Drawing.Size(150, 45);
            this.btnSaveListAsTextFile.TabIndex = 2;
            this.btnSaveListAsTextFile.Text = "Save List as .txt Document";
            this.btnSaveListAsTextFile.UseVisualStyleBackColor = true;
            // 
            // FilenameFetcherGUI
            // 
            this.AccessibleDescription = "Fetch the filenames of all files in a given Windows directory.";
            this.AccessibleName = "FilenameFetcher";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.btnSaveListAsTextFile);
            this.Controls.Add(this.BtnListFiles);
            this.Controls.Add(this.ListFilenames);
            this.Name = "FilenameFetcherGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filename Fetcher v1.0";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox ListFilenames;
        private System.Windows.Forms.Button BtnListFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveListAsTextFile;
    }
}

