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
        /// <summary>
        /// Load Configuration : 
        /// </summary>
        public static DataFilesConfiguration LoadConfiguration()
        {
            DataFilesConfiguration configuration = new DataFilesConfiguration();

            // Load XML file
            if (File.Exists("Configuration.xml"))
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(DataFilesConfiguration));
                TextReader TextWriter = new StreamReader("Configuration.xml");
                configuration = xmlSerializer.Deserialize(TextWriter) as DataFilesConfiguration;
                TextWriter.Close();


            }
            else
            {
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

            return configuration;

        }
    }
}
