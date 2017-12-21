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

namespace TP_Tracking.Presentation
{
    public partial class AppForm : Form
    {
        Repertories repertories;
        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            Repertories repertories = RepertoriesBLO.LoadRepertoies();
            this.repertoriesControl1.repertories = repertories;
            this.repertoriesControl1.Refresh();

           
        }
    }
}
