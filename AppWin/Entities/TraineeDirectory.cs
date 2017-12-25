using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    /// <summary>
    /// Represents the directory that contains all the work of the trainee
    /// </summary>
    public class TraineeDirectory : Work
    {
        /// <summary>
        /// Trainne 
        /// </summary>
        public Trainee Trainee { set; get; }

        public TraineeDirectory():base()
        {
        }
    }
}
