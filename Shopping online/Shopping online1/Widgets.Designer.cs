namespace Shopping_online1
{
    partial class Widgets
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Widgets));
            this.imgImage = new System.Windows.Forms.PictureBox();
            this.lblCost = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lbl_cate = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // imgImage
            // 
            this.imgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.imgImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imgImage.Image = ((System.Drawing.Image)(resources.GetObject("imgImage.Image")));
            this.imgImage.Location = new System.Drawing.Point(335, 21);
            this.imgImage.Name = "imgImage";
            this.imgImage.Size = new System.Drawing.Size(100, 93);
            this.imgImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgImage.TabIndex = 8;
            this.imgImage.TabStop = false;
            this.imgImage.Click += new System.EventHandler(this.imgImage_Click);
            // 
            // lblCost
            // 
            this.lblCost.AutoSize = true;
            this.lblCost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblCost.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCost.ForeColor = System.Drawing.Color.Crimson;
            this.lblCost.Location = new System.Drawing.Point(18, 83);
            this.lblCost.Name = "lblCost";
            this.lblCost.Size = new System.Drawing.Size(64, 31);
            this.lblCost.TabIndex = 7;
            this.lblCost.Text = "$1,81";
            this.lblCost.Click += new System.EventHandler(this.imgImage_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(44)))), ((int)(((byte)(73)))));
            this.lblTitle.Location = new System.Drawing.Point(18, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(122, 31);
            this.lblTitle.TabIndex = 6;
            this.lblTitle.Text = "Latte Latte";
            this.lblTitle.Click += new System.EventHandler(this.imgImage_Click);
            // 
            // lbl_cate
            // 
            this.lbl_cate.AutoSize = true;
            this.lbl_cate.Location = new System.Drawing.Point(180, 74);
            this.lbl_cate.Name = "lbl_cate";
            this.lbl_cate.Size = new System.Drawing.Size(44, 16);
            this.lbl_cate.TabIndex = 9;
            this.lbl_cate.Text = "label1";
            // 
            // Widgets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_cate);
            this.Controls.Add(this.imgImage);
            this.Controls.Add(this.lblCost);
            this.Controls.Add(this.lblTitle);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "Widgets";
            this.Size = new System.Drawing.Size(452, 133);
            this.Click += new System.EventHandler(this.imgImage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.imgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.PictureBox imgImage;
        public System.Windows.Forms.Label lblCost;
        public System.Windows.Forms.Label lblTitle;
        public System.Windows.Forms.Label lbl_cate;
    }
}
