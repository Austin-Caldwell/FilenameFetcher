using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FilenameFetcher
{
    public partial class FilenameFetcherGUI : Form
    {
        private List<FileType> fileTypes = new List<FileType>();    // List of supported file types for filtering results
        private string selectedFileExtension;    // Specifies file types to limit results from filename fetch

        public FilenameFetcherGUI()
        {
            // Build the List of FileTypes that can be "fetched"
            fileTypes.Add(new FileType() { FileTypeName = "All Files", Extension = "*.*" });
            fileTypes.Add(new FileType() { FileTypeName = "DOC (Word Documents)", Extension = "*.doc" });
            fileTypes.Add(new FileType() { FileTypeName = "DOCX (Word Documents)", Extension = "*.docx" });
            fileTypes.Add(new FileType() { FileTypeName = "JPEG (Photos)", Extension = "*.jpeg" });
            fileTypes.Add(new FileType() { FileTypeName = "JPG (Photos)", Extension = "*.jpg" });
            fileTypes.Add(new FileType() { FileTypeName = "PDF (PDF Documents)", Extension = "*.pdf" });

            // Start the GUI
            InitializeComponent();
        }

        private void FilenameFetcherGUI_Load(object sender, EventArgs e)
        {
            // Bind Data to ComboBox for FileTypes
            comboBoxFileType.DisplayMember = "FileTypeName";
            comboBoxFileType.ValueMember = "Extension";
            comboBoxFileType.DataSource = fileTypes;

            // Make FileType ComboBox Read-Only
            comboBoxFileType.DropDownStyle = ComboBoxStyle.DropDownList;

            // Set Default File Type
            selectedFileExtension = "*.*";       // Set default file type selection to "All Files" (*.*)
        }

        private void BtnListFiles_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult directory = folderBrowserDialog1.ShowDialog();     // Allow the user to specify a directory from which to "fetch" filenames

                if (directory == DialogResult.OK)
                {
                    string directorySelected = folderBrowserDialog1.SelectedPath.ToString();
                    MessageBox.Show("Selected Directory:\n" + directorySelected + "\n\n Selected file type (extension): " + selectedFileExtension);

                    // Gather all filenames with the specified "fileType" extension from the specified directory and store them in a string array
                    // Example: http://www.csharp-examples.net/get-files-from-directory/
                    // Example: http://stackoverflow.com/questions/7140081/how-to-get-only-filenames-within-a-directory-using-c -- Thanks to Thomas Levesque
                    List<string> filenames = Directory.GetFileSystemEntries(directorySelected, selectedFileExtension).Select(path => Path.GetFileNameWithoutExtension(path)).ToList<string>();

                    //// EXPERIMENTING WITH REMOVING HIDDEN FILES FROM RESULTS - 07/17/2016
                    //DirectoryInfo directoryFiles = new DirectoryInfo(directorySelected);
                    //var files = directoryFiles.GetFiles(selectedFileExtension);

                    //foreach (var file in files)
                    //{
                    //    if (file.Attributes.Equals("Hidden, System"))
                    //    {
                    //        // Do not include file in list, as it is a HIDDEN file
                    //    }
                    //}
                    //// END EXPERIMENTING

                    // Remove Hidden System Files from the list of results.
                    foreach (string filename in filenames)
                    {
                        if (filename.EndsWith(".ini"))
                        {
                            filenames.Remove(filename);
                        }
                    }

                    // If the list of filenames is empty (no matching files found), notify the user that no results were found.
                    if (filenames.Count == 0)
                    {
                        MessageBox.Show("No files with the file type extension " + selectedFileExtension + " were found!");
                    }

                    // Fill the listBox with filename results and refresh the listBox display just to be sure the correct data is shown.
                    listFilenames.DataSource = filenames;
                    listFilenames.Refresh();
                }
                else
                {
                    MessageBox.Show("Unable To Open Selected Directory");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
        }

        private void comboBoxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFileExtension = comboBoxFileType.SelectedValue.ToString();
        }
    }
}