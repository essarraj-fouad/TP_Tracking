using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class WorkToDoConfiguration 
    {
        public List<WorkToDo> ListRootDirectory { set; get; }
        public List<WorkToDo> ListTP { set; get; }
        public List<WorkToDo> ListTD { set; get; }
        public List<WorkToDo> ListCours { set; get; }

        public WorkToDoConfiguration()
        {
            ListRootDirectory = new List<WorkToDo>();
            ListTP = new List<WorkToDo>();
            ListTD = new List<WorkToDo>();
            ListCours = new List<WorkToDo>();
        }
    }
}
