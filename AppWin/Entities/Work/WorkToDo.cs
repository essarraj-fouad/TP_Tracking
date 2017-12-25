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


        public WorkToDo() { }

        public WorkToDo(string Title, WorkCategory WorkCategory)
        {
            this.Title = Title;
            this.WorkCategory = WorkCategory;
        }

        public override string ToString()
        {
            return Title;
        }

        private WorkCategory workCategory;
        public WorkCategory WorkCategory
        {
            set {
                // Set WorkCategory by reference
                // By XMLSerialiser
                this.workCategory = value;
            }
            get
            {
                return this.workCategory;
            }
        }


    }
}
