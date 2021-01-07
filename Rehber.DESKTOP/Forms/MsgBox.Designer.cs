namespace Rehber.DESKTOP.Forms
{
    partial class MsgBox
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
            this.TamamBtn = new System.Windows.Forms.Button();
            this.TextLbl = new System.Windows.Forms.Label();
            this.HayırBtn = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.IconPb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).BeginInit();
            this.SuspendLayout();
            // 
            // TamamBtn
            // 
            this.TamamBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.TamamBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TamamBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TamamBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.TamamBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.TamamBtn.Location = new System.Drawing.Point(102, 86);
            this.TamamBtn.Name = "TamamBtn";
            this.TamamBtn.Size = new System.Drawing.Size(61, 23);
            this.TamamBtn.TabIndex = 13;
            this.TamamBtn.Text = "Tamam";
            this.TamamBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.TamamBtn.UseVisualStyleBackColor = false;
            this.TamamBtn.Click += new System.EventHandler(this.TamamBtn_Click);
            // 
            // TextLbl
            // 
            this.TextLbl.AutoSize = true;
            this.TextLbl.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextLbl.Location = new System.Drawing.Point(85, 49);
            this.TextLbl.Name = "TextLbl";
            this.TextLbl.Size = new System.Drawing.Size(96, 15);
            this.TextLbl.TabIndex = 15;
            this.TextLbl.Text = "Bir kayıt seçiniz";
            // 
            // HayırBtn
            // 
            this.HayırBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(87)))), ((int)(((byte)(94)))));
            this.HayırBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.HayırBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.HayırBtn.ForeColor = System.Drawing.Color.Cornsilk;
            this.HayırBtn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HayırBtn.Location = new System.Drawing.Point(138, 86);
            this.HayırBtn.Name = "HayırBtn";
            this.HayırBtn.Size = new System.Drawing.Size(61, 23);
            this.HayırBtn.TabIndex = 16;
            this.HayırBtn.Text = " Hayır";
            this.HayırBtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.HayırBtn.UseVisualStyleBackColor = false;
            this.HayırBtn.Visible = false;
            this.HayırBtn.Click += new System.EventHandler(this.HayırBtn_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Rehber.DESKTOP.Properties.Resources.MsgBoxContainerTop;
            this.pictureBox2.Location = new System.Drawing.Point(-4, 1);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(343, 5);
            this.pictureBox2.TabIndex = 19;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Rehber.DESKTOP.Properties.Resources.MsgBoxContainer;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(5, 126);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // IconPb
            // 
            this.IconPb.Image = global::Rehber.DESKTOP.Properties.Resources.exclamation;
            this.IconPb.Location = new System.Drawing.Point(19, 24);
            this.IconPb.Name = "IconPb";
            this.IconPb.Size = new System.Drawing.Size(55, 55);
            this.IconPb.TabIndex = 14;
            this.IconPb.TabStop = false;
            // 
            // MsgBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(248, 119);
            this.ControlBox = false;
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.HayırBtn);
            this.Controls.Add(this.TextLbl);
            this.Controls.Add(this.IconPb);
            this.Controls.Add(this.TamamBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MsgBox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MsgBox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button TamamBtn;
        private System.Windows.Forms.PictureBox IconPb;
        private System.Windows.Forms.Label TextLbl;
        private System.Windows.Forms.Button HayırBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}