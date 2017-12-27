using GApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace TP_Tracking.DAL
{
    public abstract class XmlBaseDAO<T, TDao> where TDao : new()
    {
        #region Segleton Pattern
        private static TDao instance;
        public static TDao Instance
        {
            get
            {
                if (instance == null)
                    instance = new TDao();
                return instance;
            }
        }
        #endregion

     

        protected string XMLDataBaseName;
        protected string XMLDataBaseDirectory = "./";
        protected T Data { set; get; }
        public T getData()
        {
            return Data;
        }


        public XmlBaseDAO()
        {
            XMLDataBaseName = nameof(T);
        }

        protected string XMLDataBasePath
        {
            get
            {
                return XMLDataBaseDirectory + XMLDataBaseName;
            }
        }


        protected void LoadXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextReader TextWriter = new StreamReader(this.XMLDataBasePath);
            this.Data = (T) xmlSerializer.Deserialize(TextWriter) ;
            TextWriter.Close();
        }

        protected void SaveXML()
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextWriter TextWriter = new StreamWriter(this.XMLDataBasePath);
            xmlSerializer.Serialize(TextWriter, this.Data);
            TextWriter.Close();
        }

        public void SaveData()
        {
            this.SaveXML();
        }


    }
}
