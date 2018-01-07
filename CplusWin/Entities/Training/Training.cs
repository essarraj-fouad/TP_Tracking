using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class Training : NamedBaseEntity
    {
        public virtual Group Group { set; get; }
        public virtual Module Module { set; get; }
        public virtual Former Former { set; get; }

    }
}
