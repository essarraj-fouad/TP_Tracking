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
    public class WorkToDoFileData : BaseEntity
    {
        public WorkToDo WorkToDo { set; get; }

        public string FileName { set; get; }

        public WorkToDoFileData Parent { set; get; }

        public List<WorkToDoFileData> ChildsWorkToDoFileData { set; get; }

        public ValisationStat Validation { set; get; }

        private FileInfo fileInfo;

        public List<ValidateErrorMessage> ListErrorMessage { set; get; }
        
        public WorkToDoFileData():this(null){}
        public WorkToDoFileData(FileInfo fileInfo) : this(null, fileInfo) { }
        public WorkToDoFileData(WorkToDoFileData Parent, FileInfo fileInfo)
        {
            this.fileInfo = fileInfo;
            this.Parent = Parent;
            this.Validation = ValisationStat.Neutral;
            this.ChildsWorkToDoFileData = new List<WorkToDoFileData>();
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
    }
}
