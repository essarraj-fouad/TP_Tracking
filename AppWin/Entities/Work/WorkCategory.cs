﻿using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class WorkCategory : BaseEntity
    {

        public WorkCategory()
        {

        }
        public WorkCategory(string Name)
        {
            this.Name = Name;
            this.Reference = this.Name;
           
        }

        public string Name { set; get; }
        public string Description { set; get; }
    }
}
