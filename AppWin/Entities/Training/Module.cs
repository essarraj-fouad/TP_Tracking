using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class Module : NamedBaseEntity
    {
        public string Code { get;  set; }
        public int HourNumber { get; set; }
    }
}
