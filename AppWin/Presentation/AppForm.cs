using GApp.DAL.Exceptions;
using GApp.DAL.Xml.Exceptions;
using GwinApp;
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
using TP_Tracking.GwinApp;
using TP_Tracking.Presentation.UI;
using TP_Tracking.Presentation.UI.Trainees;

namespace TP_Tracking.Presentation
{
    public partial class AppForm : Form
    {
        TraineeDirectoryBLO2 workBLO;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            this.LoadData();
        }

        private void LoadData()
        {
            try
            {
                workBLO = TraineeDirectoryBLO2.Instance;

                this.showWorksByCategoriesControl1.RefreshShow(workBLO.TraineeDirectory);
                this.configurationFileDeviceControl1.RefreshControl();
            }
            catch (XmlDataFileNotExistException ex)
            {
                MessageBox.Show(ex.Message);
            }
           // lbl_dataFileName.Text = TraineeDirectoryBLO2.Instance.DataFileName;
        }

        private void bt_refresh_Click(object sender, EventArgs e)
        {
            TraineeDirectoryBLO2.Instance.ReloadData();
            this.LoadData();
           


        }

        private void bt_save_repport_Click(object sender, EventArgs e)
        {
            EditerProfile();
            try
            {
                if (workBLO.SaveWorksState() == Enumerations.UserCategory.Former)
                {
                    MessageBox.Show("Bien enregistrer sur le USB du formateur");
                }
                else
                {
                    MessageBox.Show("Bien enregistrer dans votre répertoire du travail");
                }

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

        private void bt_edit_profile_Click(object sender, EventArgs e)
        {
            EditerProfile();
        }

        private void EditerProfile()
        {
            eFormsManager formsManager = new eFormsManager();

            Trainee work_directory_trainee = workBLO.TraineeDirectory.Trainee;
            Trainee Cuurent_Trainee = new TraineeBLO().Find(work_directory_trainee);

            // Create Manager Form
            TraineeUpdate TraineeUpdate = new TraineeUpdate();
            TraineeUpdate.UpdateTrainee(Cuurent_Trainee);

            formsManager.ShwoForm(TraineeUpdate, new Size(350, 220), "Validation du profile");
        }
    }
}
