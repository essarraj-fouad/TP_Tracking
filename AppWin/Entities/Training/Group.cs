using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Group : NamedBaseEntity
    {
        public string Code { set; get; }
        public virtual Specialty Specialty { set; get; }
    }
}
