using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class Repertories
    {
        public List<ErrorMessage> ListErrorMessage { set; get; }
        public List<Repertory> ListRepertory { set; get; }
        public List<TP> ListTP { set; get; }
        public List<TD> ListTD { set; get; }
        public Repertories()
        {
            ListRepertory = new List<Repertory>();
            ListErrorMessage = new List<ErrorMessage>();
            ListTP = new List<TP>();
            ListTD = new List<TD>();
        }
    }
}
