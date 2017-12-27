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
using TP_Tracking.Presentation.UI.Trainees;

namespace TP_Tracking.Presentation
{
    public partial class AppForm : Form
    {
        WorkBLO workBLO;
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
                workBLO = WorkBLO.Instance;
                this.showWorksByCategoriesControl1.RefreshShow(workBLO.TraineeDirectory);
                this.configurationFileDeviceControl1.RefreshControl();
            }
            catch (ConfigurationFileNotExistException ex)
            {
                MessageBox.Show("Le fichier qui contient les travaux à faire n'exist pas");
                //DialogResult dialogResult = MessageBox.Show("Voullez-vous créer un fichier exemple", "", MessageBoxButtons.YesNo);
                //if (dialogResult == DialogResult.Yes)
                //{
                //    WorkBLO.CreateConfigurationFileExample();
                //}
                //this.bt_refresh_Click(null, null);
            }
        }

        private void bt_save_repport_Click(object sender, EventArgs e)
        {
            EditerProfile();
            try
            {
               if( workBLO.SaveState() == Enumerations.UserCategory.Former)
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
            Trainee work_directory_trainee = workBLO.TraineeDirectory.Trainee;
            Trainee Cuurent_Trainee = new TraineeBLO().Find(work_directory_trainee);

            // Create form
            TraineeUpdate TraineeUpdate = new TraineeUpdate();
            TraineeUpdate.Dock = DockStyle.Fill;
            TraineeUpdate.UpdateTrainee(Cuurent_Trainee);

            // Create form
            Form formUpdate = new Form();
            formUpdate.Controls.Add(TraineeUpdate);
            formUpdate.Size = new Size(350, 220);
            formUpdate.WindowState = FormWindowState.Normal;
            formUpdate.StartPosition = FormStartPosition.CenterScreen;
            formUpdate.Text = "Validation du profile";

            formUpdate.ShowDialog();
        }
    }
}
