
using GApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;


namespace App.Entities
{
    public class PrecisionContent : BaseEntity
    {
        public String Goal { set; get; }
        public String Description { set; get; }
        public int Duration { set; get; }
        public Precision Precision { set; get; }
    }
}
