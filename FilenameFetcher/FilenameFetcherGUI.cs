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
        string fileType = "*.*";    // Specifies file types to limit results from filename fetch

        public FilenameFetcherGUI()
        {
            InitializeComponent();
        }

        private void BtnListFiles_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult directorySelected = folderBrowserDialog1.ShowDialog();     // Allow the user to specify a directory from which to "fetch" filenames

                if (directorySelected == DialogResult.OK)
                {
                    MessageBox.Show("Selected Directory:\n" + folderBrowserDialog1.SelectedPath.ToString());

                    // Gather all filenames with the specified "fileType" extension from the specified directory and store them in a string array
                    // Example: http://www.csharp-examples.net/get-files-from-directory/
                    string[] filenames = Directory.GetFileSystemEntries(directorySelected.ToString(), fileType);
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
    }
}
