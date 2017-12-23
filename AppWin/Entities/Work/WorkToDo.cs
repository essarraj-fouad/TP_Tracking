using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class WorkToDo: BaseEntity
    {
        public string Title { set; get; }
        public string Description { set; get; }
        public WorkCategory WorkCategory { set; get; }
        public WorkToDo() {}
        public override string ToString()
        {
            return Title;
        }
    }
}
