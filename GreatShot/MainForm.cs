using System;
using System.Collections.Specialized;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

using GreatShot.Data;
using GreatShot.Properties;

namespace GreatShot
{
    public partial class MainForm : Form
    {
        #region private properties

        private string[] PicturesPath { get; set; }

        private int ActualPictureIndex { get; set; }

        private string GreatShotFolderPath { get; set; }

        private string GreatShotUserFolderPath { get; set; }

        private string ActualPicturePath
        {
            get
            {
                if (PicturesPath != null && PicturesPath.Length > 0)
                {
                    return PicturesPath[ActualPictureIndex];
                }

                return string.Empty;
            }
        }

        private ILastFolderCollection LastFolderCollection
        {
            get
            {
                return XmlLastFolderCollection.Instance;
            }
        }

        #endregion

        #region constructor

        public MainForm()
        {
            InitializeComponent();
            GreatShotFolderPath = ConfigurationManager.AppSettings["GreatShotFolder"];
            if (string.IsNullOrEmpty(GreatShotFolderPath))
            {
                MessageBox.Show(Resources.InvalidFolderMessage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }

            if (!Directory.Exists(GreatShotFolderPath))
            {
                Directory.CreateDirectory(GreatShotFolderPath);
            }

            BuildLastFolderLinks();
        }

        #endregion

        #region private methods

        private void BuildLastFolderLinks()
        {
            int lastFolderCollectionCount = LastFolderCollection.Count();
            if (lastFolderCollectionCount > 0)
            {
                gbLastOpenFolders.Visible = true;
                lnkLastFolder01.Visible = lastFolderCollectionCount > 0;
                lnkLastFolder01.Text = LastFolderCollection.Get(0);
                lnkLastFolder02.Visible = lastFolderCollectionCount > 1;
                lnkLastFolder02.Text = LastFolderCollection.Get(1);
                lnkLastFolder03.Visible = lastFolderCollectionCount > 2;
                lnkLastFolder03.Text = LastFolderCollection.Get(2);
                lnkLastFolder04.Visible = lastFolderCollectionCount > 3;
                lnkLastFolder04.Text = LastFolderCollection.Get(3);
                lnkLastFolder05.Visible = lastFolderCollectionCount > 4;
                lnkLastFolder05.Text = LastFolderCollection.Get(4);
            }
            else
            {
                gbLastOpenFolders.Dispose();
            }
        }

        private void LoadPictures(string folderPath)
        {
            ActualPictureIndex = -1;
            StringCollection sc = new StringCollection();
            sc.AddRange(Directory.GetFiles(folderPath, "*.jpg"));
            sc.AddRange(Directory.GetFiles(folderPath, "*.mov"));
            sc.AddRange(Directory.GetFiles(folderPath, "*.avi"));
            PicturesPath = new string[sc.Count];
            sc.CopyTo(PicturesPath, 0);
            if (PicturesPath.Length > 0)
            {
                lblHelp.Hide();                
                gbLastOpenFolders.Dispose();
                LastFolderCollection.Add(folderPath);
                EnableToolbar();
                ShowNextPicture();
            }
            else
            {
                MessageBox.Show(Resources.LoadPicturesNoImage, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void EnableToolbar()
        {
            btnPreviousImage.Enabled = true;
            btnNextImage.Enabled = true;
            btnCopyImage.Enabled = true;
            btnOpenDestinationFolder.Enabled = true;
            btnDeleteImage.Enabled = true;
        }

        private void ShowNextPicture()
        {
            if (PicturesPath != null && ActualPictureIndex < PicturesPath.Length - 1)
            {
                ActualPictureIndex += 1;
                LoadPicture();
            }
            else
            {
                if (string.IsNullOrEmpty(PicturesPath[ActualPictureIndex]))
                {
                    imgActualPicture.Image = null;
                }
            }
        }

        private void LoadPicture()
        {
            lblFileIndexCount.Text = $"{ActualPictureIndex + 1}/{PicturesPath.Length}";
            string fileName = Path.GetFileName(PicturesPath[ActualPictureIndex]);
            lblImageFileName.Text = $"{fileName}";
            imgActualPicture.Image = Resources.wait;
            imgActualPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            lblMovieFile01.Visible = false;
            lblMovieFile02.Visible = false;
            lblMovieFile03.Visible = false;
            if (string.IsNullOrEmpty(PicturesPath[ActualPictureIndex]))
            {
                imgActualPicture.Image = imgActualPicture.ErrorImage;
                imgActualPicture.SizeMode = PictureBoxSizeMode.CenterImage;
            }
            else
            {
                imgGreatShot.Visible = IsGreatShot(); 
                if (Path.GetExtension(PicturesPath[ActualPictureIndex]).ToLower() == ".jpg")
                {
                    imgActualPicture.CancelAsync();
                    imgActualPicture.LoadAsync(PicturesPath[ActualPictureIndex]);
                    lblImageProgress.Visible = true;
                }
                else
                {
                    imgActualPicture.Image = Resources.video;
                    imgActualPicture.SizeMode = PictureBoxSizeMode.CenterImage;
                    lblMovieFile01.Visible = true;
                    lblMovieFile02.Visible = true;
                    lblMovieFile03.Visible = true;
                    lblMovieFile03.Text = fileName;
                }
            }
        }

        private bool IsGreatShot()
        {
            string outputPictureFilePath = Path.Combine(GreatShotUserFolderPath, Path.GetFileName(PicturesPath[ActualPictureIndex]));
            return File.Exists(outputPictureFilePath);
        }

        private void ShowPreviousPicture()
        {
            if (PicturesPath != null && ActualPictureIndex > 0 && PicturesPath.Length > 0)
            {
                ActualPictureIndex -= 1;
                LoadPicture();
            }
            else
            {
                if (string.IsNullOrEmpty(PicturesPath[ActualPictureIndex]))
                {
                    imgActualPicture.SizeMode = PictureBoxSizeMode.CenterImage;
                    imgActualPicture.Image = imgActualPicture.ErrorImage;
                }
            }
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Right)
            {
                if (e.Modifiers == Keys.Control)
                {
                    RotateImage(1);
                }
                else
                {
                    ShowNextPicture();
                }
            }
            else if (e.KeyCode == Keys.Left)
            {
                if (e.Modifiers == Keys.Control)
                {
                    RotateImage(2);
                }
                else
                {
                    ShowPreviousPicture();
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {
                if (e.Modifiers == Keys.Alt)
                {
                    if (FormBorderStyle != FormBorderStyle.None)
                    {
                        FormBorderStyle = FormBorderStyle.None;
                        WindowState = FormWindowState.Maximized;
                    }
                    else
                    {
                        FormBorderStyle = FormBorderStyle.Sizable;
                        WindowState = FormWindowState.Normal;
                    }
                }
                else
                {
                    CopyGreatShot();
                }
            }
            else if (e.KeyCode == Keys.F12)
            {
                OpenDestinationFolder();
            }
            else if (e.KeyCode == Keys.F11)
            {
                string actualPicturesPath = ActualPicturePath;
                if (!string.IsNullOrEmpty(actualPicturesPath))
                {
                    Process.Start(actualPicturesPath);
                }
            }
            else if (e.KeyCode == Keys.F1)
            {
                ShowHelp();
            }
            else if (e.KeyCode == Keys.Escape)
            {
                if (MessageBox.Show(Resources.CloseApplicationMessage, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                {
                    Close();
                }
            }
            else if (e.KeyCode == Keys.G && e.Modifiers == Keys.Control)
            {
                if (PicturesPath != null && PicturesPath.Length > 0)
                {
                    GotoPicture gotoPicture = new GotoPicture(PicturesPath);
                    if (gotoPicture.ShowDialog(this) == DialogResult.OK)
                    {
                        ActualPictureIndex = gotoPicture.SelectedPictureIndex;
                        LoadPicture();
                    }
                }
            }
            else if (e.KeyCode == Keys.Delete)
            {
                if (e.Modifiers == Keys.Shift)
                {
                    if (MessageBox.Show(Resources.DeleteImageWarningMessage, Text, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == System.Windows.Forms.DialogResult.Yes)
                    {
                        File.Delete(ActualPicturePath);
                        PicturesPath[ActualPictureIndex] = string.Empty;
                        ShowNextPicture();
                    }
                }
                else
                {
                    DeleteGreatShot();
                }
            }
        }

        private void DeleteGreatShot()
        {
            if (File.Exists(Path.Combine(GreatShotUserFolderPath, Path.GetFileName(ActualPicturePath))))
            {
                File.Delete(Path.Combine(GreatShotUserFolderPath, Path.GetFileName(ActualPicturePath)));
            }
        }

        private void OpenDestinationFolder()
        {
            if (CreateGreatShotUserFolder())
            {
                Process.Start(GreatShotUserFolderPath);
            }
        }

        private void ShowHelp()
        {
            Help help = new Help();
            help.Show();
        }

        private void RotateImage(int angle)
        {
            Bitmap img = new Bitmap(imgActualPicture.Image);

            // Clockwise
            if (angle == 1)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipNone);
            }

            // Anti-Clockwise
            else if (angle == 2)
            {
                img.RotateFlip(RotateFlipType.Rotate90FlipXY);
            }

            img.Save(ActualPicturePath, System.Drawing.Imaging.ImageFormat.Jpeg);

            LoadPicture();
        }

        private void CopyGreatShot()
        {
            try
            {
                string outputPictureFilePath = Path.Combine(GreatShotUserFolderPath, Path.GetFileName(PicturesPath[ActualPictureIndex]));
                if (!File.Exists(outputPictureFilePath) && CreateGreatShotUserFolder())
                {
                    File.Copy(PicturesPath[ActualPictureIndex], outputPictureFilePath);
                }
            }
            catch (Exception ex)
            {
                Error error = new Error(ex);
                error.ShowDialog();
            }
        }

        void MainForm_DragDrop(object sender, DragEventArgs e)
        {
            string[] folders = ((string[])e.Data.GetData(DataFormats.FileDrop));
            if (folders != null && folders.Length > 0)
            {
                string folderPath = folders[0];
                if (!Directory.Exists(folderPath))
                {
                    folderPath = Path.GetDirectoryName(folders[0]);
                }

                OpenFolder(folderPath);
            }
        }

        private void OpenFolder(string folderPath)
        {
            if (SelectGreatShotFolder(folderPath))
            {
                LoadPictures(folderPath);
            }
        }

        private bool CreateGreatShotUserFolder()
        {
            if (!Directory.Exists(GreatShotUserFolderPath))
            {
                try
                {
                    Directory.CreateDirectory(GreatShotUserFolderPath);
                }
                catch
                {
                    MessageBox.Show(string.Format(Resources.ErrorCreatingFolderMessage, GreatShotUserFolderPath), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return false;
                }
            }

            return true;
        }

        private bool SelectGreatShotFolder(string folderPath)
        {
            string lastFolder = Path.GetFileName(folderPath);
            CreateFolder createFolder = new CreateFolder(lastFolder);
            if (Directory.Exists(Path.Combine(GreatShotFolderPath, lastFolder)) || createFolder.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GreatShotUserFolderPath = Path.Combine(GreatShotFolderPath, createFolder.FolderName);
                return true;
            }

            return false;
        }

        void MainForm_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Link;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        void imgActualPicture_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Error != null)
            {
                MessageBox.Show(string.Format(Resources.LoadImageErrorMessage, PicturesPath[ActualPictureIndex]), Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                imgActualPicture.SizeMode = PictureBoxSizeMode.Zoom;
            }

            lblImageProgress.Visible = false;
        }

        private void lnkLastFolder_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            LinkLabel link = sender as LinkLabel;
            if (link != null)
            {
                int lastOpenFolderIndex = Convert.ToInt32(link.Tag);
                string lastOpenFolderPath = LastFolderCollection.Get(lastOpenFolderIndex);
                if (Directory.Exists(lastOpenFolderPath))
                {
                    OpenFolder(lastOpenFolderPath);
                }
                else
                {
                    if (MessageBox.Show(string.Format(Resources.CannotOpenFolderMessage, LastFolderCollection.Get(lastOpenFolderIndex)), Text, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == System.Windows.Forms.DialogResult.Yes)
                    {
                        LastFolderCollection.Remove(lastOpenFolderIndex);
                        BuildLastFolderLinks();
                    }
                }
            }
        }

        void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            LastFolderCollection.Save();
        }

        private void btnOpenFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                OpenFolder(folderBrowserDialog.SelectedPath);
            }
        }

        private void btnPreviousImage_Click(object sender, EventArgs e)
        {
            ShowPreviousPicture();
        }

        private void btnNextImage_Click(object sender, EventArgs e)
        {
            ShowNextPicture();
        }

        private void btnCopyImage_Click(object sender, EventArgs e)
        {
            CopyGreatShot();
        }

        private void btnOpenDestinationFolder_Click(object sender, EventArgs e)
        {
            OpenDestinationFolder();
        }

        private void btnDeleteImage_Click(object sender, EventArgs e)
        {
            DeleteGreatShot();
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        #endregion
    }
}
