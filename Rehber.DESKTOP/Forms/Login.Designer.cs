namespace Rehber.DESKTOP
{
    partial class Login
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
            this.Rehberlbl = new System.Windows.Forms.Label();
            this.SifrePb = new System.Windows.Forms.PictureBox();
            this.KullaniciAdiPb = new System.Windows.Forms.PictureBox();
            this.SifreTb = new System.Windows.Forms.TextBox();
            this.KullaniciAdiTb = new System.Windows.Forms.TextBox();
            this.PromptLbl = new System.Windows.Forms.Label();
            this.CıkısBtn = new System.Windows.Forms.Button();
            this.TemizleBtn = new System.Windows.Forms.Button();
            this.KaydolBtn = new System.Windows.Forms.Button();
            this.GirisBtn = new Rehber.DESKTOP.RoundButton();
            ((System.ComponentModel.ISupportInitialize)(this.SifrePb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdiPb)).BeginInit();
            this.SuspendLayout();
            // 
            // Rehberlbl
            // 
            this.Rehberlbl.AutoSize = true;
            this.Rehberlbl.Font = new System.Drawing.Font("Calibri", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Rehberlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.Rehberlbl.Location = new System.Drawing.Point(148, 241);
            this.Rehberlbl.Name = "Rehberlbl";
            this.Rehberlbl.Size = new System.Drawing.Size(118, 40);
            this.Rehberlbl.TabIndex = 0;
            this.Rehberlbl.Text = "Rehber";
            // 
            // SifrePb
            // 
            this.SifrePb.Image = global::Rehber.DESKTOP.Properties.Resources.password_icon_png_2;
            this.SifrePb.Location = new System.Drawing.Point(107, 363);
            this.SifrePb.Name = "SifrePb";
            this.SifrePb.Size = new System.Drawing.Size(15, 16);
            this.SifrePb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SifrePb.TabIndex = 21;
            this.SifrePb.TabStop = false;
            // 
            // KullaniciAdiPb
            // 
            this.KullaniciAdiPb.Image = global::Rehber.DESKTOP.Properties.Resources.id;
            this.KullaniciAdiPb.Location = new System.Drawing.Point(105, 317);
            this.KullaniciAdiPb.Name = "KullaniciAdiPb";
            this.KullaniciAdiPb.Size = new System.Drawing.Size(19, 18);
            this.KullaniciAdiPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.KullaniciAdiPb.TabIndex = 20;
            this.KullaniciAdiPb.TabStop = false;
            // 
            // SifreTb
            // 
            this.SifreTb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SifreTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SifreTb.Location = new System.Drawing.Point(99, 360);
            this.SifreTb.Name = "SifreTb";
            this.SifreTb.PasswordChar = '*';
            this.SifreTb.Size = new System.Drawing.Size(211, 22);
            this.SifreTb.TabIndex = 2;
            this.SifreTb.Text = "Şifre";
            this.SifreTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SifreTb.TextChanged += new System.EventHandler(this.SifreTb_TextChanged);
            this.SifreTb.Enter += new System.EventHandler(this.SifreTb_Enter);
            this.SifreTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SifreTb_KeyDown);
            this.SifreTb.Leave += new System.EventHandler(this.SifreTb_Leave);
            // 
            // KullaniciAdiTb
            // 
            this.KullaniciAdiTb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KullaniciAdiTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.KullaniciAdiTb.Location = new System.Drawing.Point(99, 315);
            this.KullaniciAdiTb.Name = "KullaniciAdiTb";
            this.KullaniciAdiTb.Size = new System.Drawing.Size(211, 22);
            this.KullaniciAdiTb.TabIndex = 1;
            this.KullaniciAdiTb.Text = "Kullanıcı Adı";
            this.KullaniciAdiTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.KullaniciAdiTb.TextChanged += new System.EventHandler(this.KullaniciAdiTb_TextChanged_1);
            this.KullaniciAdiTb.Enter += new System.EventHandler(this.KullaniciAdiTb_Enter);
            this.KullaniciAdiTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KullaniciAdiTb_KeyDown);
            this.KullaniciAdiTb.Leave += new System.EventHandler(this.KullaniciAdiTb_Leave);
            // 
            // PromptLbl
            // 
            this.PromptLbl.AutoSize = true;
            this.PromptLbl.Font = new System.Drawing.Font("Calibri", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.PromptLbl.ForeColor = System.Drawing.Color.DarkRed;
            this.PromptLbl.Location = new System.Drawing.Point(172, 412);
            this.PromptLbl.Name = "PromptLbl";
            this.PromptLbl.Size = new System.Drawing.Size(65, 15);
            this.PromptLbl.TabIndex = 0;
            this.PromptLbl.Text = "Hatalı Giriş";
            this.PromptLbl.Visible = false;
            // 
            // CıkısBtn
            // 
            this.CıkısBtn.AutoEllipsis = true;
            this.CıkısBtn.BackColor = System.Drawing.Color.White;
            this.CıkısBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.CıkısBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CıkısBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CıkısBtn.FlatAppearance.BorderSize = 0;
            this.CıkısBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.CıkısBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.CıkısBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CıkısBtn.Font = new System.Drawing.Font("Calibri", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.CıkısBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.CıkısBtn.Location = new System.Drawing.Point(174, 505);
            this.CıkısBtn.Name = "CıkısBtn";
            this.CıkısBtn.Size = new System.Drawing.Size(58, 23);
            this.CıkısBtn.TabIndex = 5;
            this.CıkısBtn.Text = "Çıkış";
            this.CıkısBtn.UseVisualStyleBackColor = false;
            this.CıkısBtn.Click += new System.EventHandler(this.CıkısBtn_Click);
            // 
            // TemizleBtn
            // 
            this.TemizleBtn.AutoEllipsis = true;
            this.TemizleBtn.BackColor = System.Drawing.Color.White;
            this.TemizleBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.TemizleBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.TemizleBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.TemizleBtn.FlatAppearance.BorderSize = 0;
            this.TemizleBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.TemizleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.TemizleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TemizleBtn.Font = new System.Drawing.Font("Calibri", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TemizleBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.TemizleBtn.Location = new System.Drawing.Point(263, 380);
            this.TemizleBtn.Name = "TemizleBtn";
            this.TemizleBtn.Size = new System.Drawing.Size(58, 23);
            this.TemizleBtn.TabIndex = 0;
            this.TemizleBtn.Text = "Temizle";
            this.TemizleBtn.UseVisualStyleBackColor = false;
            this.TemizleBtn.Click += new System.EventHandler(this.TemizleBtn_Click);
            // 
            // KaydolBtn
            // 
            this.KaydolBtn.AutoEllipsis = true;
            this.KaydolBtn.BackColor = System.Drawing.Color.White;
            this.KaydolBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.KaydolBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.KaydolBtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.KaydolBtn.FlatAppearance.BorderSize = 0;
            this.KaydolBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.KaydolBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.KaydolBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KaydolBtn.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KaydolBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.KaydolBtn.Location = new System.Drawing.Point(175, 479);
            this.KaydolBtn.Name = "KaydolBtn";
            this.KaydolBtn.Size = new System.Drawing.Size(58, 23);
            this.KaydolBtn.TabIndex = 4;
            this.KaydolBtn.Text = "Kaydol";
            this.KaydolBtn.UseVisualStyleBackColor = false;
            this.KaydolBtn.Click += new System.EventHandler(this.KaydolBtn_Click_1);
            // 
            // GirisBtn
            // 
            this.GirisBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.GirisBtn.CausesValidation = false;
            this.GirisBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GirisBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GirisBtn.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.GirisBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.GirisBtn.Location = new System.Drawing.Point(57, 436);
            this.GirisBtn.Name = "GirisBtn";
            this.GirisBtn.Size = new System.Drawing.Size(290, 37);
            this.GirisBtn.TabIndex = 3;
            this.GirisBtn.Text = "Giriş";
            this.GirisBtn.UseVisualStyleBackColor = false;
            this.GirisBtn.Click += new System.EventHandler(this.GirisBtn_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::Rehber.DESKTOP.Properties.Resources.login_background;
            this.ClientSize = new System.Drawing.Size(400, 540);
            this.Controls.Add(this.KaydolBtn);
            this.Controls.Add(this.CıkısBtn);
            this.Controls.Add(this.PromptLbl);
            this.Controls.Add(this.GirisBtn);
            this.Controls.Add(this.SifrePb);
            this.Controls.Add(this.KullaniciAdiPb);
            this.Controls.Add(this.SifreTb);
            this.Controls.Add(this.KullaniciAdiTb);
            this.Controls.Add(this.Rehberlbl);
            this.Controls.Add(this.TemizleBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Text = "Rehber Giriş";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Login_MouseDown_1);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Login_MouseMove_1);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Login_MouseUp);
            ((System.ComponentModel.ISupportInitialize)(this.SifrePb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KullaniciAdiPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Rehberlbl;
        private System.Windows.Forms.PictureBox SifrePb;
        private System.Windows.Forms.PictureBox KullaniciAdiPb;
        private System.Windows.Forms.TextBox SifreTb;
        private System.Windows.Forms.TextBox KullaniciAdiTb;
        private RoundButton GirisBtn;
        private System.Windows.Forms.Label PromptLbl;
        private System.Windows.Forms.Button CıkısBtn;
        private System.Windows.Forms.Button TemizleBtn;
        private System.Windows.Forms.Button KaydolBtn;
    }
}