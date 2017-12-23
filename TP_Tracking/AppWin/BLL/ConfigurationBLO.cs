using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Serialization;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ConfigurationBLO
    {

        public static string ConfigurationFilePath()
        {
            DriveInfo driveFormateur = USBDevice.GetDeviceInfo();    
            if (driveFormateur != null)
                return driveFormateur.RootDirectory + "Configuration.xml"; 
            else
                return "Configuration.xml";
        }
        


        /// <summary>
        /// Load Configuration : 
        /// </summary>
        public static DataFilesConfiguration LoadConfiguration()
        {
            DataFilesConfiguration configuration = null;


            // Load from formateur USB device
            configuration = ReadConfigurationFromDevice();

            // Load from Local
            if (configuration == null)
                configuration = ReadCondfigurationFromLocal();

            // Create configuration file exemple if not exisite
            //if (configuration == null)
            //    configuration = ReadCondfigurationFromLocal();

            if (configuration == null)
                throw new ConfigurationFileNotExistException();

            return configuration;
        }

        private static DataFilesConfiguration ReadCondfigurationFromLocal()
        {
            DataFilesConfiguration configuration = null;
            if (File.Exists(ConfigurationFilePath()))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFilesConfiguration));
                TextReader TextWriter = new StreamReader(ConfigurationFilePath());
                configuration = xmlSerializer.Deserialize(TextWriter) as DataFilesConfiguration;
                TextWriter.Close();
            }
            return configuration;
        }



        /// <summary>
        /// Read Configuration file from usb devide of former
        /// </summary>
        private static DataFilesConfiguration ReadConfigurationFromDevice()
        {
            DataFilesConfiguration configuration = null;
            DriveInfo driveFormateur = USBDevice.GetDeviceInfo();
            if (driveFormateur != null)
            {
                if (File.Exists(ConfigurationFilePath()))
                {
                    XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFilesConfiguration));
                    TextReader TextWriter = new StreamReader(ConfigurationFilePath());
                    configuration = xmlSerializer.Deserialize(TextWriter) as DataFilesConfiguration;
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

            return configuration;
        }

        /// <summary>
        /// Create Configuration file example
        /// </summary>
        private static void CreateConfigurationFileExample()
        {
            DataFilesConfiguration configuration = new DataFilesConfiguration();

            // Load List of requied repetories
            configuration.ListRootDirectory.Add("TD");
            configuration.ListRootDirectory.Add("TP");
            configuration.ListRootDirectory.Add("Cours");

            // Load List of TD
            configuration.ListTP.Add("TD1");

            // Load List of TP
            configuration.ListTP.Add("TP1");

            // List of cours
            configuration.ListCours.Add("Cours_V2");

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFilesConfiguration));
            TextWriter TextWriter = new StreamWriter("Configuration.xml");
            xmlSerializer.Serialize(TextWriter, configuration);
            TextWriter.Close();
        }

       

    }
}
