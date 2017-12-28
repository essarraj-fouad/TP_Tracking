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

namespace TP_Tracking.Presentation.UI.Trainees
{
    public partial class TraineeUpdate : UserControl
    {
        public TraineeUpdate()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            this.traineeForm1.GetEntityFromControls();
            TraineeBLO.Instance.Save(this.traineeForm1.Value as Trainee);
            (this.Parent as Form).Close();

        }
        public Trainee getTrainee()
        {
            return this.traineeForm1.Value as Trainee;
        }

        public void UpdateTrainee(Trainee curent_Trainee)
        {
            if (curent_Trainee != null)
            {
                this.traineeForm1.Value = curent_Trainee;
                this.traineeForm1.SetEntityToControls();
            }
        }
    }
}
