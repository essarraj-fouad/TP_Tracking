using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class WorkToDo : BaseEntity
    {

        public string Title { set; get; }
        public string Description { set; get; }

        public virtual Module Module { set; get; }
        public virtual WorkToDoCategory WorkToDoCategory { set; get; }

        public override string ToString()
        {
            return Title;
        }
    }
}
