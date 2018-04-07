using System;
using System.Windows.Forms;

namespace GreatShot.UI
{
    public partial class Error : Form
    {
        public Error(Exception ex)
        {
            InitializeComponent();

            txtError.Text = $"{ex.Message}\n\n{(ex.InnerException != null ? ex.InnerException.Message : string.Empty)}";
            Text = Application.ProductName;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkCopyToClipboard_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Clipboard.SetText(txtError.Text);
        }
    }
}