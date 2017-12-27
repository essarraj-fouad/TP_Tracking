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
    public class WorkToDoDAO : XmlBaseDAO<WorkToDoDAO_DB, WorkToDoDAO>
    {
        public WorkToDoDAO():base()
        {
            this.XMLDataBaseName = "works_db";
            this.LoadXML();
        }

     
        /// <summary>
        /// Create Configuration file example
        /// </summary>
        public static void  CreateConfigurationFileExample()
        {
            // Create Data Exemple Instance
            WorkToDoDAO_DB data = new WorkToDoDAO_DB();

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

             XmlSerializer xmlSerializer = new XmlSerializer(typeof(WorkToDoDAO_DB));
            TextWriter TextWriter = new StreamWriter("work_to_do_exemple.xml");
            xmlSerializer.Serialize(TextWriter, data);
            TextWriter.Close();
        }
        public static void DeleteConfigurationFileExample()
        {
            File.Delete("work_to_do_exemple.xml");
        }

    
    }
}
