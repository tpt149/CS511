namespace Musicapp
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.picSong = new System.Windows.Forms.PictureBox();
            this.labAuthor = new System.Windows.Forms.Label();
            this.labName = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.picLove = new System.Windows.Forms.PictureBox();
            this.pb_str5 = new System.Windows.Forms.PictureBox();
            this.pb_str4 = new System.Windows.Forms.PictureBox();
            this.pb_str3 = new System.Windows.Forms.PictureBox();
            this.pb_str2 = new System.Windows.Forms.PictureBox();
            this.pb_str1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.btnClose = new Bunifu.UI.WinForms.BunifuImageButton();
            this.wplayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.lbl_core = new System.Windows.Forms.Label();
            this.txtLyric = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picSong
            // 
            this.picSong.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picSong.Location = new System.Drawing.Point(118, 135);
            this.picSong.Name = "picSong";
            this.picSong.Size = new System.Drawing.Size(300, 300);
            this.picSong.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSong.TabIndex = 0;
            this.picSong.TabStop = false;
            // 
            // labAuthor
            // 
            this.labAuthor.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labAuthor.ForeColor = System.Drawing.Color.Silver;
            this.labAuthor.Location = new System.Drawing.Point(160, 523);
            this.labAuthor.Name = "labAuthor";
            this.labAuthor.Size = new System.Drawing.Size(232, 21);
            this.labAuthor.TabIndex = 7;
            this.labAuthor.Text = "Văn Mai Hương, Hứa Kim Tuyền";
            this.labAuthor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labName.Location = new System.Drawing.Point(148, 483);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(258, 31);
            this.labName.TabIndex = 6;
            this.labName.Text = "Lặng thầm một tình yêu";
            this.labName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // picLove
            // 
            this.picLove.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLove.BackgroundImage")));
            this.picLove.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLove.Location = new System.Drawing.Point(382, 564);
            this.picLove.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picLove.Name = "picLove";
            this.picLove.Size = new System.Drawing.Size(36, 32);
            this.picLove.TabIndex = 25;
            this.picLove.TabStop = false;
            this.picLove.Click += new System.EventHandler(this.picLove_Click);
            // 
            // pb_str5
            // 
            this.pb_str5.BackColor = System.Drawing.Color.Transparent;
            this.pb_str5.Image = ((System.Drawing.Image)(resources.GetObject("pb_str5.Image")));
            this.pb_str5.Location = new System.Drawing.Point(351, 441);
            this.pb_str5.Name = "pb_str5";
            this.pb_str5.Size = new System.Drawing.Size(30, 30);
            this.pb_str5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str5.TabIndex = 30;
            this.pb_str5.TabStop = false;
            this.pb_str5.Click += new System.EventHandler(this.pb_str5_Click);
            // 
            // pb_str4
            // 
            this.pb_str4.BackColor = System.Drawing.Color.Transparent;
            this.pb_str4.Image = ((System.Drawing.Image)(resources.GetObject("pb_str4.Image")));
            this.pb_str4.Location = new System.Drawing.Point(300, 441);
            this.pb_str4.Name = "pb_str4";
            this.pb_str4.Size = new System.Drawing.Size(30, 30);
            this.pb_str4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str4.TabIndex = 29;
            this.pb_str4.TabStop = false;
            this.pb_str4.Click += new System.EventHandler(this.pb_str4_Click);
            // 
            // pb_str3
            // 
            this.pb_str3.BackColor = System.Drawing.Color.Transparent;
            this.pb_str3.Image = ((System.Drawing.Image)(resources.GetObject("pb_str3.Image")));
            this.pb_str3.Location = new System.Drawing.Point(252, 441);
            this.pb_str3.Name = "pb_str3";
            this.pb_str3.Size = new System.Drawing.Size(30, 30);
            this.pb_str3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str3.TabIndex = 28;
            this.pb_str3.TabStop = false;
            this.pb_str3.Click += new System.EventHandler(this.pb_str3_Click);
            // 
            // pb_str2
            // 
            this.pb_str2.BackColor = System.Drawing.Color.Transparent;
            this.pb_str2.Image = ((System.Drawing.Image)(resources.GetObject("pb_str2.Image")));
            this.pb_str2.Location = new System.Drawing.Point(203, 441);
            this.pb_str2.Name = "pb_str2";
            this.pb_str2.Size = new System.Drawing.Size(30, 30);
            this.pb_str2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str2.TabIndex = 27;
            this.pb_str2.TabStop = false;
            this.pb_str2.Click += new System.EventHandler(this.pb_str2_Click);
            // 
            // pb_str1
            // 
            this.pb_str1.BackColor = System.Drawing.Color.Transparent;
            this.pb_str1.Image = ((System.Drawing.Image)(resources.GetObject("pb_str1.Image")));
            this.pb_str1.Location = new System.Drawing.Point(154, 441);
            this.pb_str1.Name = "pb_str1";
            this.pb_str1.Size = new System.Drawing.Size(30, 30);
            this.pb_str1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_str1.TabIndex = 26;
            this.pb_str1.TabStop = false;
            this.pb_str1.Click += new System.EventHandler(this.pb_str1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(118, 564);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 32);
            this.pictureBox1.TabIndex = 31;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(203, 564);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(36, 32);
            this.pictureBox2.TabIndex = 32;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox3.Location = new System.Drawing.Point(294, 564);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(36, 32);
            this.pictureBox3.TabIndex = 33;
            this.pictureBox3.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.ActiveImage = null;
            this.btnClose.AllowAnimations = true;
            this.btnClose.AllowBuffering = false;
            this.btnClose.AllowToggling = false;
            this.btnClose.AllowZooming = true;
            this.btnClose.AllowZoomingOnFocus = false;
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnClose.ErrorImage = ((System.Drawing.Image)(resources.GetObject("btnClose.ErrorImage")));
            this.btnClose.FadeWhenInactive = false;
            this.btnClose.Flip = Bunifu.UI.WinForms.BunifuImageButton.FlipOrientation.Normal;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageActive = null;
            this.btnClose.ImageLocation = null;
            this.btnClose.ImageMargin = 20;
            this.btnClose.ImageSize = new System.Drawing.Size(35, 35);
            this.btnClose.ImageZoomSize = new System.Drawing.Size(55, 55);
            this.btnClose.InitialImage = ((System.Drawing.Image)(resources.GetObject("btnClose.InitialImage")));
            this.btnClose.Location = new System.Drawing.Point(1345, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Rotation = 0;
            this.btnClose.ShowActiveImage = true;
            this.btnClose.ShowCursorChanges = true;
            this.btnClose.ShowImageBorders = true;
            this.btnClose.ShowSizeMarkers = false;
            this.btnClose.Size = new System.Drawing.Size(55, 55);
            this.btnClose.TabIndex = 34;
            this.btnClose.ToolTipText = "";
            this.btnClose.WaitOnLoad = false;
            this.btnClose.Zoom = 20;
            this.btnClose.ZoomSpeed = 10;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // wplayer
            // 
            this.wplayer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.wplayer.Enabled = true;
            this.wplayer.Location = new System.Drawing.Point(0, 673);
            this.wplayer.Name = "wplayer";
            this.wplayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wplayer.OcxState")));
            this.wplayer.Size = new System.Drawing.Size(1400, 127);
            this.wplayer.TabIndex = 8;
            // 
            // lbl_core
            // 
            this.lbl_core.AutoSize = true;
            this.lbl_core.BackColor = System.Drawing.Color.Transparent;
            this.lbl_core.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_core.ForeColor = System.Drawing.Color.Red;
            this.lbl_core.Location = new System.Drawing.Point(443, 490);
            this.lbl_core.Name = "lbl_core";
            this.lbl_core.Size = new System.Drawing.Size(20, 24);
            this.lbl_core.TabIndex = 36;
            this.lbl_core.Text = "0";
            // 
            // txtLyric
            // 
            this.txtLyric.AutoSize = true;
            this.txtLyric.BackColor = System.Drawing.Color.Transparent;
            this.txtLyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtLyric.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLyric.ForeColor = System.Drawing.Color.Linen;
            this.txtLyric.Location = new System.Drawing.Point(3, 0);
            this.txtLyric.Name = "txtLyric";
            this.txtLyric.Size = new System.Drawing.Size(66, 25);
            this.txtLyric.TabIndex = 28;
            this.txtLyric.Text = "txtLyric";
            this.txtLyric.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.txtLyric);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(663, 135);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(610, 460);
            this.flowLayoutPanel1.TabIndex = 37;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1400, 800);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lbl_core);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pb_str5);
            this.Controls.Add(this.pb_str4);
            this.Controls.Add(this.pb_str3);
            this.Controls.Add(this.pb_str2);
            this.Controls.Add(this.pb_str1);
            this.Controls.Add(this.picLove);
            this.Controls.Add(this.wplayer);
            this.Controls.Add(this.labAuthor);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.picSong);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picSong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLove)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_str1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wplayer)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picSong;
        private System.Windows.Forms.Label labAuthor;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Timer timer1;
        private AxWMPLib.AxWindowsMediaPlayer wplayer;
        private System.Windows.Forms.PictureBox picLove;
        private System.Windows.Forms.PictureBox pb_str5;
        private System.Windows.Forms.PictureBox pb_str4;
        private System.Windows.Forms.PictureBox pb_str3;
        private System.Windows.Forms.PictureBox pb_str2;
        private System.Windows.Forms.PictureBox pb_str1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private Bunifu.UI.WinForms.BunifuImageButton btnClose;
        private System.Windows.Forms.Label lbl_core;
        private System.Windows.Forms.Label txtLyric;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}