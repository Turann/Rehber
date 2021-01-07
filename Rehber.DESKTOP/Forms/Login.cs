using Rehber.DESKTOP.Forms;
using Rehber.DESKTOP.Shared;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Rehber.DESKTOP
{
    public partial class Login : Form
    {
        private bool mouseDown;
        private Point lastLocation;

        public Login()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.Manual;
            this.Location = new Point(420, 250);
            KullaniciAdiTb.Focus();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Escape))
            {
                Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void SifreTb_TextChanged(object sender, EventArgs e)
        {
            PromptLbl.Visible = false;
        }

        private void KullaniciAdiTb_TextChanged_1(object sender, EventArgs e)
        {
            PromptLbl.Visible = false;
        }

        private void GirisBtn_Click(object sender, EventArgs e)
        {
            var respon = LoginRestHelper.GetAll();
            
            if (KullaniciAdiTb.Text != string.Empty || SifreTb.Text != string.Empty)
            {
                foreach (var temp in respon)
                {
                    if(temp.KullaniciAdi.Equals(KullaniciAdiTb.Text, StringComparison.InvariantCultureIgnoreCase) && temp.Sifre.Equals(SifreTb.Text))
                    {
                        if(temp.Rol.Equals("A"))
                        {
                            new Mainn("A").Show();
                            this.Hide();
                        }
                        else if (temp.Rol.Equals("U"))
                        {
                            new Mainn("U").Show();
                            this.Hide();
                        }
                    }
                    else
                    {
                        PromptLbl.Visible = true;
                    }
                }
            }
        }

        private void KullaniciAdiTb_Enter(object sender, EventArgs e)
        {
            if(KullaniciAdiTb.Text == "Kullanıcı Adı")
            {
                KullaniciAdiTb.Text = "";
            }
        }

        private void KullaniciAdiTb_Leave(object sender, EventArgs e)
        {
            if (KullaniciAdiTb.Text == "")
            {
                KullaniciAdiTb.Text = "Kullanıcı Adı";
            }
        }

        private void SifreTb_Enter(object sender, EventArgs e)
        {
            SifreTb.Text = "";
        }

        private void SifreTb_Leave(object sender, EventArgs e)
        {
            if (SifreTb.Text == "")
            {
                SifreTb.Text = "Şifre";
            }
        }

        private void Login_MouseDown_1(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void Login_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                this.Location = new Point(
                    (this.Location.X - lastLocation.X) + e.X, (this.Location.Y - lastLocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        private void TemizleBtn_Click(object sender, EventArgs e)
        {
            KullaniciAdiTb.Clear();
            SifreTb.Clear();
        }

        private void CıkısBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void KullaniciAdiTb_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GirisBtn_Click(sender, e);
            }
        }

        private void SifreTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                GirisBtn_Click(sender, e);
            }
        }

        private void KaydolBtn_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("www.google.com");
        }
    }
}