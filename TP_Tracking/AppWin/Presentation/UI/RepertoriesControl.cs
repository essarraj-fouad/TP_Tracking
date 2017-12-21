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
        public event EventHandler ErrorMessage;
        public List<Repertory> ListRepertory { set; get; }

        public RepertoriesControl()
        {
            InitializeComponent();
        }

        private void RepertoriesControl_Load(object sender, EventArgs e)
        {
        }

        private void btRefresh_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Clear();
            this.RefreshRepertories();
        }

        public void RefreshRepertories(List<Repertory> ListRepertory)
        {
            this.ListRepertory = ListRepertory;
            this.RefreshRepertories();
        }
        public void RefreshRepertories()
        {
            if(ListRepertory != null)
            {
                foreach (var item in ListRepertory)
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
