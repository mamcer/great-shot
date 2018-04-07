using System;
using System.Windows.Forms;
using GreatShot.Properties;

namespace GreatShot
{
    public partial class CreateFolder : Form
    {
        public CreateFolder(string folderName)
        {
            InitializeComponent();

            txtFolder.Text = folderName;
            txtFolder.Focus();
        }

        public string FolderName => txtFolder.Text;

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIsValid();
        }

        private void CheckIsValid()
        {
            string folderName = txtFolder.Text;
            if (!string.IsNullOrEmpty(folderName))
            {
                bool invalidName = folderName.Contains("\\") || folderName.Contains("/") || folderName.Contains(":") || folderName.Contains("*") || folderName.Contains("?") || folderName.Contains("<") || folderName.Contains(">") || folderName.Contains("|");
                if (!invalidName)
                {
                    DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show(Resources.InvalidNameMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        void txtFolder_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckIsValid();
            }
        }

    }
}