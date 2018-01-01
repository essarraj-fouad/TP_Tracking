using GApp.DAL;
using GApp.DAL.Exceptions;
using GApp.DAL.Xml;
using GApp.DAL.Xml.Exceptions;
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

namespace TP_Tracking.DAL.XML
{
    /// <summary>
    /// Work to Do XML DataBase
    /// </summary>
    public class WorkToDoXmlDAO : BaseXmlDAO<XmlWorkToDoDb,WorkToDo>
    {
        #region Segleton Pattern
        private static WorkToDoXmlDAO instance;
        public static WorkToDoXmlDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new WorkToDoXmlDAO();
                return instance;
            }
        }
        #endregion


        protected override void LoadXML()
        {
            CheckXmlDataBaseVersionName();
            base.LoadXML();
        }

        private void CheckXmlDataBaseVersionName()
        {
            string[] all_data_file_names = Directory.GetFiles(".", "*" + this.XmlData.XmlDataBaseName);

            if (all_data_file_names.Count() == 0)
            {
                string msg = string.Format("Le fichier de données {0} n'exist pas", this.XmlData.XmlDataBaseName);
                throw new XmlDataFileNotExistException(msg);
            }
            else
            {
                // mofule-name_works.db;
                // module-name_v1_works.db;
                // module-name_v2_works.db;

                var DataFilesNamesObjects = from fileName in all_data_file_names.ToList<string>()
                                            let parts = fileName.Replace(".\\","").Split('.')
                                            where parts.Count() == 4
                                            select new { ModuleName = parts[0], WorksVersion = parts[1].Last(),fileName = fileName };


                if (DataFilesNamesObjects.Count() == 0)
                {
                    string msg = string.Format("Le fichier de données {0} exist mais il  ne contient pas le nom du module et le numéro de version", this.XmlData.XmlDataBaseName);
                    throw new XmlDataFileNotExistException(msg);
                }

                this.XmlData.XmlDataBaseName = (from d in DataFilesNamesObjects
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
            XmlWorkToDoDb data = new XmlWorkToDoDb();

            // Create groupes examples
            data.Group.Add(new Group("TDI201"));

            // Create workCategory exemple
            WorkCategory TPCategory = new WorkCategory("TP");
            WorkCategory root = new WorkCategory("root");
            data.WorkCategory.Add(TPCategory);
            data.WorkCategory.Add(root);

            // Creatre work to do example
            data.WorkToDo.Add(new WorkToDo("TP", root));
            data.WorkToDo.Add(new WorkToDo("TD", root));

            data.WorkToDo.Add(new WorkToDo("TP1", TPCategory));
            data.WorkToDo.Add(new WorkToDo("TP2", TPCategory));

            XmlSerializer xmlSerializer = new XmlSerializer(typeof(XmlWorkToDoDb));
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
