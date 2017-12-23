using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TP_Tracking.Entities;
using TP_Tracking.BLL;
using TP_Tracking.Properties;
using TP_Tracking.DAL;
using TP_Tracking.Enumerations;

namespace TP_Tracking.Presentation.UI
{
    public partial class ConfigurationFileDeviceControl : UserControl
    {
        public ConfigurationFileDeviceControl()
        {
            InitializeComponent();
        }

        private void ConfigurationFileDeviceControl_Load(object sender, EventArgs e)
        {
            this.RefreshControl();
        }
        public void RefreshControl()
        {
            UserBLO userBLO = new UserBLO();
            // Read configuration file
            if (userBLO.GetUserCagegory() == UserCategory.Former)
                this.pictureBox1.Image = Resources.usb;
            else
                this.pictureBox1.Image = Resources.root_directory;

        }
    }
}
