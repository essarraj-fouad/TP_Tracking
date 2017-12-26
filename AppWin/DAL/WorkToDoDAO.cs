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
        
        private static WorksToDoData Data { set; get; }

        public WorksToDoData getData()
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
                XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorksToDoData));
                TextReader TextWriter = new StreamReader(XMLDataBasePath);
                Data = xmlSerializer.Deserialize(TextWriter) as WorksToDoData;
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
            // Create Data Exemple Instance
            WorksToDoData data = new WorksToDoData();

            // Create groupes examples
            data.Groups.Add(new Group("TDI201"));

            // Create workCategory exemple
            WorkCategory TPCategory = new WorkCategory("TP");
            WorkCategory root = new WorkCategory("root");
            data.WorkCategories.Add(TPCategory);
            data.WorkCategories.Add(root);

            // Creatre work to do example
            data.WorksToDo.Add(new WorkToDo("TP", root));
            data.WorksToDo.Add(new WorkToDo("TD", root));

            data.WorksToDo.Add(new WorkToDo("TP1", TPCategory));
            data.WorksToDo.Add(new WorkToDo("TP2", TPCategory));

             XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorksToDoData));
            TextWriter TextWriter = new StreamWriter(XMLDataBasePath);
            xmlSerializer.Serialize(TextWriter, data);
            TextWriter.Close();
        }
        public static void DeleteConfigurationFileExample()
        {
            File.Delete(XMLDataBasePath);
        }
    }
}
