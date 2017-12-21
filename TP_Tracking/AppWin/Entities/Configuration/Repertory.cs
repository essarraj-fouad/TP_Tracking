using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Enumerations;

namespace TP_Tracking.Entities
{
    public class Repertory
    {
        public Repertory()
        {
            this.Validation = ValisationStat.Neutral ;
        }
        public FileInfo FileInfo { set; get; }
        public string Name { set; get; }

        public ValisationStat Validation { set; get; }
        public string ValidationErrorMessage { set; get; }
        
    }
}
