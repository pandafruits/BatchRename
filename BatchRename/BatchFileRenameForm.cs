using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BatchRename
{
    public partial class BatchFileRenameForm : Form
    {
        private FolderBrowserDialog folderBrowserDialog;
        private string folderPath;

        public BatchFileRenameForm()
        {
            InitializeComponent();

            this.folderBrowserDialog = new FolderBrowserDialog();
            // Set the help text description for the FolderBrowserDialog.
            this.folderBrowserDialog.Description =
                "Select the directory that contains the files to be renamed.";
            // Do not allow the user to create new files via the FolderBrowserDialog.
            this.folderBrowserDialog.ShowNewFolderButton = false;
            // Default to the My Computer folder.
            this.folderBrowserDialog.RootFolder = Environment.SpecialFolder.MyComputer;
        }

        private void buttonBrowse_Click(object sender, EventArgs e)
        {
            // Show the FolderBrowserDialog.
            DialogResult result = folderBrowserDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                folderPath = folderBrowserDialog.SelectedPath;
                labelFolderPath.Text = folderPath;
                string[] fileEntries = Directory.GetFiles(folderPath);
                foreach(string fileName in fileEntries)
                {
                    textBoxFileEntries.AppendText(Path.GetFileName(fileName) + Environment.NewLine);
                }
                buttonRename.Enabled = true;
            }
        }

        private void buttonRename_Click(object sender, EventArgs e)
        {
            try
            {
                string oldString = textBoxOldName.Text;
                string newString = textBoxNewName.Text;

                textBoxFileEntries.Clear();

                string[] fileEntries = Directory.GetFiles(folderPath);
                foreach (string fileName in fileEntries)
                {
                    string path = Path.GetDirectoryName(fileName);
                    string oldName = Path.GetFileName(fileName);

                    string newName = oldName.Replace(oldString, newString);
                    string newFileName = Path.Combine(path, newName);

                    File.Move(fileName, newFileName);
                }

                fileEntries = Directory.GetFiles(folderPath);
                foreach (string fileName in fileEntries)
                {
                    textBoxFileEntries.AppendText(Path.GetFileName(fileName) + Environment.NewLine);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Something went wrong!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
