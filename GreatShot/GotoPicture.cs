using System.IO;
using System.Windows.Forms;

namespace GreatShot
{
    public partial class GotoPicture : Form
    {
        public int SelectedPictureIndex => lstPictures.SelectedIndex;

        public GotoPicture(string[] picturesPath)
        {
            InitializeComponent();

            foreach (string picturePath in picturesPath)
            {
                lstPictures.Items.Add(Path.GetFileName(picturePath));
            }
        }

        private void lstPictures_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
            }

            if (e.KeyCode == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }

        private void GotoPicture_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Escape)
            {
                DialogResult = DialogResult.Cancel;
            }
        }
    }
}