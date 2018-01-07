using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GwinForm;
using App.BLL;
using App.DAL;
using App.Entities;

namespace App.Presentation.Tasks
{
    public partial class TaskForm : GwinFormControl
    {
        public TaskForm()
        {
            InitializeComponent();
            this.projectComboBox.DataSource = 
                new ProjectBLO(ModelContext.getContext(nameof(Entities.Task)))
                .FindAll();
        }
    }
}
