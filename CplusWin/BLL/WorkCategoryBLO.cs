using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL.XML;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public partial class WorkCategoryBLO
    {
        public WorkCategoryBLO() : base()
        {
            this.entityDAO = new WorkCategoryXmlDAO();
        }
    }
}
