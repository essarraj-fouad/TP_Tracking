using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL
{
    /// <summary>
    /// WrokToDo XML DataBase Schema Object
    /// </summary>
    public class WorksToDoData 
    {
        public string ModuleName = "DefaultModule";
        public List<WorkToDo> WorksToDo { set; get; }
        public List<WorkCategory> WorkCategories { set; get; }
        public List<Group> Groups { set; get; }

        public WorksToDoData()
        {
            WorksToDo = new List<WorkToDo>();
            WorkCategories = new List<WorkCategory>();
            Groups = new List<Group>();
        }
    }
}
