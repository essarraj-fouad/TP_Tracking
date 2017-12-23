using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.Entities
{
    /// <summary>
    /// Represents the directory that contains all the work of the trainee
    /// </summary>
    public class ModuleDirectory
    {
        public Trainee Trainee { set; get; }
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
            ListErrorMessage = new List<ValidateErrorMessage>();
        }

        /// <summary>
        /// Trainne 
        /// </summary>
        public Trainee Trainee { set; get; }
        /// <summary>
        /// List of Error
        /// </summary>
        public List<ValidateErrorMessage> ListErrorMessage { set; get; }
 
        /// <summary>
        /// Add Error Message 
        /// </summary>
        /// <param name="errorMessage"></param>
        public  void AddErrorMessage(ValidateErrorMessage errorMessage)
        {
            ListErrorMessage.Add(errorMessage);
        }
    }
}
