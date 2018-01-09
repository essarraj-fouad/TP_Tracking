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
using App.Presentation.Projects;
using App.Presentation.Tasks;
using App.DAL;

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

            new ShowFormManager(this).ShwoForm(managerForm,"Gestion des spécialité");
        }

        private void gestionDesGroupesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            GwinManagerControl<Group, GroupForm, GroupDataGrid>
             managerForm = new GwinManagerControl<Group, GroupForm, GroupDataGrid>(
                 new GroupBLO(ModelContext.getContext(nameof(Group)))
                 );

            new ShowFormManager(this).ShwoForm(managerForm,"Gestion des groupes", FormWindowState.Maximized);
        }

        private void projetsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GwinManagerControl<Project, ProjectForm, ProjectDataGrid>
             managerForm = new
            GwinManagerControl<Project, ProjectForm, ProjectDataGrid>
             (new ProjectBLO());

            new ShowFormManager(this).ShwoForm(managerForm, "Gestion des projets", FormWindowState.Maximized);
        }

        private void tâchesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GwinManagerControl<Entities.Task, TaskForm, TaskDataGrid>
            managerForm = new
           GwinManagerControl<Entities.Task, TaskForm, TaskDataGrid>
            (new TaskBLO(ModelContext.getContext(nameof(Entities.Task))));

            new ShowFormManager(this).ShwoForm(managerForm, "Gestion des tâches", FormWindowState.Maximized);
        }
    }
}
