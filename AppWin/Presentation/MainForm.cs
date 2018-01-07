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
using App.BLL;
using App.Entities;
using App.Presentation.Groups;
using App.Specialties;

namespace App.Presentation
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

            new GwinShowFormManager().ShwoForm(managerForm,"Gestion des spécialité");
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GwinManagerControl<Group, GroupForm, GroupDataGrid>
             managerForm = new GwinManagerControl<Group, GroupForm, GroupDataGrid>(new GroupBLO());

            new GwinShowFormManager().ShwoForm(managerForm,"Gestion des groupes");
        }
    }
}
