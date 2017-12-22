using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Tracking.BLL;
using TP_Tracking.Entities;

namespace TP_Tracking.Presentation.UI
{
    public partial class RepertoriesControl : UserControl
    {
        public List<FileData> ListDirectory { set; get; }

        public RepertoriesControl()
        {
            InitializeComponent();
        }

        private void RepertoriesControl_Load(object sender, EventArgs e)
        {
        }

        

        public void RefreshRepertories(FileData fileData)
        {
            this.ListDirectory = fileData.ChildsFils;
            this.RefreshRepertories();
        }
        public void RefreshRepertories()
        {
            if(ListDirectory != null)
            {
                treeView1.Nodes.Clear();
                foreach (var item in ListDirectory)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = item.FileInfo.Name;
                    if (item.Validation == Enumerations.ValisationStat.NotValid)
                        treeNode.BackColor = Color.Red;
                    treeView1.Nodes.Add(treeNode);

                }
            }
          

            
        }
    }
}
