using GApp.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.XML
{
    public class WorkCategoryXmlDAO : BaseXmlDAO<XmlWorkToDoDb, WorkToDoCategory>
    {
        #region Segleton Pattern
        private static WorkCategoryXmlDAO instance;
        public static WorkCategoryXmlDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkCategoryXmlDAO();
                return instance;
            }
        }

     
        #endregion
    }
}
