using GApp.DAL.Exceptions;
using GApp.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace GApp.DAL
{
    public abstract class XmlBaseDAO<T, TDao> where TDao : new() where T : new()
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

        /// <summary>
        /// Create the file data if not exist
        /// </summary>
        public bool CreateFileDataIdNotExist = true;


        protected string XMLDataBaseName;
        protected string XMLDataBaseDirectory = "./";
        protected T Data { set; get; }
        public T getData()
        {
            return this.Data;
        }


        public XmlBaseDAO()
        {
            XMLDataBaseName = nameof(T);
            this.Data = new T();
        }

        protected string XMLDataBasePath
        {
            get
            {
                return XMLDataBaseDirectory + XMLDataBaseName;
            }
        }

        protected virtual void CheckFileDate()
        {
            // Check file data 
           
        }

        protected virtual void LoadXML()
        {
            if (!File.Exists(this.XMLDataBasePath))
            {
                if (this.CreateFileDataIdNotExist)
                    throw new XmlDataFileNotExistException();
                this.SaveXML();
            }
           
            // Load Data
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(T));
            TextReader TextWriter = new StreamReader(this.XMLDataBasePath);
            this.Data = (T)xmlSerializer.Deserialize(TextWriter);
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
