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
    public class Work : BaseEntity
    {
        public WorkToDo WorkToDo { set; get; }

        public string FileName { set; get; }

        public Work Parent { set; get; }

        public List<Work> WorksChilds { set; get; }

        public ValisationStat Validation { set; get; }

        private FileInfo fileInfo;

        public List<ValidateErrorMessage> ListErrorMessage { set; get; }
        
        public Work():this(null){}
        public Work(FileInfo fileInfo) : this(null, fileInfo) { }
        public Work(Work Parent, FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
            this.Parent = Parent;
            this.Validation = ValisationStat.Neutral;
            this.WorksChilds = new List<Work>();
            this.ListErrorMessage = new List<ValidateErrorMessage>();

            if(this.fileInfo != null)
            {
                this.FileName = fileInfo.Name;
                this.Reference = this.FileName;
            }
        }

       

        [XmlIgnoreAttribute]
        public FileInfo FileInfo
        {
            set
            {
                this.fileInfo = value;
                if(this.fileInfo != null)
                this.FileName = fileInfo.Name;
            }
            get
            {

                return this.fileInfo;
            }
        }

        public void AddErrorMessage(ValidateErrorMessage errorMessage)
        {
            ListErrorMessage.Add(errorMessage);
        }

        /// <summary>
        /// is the work file hase Errors
        /// </summary>
        /// <returns></returns>
        public bool hasErrors()
        {
            // recurent Algorithme 

            bool isChildsHasErrors = false;
            if (this.WorksChilds.Count > 0)
             isChildsHasErrors = this
                .WorksChilds
                .Where(w => w.hasErrors()).Count() > 0;

            if(this.ListErrorMessage.Count > 0 || isChildsHasErrors)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
