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

namespace TP_Tracking.Presentation.UI
{
    public partial class ErrorMessageControl : UserControl
    {
       
        public ErrorMessageControl()
        {
            InitializeComponent();
        }


        public void ShowMessages(List<ErrorMessage> listErrorMessage)
        {
            this.listBoxErrorMessage.Items.Clear();
            this.listBoxErrorMessage.DataSource = listErrorMessage;
        }
    }
}
