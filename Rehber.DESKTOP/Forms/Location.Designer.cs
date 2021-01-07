namespace Rehber.DESKTOP.Forms
{
    partial class Location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Location));
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnSec = new System.Windows.Forms.ToolStripDropDownButton();
            this.DuzeltBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.SilBtn = new System.Windows.Forms.ToolStripSplitButton();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.treeView1.ItemHeight = 21;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(365, 311);
            this.treeView1.TabIndex = 12;
            this.treeView1.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.treeView1_AfterLabelEdit);
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(71)))), ((int)(((byte)(89)))));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSec,
            this.DuzeltBtn,
            this.SilBtn});
            this.statusStrip1.Location = new System.Drawing.Point(0, 289);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(365, 22);
            this.statusStrip1.TabIndex = 29;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnSec
            // 
            this.btnSec.ForeColor = System.Drawing.Color.White;
            this.btnSec.Image = global::Rehber.DESKTOP.Properties.Resources.ekle;
            this.btnSec.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(57, 20);
            this.btnSec.Text = "Ekle";
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // DuzeltBtn
            // 
            this.DuzeltBtn.DropDownButtonWidth = 0;
            this.DuzeltBtn.ForeColor = System.Drawing.Color.White;
            this.DuzeltBtn.Image = global::Rehber.DESKTOP.Properties.Resources.düzelt;
            this.DuzeltBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DuzeltBtn.Name = "DuzeltBtn";
            this.DuzeltBtn.Size = new System.Drawing.Size(61, 20);
            this.DuzeltBtn.Text = "Düzelt";
            this.DuzeltBtn.ButtonClick += new System.EventHandler(this.DuzeltBtn_ButtonClick);
            // 
            // SilBtn
            // 
            this.SilBtn.DropDownButtonWidth = 0;
            this.SilBtn.ForeColor = System.Drawing.Color.White;
            this.SilBtn.Image = global::Rehber.DESKTOP.Properties.Resources.sil;
            this.SilBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SilBtn.Name = "SilBtn";
            this.SilBtn.Size = new System.Drawing.Size(40, 20);
            this.SilBtn.Text = "Sil";
            this.SilBtn.ButtonClick += new System.EventHandler(this.SilBtn_ButtonClick);
            // 
            // Location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(365, 311);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.treeView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Location";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lokasyon";
            this.Load += new System.EventHandler(this.Location_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton btnSec;
        private System.Windows.Forms.ToolStripSplitButton DuzeltBtn;
        private System.Windows.Forms.ToolStripSplitButton SilBtn;
    }
}