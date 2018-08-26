namespace Gameshoot
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Gun_PointAway = new System.Windows.Forms.PictureBox();
            this.Gun_PointHead = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label_score = new System.Windows.Forms.Label();
            this.label_round = new System.Windows.Forms.Label();
            this.btn_load = new System.Windows.Forms.Button();
            this.btn_spin = new System.Windows.Forms.Button();
            this.btn_shoot = new System.Windows.Forms.Button();
            this.btn_shootAway = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointAway)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointHead)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 394);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Gun_PointAway
            // 
            this.Gun_PointAway.Image = ((System.Drawing.Image)(resources.GetObject("Gun_PointAway.Image")));
            this.Gun_PointAway.Location = new System.Drawing.Point(402, 156);
            this.Gun_PointAway.Name = "Gun_PointAway";
            this.Gun_PointAway.Size = new System.Drawing.Size(141, 92);
            this.Gun_PointAway.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun_PointAway.TabIndex = 1;
            this.Gun_PointAway.TabStop = false;
            this.Gun_PointAway.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Gun_PointHead
            // 
            this.Gun_PointHead.Image = ((System.Drawing.Image)(resources.GetObject("Gun_PointHead.Image")));
            this.Gun_PointHead.Location = new System.Drawing.Point(255, 156);
            this.Gun_PointHead.Name = "Gun_PointHead";
            this.Gun_PointHead.Size = new System.Drawing.Size(141, 92);
            this.Gun_PointHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Gun_PointHead.TabIndex = 1;
            this.Gun_PointHead.TabStop = false;
            this.Gun_PointHead.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Player :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(245, -7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(331, 57);
            this.label2.TabIndex = 2;
            this.label2.Text = "Russian Roulette";
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.Transparent;
            this.label_score.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(292, 73);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(134, 33);
            this.label_score.TabIndex = 2;
            this.label_score.Text = "Total Score :";
            // 
            // label_round
            // 
            this.label_round.AutoSize = true;
            this.label_round.BackColor = System.Drawing.Color.Transparent;
            this.label_round.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_round.ForeColor = System.Drawing.Color.Black;
            this.label_round.Location = new System.Drawing.Point(330, 307);
            this.label_round.Name = "label_round";
            this.label_round.Size = new System.Drawing.Size(109, 33);
            this.label_round.TabIndex = 2;
            this.label_round.Text = "Round : 0";
            this.label_round.Click += new System.EventHandler(this.label4_Click);
            // 
            // btn_load
            // 
            this.btn_load.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_load.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_load.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_load.Location = new System.Drawing.Point(563, 73);
            this.btn_load.Name = "btn_load";
            this.btn_load.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_load.Size = new System.Drawing.Size(136, 47);
            this.btn_load.TabIndex = 3;
            this.btn_load.Text = "Load";
            this.btn_load.UseVisualStyleBackColor = false;
            this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
            // 
            // btn_spin
            // 
            this.btn_spin.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_spin.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_spin.ForeColor = System.Drawing.Color.Cornsilk;
            this.btn_spin.Location = new System.Drawing.Point(563, 126);
            this.btn_spin.Name = "btn_spin";
            this.btn_spin.Size = new System.Drawing.Size(136, 42);
            this.btn_spin.TabIndex = 4;
            this.btn_spin.Text = "Spin";
            this.btn_spin.UseVisualStyleBackColor = false;
            this.btn_spin.Click += new System.EventHandler(this.btn_spin_Click);
            // 
            // btn_shoot
            // 
            this.btn_shoot.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shoot.Location = new System.Drawing.Point(563, 205);
            this.btn_shoot.Name = "btn_shoot";
            this.btn_shoot.Size = new System.Drawing.Size(136, 43);
            this.btn_shoot.TabIndex = 5;
            this.btn_shoot.Text = "Shoot ";
            this.btn_shoot.UseVisualStyleBackColor = true;
            this.btn_shoot.Click += new System.EventHandler(this.btn_shoot_Click);
            // 
            // btn_shootAway
            // 
            this.btn_shootAway.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_shootAway.Location = new System.Drawing.Point(563, 254);
            this.btn_shootAway.Name = "btn_shootAway";
            this.btn_shootAway.Size = new System.Drawing.Size(136, 39);
            this.btn_shootAway.TabIndex = 6;
            this.btn_shootAway.Text = "Shoot Away";
            this.btn_shootAway.UseVisualStyleBackColor = true;
            this.btn_shootAway.Click += new System.EventHandler(this.btn_shootAway_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn_reset.Font = new System.Drawing.Font("Monotype Corsiva", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.ForeColor = System.Drawing.Color.LightYellow;
            this.btn_reset.Location = new System.Drawing.Point(563, 326);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(136, 36);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Restart";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(106, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 33);
            this.label5.TabIndex = 2;
            this.label5.Click += new System.EventHandler(this.label1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(97, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 33);
            this.label6.TabIndex = 2;
            this.label6.Text = "P";
            this.label6.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(711, 454);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_shootAway);
            this.Controls.Add(this.btn_shoot);
            this.Controls.Add(this.btn_spin);
            this.Controls.Add(this.btn_load);
            this.Controls.Add(this.label_round);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Gun_PointHead);
            this.Controls.Add(this.Gun_PointAway);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointAway)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Gun_PointHead)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Gun_PointAway;
        private System.Windows.Forms.PictureBox Gun_PointHead;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_round;
        private System.Windows.Forms.Button btn_load;
        private System.Windows.Forms.Button btn_spin;
        private System.Windows.Forms.Button btn_shoot;
        private System.Windows.Forms.Button btn_shootAway;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}