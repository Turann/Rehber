using Rehber.DESKTOP.Classes;
using Rehber.DESKTOP.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Rehber.DESKTOP.Forms
{
    public partial class Tool : Form
    {
        string flag;

        public Tool()
        {
            InitializeComponent();
        }

        public Tool(string flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void Tool_Load(object sender, EventArgs e)
        {
            KaydetBtn.ShowDropDownArrow = false;
            dataGridView1.Columns[1].Width = 362;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;

            if (flag == "KisiDüzelt")
            {
                AdTb.Text = Mainn.First;
                SoyadTb.Text = Mainn.Second;
                DahiliTb.Text = Mainn.Third;
                MobilTb.Text = Mainn.Fourth;
                EmailTb.Text = Mainn.Fifth;
                SirketTb.Text = Mainn.Sixth;
                DepartmanTb.Text = Mainn.Seventh;
                AciklamaTb.Text = Mainn.Eighth;
            }
            else if (flag == "SirketEkle")
            {
                AdLbl.Text = "Şirket Adı:";
                SoyadLbl.Text = "Sabit No:";
                SoyadTb.Size = new Size(56, 20);
                DahiliLbl.Text = "Fax No:";
                DahiliTb.Size = new Size(105, 20);
                MobilLbl.Text = "Vergi No:";
                MobilTb.Size = new Size(105, 20);
                EmailLbl.Text = "Yetkilisi:";
                EmailTb.Size = new Size(243, 20);
                DepartmanLbl.Text = "Yetkili Ünvanı:";
                DepartmanTb.Size = new Size(203, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                LokasyonLbl.Location = new Point(25, 139);
                myLocationControl.Location = new Point(123, 136);
            }
            else if (flag == "SirketDüzelt")
            {
                AdLbl.Text = "Şirket Adı:";
                SoyadLbl.Text = "Sabit No:";
                SoyadTb.Size = new Size(56, 20);
                DahiliLbl.Text = "Fax No:";
                DahiliTb.Size = new Size(105, 20);
                MobilLbl.Text = "Vergi No:";
                MobilTb.Size = new Size(105, 20);
                EmailLbl.Text = "Yetkilisi:";
                EmailTb.Size = new Size(243, 20);
                DepartmanLbl.Text = "Yetkili Ünvanı:";
                DepartmanTb.Size = new Size(203, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                AdTb.Text = Mainn.First;
                SoyadTb.Text = Mainn.Second;
                DahiliTb.Text = Mainn.Third;
                MobilTb.Text = Mainn.Fourth;
                EmailTb.Text = Mainn.Fifth;
                DepartmanTb.Text = Mainn.Sixth;
                LokasyonLbl.Location = new Point(25, 139);
                myLocationControl.Location = new Point(123, 136);
            }
            else if (flag == "BirimEkle")
            {
                AdLbl.Text = "Birim Adı:";
                SoyadLbl.Text = "Şirket Adı:";
                DahiliLbl.Text = "Dahili No:";
                MobilLbl.Text = "Görevli:";
                MobilTb.Size = new Size(243, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                EmailLbl.Visible = false;
                EmailTb.Visible = false;
                DepartmanLbl.Visible = false;
                DepartmanTb.Visible = false;
                LokasyonLbl.Location = new Point(25, 97);
                myLocationControl.Location = new Point(123, 94);
            }
            else if (flag == "BirimDüzelt")
            {
                AdLbl.Text = "Birim Adı:";
                SoyadLbl.Text = "Şirket Adı:";
                DahiliLbl.Text = "Dahili No:";
                MobilLbl.Text = "Görevli:";
                MobilTb.Size = new Size(243, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                EmailLbl.Visible = false;
                EmailTb.Visible = false;
                DepartmanLbl.Visible = false;
                DepartmanTb.Visible = false;
                AdTb.Text = Mainn.First;
                SoyadTb.Text = Mainn.Second;
                DahiliTb.Text = Mainn.Third;
                MobilTb.Text = Mainn.Fourth;
                LokasyonLbl.Location = new Point(25, 97);
                myLocationControl.Location = new Point(123, 94);
            }
            else if (flag == "SantiyeEkle")
            {
                AdLbl.Text = "Şantiye Adı:";
                SoyadLbl.Text = "Sabit No:";
                SoyadTb.Size = new Size(143, 20);
                DahiliLbl.Text = "Fax No:";
                DahiliTb.Size = new Size(105, 20);
                MobilLbl.Text = "Yetkilisi:";
                MobilTb.Size = new Size(243, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                EmailLbl.Visible = false;
                EmailTb.Visible = false;
                DepartmanLbl.Visible = false;
                DepartmanTb.Visible = false;
                LokasyonLbl.Location = new Point(25, 97);
                myLocationControl.Location = new Point(123, 94);
            }
            else if (flag == "SantiyeDüzelt")
            {
                AdLbl.Text = "Şantiye Adı:";
                SoyadLbl.Text = "Sabit No:";
                SoyadTb.Size = new Size(110, 20);
                DahiliLbl.Text = "Fax No:";
                DahiliTb.Size = new Size(110, 20);
                MobilLbl.Text = "Yetkilisi:";
                MobilTb.Size = new Size(243, 20);
                BirimLbl.Visible = false;
                BirimTb.Visible = false;
                SantiyeLbl.Visible = false;
                SantiyeTb.Visible = false;
                AciklamaLbl.Visible = false;
                AciklamaTb.Visible = false;
                SirketLbl.Visible = false;
                SirketTb.Visible = false;
                EmailLbl.Visible = false;
                EmailTb.Visible = false;
                DepartmanLbl.Visible = false;
                DepartmanTb.Visible = false;
                AdTb.Text = Mainn.First;
                SoyadTb.Text = Mainn.Second;
                DahiliTb.Text = Mainn.Third;
                MobilTb.Text = Mainn.Fourth;
                LokasyonLbl.Location = new Point(25, 97);
                myLocationControl.Location = new Point(123, 94);
            }
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

        public static string ToUpperEveryWord(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }

            var words = s.Split(' ');

            var t = "";
            foreach (var word in words)
            {
                t += char.ToUpper(word[0]) + word.Substring(1) + ' ';
            }
            return t.Trim();
        }

        static string UppercaseFirst(string s)
        {
            if (string.IsNullOrEmpty(s))
            {
                return string.Empty;
            }
            return char.ToUpper(s[0]) + s.Substring(1);
        }

        private int IdFinderEkle()
        {
            var RehberInfoData = RehberInfoRestHelper.GetAll();

            foreach (var RehberInfoTemp in RehberInfoData)
            {
                if (RehberInfoTemp.Ad == ToUpperEveryWord(AdTb.Text) && RehberInfoTemp.Soyad == UppercaseFirst(SoyadTb.Text) && RehberInfoTemp.DepartmanAdi == ToUpperEveryWord(DepartmanTb.Text) && RehberInfoTemp.Sirket == ToUpperEveryWord(SirketTb.Text) && RehberInfoTemp.Santiye == ToUpperEveryWord(SantiyeTb.Text) && RehberInfoTemp.RAciklama == UppercaseFirst(AciklamaTb.Text))
                {
                    return RehberInfoTemp.Id;
                }
            }
            return 0;
        }

        private int SirketIdFinderEkle()
        {
            var RehberInfoData = RehberInfoRestHelper.GetAll();

            foreach (var RehberInfoTemp in RehberInfoData)
            {
                if (RehberInfoTemp.Sirket == ToUpperEveryWord(AdTb.Text) && RehberInfoTemp.Yetkilisi == ToUpperEveryWord(EmailTb.Text) && RehberInfoTemp.SirketUnvani == ToUpperEveryWord(DepartmanTb.Text))
                {
                    return RehberInfoTemp.Id;
                }
            }
            return 0;
        }

        private int BirimIdFinderEkle()
        {
            var RehberInfoData = RehberInfoRestHelper.GetAll();

            foreach (var RehberInfoTemp in RehberInfoData)
            {
                if (RehberInfoTemp.BirimAdi == ToUpperEveryWord(AdTb.Text) && RehberInfoTemp.Sirket == ToUpperEveryWord(SoyadTb.Text) && RehberInfoTemp.Yetkilisi == ToUpperEveryWord(MobilTb.Text))
                {
                    return RehberInfoTemp.Id;
                }
            }
            return 0;
        }

        private int SantiyeIdFinderEkle()
        {
            var RehberInfoData = RehberInfoRestHelper.GetAll();

            foreach (var RehberInfoTemp in RehberInfoData)
            {
                if (RehberInfoTemp.Santiye == ToUpperEveryWord(AdTb.Text) && RehberInfoTemp.Yetkilisi == ToUpperEveryWord(MobilTb.Text))
                {
                    return RehberInfoTemp.Id;
                }
            }
            return 0;
        }

        private int IleDahiliIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach(var IletisimTemp in IletisimData)
            {
                if(IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 1 && IletisimTemp.IAciklama == Mainn.Third)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int SirketIleSabitIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 2 && IletisimTemp.IAciklama == Mainn.Second)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int BirimIleSabitIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 1 && IletisimTemp.IAciklama == Mainn.Third)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int SantiyeIleSabitIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 2 && IletisimTemp.IAciklama == Mainn.Second)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int IleMobilIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 3 && IletisimTemp.IAciklama == Mainn.Fourth)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int SirketIleFaxIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 4 && IletisimTemp.IAciklama == Mainn.Third)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int SantiyeIleFaxIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 4 && IletisimTemp.IAciklama == Mainn.Third)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int IleEmailIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 7 && IletisimTemp.IAciklama == Mainn.Fifth)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private int SirketIleVergiIdFinder(int RehberInfoIdHolder)
        {
            var IletisimData = IletisimRestHelper.GetAll();

            foreach (var IletisimTemp in IletisimData)
            {
                if (IletisimTemp.RehberId == RehberInfoIdHolder && IletisimTemp.IletisimTuru == 5 && IletisimTemp.IAciklama == Mainn.Fourth)
                {
                    return IletisimTemp.Id;
                }
            }
            return 0;
        }

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            int IletisimHolder;

            if (AdTb.Text == "")
            {
                AdTb.Focus();
                errorProvider1.SetError(AdTb, "Bu kısım boş bırakılamaz");
            }
            else if (AdTb.Text != "")
            {
                Cursor.Current = Cursors.WaitCursor;

                if (flag == "KisiEkle")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = 32;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Ad = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Soyad = ToUpperEveryWord(SoyadTb.Text);
                    RehberInfoVar.Sirket = ToUpperEveryWord(SirketTb.Text);
                    RehberInfoVar.DepartmanAdi = ToUpperEveryWord(DepartmanTb.Text);
                    RehberInfoVar.Santiye = ToUpperEveryWord(SantiyeTb.Text);
                    RehberInfoVar.RAciklama = UppercaseFirst(AciklamaTb.Text);
                    RehberInfoVar.BirimAdi = ToUpperEveryWord(BirimTb.Text);
                    RehberInfoVar.RehberKayitTuru = 0;

                    await RehberInfoRestHelper.Post(RehberInfoVar);

                    int RehberInfoIdHolder = IdFinderEkle();
                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 1;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);

                    }
                    if (RehberInfoIdHolder != 0 && MobilTb.Text != null && MobilTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 3;
                        IletisimVar.IAciklama = MobilTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);
                    }
                    if (RehberInfoIdHolder != 0 && EmailTb.Text != null && EmailTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 7;
                        IletisimVar.IAciklama = EmailTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    dataGridView1.Rows[0].Cells[0].Value.

                    if ((string)dataGridView1.Rows[0].Cells[0].Value == "Fax No")
                    {
                        int p = dataGridView1.Rows[0].Index;
                    }


                    string AdSoyad = ToUpperEveryWord(AdTb.Text) + " " + UppercaseFirst(SoyadTb.Text);

                    var _messageBox = new MsgBox(4, AdSoyad, "", "eklendi");
                    _messageBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "KisiDüzelt")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    int RehberInfoIdHolder = Mainn.Ninth;

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = RehberInfoRestHelper.Get(RehberInfoIdHolder).LokasId;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Ad = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Soyad = ToUpperEveryWord(SoyadTb.Text);
                    RehberInfoVar.Sirket = ToUpperEveryWord(SirketTb.Text);
                    RehberInfoVar.DepartmanAdi = ToUpperEveryWord(DepartmanTb.Text);
                    RehberInfoVar.Santiye = ToUpperEveryWord(SantiyeTb.Text);
                    RehberInfoVar.RAciklama = UppercaseFirst(AciklamaTb.Text);
                    RehberInfoVar.BirimAdi = ToUpperEveryWord(BirimTb.Text);
                    RehberInfoVar.RehberKayitTuru = 0;

                    await RehberInfoRestHelper.Put(RehberInfoIdHolder, RehberInfoVar);

                    var RehberInfoData = RehberInfoRestHelper.GetAll();

                    int IletisimIdHolder = IleDahiliIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 1;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        if (IletisimIdHolder == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder, IletisimVar);
                        }
                    }
                    int IletisimIdHolder2 = IleMobilIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && MobilTb.Text != null && MobilTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 3;
                        IletisimVar.IAciklama = MobilTb.Text;
                        if (IletisimIdHolder2 == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder2, IletisimVar);
                        }
                    }
                    int IletisimIdHolder3 = IleEmailIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && EmailTb.Text != null && EmailTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 7;
                        IletisimVar.IAciklama = EmailTb.Text;
                        if (IletisimIdHolder3 == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder3, IletisimVar);
                        }
                    }

                    string AdSoyad = ToUpperEveryWord(AdTb.Text) + " " + UppercaseFirst(SoyadTb.Text);

                    var _messageBox = new MsgBox(4, AdSoyad, "", "düzenlendi");
                    _messageBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "SirketEkle")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = 32;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Sirket = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(EmailTb.Text);
                    RehberInfoVar.SirketUnvani = ToUpperEveryWord(DepartmanTb.Text);
                    RehberInfoVar.RehberKayitTuru = 1;

                    await RehberInfoRestHelper.Post(RehberInfoVar);

                    int RehberInfoIdHolder = SirketIdFinderEkle();

                    if (RehberInfoIdHolder != 0 && SoyadTb.Text != null && SoyadTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 2;
                        IletisimVar.IAciklama = SoyadTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);

                    }
                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 4;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);
                    }
                    if (RehberInfoIdHolder != 0 && MobilTb.Text != null && MobilTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 5;
                        IletisimVar.IAciklama = MobilTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                if (flag == "SirketDüzelt")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    int RehberInfoIdHolder = Mainn.Ninth;

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = RehberInfoRestHelper.Get(RehberInfoIdHolder).LokasId;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Sirket = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(EmailTb.Text);
                    RehberInfoVar.SirketUnvani = ToUpperEveryWord(DepartmanTb.Text);
                    RehberInfoVar.RehberKayitTuru = 1;

                    await RehberInfoRestHelper.Put(RehberInfoIdHolder, RehberInfoVar);

                    var RehberInfoData = RehberInfoRestHelper.GetAll();

                    int IletisimIdHolder = SirketIleSabitIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && SoyadTb.Text != null && SoyadTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 2;
                        IletisimVar.IAciklama = SoyadTb.Text;
                        if (IletisimIdHolder == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder, IletisimVar);
                        }
                    }
                    int IletisimIdHolder2 = SirketIleFaxIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 4;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        if (IletisimIdHolder2 == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder2, IletisimVar);
                        }
                    }
                    int IletisimIdHolder3 = SirketIleVergiIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && MobilTb.Text != null && MobilTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 5;
                        IletisimVar.IAciklama = MobilTb.Text;
                        if (IletisimIdHolder3 == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder3, IletisimVar);
                        }
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "düzenlendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "BirimEkle")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = 32;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.BirimAdi = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Sirket = ToUpperEveryWord(SoyadTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(MobilTb.Text);
                    RehberInfoVar.RehberKayitTuru = 2;

                    await RehberInfoRestHelper.Post(RehberInfoVar);

                    int RehberInfoIdHolder = BirimIdFinderEkle();

                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 1;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);

                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "BirimDüzelt")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    int RehberInfoIdHolder = Mainn.Ninth;

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = RehberInfoRestHelper.Get(RehberInfoIdHolder).LokasId;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.BirimAdi = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Sirket = ToUpperEveryWord(SoyadTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(MobilTb.Text);
                    RehberInfoVar.RehberKayitTuru = 2;

                    await RehberInfoRestHelper.Put(RehberInfoIdHolder, RehberInfoVar);

                    var RehberInfoData = RehberInfoRestHelper.GetAll();

                    int IletisimIdHolder = BirimIleSabitIdFinder(RehberInfoIdHolder);

                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 1;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        if (IletisimIdHolder == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder, IletisimVar);
                        }
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "düzenlendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "SantiyeEkle")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = 32;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Santiye = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(MobilTb.Text);
                    RehberInfoVar.RehberKayitTuru = 3;

                    await RehberInfoRestHelper.Post(RehberInfoVar);

                    int RehberInfoIdHolder = SantiyeIdFinderEkle();

                    if (RehberInfoIdHolder != 0 && SoyadTb.Text != null && SoyadTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 2;
                        IletisimVar.IAciklama = SoyadTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);

                    }

                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 4;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        await IletisimRestHelper.Post(IletisimVar);

                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "SantiyeDüzelt")
                {
                    RehberInfo RehberInfoVar = new RehberInfo();
                    Lokasyon LokasyonVar = new Lokasyon();
                    Iletisim IletisimVar = new Iletisim();

                    var LokasyonData = LokasyonRestHelper.GetAll();

                    int RehberInfoIdHolder = Mainn.Ninth;

                    if (myLocationControl.locationId == 0)
                    {
                        RehberInfoVar.LokasId = RehberInfoRestHelper.Get(RehberInfoIdHolder).LokasId;
                    }
                    else
                    {
                        RehberInfoVar.LokasId = myLocationControl.locationId;
                    }

                    RehberInfoVar.Santiye = ToUpperEveryWord(AdTb.Text);
                    RehberInfoVar.Yetkilisi = ToUpperEveryWord(MobilTb.Text);
                    RehberInfoVar.RehberKayitTuru = 3;

                    await RehberInfoRestHelper.Put(RehberInfoIdHolder, RehberInfoVar);

                    var RehberInfoData = RehberInfoRestHelper.GetAll();

                    int IletisimIdHolder = SantiyeIleSabitIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && SoyadTb.Text != null && SoyadTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 2;
                        IletisimVar.IAciklama = SoyadTb.Text;
                        if (IletisimIdHolder == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder, IletisimVar);
                        }
                    }

                    int IletisimIdHolder2 = SantiyeIleFaxIdFinder(RehberInfoIdHolder);
                    if (RehberInfoIdHolder != 0 && DahiliTb.Text != null && DahiliTb.Text != "")
                    {
                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = 4;
                        IletisimVar.IAciklama = DahiliTb.Text;
                        if (IletisimIdHolder2 == 0)
                        {
                            await IletisimRestHelper.Post(IletisimVar);
                        }
                        else
                        {
                            await IletisimRestHelper.Put(IletisimIdHolder2, IletisimVar);
                        }
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "düzenlendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                Cursor.Current = Cursors.WaitCursor;
            }
        }

        private void tabControlRehberInfo_DrawItem(object sender, DrawItemEventArgs e)
        {
            Brush br = new SolidBrush(Color.FromArgb(48, 87, 94));
            Brush bc = new SolidBrush(Color.White);

            if (tabControlRehberInfo.SelectedIndex == e.Index)
            {
                e.Graphics.FillRectangle(br, e.Bounds);
            }
            else
                e.Graphics.FillRectangle(bc, e.Bounds);

            var rotatedRectangle = new Rectangle(0, 0, e.Bounds.Height, e.Bounds.Width);

            e.Graphics.ResetTransform();
            e.Graphics.RotateTransform(-90);

            e.Graphics.TranslateTransform(e.Bounds.Left, e.Bounds.Bottom, System.Drawing.Drawing2D.MatrixOrder.Append);

            var drawFormat = new System.Drawing.StringFormat();
            drawFormat.Alignment = StringAlignment.Center;
            drawFormat.LineAlignment = StringAlignment.Center;

            if (tabControlRehberInfo.SelectedIndex == e.Index)
            {
                e.Graphics.DrawString(tabControlRehberInfo.TabPages[e.Index].Text, e.Font, Brushes.White, rotatedRectangle, drawFormat);
            }
            else
                e.Graphics.DrawString(tabControlRehberInfo.TabPages[e.Index].Text, e.Font, Brushes.Black, rotatedRectangle, drawFormat);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }

        private void dataGridView1_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var hitTestInfo = dataGridView1.HitTest(e.X, e.Y);

                if (hitTestInfo.Type == DataGridViewHitTestType.Cell)
                    dataGridView1.BeginEdit(true);
                else
                    dataGridView1.EndEdit();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;
            if (e.ColumnIndex != 0)
                return;

            dataGridView1.BeginEdit(true);
            ComboBox com = (ComboBox)dataGridView1.EditingControl;
            com.DroppedDown = true;
        }
    }
}