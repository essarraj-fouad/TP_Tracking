using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Tracking.BLL;
using TP_Tracking.Entities;

namespace TP_Tracking.Presentation
{
    public partial class AppForm : Form
    {
        ModuleDirectory repertories;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            ModuleDirectory repertories = RepertoriesBLO.LoadRepertoies();
            this.repertoriesRoot.RefreshRepertories(repertories.ListRepertory);
            this.repertoriesTD.RefreshRepertories(repertories.ListTD);
            this.repertoriesTP.RefreshRepertories(repertories.ListTP);

            this.errorMessageControl.ShowMessages(repertories.ListErrorMessage);

           
        }
    }
}
