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
using TP_Tracking.DAL;
using TP_Tracking.Entities;
using TP_Tracking.Exceptions;
using TP_Tracking.Presentation.UI;

namespace TP_Tracking.Presentation
{
    public partial class AppForm : Form
    {
        WorkBLO moduleDirectoryBLO;
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
            try
            {
                moduleDirectoryBLO = new WorkBLO();
                this.showWorksByCategoriesControl1.RefreshShow(moduleDirectoryBLO.TraineeDirectory);
                this.configurationFileDeviceControl1.RefreshControl();
            }
            catch (ConfigurationFileNotExistException ex)
            {
                MessageBox.Show("Le fichier qui contient les travaux à faire n'exist pas");
                DialogResult dialogResult = MessageBox.Show("Voullez-vous créer un fichier exemple", "", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    WorkBLO.CreateConfigurationFileExample();
                }
                this.bt_refresh_Click(null, null);
            }
        }

        private void bt_save_repport_Click(object sender, EventArgs e)
        {
            try
            {
                moduleDirectoryBLO.SaveState();
            }
            catch (USBDeviceNotExistException ex)
            {

                string msg = string.Format("USB du formateur n'est pas enregistrer");
                MessageBox.Show(msg);
            }
           
        }

        private void groupBoxRepertories_Enter(object sender, EventArgs e)
        {

        }

        private void btEditeProfile_Click(object sender, EventArgs e)
        {

        }
    }
}
