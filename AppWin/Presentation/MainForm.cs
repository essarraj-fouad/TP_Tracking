using GwinApp;
using GwinManager;
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
using TP_Tracking.Presentation.Forms;
using TP_Tracking.Presentation.Groups;
using TP_Tracking.Specialties;

namespace TP_Tracking.Presentation
{
    public partial class MainForm : FormApplication
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void gestionDesSpécialitésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GwinManagerControl<Specialty, SpecialtyForm, SpecialtyDataGrid>
              managerForm = new GwinManagerControl<Specialty, SpecialtyForm, SpecialtyDataGrid>(new SpecialtyBLO());

            new GwinShowFormManager().ShwoManagerForm(managerForm);
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GwinManagerControl<Group, GroupForm, GroupDataGrid>
             managerForm = new GwinManagerControl<Group, GroupForm, GroupDataGrid>(new GroupBLO());

            new GwinShowFormManager().ShwoManagerForm(managerForm);
        }
    }
}
