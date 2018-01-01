using GApp.DAL.Xml;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.XML
{
    /// <summary>
    /// WrokToDo XML DataBase Schema Object
    /// </summary>
    public class XmlWorkToDoDb : XmlDataBase
    {
        static XmlWorkToDoDb()
        {
            instance = new XmlWorkToDoDb();
        }
        public List<Module> Module { set; get; }
        public List<WorkToDo> WorkToDo { set; get; }
        public List<WorkToDoCategory> WorkCategory { set; get; }
        public List<Group> Group { set; get; }

        public XmlWorkToDoDb()
        {
            this.CreateFileDataIdNotExist = false;
            this.XmlDataBaseName = "works.db";

            WorkToDo = new List<WorkToDo>();
            WorkCategory = new List<WorkToDoCategory>();
            Group = new List<Group>();
            Module = new List<Entities.Module>();
        }
    }
}
