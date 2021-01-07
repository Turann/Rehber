namespace Rehber.DESKTOP.Forms
{
    partial class Mainn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Mainn));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.AktarBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panelUstBilgi = new System.Windows.Forms.Panel();
            this.LokasyonBtn = new System.Windows.Forms.Button();
            this.SantiyeBtn = new System.Windows.Forms.Button();
            this.BirimBtn = new System.Windows.Forms.Button();
            this.SirketBtn = new System.Windows.Forms.Button();
            this.KisiBtn = new System.Windows.Forms.Button();
            this.SilBtn = new System.Windows.Forms.Button();
            this.DuzeltBtn = new System.Windows.Forms.Button();
            this.EkleBtn = new System.Windows.Forms.Button();
            this.ListeleBtn = new System.Windows.Forms.Button();
            this.SoyadTb = new System.Windows.Forms.TextBox();
            this.AdTb = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panelUstBilgi.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(49)))), ((int)(((byte)(78)))), ((int)(((byte)(95)))));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AktarBtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 623);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(856, 30);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // AktarBtn
            // 
            this.AktarBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.AktarBtn.DropDownButtonWidth = 0;
            this.AktarBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AktarBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.AktarBtn.Image = global::Rehber.DESKTOP.Properties.Resources.aktar1;
            this.AktarBtn.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.AktarBtn.ImageTransparentColor = System.Drawing.Color.Black;
            this.AktarBtn.MergeIndex = 10;
            this.AktarBtn.Name = "AktarBtn";
            this.AktarBtn.Size = new System.Drawing.Size(66, 28);
            this.AktarBtn.Text = "Aktar";
            this.AktarBtn.ButtonClick += new System.EventHandler(this.AktarBtn_ButtonClick);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Lokasyon";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Soyad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(71, 34);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 20);
            this.txtAd.TabIndex = 0;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(12, 37);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(20, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 222);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.Size = new System.Drawing.Size(856, 401);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDown);
            // 
            // panelUstBilgi
            // 
            this.panelUstBilgi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelUstBilgi.BackgroundImage")));
            this.panelUstBilgi.Controls.Add(this.LokasyonBtn);
            this.panelUstBilgi.Controls.Add(this.SantiyeBtn);
            this.panelUstBilgi.Controls.Add(this.BirimBtn);
            this.panelUstBilgi.Controls.Add(this.SirketBtn);
            this.panelUstBilgi.Controls.Add(this.KisiBtn);
            this.panelUstBilgi.Controls.Add(this.SilBtn);
            this.panelUstBilgi.Controls.Add(this.DuzeltBtn);
            this.panelUstBilgi.Controls.Add(this.EkleBtn);
            this.panelUstBilgi.Controls.Add(this.ListeleBtn);
            this.panelUstBilgi.Controls.Add(this.SoyadTb);
            this.panelUstBilgi.Controls.Add(this.AdTb);
            this.panelUstBilgi.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUstBilgi.Location = new System.Drawing.Point(0, 0);
            this.panelUstBilgi.Name = "panelUstBilgi";
            this.panelUstBilgi.Size = new System.Drawing.Size(856, 222);
            this.panelUstBilgi.TabIndex = 0;
            // 
            // LokasyonBtn
            // 
            this.LokasyonBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.LokasyonBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LokasyonBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.LokasyonBtn.Image = global::Rehber.DESKTOP.Properties.Resources.lokasyon;
            this.LokasyonBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.LokasyonBtn.Location = new System.Drawing.Point(544, 36);
            this.LokasyonBtn.Name = "LokasyonBtn";
            this.LokasyonBtn.Size = new System.Drawing.Size(114, 55);
            this.LokasyonBtn.TabIndex = 10;
            this.LokasyonBtn.Text = "Lokasyon";
            this.LokasyonBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LokasyonBtn.UseVisualStyleBackColor = false;
            this.LokasyonBtn.Click += new System.EventHandler(this.LokasyonBtn_Click);
            // 
            // SantiyeBtn
            // 
            this.SantiyeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.SantiyeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SantiyeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SantiyeBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SantiyeBtn.Image = global::Rehber.DESKTOP.Properties.Resources.şantiye;
            this.SantiyeBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SantiyeBtn.Location = new System.Drawing.Point(428, 36);
            this.SantiyeBtn.Name = "SantiyeBtn";
            this.SantiyeBtn.Size = new System.Drawing.Size(114, 55);
            this.SantiyeBtn.TabIndex = 10;
            this.SantiyeBtn.Text = "Şantiye";
            this.SantiyeBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SantiyeBtn.UseVisualStyleBackColor = false;
            this.SantiyeBtn.Click += new System.EventHandler(this.SantiyeBtn_Click);
            // 
            // BirimBtn
            // 
            this.BirimBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.BirimBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BirimBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BirimBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.BirimBtn.Image = ((System.Drawing.Image)(resources.GetObject("BirimBtn.Image")));
            this.BirimBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.BirimBtn.Location = new System.Drawing.Point(312, 36);
            this.BirimBtn.Name = "BirimBtn";
            this.BirimBtn.Size = new System.Drawing.Size(114, 55);
            this.BirimBtn.TabIndex = 9;
            this.BirimBtn.Text = "Birim";
            this.BirimBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BirimBtn.UseVisualStyleBackColor = false;
            this.BirimBtn.Click += new System.EventHandler(this.BirimBtn_Click);
            // 
            // SirketBtn
            // 
            this.SirketBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.SirketBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SirketBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SirketBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.SirketBtn.Image = global::Rehber.DESKTOP.Properties.Resources.sirket;
            this.SirketBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SirketBtn.Location = new System.Drawing.Point(196, 36);
            this.SirketBtn.Name = "SirketBtn";
            this.SirketBtn.Size = new System.Drawing.Size(114, 55);
            this.SirketBtn.TabIndex = 8;
            this.SirketBtn.Text = "Şirket";
            this.SirketBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.SirketBtn.UseVisualStyleBackColor = false;
            this.SirketBtn.Click += new System.EventHandler(this.SirketBtn_Click);
            // 
            // KisiBtn
            // 
            this.KisiBtn.BackColor = System.Drawing.Color.Peru;
            this.KisiBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.KisiBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KisiBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.KisiBtn.Image = global::Rehber.DESKTOP.Properties.Resources.UserMainn;
            this.KisiBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.KisiBtn.Location = new System.Drawing.Point(80, 36);
            this.KisiBtn.Name = "KisiBtn";
            this.KisiBtn.Size = new System.Drawing.Size(114, 55);
            this.KisiBtn.TabIndex = 7;
            this.KisiBtn.Text = " Kişi";
            this.KisiBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.KisiBtn.UseVisualStyleBackColor = false;
            this.KisiBtn.Click += new System.EventHandler(this.KisiBtn_Click);
            // 
            // SilBtn
            // 
            this.SilBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.SilBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SilBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SilBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.SilBtn.Image = global::Rehber.DESKTOP.Properties.Resources.sil;
            this.SilBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SilBtn.Location = new System.Drawing.Point(590, 125);
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(66, 56);
            this.SilBtn.TabIndex = 6;
            this.SilBtn.Text = "Sil";
            this.SilBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SilBtn.UseVisualStyleBackColor = false;
            this.SilBtn.Click += new System.EventHandler(this.SilBtn_Click);
            // 
            // DuzeltBtn
            // 
            this.DuzeltBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.DuzeltBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DuzeltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.DuzeltBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.DuzeltBtn.Image = global::Rehber.DESKTOP.Properties.Resources.düzelt;
            this.DuzeltBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.DuzeltBtn.Location = new System.Drawing.Point(498, 125);
            this.DuzeltBtn.Name = "DuzeltBtn";
            this.DuzeltBtn.Size = new System.Drawing.Size(66, 56);
            this.DuzeltBtn.TabIndex = 5;
            this.DuzeltBtn.Text = "Düzelt";
            this.DuzeltBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.DuzeltBtn.UseVisualStyleBackColor = false;
            this.DuzeltBtn.Click += new System.EventHandler(this.DuzeltBtn_Click);
            // 
            // EkleBtn
            // 
            this.EkleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.EkleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.EkleBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.EkleBtn.Image = global::Rehber.DESKTOP.Properties.Resources.ekle;
            this.EkleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EkleBtn.Location = new System.Drawing.Point(406, 125);
            this.EkleBtn.Name = "EkleBtn";
            this.EkleBtn.Size = new System.Drawing.Size(66, 56);
            this.EkleBtn.TabIndex = 4;
            this.EkleBtn.Text = "Ekle";
            this.EkleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EkleBtn.UseVisualStyleBackColor = false;
            this.EkleBtn.Click += new System.EventHandler(this.EkleBtn_Click);
            // 
            // ListeleBtn
            // 
            this.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.ListeleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ListeleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ListeleBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.ListeleBtn.Image = ((System.Drawing.Image)(resources.GetObject("ListeleBtn.Image")));
            this.ListeleBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.ListeleBtn.Location = new System.Drawing.Point(313, 125);
            this.ListeleBtn.Name = "ListeleBtn";
            this.ListeleBtn.Size = new System.Drawing.Size(66, 56);
            this.ListeleBtn.TabIndex = 3;
            this.ListeleBtn.Text = "Listele";
            this.ListeleBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ListeleBtn.UseVisualStyleBackColor = false;
            this.ListeleBtn.Click += new System.EventHandler(this.ListeleBtn_Click);
            // 
            // SoyadTb
            // 
            this.SoyadTb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SoyadTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.SoyadTb.Location = new System.Drawing.Point(80, 159);
            this.SoyadTb.Name = "SoyadTb";
            this.SoyadTb.Size = new System.Drawing.Size(202, 22);
            this.SoyadTb.TabIndex = 2;
            this.SoyadTb.Text = "Soyad";
            this.SoyadTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SoyadTb.Enter += new System.EventHandler(this.SoyadTb_Enter);
            this.SoyadTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SoyadTb_KeyDown);
            this.SoyadTb.Leave += new System.EventHandler(this.SoyadTb_Leave);
            // 
            // AdTb
            // 
            this.AdTb.BackColor = System.Drawing.SystemColors.Window;
            this.AdTb.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.AdTb.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.AdTb.Location = new System.Drawing.Point(80, 126);
            this.AdTb.Name = "AdTb";
            this.AdTb.Size = new System.Drawing.Size(202, 22);
            this.AdTb.TabIndex = 1;
            this.AdTb.Text = "Ad";
            this.AdTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AdTb.Enter += new System.EventHandler(this.AdTb_Enter);
            this.AdTb.KeyDown += new System.Windows.Forms.KeyEventHandler(this.AdTb_KeyDown);
            this.AdTb.Leave += new System.EventHandler(this.AdTb_Leave);
            // 
            // Mainn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(856, 653);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panelUstBilgi);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Mainn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Rehber";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panelUstBilgi.ResumeLayout(false);
            this.panelUstBilgi.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripSplitButton AktarBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Panel panelUstBilgi;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox SoyadTb;
        private System.Windows.Forms.TextBox AdTb;
        private System.Windows.Forms.Button ListeleBtn;
        private System.Windows.Forms.Button DuzeltBtn;
        private System.Windows.Forms.Button EkleBtn;
        private System.Windows.Forms.Button SilBtn;
        private System.Windows.Forms.Button KisiBtn;
        private System.Windows.Forms.Button SantiyeBtn;
        private System.Windows.Forms.Button BirimBtn;
        private System.Windows.Forms.Button SirketBtn;
        private System.Windows.Forms.Button LokasyonBtn;
    }
}