using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class Trainee : User
    {
        public Group Group { set; get; }
    }
}
