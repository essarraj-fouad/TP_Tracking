using GApp.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.XML
{

    public class XmlTP_TrakingDb : XmlDataBase
    {
        // Create Static Instance
        static XmlTP_TrakingDb()
        {
            instance = new XmlTP_TrakingDb();
        }

        public List<Trainee> Trainee { set; get; }
        public List<Trainee> Module { set; get; }
        public List<TraineeDirectory> TraineeDirectory { set; get; }
        

        public XmlTP_TrakingDb()
        {
            this.XmlDataBaseName = "Suivi_TP.db.xml";
            Trainee = new List<Entities.Trainee>();
            Module = new List<Entities.Trainee>();
        }

    }
}
