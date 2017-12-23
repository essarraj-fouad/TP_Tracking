using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.Entities;
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL
{
    public class ModuleDirectoryDAO
    {
        private static ModuleDirectory moduleDirectory = new ModuleDirectory();

        public ModuleDirectory ModuleDirectory
        {
            get
            {
                return moduleDirectory;
            }
        }

        public ModuleDirectoryDAO()
        {
            moduleDirectory = new ModuleDirectory();
            Load();
        }

        /// <summary>
        /// Load Module Directory
        /// </summary>
        public void Load()
        {
            // Load Root Directory

            string[] Files = Directory.GetDirectories(".");
            foreach (var file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                FileData ParentfileData = new FileData() { FileInfo = fileInfo };
                ModuleDirectoryDAO.moduleDirectory.RootDirectoty.ChildsFils.Add(ParentfileData);


                // TD
                if (fileInfo.Name.Contains("TD"))
                {
                    ModuleDirectoryDAO.moduleDirectory.TD = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryDAO.moduleDirectory.TD);
                }

                // TP
                if (fileInfo.Name.Contains("TP"))
                {
                    ModuleDirectoryDAO.moduleDirectory.TP = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryDAO.moduleDirectory.TP);
                }

                // Cours
                if (fileInfo.Name.Contains("Cours"))
                {
                    ModuleDirectoryDAO.moduleDirectory.Cours = ParentfileData;
                    LoadChildDataFile(ModuleDirectoryDAO.moduleDirectory.Cours);
                }

            }
        }

        private void LoadChildDataFile(FileData fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.ChildsFils.Add(new FileData() { FileInfo = fileInfo });
            }


        }

        public void SaveModuleDirectoryStat()
        {
            string path = "";
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(ModuleDirectory));
            if (new FormerDAO().GetFormerDeviceInfo() != null)
            {
               
                 path = new FormerDAO().GetFormerDeviceInfo().RootDirectory.FullName + "SuiviTP_Madani_Ali.xml";
               
            }
            else
            {
                path =  "SuiviTP_Madani_Ali.xml";
            }
            TextWriter TextWriter = new StreamWriter(path);
            xmlSerializer.Serialize(TextWriter, moduleDirectory);
            TextWriter.Close();

        }

    }
}
