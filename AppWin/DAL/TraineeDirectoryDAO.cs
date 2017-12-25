using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Entities;
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL
{
    public class TraineeDirectoryDAO
    {
        // Data
        private static TraineeDirectory traineeDirectory = null;

        public TraineeDirectory ModuleDirectory
        {
            get
            {
                return traineeDirectory;
            }
        }

        public TraineeDirectoryDAO()
        {
            traineeDirectory = new TraineeDirectory();
            Load();
        }

        /// <summary>
        /// Load Wrok to do dataFile
        /// </summary>
        public void Load()
        {
            // Create traineeDirectory Instance
            traineeDirectory = new TraineeDirectory();

            // trainee Directory File Info
            traineeDirectory.FileInfo = new FileInfo(".");

            // Load Childs Directories
            string[] Files = Directory.GetDirectories(".");
            foreach (var file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);

                WorkToDoFileData FirstChild = new WorkToDoFileData(fileInfo);
              

                traineeDirectory.ChildsWorkToDoFileData.Add(FirstChild);

                LoadChildDataFile(FirstChild);
            }
        }

        private void LoadChildDataFile(WorkToDoFileData fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.ChildsWorkToDoFileData.Add(new WorkToDoFileData(fileInfo));
            }
        }

        public void SaveModuleDirectoryStat()
        {
            string path = "";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(TraineeDirectory));
            if (new UserDAO().GetFormerDeviceInfo() != null)
            {

                path = new UserDAO().GetFormerDeviceInfo().RootDirectory.FullName + "SuiviTP_Madani_Ali.xml";

            }
            else
            {
                path = "SuiviTP_Madani_Ali.xml";
            }
            TextWriter TextWriter = new StreamWriter(path);
            xmlSerializer.Serialize(TextWriter, traineeDirectory);
            TextWriter.Close();
        }

    }
}
