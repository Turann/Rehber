namespace Rehber.DESKTOP.MyUserControl
{
    partial class MyLocationControl
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
            this.myLocationButton = new System.Windows.Forms.Button();
            this.myLocationText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // myLocationButton
            // 
            this.myLocationButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.myLocationButton.Location = new System.Drawing.Point(173, 0);
            this.myLocationButton.Name = "myLocationButton";
            this.myLocationButton.Size = new System.Drawing.Size(25, 20);
            this.myLocationButton.TabIndex = 0;
            this.myLocationButton.Text = "...";
            this.myLocationButton.UseVisualStyleBackColor = true;
            this.myLocationButton.Click += new System.EventHandler(this.myLocationButton_Click);
            // 
            // myLocationText
            // 
            this.myLocationText.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myLocationText.Location = new System.Drawing.Point(0, 0);
            this.myLocationText.Name = "myLocationText";
            this.myLocationText.Size = new System.Drawing.Size(173, 20);
            this.myLocationText.TabIndex = 1;
            // 
            // MyLocationControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.myLocationText);
            this.Controls.Add(this.myLocationButton);
            this.Name = "MyLocationControl";
            this.Size = new System.Drawing.Size(198, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button myLocationButton;
        private System.Windows.Forms.TextBox myLocationText;
    }
}
