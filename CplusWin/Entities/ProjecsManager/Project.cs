using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Project : NamedBaseEntity
    {
        public virtual List<Task> Tasks { set; get; }
    }
}
