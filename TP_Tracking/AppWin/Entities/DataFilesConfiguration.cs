using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class DataFilesConfiguration 
    {
        public List<string> ListRootDirectory { set; get; }
        public List<string> ListTP { set; get; }
        public List<string> ListTD { set; get; }
        public List<string> ListCours { set; get; }

        public DataFilesConfiguration()
        {
            ListRootDirectory = new List<string>();
            ListTP = new List<string>();
            ListTD = new List<string>();
            ListCours = new List<string>();
        }
    }
}
