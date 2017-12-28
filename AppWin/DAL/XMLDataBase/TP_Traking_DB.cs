using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.XMLDataBase
{
    public class TP_Traking_DB
    {
        public Trainee Trainee { set; get; }
        public Module Module { set; get; }

        public void setTrainee (Trainee trainee)
        {
            this.Trainee = trainee;
        }
        public Trainee getTrainee()
        {
          return this.Trainee;
        }
    }
}
