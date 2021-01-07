using Rehber.DESKTOP.Classes;
using Rehber.DESKTOP.Shared;
using System;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Rehber.DESKTOP.Forms
{
    public partial class Location : Form
    {
        public int locationId { get; set; }
        public string locationText { get; set; }
        private string flagConnector;
        private string insideConnector = "";
        private string selectedNodeNewText = "";
        private string _selectedNode = "";
        private int IdofOld = 0;
        private int ParentIdofOld = 0;
        TreeViewEventArgs ee;

        public Location()
        {
            InitializeComponent();
        }
        public Location(string flagConnector)
        {
            InitializeComponent();
            this.flagConnector = flagConnector;
        }

        private void Location_Load(object sender, EventArgs e)
        {
            btnSec.ShowDropDownArrow = false;

            if (flagConnector == "other")
            {
                btnSec.Text = "Seç";
                DuzeltBtn.Visible = false;
                SilBtn.Visible = false;
            }

            var LokasyonData = LokasyonRestHelper.GetAll();

            TreeNode TopRootNode = new TreeNode("Lokasyonlar");

            var node = LokasyonData.Where(a => a.ParentId == 0);
            foreach (var item in node)
            {
                TreeNode rootNode = new TreeNode(item.LAciklama);
                Lokasyon LokasyonVar = item as Lokasyon;
                TopRootNode.Nodes.Add(rootNode);
                var childNode = LokasyonData.Where(a => a.ParentId == LokasyonVar.Id);
                foreach (var child in childNode)
                {
                    TreeNode childNo = new TreeNode(child.LAciklama);
                    rootNode.Nodes.Add(childNo);
                    var secondChildNode = LokasyonData.Where(a => a.ParentId == child.Id);
                    foreach (var secChild in secondChildNode)
                    {
                        TreeNode secChildNo = new TreeNode(secChild.LAciklama);
                        childNo.Nodes.Add(secChildNo);
                        var thirdChildNode = LokasyonData.Where(a => a.ParentId == secChild.Id);
                        foreach (var thirdChild in thirdChildNode)
                        {
                            TreeNode thirdChildNo = new TreeNode(thirdChild.LAciklama);
                            secChildNo.Nodes.Add(thirdChildNo);
                            var fourthChildNode = LokasyonData.Where(a => a.ParentId == thirdChild.Id);
                            foreach (var fourthChild in fourthChildNode)
                            {
                                TreeNode fourthChildNo = new TreeNode(fourthChild.LAciklama);
                                thirdChildNo.Nodes.Add(fourthChildNo);
                                var fifthChildNode = LokasyonData.Where(a => a.ParentId == fourthChild.Id); // last written
                                foreach (var fifthChild in fifthChildNode)
                                {
                                    TreeNode fifthChildNo = new TreeNode(fifthChild.LAciklama);
                                    fourthChildNo.Nodes.Add(fifthChildNo);
                                }
                            }
                        }
                    }
                }
            }
            treeView1.Nodes.Add(TopRootNode);
            treeView1.Sort();
            treeView1.ExpandAll();
            treeView1.SelectedNode = null;
            SetTreeViewTheme(treeView1.Handle);
            Cursor.Current = Cursors.Default;
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

        private async void LokasyonImporter()
        {
            Lokasyon LokasyonVar = new Lokasyon();
            LokasyonVar.ParentId = ParentIdofOld;
            LokasyonVar.LAciklama = selectedNodeNewText;

            await LokasyonRestHelper.Put(IdofOld, LokasyonVar);
        }

        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)]
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (flagConnector == "other")
            {
                this.DialogResult = DialogResult.OK;
                locationText = treeView1.SelectedNode.Text;

                var LokasyonData = LokasyonRestHelper.GetAll();

                foreach (var LokasyonTemp in LokasyonData)
                {
                    if (LokasyonTemp.LAciklama == locationText)
                    {
                        locationId = LokasyonTemp.Id;
                    }
                }
            }
            else if (flagConnector == "Lokasyon")
            {
                if (treeView1.SelectedNode == null)
                {
                    var _messageBox = new MsgBox(0, "", "", "");
                    _messageBox.ShowDialog();
                }
                else
                {
                    insideConnector = "LokasyonEkle";
                    treeView1.LabelEdit = true;
                    treeView1.SelectedNode.Nodes.Add("");
                    treeView1.ExpandAll();
                    treeView1.SelectedNode.Nodes[0].BeginEdit();
                }
            }
        }

        private void DuzeltBtn_ButtonClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                var _messageBox = new MsgBox(0, "", "", "");
                _messageBox.ShowDialog();
            }
            else
            {
                insideConnector = "LokasyonDuzelt";
                var LokasyonData = LokasyonRestHelper.GetAll();

                foreach (var LokasyonTemp in LokasyonData)
                {
                    if (LokasyonTemp.LAciklama == _selectedNode)
                    {
                        IdofOld = LokasyonTemp.Id;
                        ParentIdofOld = (int)LokasyonTemp.ParentId;
                    }
                }

                treeView1.LabelEdit = true;
                treeView1.SelectedNode = ee.Node;
                ee.Node.BeginEdit();
            }
        }

        private async void SilBtn_ButtonClick(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode == null)
            {
                var _messageBox = new MsgBox(0, "", "", "");
                _messageBox.ShowDialog();
            }
            else
            {
                insideConnector = "LokasyonSil";

                var _messageBox = new MsgBox(1, _selectedNode, "", "silmek");
                var result = _messageBox.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    var LokasyonData = LokasyonRestHelper.GetAll();

                    foreach (var LokasyonTemp in LokasyonData)
                    {
                        if (LokasyonTemp.LAciklama == _selectedNode)
                        {
                            await LokasyonRestHelper.Delete(LokasyonTemp.Id);
                        }
                    }
                    treeView1.LabelEdit = true;
                    treeView1.SelectedNode.BeginEdit();
                    treeView1.SelectedNode.Remove();
                    treeView1.SelectedNode.EndEdit(true);
                    treeView1.LabelEdit = false;
                    treeView1.SelectedNode = null;
                    _selectedNode = "";
                }
            }
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView1.SelectedNode == e.Node)
            {
                _selectedNode = e.Node.Text;
                ee = e;
                treeView1.SelectedNode = e.Node;
            }
        }

        public static void SetTreeViewTheme(IntPtr treeHandle)
        {
            SetWindowTheme(treeHandle, "explorer", null);
        }

        private async void treeView1_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
        {
            if(insideConnector == "LokasyonEkle") 
            {
                var _messageBox = new MsgBox(1, e.Label, "", "eklemek");
                var result = _messageBox.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    treeView1.SelectedNode.Nodes[0].EndEdit(true);
                    treeView1.LabelEdit = false;                    

                    var LokasyonData = LokasyonRestHelper.GetAll();
                    int LokasyonParentId = 0;
                    Lokasyon LokasyonVar = new Lokasyon();

                    foreach (var LokasyonTemp in LokasyonData)
                    {
                        if (LokasyonTemp.LAciklama == treeView1.SelectedNode.Text)
                        {
                            LokasyonParentId = (int)LokasyonTemp.Id;
                        }
                    }
                    LokasyonVar.ParentId = LokasyonParentId;
                    LokasyonVar.LAciklama = e.Label;

                    await LokasyonRestHelper.Post(LokasyonVar);
                    treeView1.SelectedNode = null;
                    _selectedNode = "";
                }
                else if (result == DialogResult.No)
                {
                    treeView1.SelectedNode.Nodes[0].Remove();
                }
            }
            else if(insideConnector == "LokasyonDuzelt")
            {
                treeView1.LabelEdit = false;
                var _messageBox = new MsgBox(1, e.Node.Text, e.Label, "düzeltmek");
                var result = _messageBox.ShowDialog();

                if (result == DialogResult.Yes)
                {
                    treeView1.SelectedNode = e.Node;
                    selectedNodeNewText = e.Label;
                    LokasyonImporter();
                    treeView1.SelectedNode = null;
                    _selectedNode = "";
                }
            }
        }
    
        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            treeView1.SelectedNode = null;
        }
    }
}