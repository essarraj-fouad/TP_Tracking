using GApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Enumerations;

namespace TP_Tracking.Entities
{
    public class TraineeWork : BaseEntity
    {
        public string FolderName { set; get; }
        public ValisationStat Validation { set; get; }
        public virtual WorkToDo WorkToDo { set; get; }
        public virtual List<TraineeWorkValidateError> TraineeWorkValidateErrors { set; get; }
        public virtual List<TraineeWorkNote> TraineeWorkNotes { set; get; }


        public void AddValidateError(TraineeWorkValidateError errorMessage)
        {
            if (TraineeWorkValidateErrors == null) TraineeWorkValidateErrors = new List<TraineeWorkValidateError>();
            TraineeWorkValidateErrors.Add(errorMessage);
        }

        /// <summary>
        /// is the work file hase Errors
        /// </summary>
        /// <returns></returns>
        public bool hasErrors()
        {
            return (this.TraineeWorkValidateErrors?.Count > 0);
        }

    }
}
