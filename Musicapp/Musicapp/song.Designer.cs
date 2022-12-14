namespace Musicapp
{
    partial class song
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(song));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labName = new System.Windows.Forms.Label();
            this.labType = new System.Windows.Forms.Label();
            this.lab_author = new System.Windows.Forms.Label();
            this.labDur = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(16, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // labName
            // 
            this.labName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labName.ForeColor = System.Drawing.Color.Sienna;
            this.labName.Location = new System.Drawing.Point(101, 24);
            this.labName.Name = "labName";
            this.labName.Size = new System.Drawing.Size(414, 23);
            this.labName.TabIndex = 1;
            this.labName.Text = "Tên bài hát";
            // 
            // labType
            // 
            this.labType.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labType.ForeColor = System.Drawing.Color.Sienna;
            this.labType.Location = new System.Drawing.Point(469, 24);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(99, 23);
            this.labType.TabIndex = 2;
            this.labType.Text = "Thể loại";
            // 
            // lab_author
            // 
            this.lab_author.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lab_author.ForeColor = System.Drawing.Color.Sienna;
            this.lab_author.Location = new System.Drawing.Point(603, 24);
            this.lab_author.Name = "lab_author";
            this.lab_author.Size = new System.Drawing.Size(275, 23);
            this.lab_author.TabIndex = 3;
            this.lab_author.Text = "Văn Mai Hương, Hứa Kim Tuyền";
            // 
            // labDur
            // 
            this.labDur.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labDur.ForeColor = System.Drawing.Color.Sienna;
            this.labDur.Location = new System.Drawing.Point(929, 24);
            this.labDur.Name = "labDur";
            this.labDur.Size = new System.Drawing.Size(99, 23);
            this.labDur.TabIndex = 4;
            this.labDur.Text = "Thời gian";
            // 
            // song
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.labDur);
            this.Controls.Add(this.lab_author);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labName);
            this.Controls.Add(this.pictureBox1);
            this.Name = "song";
            this.Size = new System.Drawing.Size(1100, 75);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labName;
        private System.Windows.Forms.Label labType;
        private System.Windows.Forms.Label lab_author;
        private System.Windows.Forms.Label labDur;
    }
}
