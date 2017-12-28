using GApp.DAL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Entities;
using TP_Tracking.XMLDataBase;

namespace TP_Tracking.DAL
{
    public class TP_TrakingDAO : XmlBaseDAO<TP_Traking_DB, TP_TrakingDAO>
    {
        public  TP_TrakingDAO() : base()
        {
            this.XMLDataBaseName = "TP_traking_db";
            this.LoadXML();
        }
    }
}
