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
            fileTypes.Add(new FileType() { FileTypeName = "CSV (Comma Separated Lists)", Extension = "*.csv" });
            fileTypes.Add(new FileType() { FileTypeName = "DOC (Word Documents)", Extension = "*.doc" });
            fileTypes.Add(new FileType() { FileTypeName = "DOCX (Word Documents)", Extension = "*.docx" });
            fileTypes.Add(new FileType() { FileTypeName = "JPEG (Photos)", Extension = "*.jpeg" });
            fileTypes.Add(new FileType() { FileTypeName = "JPG (Photos)", Extension = "*.jpg" });
            fileTypes.Add(new FileType() { FileTypeName = "PDF (PDF Documents)", Extension = "*.pdf" });
            fileTypes.Add(new FileType() { FileTypeName = "PNG (Photos)", Extension = "*.png" });
            fileTypes.Add(new FileType() { FileTypeName = "PPT (Powerpoint Presentations)", Extension = "*.ppt" });
            fileTypes.Add(new FileType() { FileTypeName = "PPTX (Powerpoint Presentations)", Extension = "*.pptx" });
            fileTypes.Add(new FileType() { FileTypeName = "XLS (Excel Workbooks)", Extension = "*.xlsx" });
            fileTypes.Add(new FileType() { FileTypeName = "XLSX (Excel Workbooks)", Extension = "*.xls" });

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

        private void comboBoxFileType_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedFileExtension = comboBoxFileType.SelectedValue.ToString();  // Change the filetype extension used to filter search results.
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

        private void btnSaveListAsTextFile_Click(object sender, EventArgs e)
        {
            List<string> filenamesForSaveToFile = new List<string>();     // Create a list to hold all the filenames selected for saving to a text document.

            if (listFilenames.SelectedIndices.Count > 0)
            {
                // Loop through selected items in the listBox of filenames and add every selected filename to the list for saving to a text file.
                // EXAMPLE: http://stackoverflow.com/questions/1586078/getting-all-selected-values-from-an-asp-listbox -- Thanks to Ahmad Mageed
                foreach (int selectedFilename in listFilenames.SelectedIndices)
                {
                    filenamesForSaveToFile.Add(listFilenames.Items[selectedFilename].ToString());
                }
                
                try
                {
                    // Perform the actual writing of filenames to a text document.
                    File.WriteAllLines(@"C:\WriteLines.txt", filenamesForSaveToFile);
                }
                catch (Exception ex)
                {
                    // Failed to write filenames to text document file.
                    MessageBox.Show("Error writing filenames to text document: " + ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Error: Must select at least 1 (one) filename result from list to save to a text file.");
            }
        }

        private void checkBoxSelectAllFilenames_CheckedChanged(object sender, EventArgs e)
        {
            bool checkboxIsChecked = checkBoxSelectAllFilenames.Checked;
            if (checkboxIsChecked)
            {
                // If the checkBox is checked, Select All Items in the Filenames ListBox
                // Example: http://stackoverflow.com/questions/934241/listbox-select-all-items -- Thanks to George Stocker & Mehdi LAMRANI
                for (int i = 0; i < listFilenames.Items.Count; i++)
                {
                    listFilenames.SetSelected(i, true);
                }
            }
            else
            {
                // If the checkBox is not (or no longer) checked, Deselect All Items in the Filenames ListBox
                for (int i = 0; i < listFilenames.Items.Count; i++)
                {
                    listFilenames.SetSelected(i, false);
                }
            }
        }
    }
}