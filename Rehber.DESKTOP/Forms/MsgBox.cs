using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rehber.DESKTOP.Forms
{
    public partial class MsgBox : Form
    {
        private int MsgType; //0 = lower than 1, 1 = YesNo, 2 = Aktar, 3 = lokasyonbul, 4 = tool, 5 = aktarbtn
        private string Filler, Filler2, verb;

        public MsgBox()
        {
            InitializeComponent();
        }

        public MsgBox(int MsgType, string Filler, string Filler2, string verb)
        {
            InitializeComponent();
            this.MsgType = MsgType;
            this.Filler = Filler;
            this.verb = verb;
            this.Filler2 = Filler2;
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                this.DialogResult = DialogResult.No;
                return true;
            }
            else if(keyData == (Keys.Enter))
            {
                if(MsgType == 1)
                {
                    Close();
                    this.DialogResult = DialogResult.Yes;
                    return true;
                }
                else
                {
                    Close();
                    this.DialogResult = DialogResult.OK;
                    return true;
                }
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void MsgBox_Load(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Speech Misrecognition.wav"))
            {
                soundPlayer.Play();
            }

            if (MsgType == 1)
            {
                IconPb.Image = Rehber.DESKTOP.Properties.Resources.questionmark;
                HayırBtn.Visible = true;
                TamamBtn.Location = new Point(86, 86);
                HayırBtn.Location = new Point(158, 86);
                TextLbl.Location = new Point(85,27);
                IconPb.Location = new Point(19,21);
                this.Size = new Size(300, 125);
                TamamBtn.Text = "Evet";
                if(Filler2 == "")
                {
                    TextLbl.Text = Filler + " isimli kaydı " + verb + "\nistediğinizden emin misiniz?";
                }
                else
                {
                    TextLbl.Text = Filler + " isimli kaydı " + Filler2 + "\nolarak " + verb +" istediğinizden\nemin misiniz?";
                }
            }
            else if(MsgType == 2)
            {
                TextLbl.Location = new Point(85, 37);
                IconPb.Location = new Point(19, 21);
                this.Size = new Size(300, 125);
                TamamBtn.Location = new Point(120, 86);
                TextLbl.Text = "Tablo masaüstüne konumuna\naktarıldı";
            }
            else if (MsgType == 3)
            {
                TextLbl.Location = new Point(85, 34);
                IconPb.Location = new Point(19, 21);
                this.Size = new Size(350, 125);
                TamamBtn.Location = new Point(145, 86);
                TextLbl.Text = Filler + " isimli kişinin lokasyonu:\n" + Filler2;
            }
            else if (MsgType == 4)
            {
                TamamBtn.Location = new Point(120, 86);
                TextLbl.Location = new Point(85, 34);
                IconPb.Location = new Point(19, 21);
                this.Size = new Size(300, 125);
                TextLbl.Text = Filler + " isimli kayıt\nbaşarıyla " + verb;
            }
            else if (MsgType == 5)
            {
                TamamBtn.Location = new Point(120, 86);
                TextLbl.Location = new Point(85, 34);
                IconPb.Location = new Point(19, 21);
                this.Size = new Size(300, 125);
                TextLbl.Text = "Aktarmak istediğiniz tabloyu\nlisteleyiniz";
            }
        }

        private bool mouseDown;
        private Point lastLocation;

        private void MsgBox_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void MsgBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void MsgBox_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void HayırBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }

        private void TamamBtn_Click(object sender, EventArgs e)
        {
            if (MsgType == 1)
            {
                this.DialogResult = DialogResult.Yes;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
