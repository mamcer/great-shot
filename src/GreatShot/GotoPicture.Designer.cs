namespace GreatShot.UI
{
    partial class GotoPicture
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
            this.lstPictures = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstPictures
            // 
            this.lstPictures.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstPictures.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstPictures.ItemHeight = 23;
            this.lstPictures.Location = new System.Drawing.Point(0, 0);
            this.lstPictures.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lstPictures.Name = "lstPictures";
            this.lstPictures.ScrollAlwaysVisible = true;
            this.lstPictures.Size = new System.Drawing.Size(346, 451);
            this.lstPictures.TabIndex = 0;
            this.lstPictures.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lstPictures_KeyDown);
            // 
            // GotoPicture
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(346, 451);
            this.ControlBox = false;
            this.Controls.Add(this.lstPictures);
            this.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GotoPicture";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Go to";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GotoPicture_KeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstPictures;
    }
}