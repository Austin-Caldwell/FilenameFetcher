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
            this.listFilenames = new System.Windows.Forms.ListBox();
            this.BtnListFiles = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.btnSaveListAsTextFile = new System.Windows.Forms.Button();
            this.comboBoxFileType = new System.Windows.Forms.ComboBox();
            this.lblFileTypeFilter = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listFilenames
            // 
            this.listFilenames.AccessibleDescription = "List of filenames";
            this.listFilenames.AccessibleName = "Filename List";
            this.listFilenames.AccessibleRole = System.Windows.Forms.AccessibleRole.List;
            this.listFilenames.Dock = System.Windows.Forms.DockStyle.Right;
            this.listFilenames.FormattingEnabled = true;
            this.listFilenames.Location = new System.Drawing.Point(300, 0);
            this.listFilenames.Name = "listFilenames";
            this.listFilenames.Size = new System.Drawing.Size(284, 414);
            this.listFilenames.TabIndex = 0;
            // 
            // BtnListFiles
            // 
            this.BtnListFiles.AccessibleDescription = "Click to fetch filenames from given Windows directory.";
            this.BtnListFiles.AccessibleName = "Fetch Filenames Button";
            this.BtnListFiles.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.BtnListFiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnListFiles.Location = new System.Drawing.Point(76, 200);
            this.BtnListFiles.Name = "BtnListFiles";
            this.BtnListFiles.Size = new System.Drawing.Size(150, 60);
            this.BtnListFiles.TabIndex = 1;
            this.BtnListFiles.Text = "Fetch Filename List from Directory (Folder)";
            this.BtnListFiles.UseVisualStyleBackColor = true;
            this.BtnListFiles.Click += new System.EventHandler(this.BtnListFiles_Click);
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "Select a directory (folder) from which to fetch filenames.";
            this.folderBrowserDialog1.RootFolder = System.Environment.SpecialFolder.MyComputer;
            this.folderBrowserDialog1.ShowNewFolderButton = false;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.CheckFileExists = true;
            this.saveFileDialog1.DefaultExt = "txt";
            this.saveFileDialog1.Filter = "Text files (*.txt)|*.txt";
            this.saveFileDialog1.Title = "Save Filename List as Text Document";
            // 
            // btnSaveListAsTextFile
            // 
            this.btnSaveListAsTextFile.AccessibleDescription = "Save the list of filenames as a text document.";
            this.btnSaveListAsTextFile.AccessibleName = "Save List As Text Document";
            this.btnSaveListAsTextFile.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnSaveListAsTextFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveListAsTextFile.Location = new System.Drawing.Point(76, 342);
            this.btnSaveListAsTextFile.Name = "btnSaveListAsTextFile";
            this.btnSaveListAsTextFile.Size = new System.Drawing.Size(150, 60);
            this.btnSaveListAsTextFile.TabIndex = 2;
            this.btnSaveListAsTextFile.Text = "Save Filename List as Text Document";
            this.btnSaveListAsTextFile.UseVisualStyleBackColor = true;
            // 
            // comboBoxFileType
            // 
            this.comboBoxFileType.AccessibleDescription = "Select a file type by which to filter results.";
            this.comboBoxFileType.AccessibleName = "File Type Selector";
            this.comboBoxFileType.AccessibleRole = System.Windows.Forms.AccessibleRole.ComboBox;
            this.comboBoxFileType.FormattingEnabled = true;
            this.comboBoxFileType.Location = new System.Drawing.Point(76, 51);
            this.comboBoxFileType.Name = "comboBoxFileType";
            this.comboBoxFileType.Size = new System.Drawing.Size(150, 21);
            this.comboBoxFileType.TabIndex = 1;
            this.comboBoxFileType.SelectedIndexChanged += new System.EventHandler(this.comboBoxFileType_SelectedIndexChanged);
            // 
            // lblFileTypeFilter
            // 
            this.lblFileTypeFilter.AccessibleDescription = "Select a file type by which to filter results.";
            this.lblFileTypeFilter.AccessibleName = "File Type Filter Label";
            this.lblFileTypeFilter.AutoSize = true;
            this.lblFileTypeFilter.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileTypeFilter.Location = new System.Drawing.Point(76, 32);
            this.lblFileTypeFilter.Name = "lblFileTypeFilter";
            this.lblFileTypeFilter.Size = new System.Drawing.Size(146, 13);
            this.lblFileTypeFilter.TabIndex = 0;
            this.lblFileTypeFilter.Text = "Filter results by file type:";
            // 
            // FilenameFetcherGUI
            // 
            this.AccessibleDescription = "Fetch the filenames of all files in a given Windows directory.";
            this.AccessibleName = "FilenameFetcher";
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.Window;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 414);
            this.Controls.Add(this.lblFileTypeFilter);
            this.Controls.Add(this.comboBoxFileType);
            this.Controls.Add(this.btnSaveListAsTextFile);
            this.Controls.Add(this.BtnListFiles);
            this.Controls.Add(this.listFilenames);
            this.Name = "FilenameFetcherGUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filename Fetcher v1.0";
            this.Load += new System.EventHandler(this.FilenameFetcherGUI_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listFilenames;
        private System.Windows.Forms.Button BtnListFiles;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button btnSaveListAsTextFile;
        private System.Windows.Forms.ComboBox comboBoxFileType;
        private System.Windows.Forms.Label lblFileTypeFilter;
    }
}

