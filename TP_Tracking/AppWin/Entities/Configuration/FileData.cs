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
    public class FileData
    {
        public List<ErrorMessage> ListErrorMessage { set; get; }
        public FileData():this(null){}
        public FileData(FileData Parent)
        {
            this.Parent = Parent;
            this.Validation = ValisationStat.Neutral;
            this.ChildsFils = new List<FileData>();
            this.ListErrorMessage = new List<ErrorMessage>();
        }


        private FileInfo fileInfo;

        [XmlIgnoreAttribute]
        public FileInfo FileInfo
        {
            set
            {
                this.fileInfo = value;
                if(this.fileInfo != null)
                this.Name = fileInfo.Name;
            }
            get
            {

                return this.fileInfo;
            }
        }
        public string Name
        {
            set;
            get;
        }
        public ValisationStat Validation { set; get; }
        public FileData Parent { set; get; }
        public List<FileData> ChildsFils { set; get; }

        public void AddErrorMessage(ErrorMessage errorMessage)
        {
            ListErrorMessage.Add(errorMessage);
        }
    }
}
