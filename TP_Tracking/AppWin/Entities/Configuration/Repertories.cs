using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class Repertories : RepertoriesConfiguration
    {
        public List<ErrorMessage> ListErrorMessage { set; get; }
       
        public Repertories():base()
        {
            ListErrorMessage = new List<ErrorMessage>();
        }

        /// <summary>
        /// Add Error Message 
        /// </summary>
        /// <param name="errorMessage"></param>
        public  void AddErrorMessage(ErrorMessage errorMessage)
        {
            ListErrorMessage.Add(errorMessage);
        }
    }
}
