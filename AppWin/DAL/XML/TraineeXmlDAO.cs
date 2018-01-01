using GApp.DAL;
using GApp.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.XML
{
    public class TraineeXmlDAO : BaseXmlDAO<XmlTP_TrakingDb,Trainee>
    {
        #region Signleton Pattern
        private static TraineeXmlDAO instance;
        public static TraineeXmlDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraineeXmlDAO();
                return instance;
            }
        }
        #endregion
    }
}
