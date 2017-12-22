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
        ModuleDirectory moduleDirectory;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.bt_refresh_Click(null, null);
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            moduleDirectory = ModuleDirectoryBLO.LoadAndValidateFils();
            this.repertoriesRoot.RefreshRepertories(moduleDirectory.RootDirectoty);
            this.repertoriesTD.RefreshRepertories(moduleDirectory.TD);
            this.repertoriesTP.RefreshRepertories(moduleDirectory.TP);
            this.errorMessageControl.ShowMessages(moduleDirectory.ListErrorMessage);
        }
    }
}
