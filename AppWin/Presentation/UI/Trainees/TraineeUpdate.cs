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

        }
        public Trainee getTrainee()
        {
            return this.traineeForm1.Value as Trainee;
        }
    }
}
