using GApp.DAL;
using GApp.DAL.Exceptions;
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
        public string DataFileName
        {
            get
            {
                return this.XMLDataBaseName;
            }
        }

        public WorkToDoDAO() : base()
        {
            this.CreateFileDataIdNotExist = false;
            this.XMLDataBaseName = "works.db";

            
            this.LoadXML();
        }

        protected override void LoadXML()
        {
            CheckXMLDataBaseName();
            base.LoadXML();
        }

        private void CheckXMLDataBaseName()
        {
            string[] all_data_file_names = Directory.GetFiles(".", "*" + this.XMLDataBaseName);

            if (all_data_file_names.Count() == 0)
            {
                string msg = string.Format("Le fichier de données {0} n'exist pas", this.XMLDataBaseName);
                throw new ConfigurationFileNotExistException(msg);
            }
            else
            {
                // mofule-name_works.db;
                // module-name_v1_works.db;
                // module-name_v2_works.db;

                var DataFilesNamesObjects = from fileName in all_data_file_names.ToList<string>()
                                            let parts = fileName.Split('_')
                                            where parts.Count() == 3
                                            select new { ModuleName = parts[0], WorksVersion = parts[1].Last(),fileName = fileName };


                if (DataFilesNamesObjects.Count() == 0)
                {
                    string msg = string.Format("Le fichier de données {0} exist mais il  ne contient pas le nom du module et le numéro de version", this.XMLDataBaseName);
                    throw new XmlDataFileNotExistException();
                }

                this.XMLDataBaseName = (from d in DataFilesNamesObjects
                                        orderby d.WorksVersion
                                        select d).Last().fileName;

            }

        }

        /// <summary>
        /// Create Configuration file example
        /// </summary>
        public static void CreateConfigurationFileExample()
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
