namespace Minigames1
{
    partial class Chude
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chude));
            this.piccbx_fruit = new System.Windows.Forms.PictureBox();
            this.picbx_animal = new System.Windows.Forms.PictureBox();
            this.picbx_vegetables = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_test_audio = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.piccbx_fruit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_animal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_vegetables)).BeginInit();
            this.SuspendLayout();
            // 
            // piccbx_fruit
            // 
            this.piccbx_fruit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("piccbx_fruit.BackgroundImage")));
            this.piccbx_fruit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.piccbx_fruit.Location = new System.Drawing.Point(43, 144);
            this.piccbx_fruit.Name = "piccbx_fruit";
            this.piccbx_fruit.Size = new System.Drawing.Size(280, 280);
            this.piccbx_fruit.TabIndex = 0;
            this.piccbx_fruit.TabStop = false;
            this.piccbx_fruit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picbx_animal
            // 
            this.picbx_animal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_animal.BackgroundImage")));
            this.picbx_animal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_animal.Location = new System.Drawing.Point(364, 144);
            this.picbx_animal.Name = "picbx_animal";
            this.picbx_animal.Size = new System.Drawing.Size(280, 280);
            this.picbx_animal.TabIndex = 1;
            this.picbx_animal.TabStop = false;
            this.picbx_animal.Click += new System.EventHandler(this.picbx_animal_Click);
            // 
            // picbx_vegetables
            // 
            this.picbx_vegetables.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("picbx_vegetables.BackgroundImage")));
            this.picbx_vegetables.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picbx_vegetables.Location = new System.Drawing.Point(683, 144);
            this.picbx_vegetables.Name = "picbx_vegetables";
            this.picbx_vegetables.Size = new System.Drawing.Size(280, 280);
            this.picbx_vegetables.TabIndex = 2;
            this.picbx_vegetables.TabStop = false;
            this.picbx_vegetables.Click += new System.EventHandler(this.picbx_vegetables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(111, 437);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Fruits";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(426, 437);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "ANIMALS";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Stencil", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(714, 437);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(222, 39);
            this.label3.TabIndex = 3;
            this.label3.Text = "VEGETABLES";
            // 
            // btn_test_audio
            // 
            this.btn_test_audio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_test_audio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_test_audio.Location = new System.Drawing.Point(12, 543);
            this.btn_test_audio.Name = "btn_test_audio";
            this.btn_test_audio.Size = new System.Drawing.Size(45, 45);
            this.btn_test_audio.TabIndex = 18;
            this.btn_test_audio.UseVisualStyleBackColor = false;
            this.btn_test_audio.Click += new System.EventHandler(this.btn_test_audio_Click);
            // 
            // btn_back
            // 
            this.btn_back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_back.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_back.BackgroundImage")));
            this.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_back.FlatAppearance.BorderSize = 0;
            this.btn_back.Location = new System.Drawing.Point(0, -1);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(37, 37);
            this.btn_back.TabIndex = 19;
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.btn_exit.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_exit.BackgroundImage")));
            this.btn_exit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_exit.FlatAppearance.BorderSize = 0;
            this.btn_exit.Location = new System.Drawing.Point(963, -1);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(37, 37);
            this.btn_exit.TabIndex = 20;
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(43, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(37, 37);
            this.button1.TabIndex = 23;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Chude
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(209)))), ((int)(((byte)(214)))));
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_test_audio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.picbx_vegetables);
            this.Controls.Add(this.picbx_animal);
            this.Controls.Add(this.piccbx_fruit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Chude";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chude";
            this.Load += new System.EventHandler(this.Chude_Load);
            ((System.ComponentModel.ISupportInitialize)(this.piccbx_fruit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_animal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbx_vegetables)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox piccbx_fruit;
        private System.Windows.Forms.PictureBox picbx_animal;
        private System.Windows.Forms.PictureBox picbx_vegetables;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_test_audio;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button button1;
    }
}