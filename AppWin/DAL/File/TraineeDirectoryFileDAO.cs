using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Entities;
using TP_Tracking.Enumerations;
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL
{
    public class TraineeDirectoryFileDAO 
    {
        // Data
        private static TraineeDirectory traineeDirectory = null;

        public TraineeDirectory TraineeDirectory
        {
            get
            {
                return traineeDirectory;
            }
        }

        public TraineeDirectoryFileDAO()
        {
            traineeDirectory = new TraineeDirectory();
            this.Load();
        }

        /// <summary>
        /// Load Trainee Wrok  
        /// </summary>
        public void Load()
        {
            // Create traineeDirectory Instance
            traineeDirectory = new TraineeDirectory();

            // trainee Directory
            traineeDirectory.FileInfo = new FileInfo(".");
            traineeDirectory.Trainee = new Trainee(traineeDirectory.FileInfo.FullName.Split('\\').Last());

            // Load   root work Directories
            string[] Files = Directory.GetDirectories(".");
            foreach (var file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                TraineeWork rootWork = new TraineeWork(fileInfo);
                traineeDirectory.WorksChilds.Add(rootWork);

                LoadChildDataFile(rootWork);
            }
        }

        private void LoadChildDataFile(TraineeWork fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.WorksChilds.Add(new TraineeWork(fileInfo));
            }
        }

        /// <summary>
        /// Save works state to Trainee or Former Directory
        /// </summary>
        /// <param name="ModuleName"></param>
        /// <returns></returns>
        public UserCategory SaveWorksState(string ModuleName)
        {
            string path = "";
           
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TraineeDirectory));

            // if former
            if (new DeviceDA().GetFormerDeviceInfo() != null)
            {
                // Create former directory if not exist
                path = new DeviceDA().GetFormerDeviceInfo().RootDirectory.FullName + ModuleName;
                if (!File.Exists(path)) Directory.CreateDirectory(path);
                path  += "/Trainees/";
                if (!File.Exists(path)) Directory.CreateDirectory(path);
                path += this.StateXmlFileName(ModuleName);
                TextWriter TextWriter = new StreamWriter(path);

                xmlSerializer.Serialize(TextWriter, traineeDirectory);
                TextWriter.Close();
                return UserCategory.Former;

            }
            // if trainee
            else
            {
                path = this.StateXmlFileName(ModuleName) ;
                TextWriter TextWriter = new StreamWriter(path);
                xmlSerializer.Serialize(TextWriter, traineeDirectory);
                TextWriter.Close();
                return UserCategory.Trainee;
            }
            
            
        }

        private string StateXmlFileName(string module_name)
        {
            string trainee_reference = this.TraineeDirectory.Trainee.FirstName + "_" + this.TraineeDirectory.Trainee.LastName;

            return trainee_reference + "." + module_name + ".works";
        }
    }
}
