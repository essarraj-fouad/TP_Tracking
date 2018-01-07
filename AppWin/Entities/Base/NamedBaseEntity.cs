using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Entities
{
    public class NamedBaseEntity : BaseEntity
    {
        public string Name { set; get; }
        public string Description { set; get; }
    }
}
