using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class RepertoriesConfiguration 
    {
        public List<Repertory> ListRepertory { set; get; }
        public List<Repertory> ListTP { set; get; }
        public List<Repertory> ListTD { set; get; }


         public RepertoriesConfiguration()
        {
            ListRepertory = new List<Repertory>();
            ListTP = new List<Repertory>();
            ListTD = new List<Repertory>();
        }
    }
}
