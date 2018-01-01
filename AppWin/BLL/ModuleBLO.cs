using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL.XML;

namespace TP_Tracking.BLL
{
    public partial class ModuleBLO
    {
        public ModuleBLO()
        {
            this.entityDAO = ModuleXmlDAO.Instance;
        }
    }
}
