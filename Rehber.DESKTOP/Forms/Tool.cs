using Rehber.DESKTOP.Classes;
using Rehber.DESKTOP.Shared;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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

        List<string> DahiliList = new List<string>();
        List<string> SabitList = new List<string>();
        List<string> MobilList = new List<string>();
        List<string> FaxList = new List<string>();
        List<string> VergiList = new List<string>();
        List<string> EMailList = new List<string>();
        List<Iletisim> DahiliListObj = new List<Iletisim>();
        List<Iletisim> SabitListObj = new List<Iletisim>();
        List<Iletisim> MobilListObj = new List<Iletisim>();
        List<Iletisim> FaxListObj = new List<Iletisim>();
        List<Iletisim> VergiListObj = new List<Iletisim>();
        List<Iletisim> EMailListObj = new List<Iletisim>();

        private void Tool_Load(object sender, EventArgs e)
        {
            int q = 0;
            KaydetBtn.ShowDropDownArrow = false;
            dataGridView1.Columns[1].Width = 362;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.White;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            

            if (flag == "KisiDüzelt")
            {
                q = 0;
                AdTb.Text = Mainn.First;
                SoyadTb.Text = Mainn.Second;
                DahiliTb.Text = Mainn.Third;
                MobilTb.Text = Mainn.Fourth;
                EmailTb.Text = Mainn.Fifth;
                SirketTb.Text = Mainn.Sixth;
                DepartmanTb.Text = Mainn.Seventh;
                AciklamaTb.Text = Mainn.Eighth;

                DahiliListObj = new List<Iletisim>();
                MobilListObj = new List<Iletisim>();
                EMailListObj = new List<Iletisim>();

                var DetayHolders = IletisimRestHelper.GetAll().Where(a => a.RehberId == Mainn.Ninth);

                foreach (var IletisimContainerTemp in DetayHolders)
                {
                    if (IletisimContainerTemp.IletisimTuru == 1)
                    {
                        DahiliListObj.Add(IletisimContainerTemp);
                    }
                    else if (IletisimContainerTemp.IletisimTuru == 3)
                    {
                        MobilListObj.Add(IletisimContainerTemp);
                    }
                    else if (IletisimContainerTemp.IletisimTuru == 7)
                    {
                        EMailListObj.Add(IletisimContainerTemp);
                    }
                }

                if (DahiliListObj.Count() > 1)
                {
                    for(int i = 1; i < DahiliListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Dahili No";
                        dataGridView1.Rows[q].Cells[1].Value = DahiliListObj[i].IAciklama;
                        q++;
                    }
                }
                if (MobilListObj.Count() > 1)
                {
                    for (int i = 1; i < MobilListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Mobil No";
                        dataGridView1.Rows[q].Cells[1].Value = MobilListObj[i].IAciklama;
                        q++;
                    }
                }
                if (EMailListObj.Count() > 1)
                {
                    for (int i = 1; i < EMailListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "E-mail Adresi";
                        dataGridView1.Rows[q].Cells[1].Value = EMailListObj[i].IAciklama;
                        q++;
                    }
                }
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
                q = 0;
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

                var DetayHolders = IletisimRestHelper.GetAll().Where(a => a.RehberId == Mainn.Ninth);

                SabitListObj = new List<Iletisim>();

                foreach (var IletisimContainerTemp in DetayHolders)
                {
                    if (IletisimContainerTemp.IletisimTuru == 2)
                    {
                        SabitListObj.Add(IletisimContainerTemp);
                    }
                }

                if (SabitListObj.Count() > 1)
                {
                    for (int i = 1; i < SabitListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Sabit No";
                        dataGridView1.Rows[q].Cells[1].Value = SabitListObj[i].IAciklama;
                        q++;
                    }
                }
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
                q = 0;
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

                var DetayHolders = IletisimRestHelper.GetAll().Where(a => a.RehberId == Mainn.Ninth);

                DahiliListObj = new List<Iletisim>();

                foreach (var IletisimContainerTemp in DetayHolders)
                {
                    if (IletisimContainerTemp.IletisimTuru == 1)
                    {
                        DahiliListObj.Add(IletisimContainerTemp);
                    }
                }

                if (DahiliList.Count() > 1)
                {
                    for (int i = 1; i < DahiliListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Dahili No";
                        dataGridView1.Rows[q].Cells[1].Value = DahiliListObj[i].IAciklama;
                        q++;
                    }
                }
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
                q = 0;
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

                var DetayHolders = IletisimRestHelper.GetAll().Where(a => a.RehberId == Mainn.Ninth);

                SabitListObj = new List<Iletisim>();
                FaxListObj = new List<Iletisim>();

                foreach (var IletisimContainerTemp in DetayHolders)
                {
                    if (IletisimContainerTemp.IletisimTuru == 2)
                    {
                        SabitListObj.Add(IletisimContainerTemp);
                    }
                    else if (IletisimContainerTemp.IletisimTuru == 4)
                    {
                        FaxListObj.Add(IletisimContainerTemp);
                    }
                }

                if (SabitListObj.Count() > 1)
                {
                    for (int i = 1; i < SabitListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Sabit No";
                        dataGridView1.Rows[q].Cells[1].Value = SabitListObj[i].IAciklama;
                        q++;
                    }
                }
                if (FaxListObj.Count() > 1)
                {
                    for (int i = 1; i < FaxListObj.Count(); i++)
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[q].Cells[0].Value = "Fax No";
                        dataGridView1.Rows[q].Cells[1].Value = FaxListObj[i].IAciklama;
                        q++;
                    }
                }
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

        int IletisimHolder;

        private async void btnKaydet_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            dataGridView1.EndEdit();

            if (AdTb.Text == "")
            {
                tabControlRehberInfo.SelectedTab = this.tabPage1;
                AdTb.Focus();
                errorProvider1.SetError(AdTb, "Bu kısım boş bırakılamaz");
            }
            else if (AdTb.Text != "")
            {
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

                    for(int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    string AdSoyad = ToUpperEveryWord(AdTb.Text) + " " + UppercaseFirst(SoyadTb.Text);

                    var _messageBox = new MsgBox(4, AdSoyad, "", "eklendi");
                    _messageBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "KisiDüzelt")
                {
                    for (int i = 1; i < DahiliListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(DahiliListObj[i].Id);
                    }
                    for (int i = 1; i < MobilListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(MobilListObj[i].Id);
                    }
                    for (int i = 1; i < EMailListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(EMailListObj[i].Id);
                    }

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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();
                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                if (flag == "SirketDüzelt")
                {
                    for (int i = 1; i < SabitListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(DahiliListObj[i].Id);
                    }

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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "BirimDüzelt")
                {
                    for (int i = 1; i < DahiliListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(DahiliListObj[i].Id);
                    }

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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "eklendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
                else if (flag == "SantiyeDüzelt")
                {
                    for (int i = 1; i < SabitListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(SabitListObj[i].Id);
                    }
                    for (int i = 1; i < FaxListObj.Count(); i++)
                    {
                        await IletisimRestHelper.Delete(FaxListObj[i].Id);
                    }

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

                    for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                    {
                        if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Dahili No")
                        {
                            IletisimHolder = 1;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Sabit No")
                        {
                            IletisimHolder = 2;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Mobil No")
                        {
                            IletisimHolder = 3;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Fax No")
                        {
                            IletisimHolder = 4;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "Vergi No")
                        {
                            IletisimHolder = 5;
                        }
                        else if (dataGridView1.Rows[i].Cells[0].Value.ToString() == "E-mail Adresi")
                        {
                            IletisimHolder = 7;
                        }

                        IletisimVar = new Iletisim();
                        IletisimVar.RehberId = RehberInfoIdHolder;
                        IletisimVar.IletisimTuru = (byte)IletisimHolder;
                        IletisimVar.IAciklama = dataGridView1.Rows[i].Cells[1].Value.ToString();
                        await IletisimRestHelper.Post(IletisimVar);
                    }

                    var _messageBox = new MsgBox(4, ToUpperEveryWord(AdTb.Text), "", "düzenlendi");
                    _messageBox.ShowDialog();

                    this.DialogResult = DialogResult.OK;
                    Close();
                }
            }
            Cursor.Current = Cursors.Default;
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
            dataGridView1.EndEdit();
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