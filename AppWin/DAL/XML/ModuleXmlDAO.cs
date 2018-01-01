using GApp.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.XML
{
   public class ModuleXmlDAO : BaseXmlDAO<XmlTP_TrakingDb,Module>
    {
        #region Signleton Pattern
        private static ModuleXmlDAO instance;
        public static ModuleXmlDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new ModuleXmlDAO();
                return instance;
            }
        }
        #endregion
    }
}
