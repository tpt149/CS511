namespace Minigames1
{
    partial class Fruits
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fruits));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pic = new System.Windows.Forms.PictureBox();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.btnFirstHint = new System.Windows.Forms.Button();
            this.lblFirstHint = new System.Windows.Forms.Label();
            this.picLock = new System.Windows.Forms.PictureBox();
            this.lblSecondHint = new System.Windows.Forms.Label();
            this.btn_Next = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.lbl_hideanswer = new System.Windows.Forms.Label();
            this.lbl_goodjob = new System.Windows.Forms.Label();
            this.lbl_point = new System.Windows.Forms.Label();
            this.btn_check = new System.Windows.Forms.Button();
            this.btn_test_audio = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl_left = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnSecondHint = new System.Windows.Forms.Button();
            this.btn_rank = new System.Windows.Forms.Button();
            this.btn_thirdhint = new System.Windows.Forms.Button();
            this.lblThirdHint = new System.Windows.Forms.Label();
            this.picLock2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(177, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(630, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Type the name of object shown in each picture";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.DarkCyan;
            this.label2.Location = new System.Drawing.Point(246, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(495, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "You need to answer at least three questions to pass this level.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.DarkMagenta;
            this.label3.Location = new System.Drawing.Point(212, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(560, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "If you answer correctly the first time with no hints you get five points.";
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Location = new System.Drawing.Point(80, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 28);
            this.label4.TabIndex = 3;
            this.label4.Text = "Points";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pic
            // 
            this.pic.Location = new System.Drawing.Point(246, 159);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(370, 370);
            this.pic.TabIndex = 5;
            this.pic.TabStop = false;
            // 
            // txt_input
            // 
            this.txt_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.txt_input.Font = new System.Drawing.Font("Segoe UI", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.txt_input.ForeColor = System.Drawing.Color.Olive;
            this.txt_input.Location = new System.Drawing.Point(325, 543);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(226, 31);
            this.txt_input.TabIndex = 6;
            this.txt_input.Text = "Type your answer heer...";
            this.txt_input.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txt_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txt_input_KeyDown);
            // 
            // btnFirstHint
            // 
            this.btnFirstHint.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnFirstHint.Location = new System.Drawing.Point(716, 276);
            this.btnFirstHint.Name = "btnFirstHint";
            this.btnFirstHint.Size = new System.Drawing.Size(89, 29);
            this.btnFirstHint.TabIndex = 7;
            this.btnFirstHint.Text = "First Hint";
            this.btnFirstHint.UseVisualStyleBackColor = true;
            this.btnFirstHint.Click += new System.EventHandler(this.button1_Click);
            // 
            // lblFirstHint
            // 
            this.lblFirstHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFirstHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFirstHint.Location = new System.Drawing.Point(716, 308);
            this.lblFirstHint.Name = "lblFirstHint";
            this.lblFirstHint.Size = new System.Drawing.Size(212, 29);
            this.lblFirstHint.TabIndex = 8;
            this.lblFirstHint.Click += new System.EventHandler(this.label5_Click);
            // 
            // picLock
            // 
            this.picLock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLock.BackgroundImage")));
            this.picLock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLock.Location = new System.Drawing.Point(675, 335);
            this.picLock.Name = "picLock";
            this.picLock.Size = new System.Drawing.Size(35, 34);
            this.picLock.TabIndex = 9;
            this.picLock.TabStop = false;
            // 
            // lblSecondHint
            // 
            this.lblSecondHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSecondHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblSecondHint.Location = new System.Drawing.Point(716, 372);
            this.lblSecondHint.Name = "lblSecondHint";
            this.lblSecondHint.Size = new System.Drawing.Size(251, 29);
            this.lblSecondHint.TabIndex = 8;
            this.lblSecondHint.Click += new System.EventHandler(this.label5_Click);
            // 
            // btn_Next
            // 
            this.btn_Next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_Next.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Next.BackgroundImage")));
            this.btn_Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_Next.FlatAppearance.BorderSize = 0;
            this.btn_Next.Location = new System.Drawing.Point(897, 525);
            this.btn_Next.Name = "btn_Next";
            this.btn_Next.Size = new System.Drawing.Size(70, 70);
            this.btn_Next.TabIndex = 10;
            this.btn_Next.UseVisualStyleBackColor = false;
            this.btn_Next.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // lbl_hideanswer
            // 
            this.lbl_hideanswer.AutoSize = true;
            this.lbl_hideanswer.Location = new System.Drawing.Point(21, 94);
            this.lbl_hideanswer.Name = "lbl_hideanswer";
            this.lbl_hideanswer.Size = new System.Drawing.Size(138, 20);
            this.lbl_hideanswer.TabIndex = 11;
            this.lbl_hideanswer.Text = "correct hide answer";
            this.lbl_hideanswer.VisibleChanged += new System.EventHandler(this.lbl_hideanswer_VisibleChanged);
            // 
            // lbl_goodjob
            // 
            this.lbl_goodjob.AutoSize = true;
            this.lbl_goodjob.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lbl_goodjob.ForeColor = System.Drawing.Color.SeaGreen;
            this.lbl_goodjob.Location = new System.Drawing.Point(716, 478);
            this.lbl_goodjob.Name = "lbl_goodjob";
            this.lbl_goodjob.Size = new System.Drawing.Size(0, 28);
            this.lbl_goodjob.TabIndex = 12;
            this.lbl_goodjob.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lbl_point
            // 
            this.lbl_point.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_point.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_point.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_point.Location = new System.Drawing.Point(80, 197);
            this.lbl_point.Name = "lbl_point";
            this.lbl_point.Size = new System.Drawing.Size(140, 140);
            this.lbl_point.TabIndex = 13;
            this.lbl_point.Text = "0/100";
            this.lbl_point.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_check
            // 
            this.btn_check.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_check.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_check.BackgroundImage")));
            this.btn_check.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_check.FlatAppearance.BorderSize = 0;
            this.btn_check.Location = new System.Drawing.Point(716, 525);
            this.btn_check.Name = "btn_check";
            this.btn_check.Size = new System.Drawing.Size(70, 70);
            this.btn_check.TabIndex = 14;
            this.btn_check.UseVisualStyleBackColor = false;
            this.btn_check.Click += new System.EventHandler(this.btn_check_Click);
            // 
            // btn_test_audio
            // 
            this.btn_test_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_test_audio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_test_audio.Location = new System.Drawing.Point(12, 543);
            this.btn_test_audio.Name = "btn_test_audio";
            this.btn_test_audio.Size = new System.Drawing.Size(45, 45);
            this.btn_test_audio.TabIndex = 17;
            this.btn_test_audio.UseVisualStyleBackColor = false;
            this.btn_test_audio.Click += new System.EventHandler(this.btn_test_audio_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.Location = new System.Drawing.Point(-1, 0);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(37, 37);
            this.btn_back.TabIndex = 20;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Location = new System.Drawing.Point(964, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(37, 37);
            this.btn_exit.TabIndex = 21;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(42, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lbl_left
            // 
            this.lbl_left.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_left.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_left.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lbl_left.Location = new System.Drawing.Point(80, 389);
            this.lbl_left.Name = "lbl_left";
            this.lbl_left.Size = new System.Drawing.Size(140, 140);
            this.lbl_left.TabIndex = 23;
            this.lbl_left.Text = "1/5";
            this.lbl_left.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Location = new System.Drawing.Point(80, 352);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(140, 28);
            this.label7.TabIndex = 24;
            this.label7.Text = "Attempts Left";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSecondHint
            // 
            this.btnSecondHint.Location = new System.Drawing.Point(716, 340);
            this.btnSecondHint.Name = "btnSecondHint";
            this.btnSecondHint.Size = new System.Drawing.Size(121, 29);
            this.btnSecondHint.TabIndex = 25;
            this.btnSecondHint.Text = "Second Hint";
            this.btnSecondHint.UseVisualStyleBackColor = true;
            this.btnSecondHint.Click += new System.EventHandler(this.btnSecondHint_Click);
            // 
            // btn_rank
            // 
            this.btn_rank.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_rank.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_rank.BackgroundImage")));
            this.btn_rank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_rank.FlatAppearance.BorderSize = 0;
            this.btn_rank.Location = new System.Drawing.Point(785, 159);
            this.btn_rank.Name = "btn_rank";
            this.btn_rank.Size = new System.Drawing.Size(90, 90);
            this.btn_rank.TabIndex = 26;
            this.btn_rank.UseVisualStyleBackColor = false;
            this.btn_rank.Click += new System.EventHandler(this.btn_rank_Click);
            // 
            // btn_thirdhint
            // 
            this.btn_thirdhint.Location = new System.Drawing.Point(716, 404);
            this.btn_thirdhint.Name = "btn_thirdhint";
            this.btn_thirdhint.Size = new System.Drawing.Size(94, 29);
            this.btn_thirdhint.TabIndex = 27;
            this.btn_thirdhint.Text = "Third hint";
            this.btn_thirdhint.UseVisualStyleBackColor = true;
            this.btn_thirdhint.Click += new System.EventHandler(this.btn_thirdhint_Click);
            // 
            // lblThirdHint
            // 
            this.lblThirdHint.AutoSize = true;
            this.lblThirdHint.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblThirdHint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblThirdHint.Location = new System.Drawing.Point(716, 435);
            this.lblThirdHint.Name = "lblThirdHint";
            this.lblThirdHint.Size = new System.Drawing.Size(0, 23);
            this.lblThirdHint.TabIndex = 28;
            this.lblThirdHint.Click += new System.EventHandler(this.label5_Click_2);
            // 
            // picLock2
            // 
            this.picLock2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picLock2.BackgroundImage")));
            this.picLock2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picLock2.Location = new System.Drawing.Point(675, 399);
            this.picLock2.Name = "picLock2";
            this.picLock2.Size = new System.Drawing.Size(35, 34);
            this.picLock2.TabIndex = 29;
            this.picLock2.TabStop = false;
            // 
            // Fruits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.picLock2);
            this.Controls.Add(this.lblThirdHint);
            this.Controls.Add(this.btn_thirdhint);
            this.Controls.Add(this.btn_rank);
            this.Controls.Add(this.btnSecondHint);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lbl_left);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_test_audio);
            this.Controls.Add(this.btn_check);
            this.Controls.Add(this.lbl_point);
            this.Controls.Add(this.lbl_goodjob);
            this.Controls.Add(this.lbl_hideanswer);
            this.Controls.Add(this.btn_Next);
            this.Controls.Add(this.picLock);
            this.Controls.Add(this.lblSecondHint);
            this.Controls.Add(this.lblFirstHint);
            this.Controls.Add(this.btnFirstHint);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Fruits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fruits";
            this.Load += new System.EventHandler(this.Fruits_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picLock2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.Button btnFirstHint;
        private System.Windows.Forms.Label lblFirstHint;
        private System.Windows.Forms.PictureBox picLock;
        private System.Windows.Forms.Label lblSecondHint;
        private System.Windows.Forms.Button btn_Next;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lbl_hideanswer;
        private System.Windows.Forms.Label lbl_goodjob;
        private System.Windows.Forms.Label lbl_point;
        private System.Windows.Forms.Button btn_check;
        private System.Windows.Forms.Button btn_test_audio;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl_left;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnSecondHint;
        private System.Windows.Forms.Button btn_rank;
        private System.Windows.Forms.Button btn_thirdhint;
        private System.Windows.Forms.Label lblThirdHint;
        private System.Windows.Forms.PictureBox picLock2;
    }
}