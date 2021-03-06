﻿using System;
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
        
        public Work ParentFileData { set; get; }

        public RepertoriesControl()
        {
            InitializeComponent();
        }

        private void RepertoriesControl_Load(object sender, EventArgs e)
        {
        }

        

        public void RefreshRepertories(Work ParentFileData)
        {
            this.ParentFileData = ParentFileData;
            this.RefreshRepertories();
        }
 
        public void RefreshRepertories()
        {
            if(this.ParentFileData != null)
            {
                treeView1.Nodes.Clear();
                foreach (var dataFile in this.ParentFileData.WorksChilds)
                {
                    TreeNode treeNode = new TreeNode();
                    treeNode.Text = dataFile.FileInfo.Name;
                    if (dataFile.Validation == Enumerations.ValisationStat.NotValid)
                    {
                        treeNode.BackColor = Color.Red;
                        string messageToolTip = string.Join("\n", 
                            dataFile
                            .ListErrorMessage
                            .Select(d => d.Message)
                            .ToList<string>());
                        treeNode.ToolTipText = messageToolTip;
                    }
                      
                    treeView1.Nodes.Add(treeNode);

                }
                this.errorMessageControl1.ShowMessages(this.ParentFileData.ListErrorMessage);
            }
          

            
        }
    }
}
