using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using TP_Tracking.Entities;
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL
{
    public class WorkConfigurationDAO
    {
        private static string ConfigurationFileName = "WorkToDo.tp";
        private static WorkToDoConfiguration workToDoConfiguration;

        public WorkConfigurationDAO()
        {
            this.LoadConfiguration();
        }

        public string ConfigurationFilePath()
        {
            DriveInfo driveFormateur = new FormerDAO().GetFormerDeviceInfo();
            if (driveFormateur != null)
                return driveFormateur.RootDirectory.FullName + ConfigurationFileName;
            else
                return ConfigurationFileName;
        }

        /// <summary>
        /// Load Configuration : 
        /// </summary>
        public void LoadConfiguration()
        {
            // Load from formateur USB device
            ReadConfigurationFromDevice();

            // Load from Local
            if (workToDoConfiguration == null)
                ReadCondfigurationFromLocal();

            if (workToDoConfiguration == null)
                throw new ConfigurationFileNotExistException();
        }

      

        private void ReadCondfigurationFromLocal()
        {

            if (File.Exists(ConfigurationFilePath()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoConfiguration));
                TextReader TextWriter = new StreamReader(ConfigurationFilePath());
                workToDoConfiguration = xmlSerializer.Deserialize(TextWriter) as WorkToDoConfiguration;
                TextWriter.Close();
            }
        }



        /// <summary>
        /// Read Configuration file from usb devide of former
        /// </summary>
        private void  ReadConfigurationFromDevice()
        {

            DriveInfo driveFormateur = new FormerDAO().GetFormerDeviceInfo();
            if (driveFormateur != null)
            {
                if (File.Exists(ConfigurationFilePath()))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoConfiguration));
                    TextReader TextWriter = new StreamReader(ConfigurationFilePath());
                    workToDoConfiguration = xmlSerializer.Deserialize(TextWriter) as WorkToDoConfiguration;
                    TextWriter.Close();
                }

                // Write to USB
                //if (!File.Exists(driveFormateur.Name + "\\Stagiaire.txt"))
                //{
                //    FileStream fs = new FileStream(driveFormateur.Name + "\\Stagiaire.txt", FileMode.CreateNew, FileAccess.ReadWrite);
                //    StreamWriter sr = new StreamWriter(fs);
                //    sr.WriteLine("Hello !");
                //    sr.Close();
                //}
            }
        }

        /// <summary>
        /// Create Configuration file example
        /// </summary>
        public static void CreateConfigurationFileExample()
        {
            WorkToDoConfiguration configuration = new WorkToDoConfiguration();

            // Load List of requied repetories
            configuration.ListRootDirectory.Add(new WorkToDo() { Title = "TD" });
            configuration.ListRootDirectory.Add(new WorkToDo() { Title = "TP" });
            configuration.ListRootDirectory.Add(new WorkToDo() { Title = "Cours" });

            // Load List of TD
            configuration.ListTD.Add(new WorkToDo() { Title = "TD1" });

            // Load List of TP
            configuration.ListTP.Add(new WorkToDo() { Title = "TP1" });
            configuration.ListTP.Add(new WorkToDo() { Title = "TP2" });
            configuration.ListTP.Add(new WorkToDo() { Title = "TP3" });
            configuration.ListTP.Add(new WorkToDo() { Title = "TP4" });

            // List of cours
            configuration.ListCours.Add(new WorkToDo() { Title = "Cours_V2" });  

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoConfiguration));
            TextWriter TextWriter = new StreamWriter(ConfigurationFileName);
            xmlSerializer.Serialize(TextWriter, configuration);
            TextWriter.Close();
        }
        public static void DeleteConfigurationFileExample()
        {
            File.Delete(ConfigurationFileName);
        }

        public WorkToDoConfiguration getWorkToDoConfiguration()
        {
            return workToDoConfiguration;
        }

    }
}
