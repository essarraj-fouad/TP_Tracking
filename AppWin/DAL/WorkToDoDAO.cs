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
    /// <summary>
    /// Work to Do XML DataBase
    /// </summary>
    public class WorkToDoDAO : XMLDataBase
    {
        
        private static WorkToDoXMLDataBaseObject Data { set; get; }

        public WorkToDoXMLDataBaseObject getData()
        {
            return Data;
        }

        public WorkToDoDAO(string XMLDataBaseDirectory)
        {
            XMLDataBaseName = "works_db";
            if (string.IsNullOrEmpty(XMLDataBasePath))
                XMLDataBasePath = XMLDataBaseDirectory + XMLDataBaseName;
            
            this.LoadData();
        }

        /// <summary>
        /// Load Data from XML : 
        /// </summary>
        public void LoadData()
        {
            try
            {
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoXMLDataBaseObject));
                TextReader TextWriter = new StreamReader(XMLDataBasePath);
                Data = xmlSerializer.Deserialize(TextWriter) as WorkToDoXMLDataBaseObject;
                TextWriter.Close();
            }
            catch (FileNotFoundException)
            {

                throw new ConfigurationFileNotExistException();
            }
           

            if (Data == null)
                throw new ConfigurationFileNotExistException();
        }

        /// <summary>
        /// Create Configuration file example
        /// </summary>
        public static void  CreateConfigurationFileExample()
        {
            WorkToDoXMLDataBaseObject data = new WorkToDoXMLDataBaseObject();

            data.Groups.Add(new Group() { Name = "TDI201" });
            WorkCategory workCategory = new WorkCategory() { Name = "TP" };
            data.WorkCategories.Add(workCategory);
            data.WorksToDo.Add(new WorkToDo() { WorkCategory = workCategory,Title = "TP1" });

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoXMLDataBaseObject));
            TextWriter TextWriter = new StreamWriter(XMLDataBaseName);
            xmlSerializer.Serialize(TextWriter, data);
            TextWriter.Close();
        }
        public static void DeleteConfigurationFileExample()
        {
            File.Delete(XMLDataBasePath);
        }
    }
}
