using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    public class ModuleDirectory
    {

        public FileData RootDirectoty { set; get; }
        public FileData TP { set; get; }
        public FileData TD { set; get; }
        public FileData Cours { set; get; }


        public ModuleDirectory()
        {
            
           
            RootDirectoty = new FileData();
            TP = new FileData();
            TD = new FileData();
            Cours = new FileData();
            ListErrorMessage = new List<ErrorMessage>();
        }

        /// <summary>
        /// Trainne 
        /// </summary>
        public Trainee Trainee { set; get; }
        /// <summary>
        /// List of Error
        /// </summary>
        public List<ErrorMessage> ListErrorMessage { set; get; }
 
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
