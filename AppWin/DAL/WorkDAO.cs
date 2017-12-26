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
    public class WorkDAO
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

        public WorkDAO()
        {
            traineeDirectory = new TraineeDirectory();
            Load();
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
                Work rootWork = new Work(fileInfo);
                traineeDirectory.WorksChilds.Add(rootWork);

                LoadChildDataFile(rootWork);
            }
        }

        private void LoadChildDataFile(Work fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.WorksChilds.Add(new Work(fileInfo));
            }
        }

        public UserCategory SaveModuleDirectoryStat(string ModuleName)
        {
            string path = "";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TraineeDirectory));
            if (new UserDAO().GetFormerDeviceInfo() != null)
            {
                // Create Directories

                path = new UserDAO().GetFormerDeviceInfo().RootDirectory.FullName
                    + ModuleName;
                if (!File.Exists(path)) Directory.CreateDirectory(path);

                path  += "/Trainees/";
                if (!File.Exists(path)) Directory.CreateDirectory(path);

                path += this.StateXmlFileName() + ".xml";
                TextWriter TextWriter = new StreamWriter(path);

                xmlSerializer.Serialize(TextWriter, traineeDirectory);
                TextWriter.Close();
                return UserCategory.Former;

            }
            else
            {

                path = this.StateXmlFileName() + ".xml";

                TextWriter TextWriter = new StreamWriter(path);
                xmlSerializer.Serialize(TextWriter, traineeDirectory);
                TextWriter.Close();
                return UserCategory.Trainee;
            }
            
            
        }

        private string StateXmlFileName()
        {
            return this.TraineeDirectory.Trainee.FirstName + "_" + this.TraineeDirectory.Trainee.LastName;
        }
    }
}
