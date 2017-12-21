using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class ModuleDirectory : RepertoriesConfiguration
    {
        /// <summary>
        /// Trainne 
        /// </summary>
        public Trainee Trainee { set; get; }
        /// <summary>
        /// List of Error
        /// </summary>
        public List<ErrorMessage> ListErrorMessage { set; get; }
       
        public ModuleDirectory():base()
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
