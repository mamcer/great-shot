namespace GreatShot
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.lblHelp = new System.Windows.Forms.Label();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.gbLastOpenFolders = new System.Windows.Forms.GroupBox();
            this.lnkLastFolder05 = new System.Windows.Forms.LinkLabel();
            this.lnkLastFolder04 = new System.Windows.Forms.LinkLabel();
            this.lnkLastFolder03 = new System.Windows.Forms.LinkLabel();
            this.lnkLastFolder02 = new System.Windows.Forms.LinkLabel();
            this.lnkLastFolder01 = new System.Windows.Forms.LinkLabel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnOpenFolder = new System.Windows.Forms.ToolStripButton();
            this.lblImageProgress = new System.Windows.Forms.ToolStripLabel();
            this.btnPreviousImage = new System.Windows.Forms.ToolStripButton();
            this.btnNextImage = new System.Windows.Forms.ToolStripButton();
            this.btnCopyImage = new System.Windows.Forms.ToolStripButton();
            this.btnOpenDestinationFolder = new System.Windows.Forms.ToolStripButton();
            this.btnDeleteImage = new System.Windows.Forms.ToolStripButton();
            this.btnHelp = new System.Windows.Forms.ToolStripButton();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.lblImageFileName = new System.Windows.Forms.ToolStripLabel();
            this.lblFileIndexCount = new System.Windows.Forms.ToolStripLabel();
            this.lblMovieFile01 = new System.Windows.Forms.Label();
            this.lblMovieFile02 = new System.Windows.Forms.Label();
            this.lblMovieFile03 = new System.Windows.Forms.Label();
            this.imgActualPicture = new System.Windows.Forms.PictureBox();
            this.imgGreatShot = new System.Windows.Forms.PictureBox();
            this.gbLastOpenFolders.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActualPicture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreatShot)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHelp
            // 
            this.lblHelp.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHelp.BackColor = System.Drawing.Color.White;
            this.lblHelp.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHelp.ForeColor = System.Drawing.Color.Black;
            this.lblHelp.Location = new System.Drawing.Point(130, 491);
            this.lblHelp.Name = "lblHelp";
            this.lblHelp.Size = new System.Drawing.Size(525, 34);
            this.lblHelp.TabIndex = 2;
            this.lblHelp.Text = "Press F1 for help.";
            this.lblHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbLastOpenFolders
            // 
            this.gbLastOpenFolders.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbLastOpenFolders.BackColor = System.Drawing.Color.White;
            this.gbLastOpenFolders.Controls.Add(this.lnkLastFolder05);
            this.gbLastOpenFolders.Controls.Add(this.lnkLastFolder04);
            this.gbLastOpenFolders.Controls.Add(this.lnkLastFolder03);
            this.gbLastOpenFolders.Controls.Add(this.lnkLastFolder02);
            this.gbLastOpenFolders.Controls.Add(this.lnkLastFolder01);
            this.gbLastOpenFolders.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbLastOpenFolders.ForeColor = System.Drawing.Color.Black;
            this.gbLastOpenFolders.Location = new System.Drawing.Point(8, 36);
            this.gbLastOpenFolders.Name = "gbLastOpenFolders";
            this.gbLastOpenFolders.Size = new System.Drawing.Size(771, 224);
            this.gbLastOpenFolders.TabIndex = 9;
            this.gbLastOpenFolders.TabStop = false;
            this.gbLastOpenFolders.Text = "Last opened folders";
            this.gbLastOpenFolders.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.gbLastOpenFolders.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lnkLastFolder05
            // 
            this.lnkLastFolder05.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkLastFolder05.AutoSize = true;
            this.lnkLastFolder05.LinkColor = System.Drawing.Color.Black;
            this.lnkLastFolder05.Location = new System.Drawing.Point(7, 174);
            this.lnkLastFolder05.Name = "lnkLastFolder05";
            this.lnkLastFolder05.Size = new System.Drawing.Size(143, 25);
            this.lnkLastFolder05.TabIndex = 13;
            this.lnkLastFolder05.TabStop = true;
            this.lnkLastFolder05.Tag = "4";
            this.lnkLastFolder05.Text = "lnkLastFolder05";
            this.lnkLastFolder05.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFolder_LinkClicked);
            this.lnkLastFolder05.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lnkLastFolder05.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lnkLastFolder04
            // 
            this.lnkLastFolder04.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkLastFolder04.AutoSize = true;
            this.lnkLastFolder04.LinkColor = System.Drawing.Color.Black;
            this.lnkLastFolder04.Location = new System.Drawing.Point(7, 138);
            this.lnkLastFolder04.Name = "lnkLastFolder04";
            this.lnkLastFolder04.Size = new System.Drawing.Size(143, 25);
            this.lnkLastFolder04.TabIndex = 12;
            this.lnkLastFolder04.TabStop = true;
            this.lnkLastFolder04.Tag = "3";
            this.lnkLastFolder04.Text = "lnkLastFolder04";
            this.lnkLastFolder04.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFolder_LinkClicked);
            this.lnkLastFolder04.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lnkLastFolder04.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lnkLastFolder03
            // 
            this.lnkLastFolder03.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkLastFolder03.AutoSize = true;
            this.lnkLastFolder03.LinkColor = System.Drawing.Color.Black;
            this.lnkLastFolder03.Location = new System.Drawing.Point(7, 102);
            this.lnkLastFolder03.Name = "lnkLastFolder03";
            this.lnkLastFolder03.Size = new System.Drawing.Size(143, 25);
            this.lnkLastFolder03.TabIndex = 11;
            this.lnkLastFolder03.TabStop = true;
            this.lnkLastFolder03.Tag = "2";
            this.lnkLastFolder03.Text = "lnkLastFolder03";
            this.lnkLastFolder03.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFolder_LinkClicked);
            this.lnkLastFolder03.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lnkLastFolder03.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lnkLastFolder02
            // 
            this.lnkLastFolder02.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkLastFolder02.AutoSize = true;
            this.lnkLastFolder02.LinkColor = System.Drawing.Color.Black;
            this.lnkLastFolder02.Location = new System.Drawing.Point(7, 67);
            this.lnkLastFolder02.Name = "lnkLastFolder02";
            this.lnkLastFolder02.Size = new System.Drawing.Size(143, 25);
            this.lnkLastFolder02.TabIndex = 10;
            this.lnkLastFolder02.TabStop = true;
            this.lnkLastFolder02.Tag = "1";
            this.lnkLastFolder02.Text = "lnkLastFolder02";
            this.lnkLastFolder02.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFolder_LinkClicked);
            this.lnkLastFolder02.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lnkLastFolder02.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // lnkLastFolder01
            // 
            this.lnkLastFolder01.ActiveLinkColor = System.Drawing.Color.White;
            this.lnkLastFolder01.AutoSize = true;
            this.lnkLastFolder01.LinkColor = System.Drawing.Color.Black;
            this.lnkLastFolder01.Location = new System.Drawing.Point(7, 31);
            this.lnkLastFolder01.Name = "lnkLastFolder01";
            this.lnkLastFolder01.Size = new System.Drawing.Size(143, 25);
            this.lnkLastFolder01.TabIndex = 9;
            this.lnkLastFolder01.TabStop = true;
            this.lnkLastFolder01.Tag = "0";
            this.lnkLastFolder01.Text = "lnkLastFolder01";
            this.lnkLastFolder01.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkLastFolder_LinkClicked);
            this.lnkLastFolder01.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.lnkLastFolder01.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.Indigo;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.toolStrip1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip1.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOpenFolder,
            this.lblImageProgress,
            this.btnPreviousImage,
            this.btnNextImage,
            this.btnCopyImage,
            this.btnOpenDestinationFolder,
            this.btnDeleteImage,
            this.btnHelp});
            this.toolStrip1.Location = new System.Drawing.Point(0, 530);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(788, 35);
            this.toolStrip1.TabIndex = 11;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnOpenFolder
            // 
            this.btnOpenFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenFolder.Image = global::GreatShot.Properties.Resources.folder_closed;
            this.btnOpenFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenFolder.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.btnOpenFolder.Name = "btnOpenFolder";
            this.btnOpenFolder.Size = new System.Drawing.Size(24, 32);
            this.btnOpenFolder.Text = "+";
            this.btnOpenFolder.ToolTipText = "Open Folder";
            this.btnOpenFolder.Click += new System.EventHandler(this.btnOpenFolder_Click);
            // 
            // lblImageProgress
            // 
            this.lblImageProgress.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblImageProgress.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageProgress.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImageProgress.Margin = new System.Windows.Forms.Padding(0, 0, 2, 2);
            this.lblImageProgress.Name = "lblImageProgress";
            this.lblImageProgress.Size = new System.Drawing.Size(85, 33);
            this.lblImageProgress.Text = "loading...";
            this.lblImageProgress.Visible = false;
            // 
            // btnPreviousImage
            // 
            this.btnPreviousImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnPreviousImage.Enabled = false;
            this.btnPreviousImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPreviousImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnPreviousImage.Image = ((System.Drawing.Image)(resources.GetObject("btnPreviousImage.Image")));
            this.btnPreviousImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPreviousImage.Name = "btnPreviousImage";
            this.btnPreviousImage.Size = new System.Drawing.Size(30, 32);
            this.btnPreviousImage.Text = "<";
            this.btnPreviousImage.ToolTipText = "Previous Image";
            this.btnPreviousImage.Click += new System.EventHandler(this.btnPreviousImage_Click);
            // 
            // btnNextImage
            // 
            this.btnNextImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnNextImage.Enabled = false;
            this.btnNextImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNextImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnNextImage.Image = global::GreatShot.Properties.Resources.great_shot;
            this.btnNextImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNextImage.Name = "btnNextImage";
            this.btnNextImage.Size = new System.Drawing.Size(30, 32);
            this.btnNextImage.Text = ">";
            this.btnNextImage.ToolTipText = "Next Image";
            this.btnNextImage.Click += new System.EventHandler(this.btnNextImage_Click);
            // 
            // btnCopyImage
            // 
            this.btnCopyImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCopyImage.Enabled = false;
            this.btnCopyImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCopyImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnCopyImage.Image = global::GreatShot.Properties.Resources.floppy;
            this.btnCopyImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCopyImage.Name = "btnCopyImage";
            this.btnCopyImage.Size = new System.Drawing.Size(24, 32);
            this.btnCopyImage.Text = "!";
            this.btnCopyImage.ToolTipText = "Copy Image";
            this.btnCopyImage.Click += new System.EventHandler(this.btnCopyImage_Click);
            // 
            // btnOpenDestinationFolder
            // 
            this.btnOpenDestinationFolder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnOpenDestinationFolder.Enabled = false;
            this.btnOpenDestinationFolder.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenDestinationFolder.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnOpenDestinationFolder.Image = global::GreatShot.Properties.Resources.folder_favorites;
            this.btnOpenDestinationFolder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenDestinationFolder.Name = "btnOpenDestinationFolder";
            this.btnOpenDestinationFolder.Size = new System.Drawing.Size(24, 32);
            this.btnOpenDestinationFolder.Text = "=";
            this.btnOpenDestinationFolder.ToolTipText = "Go to destination folder";
            this.btnOpenDestinationFolder.Click += new System.EventHandler(this.btnOpenDestinationFolder_Click);
            // 
            // btnDeleteImage
            // 
            this.btnDeleteImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDeleteImage.Enabled = false;
            this.btnDeleteImage.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteImage.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnDeleteImage.Image = global::GreatShot.Properties.Resources.recyclebin_full;
            this.btnDeleteImage.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleteImage.Name = "btnDeleteImage";
            this.btnDeleteImage.Size = new System.Drawing.Size(24, 32);
            this.btnDeleteImage.Text = "x";
            this.btnDeleteImage.ToolTipText = "Delete";
            this.btnDeleteImage.Click += new System.EventHandler(this.btnDeleteImage_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnHelp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnHelp.Image = ((System.Drawing.Image)(resources.GetObject("btnHelp.Image")));
            this.btnHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(25, 32);
            this.btnHelp.Text = "?";
            this.btnHelp.ToolTipText = "Help";
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // toolStrip2
            // 
            this.toolStrip2.BackColor = System.Drawing.Color.Indigo;
            this.toolStrip2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStrip2.GripMargin = new System.Windows.Forms.Padding(0);
            this.toolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblImageFileName,
            this.lblFileIndexCount});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip2.Size = new System.Drawing.Size(788, 25);
            this.toolStrip2.TabIndex = 12;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // lblImageFileName
            // 
            this.lblImageFileName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImageFileName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblImageFileName.Margin = new System.Windows.Forms.Padding(2, 1, 0, 2);
            this.lblImageFileName.Name = "lblImageFileName";
            this.lblImageFileName.Size = new System.Drawing.Size(0, 22);
            // 
            // lblFileIndexCount
            // 
            this.lblFileIndexCount.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.lblFileIndexCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFileIndexCount.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblFileIndexCount.Margin = new System.Windows.Forms.Padding(0, 1, 2, 2);
            this.lblFileIndexCount.Name = "lblFileIndexCount";
            this.lblFileIndexCount.Size = new System.Drawing.Size(0, 22);
            // 
            // lblMovieFile01
            // 
            this.lblMovieFile01.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMovieFile01.AutoSize = true;
            this.lblMovieFile01.Location = new System.Drawing.Point(206, 444);
            this.lblMovieFile01.Name = "lblMovieFile01";
            this.lblMovieFile01.Size = new System.Drawing.Size(415, 23);
            this.lblMovieFile01.TabIndex = 13;
            this.lblMovieFile01.Text = "Press F11 to see the video in the associated program.";
            this.lblMovieFile01.Visible = false;
            // 
            // lblMovieFile02
            // 
            this.lblMovieFile02.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.lblMovieFile02.AutoSize = true;
            this.lblMovieFile02.Location = new System.Drawing.Point(276, 468);
            this.lblMovieFile02.Name = "lblMovieFile02";
            this.lblMovieFile02.Size = new System.Drawing.Size(217, 23);
            this.lblMovieFile02.TabIndex = 14;
            this.lblMovieFile02.Text = "Press Enter to copy the file.";
            this.lblMovieFile02.Visible = false;
            // 
            // lblMovieFile03
            // 
            this.lblMovieFile03.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMovieFile03.AutoSize = true;
            this.lblMovieFile03.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieFile03.Location = new System.Drawing.Point(353, 97);
            this.lblMovieFile03.Name = "lblMovieFile03";
            this.lblMovieFile03.Size = new System.Drawing.Size(119, 25);
            this.lblMovieFile03.TabIndex = 15;
            this.lblMovieFile03.Text = "MovieName";
            this.lblMovieFile03.Visible = false;
            // 
            // imgActualPicture
            // 
            this.imgActualPicture.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.imgActualPicture.BackColor = System.Drawing.Color.White;
            this.imgActualPicture.Location = new System.Drawing.Point(0, 30);
            this.imgActualPicture.Name = "imgActualPicture";
            this.imgActualPicture.Size = new System.Drawing.Size(788, 503);
            this.imgActualPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imgActualPicture.TabIndex = 0;
            this.imgActualPicture.TabStop = false;
            this.imgActualPicture.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.imgActualPicture_LoadCompleted);
            // 
            // imgGreatShot
            // 
            this.imgGreatShot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.imgGreatShot.Image = global::GreatShot.Properties.Resources.favorites;
            this.imgGreatShot.InitialImage = global::GreatShot.Properties.Resources.favorites;
            this.imgGreatShot.Location = new System.Drawing.Point(2, 491);
            this.imgGreatShot.Name = "imgGreatShot";
            this.imgGreatShot.Size = new System.Drawing.Size(34, 39);
            this.imgGreatShot.TabIndex = 18;
            this.imgGreatShot.TabStop = false;
            this.imgGreatShot.Visible = false;
            // 
            // MainForm
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(788, 565);
            this.Controls.Add(this.imgGreatShot);
            this.Controls.Add(this.lblMovieFile03);
            this.Controls.Add(this.lblMovieFile02);
            this.Controls.Add(this.lblMovieFile01);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.gbLastOpenFolders);
            this.Controls.Add(this.lblHelp);
            this.Controls.Add(this.imgActualPicture);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Great Shot";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.MainForm_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.MainForm_DragEnter);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.gbLastOpenFolders.ResumeLayout(false);
            this.gbLastOpenFolders.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgActualPicture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgGreatShot)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imgActualPicture;
        private System.Windows.Forms.Label lblHelp;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox gbLastOpenFolders;
        private System.Windows.Forms.LinkLabel lnkLastFolder01;
        private System.Windows.Forms.LinkLabel lnkLastFolder02;
        private System.Windows.Forms.LinkLabel lnkLastFolder03;
        private System.Windows.Forms.LinkLabel lnkLastFolder04;
        private System.Windows.Forms.LinkLabel lnkLastFolder05;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnOpenFolder;
        private System.Windows.Forms.ToolStripLabel lblImageProgress;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripLabel lblImageFileName;
        private System.Windows.Forms.ToolStripLabel lblFileIndexCount;
        private System.Windows.Forms.ToolStripButton btnPreviousImage;
        private System.Windows.Forms.ToolStripButton btnNextImage;
        private System.Windows.Forms.ToolStripButton btnCopyImage;
        private System.Windows.Forms.ToolStripButton btnOpenDestinationFolder;
        private System.Windows.Forms.ToolStripButton btnDeleteImage;
        private System.Windows.Forms.ToolStripButton btnHelp;
        private System.Windows.Forms.Label lblMovieFile01;
        private System.Windows.Forms.Label lblMovieFile02;
        private System.Windows.Forms.Label lblMovieFile03;
        private System.Windows.Forms.PictureBox imgGreatShot;
    }
}