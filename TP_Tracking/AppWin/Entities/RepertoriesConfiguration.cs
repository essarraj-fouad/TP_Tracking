using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class RepertoriesConfiguration 
    {
        public List<FileData> ListRepertory { set; get; }
        public List<FileData> ListTP { set; get; }
        public List<FileData> ListTD { set; get; }


         public RepertoriesConfiguration()
        {
            ListRepertory = new List<FileData>();
            ListTP = new List<FileData>();
            ListTD = new List<FileData>();
        }
    }
}
