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
using TP_Tracking.BLL;

namespace TP_Tracking.Presentation.Forms
{
    public partial class GroupForm : GwinFormControl
    {
        public GroupForm()
        {
            InitializeComponent();
        }

        private void groupBoxEntity_Enter(object sender, EventArgs e)
        {

        }

        private void GroupForm_Load(object sender, EventArgs e)
        {
            this.specialtyComboBox.DataSource = new SpecialtyBLO().FindAll();
        }
    }
}
