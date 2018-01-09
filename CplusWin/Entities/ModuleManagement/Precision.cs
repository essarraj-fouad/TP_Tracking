using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace App.Entities
{
    public class Precision : NamedBaseEntity
    {
        public int Duration { set; get; }
        public virtual Module Module { set; get; }
        public virtual List<PrecisionContent> PrecisionContents { set; get; }

        //public virtual List<Sequence> Sequences { get; set; }
    }
}
