using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Enumerations;

namespace TP_Tracking.Entities
{
    public class FileData
    {
        public FileData(){
            this.Validation = ValisationStat.Neutral;
            this.ChildsFils = new List<FileData>();
        }
        public FileData(FileData Parent)
        {
            this.Parent = Parent;
            this.Validation = ValisationStat.Neutral;
            this.ChildsFils = new List<FileData>();
            
        }
        private FileInfo fileInfo;
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
       
       

    }
}
