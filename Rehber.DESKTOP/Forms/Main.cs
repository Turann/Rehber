using ClosedXML.Excel;
using Rehber.DESKTOP.Shared;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Windows.Forms;

namespace Rehber.DESKTOP.Forms
{
    public partial class Mainn : Form
    {
        private string flag = "Kisi";
        private readonly string uType;
        readonly Color colour = Color.Peru;
        public static string First, Second, Third, Fourth, Fifth, Sixth, Seventh, Eighth;
        public static int Ninth;
        List<int> RehberInfoIds = new List<int>();

        public Mainn()
        {
            InitializeComponent();
        }

        public Mainn(string uType)
        {
            this.uType = uType;
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            using (var soundPlayer = new SoundPlayer(@"c:\Windows\Media\Speech On.wav"))
            {
                soundPlayer.Play();
            }

            if (uType == "U")
            {
                LokasyonBtn.Visible = false;
                EkleBtn.Visible = false;
                DuzeltBtn.Visible = false;
                SilBtn.Visible = false;
            }

            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Ad";
            dataGridView1.Columns[1].Name = "Soyad";
            dataGridView1.Columns[2].Name = "Dahili No";
            dataGridView1.Columns[3].Name = "Mobil No";
            dataGridView1.Columns[4].Name = "E-Mail";
            dataGridView1.Columns[5].Name = "Şirket";
            dataGridView1.Columns[6].Name = "Görev Yeri";
            dataGridView1.Columns[7].Name = "Açıklama";

            dataGridView1.Columns[0].ValueType = typeof(string);
            dataGridView1.Columns[1].ValueType = typeof(string);
            dataGridView1.Columns[2].ValueType = typeof(string);
            dataGridView1.Columns[3].ValueType = typeof(string);
            dataGridView1.Columns[4].ValueType = typeof(string);
            dataGridView1.Columns[5].ValueType = typeof(string);
            dataGridView1.Columns[6].ValueType = typeof(string);
            dataGridView1.Columns[7].ValueType = typeof(string);

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(250, 250, 250);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(60, 102, 126);
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(41, 71, 89);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 132;
            dataGridView1.Columns[3].Width = 167;
            dataGridView1.Columns[4].Width = 192;
            dataGridView1.Columns[5].Width = 154;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 194;
            dataGridView1.RowHeadersWidth = 30;
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

        private void KisiCellEqualizer()
        {
            First = dataGridView1.SelectedRows[0].Cells["Ad"].Value?.ToString();
            Second = dataGridView1.SelectedRows[0].Cells["Soyad"].Value?.ToString();
            Third = dataGridView1.SelectedRows[0].Cells["Dahili No"].Value?.ToString();
            Fourth = dataGridView1.SelectedRows[0].Cells["Mobil No"].Value?.ToString();
            Fifth = dataGridView1.SelectedRows[0].Cells["E-Mail"].Value?.ToString();
            Sixth = dataGridView1.SelectedRows[0].Cells["Şirket"].Value?.ToString();
            Seventh = dataGridView1.SelectedRows[0].Cells["Görev Yeri"].Value?.ToString();
            Eighth = dataGridView1.SelectedRows[0].Cells["Açıklama"].Value?.ToString();
            Ninth = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];
        }

        private void SirketCellEqualizer()
        {
            First = dataGridView1.SelectedRows[0].Cells["Şirket"].Value?.ToString();
            Second = dataGridView1.SelectedRows[0].Cells["Sabit No"].Value?.ToString();
            Third = dataGridView1.SelectedRows[0].Cells["Fax No"].Value?.ToString();
            Fourth = dataGridView1.SelectedRows[0].Cells["Vergi No"].Value?.ToString();
            Fifth = dataGridView1.SelectedRows[0].Cells["Yetkilisi"].Value?.ToString();
            Sixth = dataGridView1.SelectedRows[0].Cells["Ünvanı"].Value?.ToString();
            Ninth = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];
        }

        private void BirimCellEqualizer()
        {
            First = dataGridView1.SelectedRows[0].Cells["Birim"].Value?.ToString();
            Second = dataGridView1.SelectedRows[0].Cells["Şirket"].Value?.ToString();
            Third = dataGridView1.SelectedRows[0].Cells["Dahili No"].Value?.ToString();
            Fourth = dataGridView1.SelectedRows[0].Cells["Görevli"].Value?.ToString();
            Ninth = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];
        }

        private void SantiyeCellEqualizer()
        {
            First = dataGridView1.SelectedRows[0].Cells["Şantiye"].Value?.ToString();
            Second = dataGridView1.SelectedRows[0].Cells["Sabit No"].Value?.ToString();
            Third = dataGridView1.SelectedRows[0].Cells["Fax No"].Value?.ToString();
            Fourth = dataGridView1.SelectedRows[0].Cells["Yetkilisi"].Value?.ToString();
            Ninth = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];
        }

        private void ListeleBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            dataGridView1.Rows.Clear();
            string AdTemp = AdTb.Text;
            string SoyadTemp = SoyadTb.Text;

            if (AdTb.Text == "Ad" || AdTb.Text == "Şirket Adı" || AdTb.Text == "Birim Adı" || AdTb.Text == "Şantiye Adı")
            {
                AdTemp = "";
            }
            if (SoyadTb.Text == "Soyad")
            {
                SoyadTemp = "";
            }

            var RehberData = RehberInfoRestHelper.GetAll();
            var IletisimData = IletisimRestHelper.GetAll();
            ArrayList row = new ArrayList();
            RehberInfoIds = new List<int>();

            if (flag == "Kisi")
            {
                var RehberTempGate = RehberData.Where(a => a.RehberKayitTuru == 0);

                if (AdTemp != "" && SoyadTemp != "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberTempGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.Ad.Contains(ToUpperEveryWord(AdTemp)) && RehberTemp.Soyad.Contains(ToUpperEveryWord(SoyadTemp)))
                        {
                            row.Add(RehberTemp.Ad);
                            row.Add(RehberTemp.Soyad);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 3).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 7).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Sirket);

                            List<string> GorevYeriList = new List<string>();
                            GorevYeriList.Add(RehberTemp.DepartmanAdi);
                            GorevYeriList.Add(RehberTemp.BirimAdi);
                            GorevYeriList.Add(RehberTemp.Santiye);
                            GorevYeriList.RemoveAll(item => item == "");
                            row.Add(string.Join(", ", GorevYeriList));

                            row.Add(RehberTemp.RAciklama);

                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.Rows.Add(row.ToArray());
                        }
                    }
                    dataGridView1.ClearSelection();
                }
                else if (AdTemp != "" && SoyadTemp == "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberTempGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.Ad.Contains(ToUpperEveryWord(AdTemp)))
                        {
                            row.Add(RehberTemp.Ad);
                            row.Add(RehberTemp.Soyad);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 3).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 7).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Sirket);

                            List<string> GorevYeriList = new List<string>();
                            GorevYeriList.Add(RehberTemp.DepartmanAdi);
                            GorevYeriList.Add(RehberTemp.BirimAdi);
                            GorevYeriList.Add(RehberTemp.Santiye);
                            GorevYeriList.RemoveAll(item => item == "");
                            row.Add(string.Join(", ", GorevYeriList));

                            row.Add(RehberTemp.RAciklama);

                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.Rows.Add(row.ToArray());
                        }
                    }
                    dataGridView1.ClearSelection();
                }
                else if (AdTemp == "" && SoyadTemp != "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberTempGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.Soyad.Contains(ToUpperEveryWord(SoyadTemp)))
                        {
                            row.Add(RehberTemp.Ad);
                            row.Add(RehberTemp.Soyad);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 3).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 7).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Sirket);

                            List<string> GorevYeriList = new List<string>();
                            GorevYeriList.Add(RehberTemp.DepartmanAdi);
                            GorevYeriList.Add(RehberTemp.BirimAdi);
                            GorevYeriList.Add(RehberTemp.Santiye);
                            GorevYeriList.RemoveAll(item => item == "");
                            row.Add(string.Join(", ", GorevYeriList));

                            row.Add(RehberTemp.RAciklama);

                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.Rows.Add(row.ToArray());
                        }
                    }
                    dataGridView1.ClearSelection();
                }
                else
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberTempGate)
                    {
                        row = new ArrayList();

                        row.Add(RehberTemp.Ad);
                        row.Add(RehberTemp.Soyad);

                        int RehId = RehberTemp.Id;

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 3).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 7).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        row.Add(RehberTemp.Sirket);

                        List<string> GorevYeriList = new List<string>();
                        GorevYeriList.Add(RehberTemp.DepartmanAdi);
                        GorevYeriList.Add(RehberTemp.BirimAdi);
                        GorevYeriList.Add(RehberTemp.Santiye);
                        GorevYeriList.RemoveAll(item => item == "");
                        row.Add(string.Join(", ", GorevYeriList));

                        row.Add(RehberTemp.RAciklama);
                        RehberInfoIds.Add(RehberTemp.Id);
                        dataGridView1.Rows.Add(row.ToArray());
                    }
                    dataGridView1.ClearSelection();
                }
            }
            else if (flag == "Sirket")
            {
                var RehberDataGate = RehberData.Where(a => a.RehberKayitTuru == 1);
                var LokasyonData = LokasyonRestHelper.GetAll();
                ArrayList rowTemp = new ArrayList();

                if (AdTemp != "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.Sirket.Contains(ToUpperEveryWord(AdTemp)))
                        {
                            row.Add(RehberTemp.Sirket);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 2).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 4).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 5).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Yetkilisi);
                            row.Add(RehberTemp.SirketUnvani);

                            rowTemp = new ArrayList();

                            foreach (var LokasyonTemp in LokasyonData)
                            {
                                if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                                {
                                    row.Add(LokasyonTemp.LAciklama);
                                }
                                else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                                {
                                    rowTemp.Add(LokasyonTemp.Id);
                                    rowTemp.Add(LokasyonTemp.ParentId);
                                    var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                    if (gate != 0)
                                    {
                                        rowTemp.Add(gate);
                                        var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                        if (gate2 != 0)
                                        {
                                            rowTemp.Add(gate2);
                                            var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                            if (gate3 != 0)
                                            {
                                                rowTemp.Add(gate3);
                                                var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                                if (gate4 != 0)
                                                {
                                                    rowTemp.Add(gate4);
                                                    var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                    if (gate5 != 0)
                                                    {
                                                        rowTemp.Add(gate5);
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    List<string> idk = new List<string>();
                                    for (int i = 0; i < rowTemp.Count; i++)
                                    {
                                        var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                        idk.Add(yu.LAciklama);
                                    }
                                    string Outp = string.Join(", ", idk);
                                    row.Add(Outp);
                                }
                            }
                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.Rows.Add(row.ToArray());
                            dataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        row.Add(RehberTemp.Sirket);

                        int RehId = RehberTemp.Id;

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 2).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 4).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 5).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        row.Add(RehberTemp.Yetkilisi);
                        row.Add(RehberTemp.SirketUnvani);

                        rowTemp = new ArrayList();

                        foreach (var LokasyonTemp in LokasyonData)
                        {
                            if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                            {
                                row.Add(LokasyonTemp.LAciklama);
                            }
                            else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                            {
                                rowTemp.Add(LokasyonTemp.Id);
                                rowTemp.Add(LokasyonTemp.ParentId);
                                var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                if (gate != 0)
                                {
                                    rowTemp.Add(gate);
                                    var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                    if (gate2 != 0)
                                    {
                                        rowTemp.Add(gate2);
                                        var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                        if (gate3 != 0)
                                        {
                                            rowTemp.Add(gate3);
                                            var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                            if (gate4 != 0)
                                            {
                                                rowTemp.Add(gate4);
                                                var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                if (gate5 != 0)
                                                {
                                                    rowTemp.Add(gate5);
                                                }
                                            }
                                        }
                                    }
                                }

                                List<string> idk = new List<string>();
                                for (int i = 0; i < rowTemp.Count; i++)
                                {
                                    var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                    idk.Add(yu.LAciklama);
                                }
                                string Outp = string.Join(", ", idk);
                                row.Add(Outp);
                            }
                        }
                        RehberInfoIds.Add(RehberTemp.Id);
                        dataGridView1.Rows.Add(row.ToArray());
                        dataGridView1.ClearSelection();
                    }
                }
            }
            else if (flag == "Birim")
            {
                var RehberDataGate = RehberData.Where(a => a.RehberKayitTuru == 2);
                var LokasyonData = LokasyonRestHelper.GetAll();
                ArrayList rowTemp = new ArrayList();

                if (AdTemp != "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.BirimAdi.Contains(ToUpperEveryWord(AdTemp)))
                        {
                            row.Add(RehberTemp.BirimAdi);
                            row.Add(RehberTemp.Sirket);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Yetkilisi);

                            rowTemp = new ArrayList();

                            foreach (var LokasyonTemp in LokasyonData)
                            {
                                if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                                {
                                    row.Add(LokasyonTemp.LAciklama);
                                }
                                else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                                {
                                    rowTemp.Add(LokasyonTemp.Id);
                                    rowTemp.Add(LokasyonTemp.ParentId);
                                    var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                    if (gate != 0)
                                    {
                                        rowTemp.Add(gate);
                                        var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                        if (gate2 != 0)
                                        {
                                            rowTemp.Add(gate2);
                                            var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                            if (gate3 != 0)
                                            {
                                                rowTemp.Add(gate3);
                                                var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                                if (gate4 != 0)
                                                {
                                                    rowTemp.Add(gate4);
                                                    var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                    if (gate5 != 0)
                                                    {
                                                        rowTemp.Add(gate5);
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    List<string> idk = new List<string>();
                                    for (int i = 0; i < rowTemp.Count; i++)
                                    {
                                        var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                        idk.Add(yu.LAciklama);
                                    }
                                    string Outp = string.Join(", ", idk);
                                    row.Add(Outp);
                                }
                            }
                            dataGridView1.Rows.Add(row.ToArray());
                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        row.Add(RehberTemp.BirimAdi);
                        row.Add(RehberTemp.Sirket);

                        int RehId = RehberTemp.Id;

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 1).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        row.Add(RehberTemp.Yetkilisi);

                        rowTemp = new ArrayList();

                        foreach (var LokasyonTemp in LokasyonData)
                        {
                            if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                            {
                                row.Add(LokasyonTemp.LAciklama);
                            }
                            else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                            {
                                rowTemp.Add(LokasyonTemp.Id);
                                rowTemp.Add(LokasyonTemp.ParentId);
                                var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                if (gate != 0)
                                {
                                    rowTemp.Add(gate);
                                    var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                    if (gate2 != 0)
                                    {
                                        rowTemp.Add(gate2);
                                        var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                        if (gate3 != 0)
                                        {
                                            rowTemp.Add(gate3);
                                            var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                            if (gate4 != 0)
                                            {
                                                rowTemp.Add(gate4);
                                                var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                if (gate5 != 0)
                                                {
                                                    rowTemp.Add(gate5);
                                                }
                                            }
                                        }
                                    }
                                }

                                List<string> idk = new List<string>();
                                for (int i = 0; i < rowTemp.Count; i++)
                                {
                                    var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                    idk.Add(yu.LAciklama);
                                }
                                string Outp = string.Join(", ", idk);
                                row.Add(Outp);
                            }
                        }
                        dataGridView1.Rows.Add(row.ToArray());
                        RehberInfoIds.Add(RehberTemp.Id);
                        dataGridView1.ClearSelection();
                    }
                }
            }
            else if (flag == "Santiye")
            {
                var LokasyonData = LokasyonRestHelper.GetAll();
                var RehberDataGate = RehberData.Where(a => a.RehberKayitTuru == 3);
                ArrayList rowTemp = new ArrayList();

                if (AdTemp != "")
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        if (RehberTemp.Santiye.Contains(ToUpperEveryWord(AdTemp)))
                        {
                            row.Add(RehberTemp.Santiye);

                            int RehId = RehberTemp.Id;

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 2).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            try
                            {
                                row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 4).First().IAciklama);
                            }
                            catch (InvalidOperationException)
                            {
                                row.Add(null);
                            }

                            row.Add(RehberTemp.Yetkilisi);

                            rowTemp = new ArrayList();

                            foreach (var LokasyonTemp in LokasyonData)
                            {
                                if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                                {
                                    row.Add(LokasyonTemp.LAciklama);
                                }
                                else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                                {
                                    rowTemp.Add(LokasyonTemp.Id);
                                    rowTemp.Add(LokasyonTemp.ParentId);
                                    var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                    if (gate != 0)
                                    {
                                        rowTemp.Add(gate);
                                        var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                        if (gate2 != 0)
                                        {
                                            rowTemp.Add(gate2);
                                            var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                            if (gate3 != 0)
                                            {
                                                rowTemp.Add(gate3);
                                                var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                                if (gate4 != 0)
                                                {
                                                    rowTemp.Add(gate4);
                                                    var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                    if (gate5 != 0)
                                                    {
                                                        rowTemp.Add(gate5);
                                                    }
                                                }
                                            }
                                        }
                                    }

                                    List<string> idk = new List<string>();
                                    for (int i = 0; i < rowTemp.Count; i++)
                                    {
                                        var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                        idk.Add(yu.LAciklama);
                                    }
                                    string Outp = string.Join(", ", idk);
                                    row.Add(Outp);
                                }
                            }
                            dataGridView1.Rows.Add(row.ToArray());
                            RehberInfoIds.Add(RehberTemp.Id);
                            dataGridView1.ClearSelection();
                        }
                    }
                }
                else
                {
                    RehberInfoIds = new List<int>();

                    foreach (var RehberTemp in RehberDataGate)
                    {
                        row = new ArrayList();

                        row.Add(RehberTemp.Santiye);

                        int RehId = RehberTemp.Id;

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 2).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        try
                        {
                            row.Add(IletisimData.Where(a => a.RehberId == RehId && a.IletisimTuru == 4).First().IAciklama);
                        }
                        catch (InvalidOperationException)
                        {
                            row.Add(null);
                        }

                        row.Add(RehberTemp.Yetkilisi);

                        rowTemp = new ArrayList();

                        foreach (var LokasyonTemp in LokasyonData)
                        {
                            if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId == 0)
                            {
                                row.Add(LokasyonTemp.LAciklama);
                            }
                            else if (RehberTemp.LokasId == LokasyonTemp.Id && LokasyonTemp.ParentId != 0)
                            {
                                rowTemp.Add(LokasyonTemp.Id);
                                rowTemp.Add(LokasyonTemp.ParentId);
                                var gate = LokasyonRestHelper.Get((int)LokasyonTemp.ParentId).ParentId;
                                if (gate != 0)
                                {
                                    rowTemp.Add(gate);
                                    var gate2 = LokasyonRestHelper.Get((int)gate).ParentId;
                                    if (gate2 != 0)
                                    {
                                        rowTemp.Add(gate2);
                                        var gate3 = LokasyonRestHelper.Get((int)gate2).ParentId;
                                        if (gate3 != 0)
                                        {
                                            rowTemp.Add(gate3);
                                            var gate4 = LokasyonRestHelper.Get((int)gate3).ParentId;
                                            if (gate4 != 0)
                                            {
                                                rowTemp.Add(gate4);
                                                var gate5 = LokasyonRestHelper.Get((int)gate4).ParentId;
                                                if (gate5 != 0)
                                                {
                                                    rowTemp.Add(gate5);
                                                }
                                            }
                                        }
                                    }
                                }

                                List<string> idk = new List<string>();
                                for (int i = 0; i < rowTemp.Count; i++)
                                {
                                    var yu = LokasyonRestHelper.Get((int)rowTemp[i]);
                                    idk.Add(yu.LAciklama);
                                }
                                string Outp = string.Join(", ", idk);
                                row.Add(Outp);
                            }
                        }
                        dataGridView1.Rows.Add(row.ToArray());
                        RehberInfoIds.Add(RehberTemp.Id);
                        dataGridView1.ClearSelection();
                    }
                }
            }
            Cursor.Current = Cursors.Default;
        }

        private void EkleBtn_Click(object sender, EventArgs e)
        {
            if (flag == "Kisi")
            {
                string flagConnector = "KisiEkle";

                var ekle = new Tool(flagConnector);
                ekle.Text = "Kişi Ekle";
                ekle.ShowDialog();
                if(ekle.DialogResult == DialogResult.OK)
                {
                    ListeleBtn_Click(sender, e);
                }
            }
            else if (flag == "Sirket")
            {
                string flagConnector = "SirketEkle";

                var ekle = new Tool(flagConnector);
                ekle.Text = "Şirket Ekle";
                ekle.Size = new Size(554, 250);
                ekle.ShowDialog();
                if (ekle.DialogResult == DialogResult.OK)
                {
                    ListeleBtn_Click(sender, e);
                }
            }
            else if (flag == "Birim")
            {
                string flagConnector = "BirimEkle";

                var ekle = new Tool(flagConnector);
                ekle.Text = "Birim Ekle";
                ekle.Size = new Size(554, 206);
                ekle.ShowDialog();
                if (ekle.DialogResult == DialogResult.OK)
                {
                    ListeleBtn_Click(sender, e);
                }
            }
            else if (flag == "Santiye")
            {
                string flagConnector = "SantiyeEkle";

                var ekle = new Tool(flagConnector);
                ekle.Text = "Şantiye Ekle";
                ekle.Size = new Size(554, 206);
                ekle.ShowDialog();
                if (ekle.DialogResult == DialogResult.OK)
                {
                    ListeleBtn_Click(sender, e);
                }
            }
        }

        private void DuzeltBtn_Click(object sender, EventArgs e)
        {
            if (flag == "Kisi")
            {
                string flagConnector = "KisiDüzelt";

                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    KisiCellEqualizer();
                    var Duzelt = new Tool(flagConnector);
                    Duzelt.Text = "Kişi Düzelt";
                    Duzelt.ShowDialog();
                    if (Duzelt.DialogResult == DialogResult.OK)
                    {
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Sirket")
            {
                string flagConnector = "SirketDüzelt";

                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    SirketCellEqualizer();
                    var Duzelt = new Tool(flagConnector);
                    Duzelt.Text = "Şirket Düzelt";
                    Duzelt.Size = new Size(554, 250);
                    Duzelt.ShowDialog();
                    if (Duzelt.DialogResult == DialogResult.OK)
                    {
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Birim")
            {
                string flagConnector = "BirimDüzelt";

                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    BirimCellEqualizer();
                    var Duzelt = new Tool(flagConnector);
                    Duzelt.Text = "Birim Düzelt";
                    Duzelt.Size = new Size(554, 206);
                    Duzelt.ShowDialog();
                    if (Duzelt.DialogResult == DialogResult.OK)
                    {
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Santiye")
            {
                string flagConnector = "SantiyeDüzelt";

                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    SantiyeCellEqualizer();
                    var Duzelt = new Tool(flagConnector);
                    Duzelt.Text = "Şantiye Düzelt";
                    Duzelt.Size = new Size(554, 206);
                    Duzelt.ShowDialog();
                    if (Duzelt.DialogResult == DialogResult.OK)
                    {
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
        }

        private async void SilBtn_Click(object sender, EventArgs e)
        {
            if (flag == "Kisi")
            {
                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    string AdSoyad = dataGridView1.SelectedRows[0].Cells["Ad"].Value?.ToString() + " " + dataGridView1.SelectedRows[0].Cells["Soyad"].Value?.ToString();
                    
                    var _messageBox = new MsgBox(1, AdSoyad, "", "silmek");
                    var result = _messageBox.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        int RehberInfoId = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];

                        var IletisimId = IletisimRestHelper.GetAll();

                        foreach (var IletisimIdTemp in IletisimId)
                        {
                            if (IletisimIdTemp.RehberId == RehberInfoId)
                            {
                                await IletisimRestHelper.Delete(IletisimIdTemp.Id);
                            }
                        }
                        await RehberInfoRestHelper.Delete(RehberInfoId);
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Sirket")
            {
                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    string SirketAd = dataGridView1.SelectedRows[0].Cells["Şirket"].Value?.ToString();

                    var _messageBox = new MsgBox(1, SirketAd, "", "silmek");
                    var result = _messageBox.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        int RehberInfoId = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];

                        var IletisimId = IletisimRestHelper.GetAll();

                        foreach (var IletisimIdTemp in IletisimId)
                        {
                            if (IletisimIdTemp.RehberId == RehberInfoId)
                            {
                                await IletisimRestHelper.Delete(IletisimIdTemp.Id);
                            }
                        }
                        await RehberInfoRestHelper.Delete(RehberInfoId);
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Birim")
            {
                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    string BirimAd = dataGridView1.SelectedRows[0].Cells["Birim"].Value?.ToString();

                    var _messageBox = new MsgBox(1, BirimAd, "", "silmek");
                    var result = _messageBox.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        int RehberInfoId = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];

                        var IletisimId = IletisimRestHelper.GetAll();

                        foreach (var IletisimIdTemp in IletisimId)
                        {
                            if (IletisimIdTemp.RehberId == RehberInfoId)
                            {
                                await IletisimRestHelper.Delete(IletisimIdTemp.Id);
                            }
                        }
                        await RehberInfoRestHelper.Delete(RehberInfoId);
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
            else if (flag == "Santiye")
            {
                if (dataGridView1.SelectedRows.Count < 1 || dataGridView1.SelectedRows.Count > 1)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    string SantiyeAd = dataGridView1.SelectedRows[0].Cells["Şantiye"].Value?.ToString();

                    var _messageBox = new MsgBox(1, SantiyeAd, "", "silmek");
                    var result = _messageBox.ShowDialog();

                    if (result == DialogResult.Yes)
                    {
                        int RehberInfoId = RehberInfoIds[dataGridView1.CurrentCell.RowIndex];

                        var IletisimId = IletisimRestHelper.GetAll();

                        foreach (var IletisimIdTemp in IletisimId)
                        {
                            if (IletisimIdTemp.RehberId == RehberInfoId)
                            {
                                await IletisimRestHelper.Delete(IletisimIdTemp.Id);
                            }
                        }
                        await RehberInfoRestHelper.Delete(RehberInfoId);
                        ListeleBtn_Click(sender, e);
                    }
                }
            }
        }

        private void KisiBtn_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            dataGridView1.Rows.Clear();
            flag = "Kisi";
            KisiBtn.BackColor = colour;
            SirketBtn.BackColor = Color.FromArgb(48, 87, 94);
            SantiyeBtn.BackColor = Color.FromArgb(48, 87, 94);
            BirimBtn.BackColor = Color.FromArgb(48, 87, 94);
            LokasyonBtn.BackColor = Color.FromArgb(48, 87, 94);
            AdTb.Text = "Ad";
            SoyadTb.Text = "Soyad";
            SoyadTb.Visible = true;
            AdTb.Visible = true;
            ListeleBtn.Visible = true;
            if (uType == "A")
            {
                EkleBtn.Visible = true;
                DuzeltBtn.Visible = true;
                SilBtn.Visible = true;
            }
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Ad";
            dataGridView1.Columns[1].Name = "Soyad";
            dataGridView1.Columns[2].Name = "Dahili No";
            dataGridView1.Columns[3].Name = "Mobil No";
            dataGridView1.Columns[4].Name = "E-Mail";
            dataGridView1.Columns[5].Name = "Şirket";
            dataGridView1.Columns[6].Name = "Görev Yeri";
            dataGridView1.Columns[7].Name = "Açıklama";
            //dataGridView1.Columns[8].Name = "Lokasyon";

            dataGridView1.Columns[0].Width = 130;
            dataGridView1.Columns[1].Width = 130;
            dataGridView1.Columns[2].Width = 132;
            dataGridView1.Columns[3].Width = 167;
            dataGridView1.Columns[4].Width = 192;
            dataGridView1.Columns[5].Width = 154;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 194;
        }

        private void SirketBtn_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            dataGridView1.Rows.Clear();
            flag = "Sirket";
            SirketBtn.BackColor = colour;
            KisiBtn.BackColor = Color.FromArgb(48, 87, 94);
            SantiyeBtn.BackColor = Color.FromArgb(48, 87, 94);
            BirimBtn.BackColor = Color.FromArgb(48, 87, 94);
            LokasyonBtn.BackColor = Color.FromArgb(48, 87, 94);
            SoyadTb.Visible = false;
            AdTb.Visible = true;
            AdTb.Text = "Şirket Adı";
            ListeleBtn.Visible = true;
            if (uType == "A")
            {
                EkleBtn.Visible = true;
                DuzeltBtn.Visible = true;
                SilBtn.Visible = true;
            }
            dataGridView1.ColumnCount = 7;
            dataGridView1.Columns[0].Name = "Şirket";
            dataGridView1.Columns[1].Name = "Sabit No";
            dataGridView1.Columns[2].Name = "Fax No";
            dataGridView1.Columns[3].Name = "Vergi No";
            dataGridView1.Columns[4].Name = "Yetkilisi";
            dataGridView1.Columns[5].Name = "Ünvanı";
            dataGridView1.Columns[6].Name = "Lokasyon";


            dataGridView1.Columns[0].Width = 157;
            dataGridView1.Columns[1].Width = 157;
            dataGridView1.Columns[2].Width = 159;
            dataGridView1.Columns[3].Width = 196;
            dataGridView1.Columns[4].Width = 165;
            dataGridView1.Columns[5].Width = 166;
            dataGridView1.Columns[6].Width = 249;
        }

        private void BirimBtn_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            dataGridView1.Rows.Clear();
            flag = "Birim";
            BirimBtn.BackColor = colour;
            KisiBtn.BackColor = Color.FromArgb(48, 87, 94);
            SantiyeBtn.BackColor = Color.FromArgb(48, 87, 94);
            SirketBtn.BackColor = Color.FromArgb(48, 87, 94);
            LokasyonBtn.BackColor = Color.FromArgb(48, 87, 94);
            SoyadTb.Visible = false;
            AdTb.Visible = true;
            ListeleBtn.Visible = true;
            AdTb.Text = "Birim Adı";
            if (uType == "A")
            {
                EkleBtn.Visible = true;
                DuzeltBtn.Visible = true;
                SilBtn.Visible = true;
            }
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Birim";
            dataGridView1.Columns[1].Name = "Şirket";
            dataGridView1.Columns[2].Name = "Dahili No";
            dataGridView1.Columns[3].Name = "Görevli";
            dataGridView1.Columns[4].Name = "Lokasyon";

            dataGridView1.Columns[0].Width = 217;
            dataGridView1.Columns[1].Width = 192;
            dataGridView1.Columns[2].Width = 219;
            dataGridView1.Columns[3].Width = 256;
            dataGridView1.Columns[4].Width = 365;
        }

        private void SantiyeBtn_Click(object sender, EventArgs e)
        {
            statusStrip1.Visible = true;
            dataGridView1.Rows.Clear();
            flag = "Santiye";
            SantiyeBtn.BackColor = colour;
            KisiBtn.BackColor = Color.FromArgb(48, 87, 94);
            SirketBtn.BackColor = Color.FromArgb(48, 87, 94);
            BirimBtn.BackColor = Color.FromArgb(48, 87, 94);
            LokasyonBtn.BackColor = Color.FromArgb(48, 87, 94);
            SoyadTb.Visible = false;
            AdTb.Text = "Şantiye Adı";
            AdTb.Visible = true;
            ListeleBtn.Visible = true;
            if (uType == "A")
            {
                EkleBtn.Visible = true;
                DuzeltBtn.Visible = true;
                SilBtn.Visible = true;
            }
            dataGridView1.ColumnCount = 5;
            dataGridView1.Columns[0].Name = "Şantiye";
            dataGridView1.Columns[1].Name = "Sabit No";
            dataGridView1.Columns[2].Name = "Fax No";
            dataGridView1.Columns[3].Name = "Yetkilisi";
            dataGridView1.Columns[4].Name = "Lokasyon";

            dataGridView1.Columns[0].Width = 217;
            dataGridView1.Columns[1].Width = 192;
            dataGridView1.Columns[2].Width = 224;
            dataGridView1.Columns[3].Width = 251;
            dataGridView1.Columns[4].Width = 365;
        }

        private void LokasyonBtn_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            statusStrip1.Visible = false;
            dataGridView1.Rows.Clear();
            flag = "Lokasyon";
            LokasyonBtn.BackColor = colour;
            KisiBtn.BackColor = Color.FromArgb(48, 87, 94);
            SantiyeBtn.BackColor = Color.FromArgb(48, 87, 94);
            BirimBtn.BackColor = Color.FromArgb(48, 87, 94);
            SirketBtn.BackColor = Color.FromArgb(48, 87, 94);
            AdTb.Visible = false;
            SoyadTb.Visible = false;
            dataGridView1.ColumnCount = 0;
            ListeleBtn.Visible = false;
            DuzeltBtn.Visible = false;
            SilBtn.Visible = false;
            EkleBtn.Visible = false;
            new Location(flag).Show();
        }

        private void AktarBtn_ButtonClick(object sender, EventArgs e)
        {

            /*Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Kitap1"];
            worksheet = workbook.ActiveSheet;
            worksheet.Name = "Rehber";

            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                for(int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }

            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.FileName = "output";
            saveFileDialog.DefaultExt = ".xlsx";
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                workbook.SaveAs(saveFileDialog.FileName, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            }
            app.Quit();*/
            if (dataGridView1.Rows.Count == 0)
            {
                var _messageBox = new MsgBox(5, "", "", "");
                _messageBox.ShowDialog();
            }
            else
            {
                DataTable dt = new DataTable();

                foreach (DataGridViewColumn column in dataGridView1.Columns)
                {
                    dt.Columns.Add(column.HeaderText, column.ValueType);
                }

                foreach (DataGridViewRow row in dataGridView1.Rows)
                {
                    dt.Rows.Add();
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        dt.Rows[dt.Rows.Count - 1][cell.ColumnIndex] = cell.Value?.ToString();
                    }
                }

                string folderPath = "C:\\Users\\ROG\\Desktop\\";

                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(dt, "Rehber");
                    wb.SaveAs(folderPath + "Rehber.xlsx");
                }

                var _messageBox = new MsgBox(2, "", "", "");
                _messageBox.ShowDialog();
            }
        }

        private void AdTb_Leave(object sender, EventArgs e)
        {
            if (flag == "Kisi" && AdTb.Text == "")
            {
                AdTb.Text = "Ad";
            }
            else if (flag == "Sirket" && AdTb.Text == "")
            {
                AdTb.Text = "Şirket Adı";
            }
            else if (flag == "Birim" && AdTb.Text == "")
            {
                AdTb.Text = "Birim Adı";
            }
            else if (flag == "Santiye" && AdTb.Text == "")
            {
                AdTb.Text = "Şantiye Adı";
            }
        }

        private void AdTb_Enter(object sender, EventArgs e)
        {
            AdTb.Text = "";

            if (flag == "Kisi" && SoyadTb.Text == "")
            {
                SoyadTb.Text = "Soyad";
            }
        }

        private void SoyadTb_Leave(object sender, EventArgs e)
        {
            if (flag == "Kisi" && SoyadTb.Text == "")
            {
                SoyadTb.Text = "Soyad";
            }
        }

        private void SoyadTb_Enter(object sender, EventArgs e)
        {
            SoyadTb.Text = "";

            if (flag == "Kisi" && AdTb.Text == "")
            {
                AdTb.Text = "Ad";
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
        }

        private void AdTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ListeleBtn_Click(sender, e);
            }
        }

        private void SoyadTb_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true;
                ListeleBtn_Click(sender, e);
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            DuzeltBtn_Click(sender, e);
        }

        private void dataGridView1_MouseDown(object sender, MouseEventArgs e)
        {
            dataGridView1.ClearSelection();
        }
    }
}