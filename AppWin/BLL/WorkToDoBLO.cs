using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class WorkToDoBLO
    {
       private WorkToDoDAO workToDoDAO { set; get; }
       public WorkToDoBLO()
        {
            this.workToDoDAO =  WorkToDoDAO.Instance;
        }

        public WorkToDoDAO_DB getData()
        {
            return this.workToDoDAO.getData();
        }
        /// <summary>
        /// get a list of work in the root directory
        /// </summary>
        /// <returns></returns>
        public List<WorkToDo> FindByCategoryReference(string CategoryReference)
        {
            // a root works have WorkCategory with reference == "root"
          return  this.workToDoDAO.getData().WorksToDo
               .Where(w => w.WorkCategory?.Reference == CategoryReference)
               .OrderBy(w => w.Ordre).ToList<WorkToDo>();
        }
    }
}
