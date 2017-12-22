using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ModuleDirectoryBLO
    {
        public static ModuleDirectory moduleDirectory = new ModuleDirectory();
        /// <summary>
        /// Load and Validate Repertories 
        /// </summary>
        /// <returns></returns>
        public static ModuleDirectory LoadAndValidateFils()
        {

             moduleDirectory = new ModuleDirectory();

            // Load Root Directory
            string[] Files = Directory.GetFileSystemEntries(".");
            foreach (var file in Files)
            {
                FileInfo fileInfo = new FileInfo(file);
                FileData ParentfileData = new FileData() { FileInfo = fileInfo };
                moduleDirectory.RootDirectoty.ChildsFils.Add(ParentfileData);


                // TD
                if (fileInfo.Name.Contains("TD"))
                {
                    moduleDirectory.TD = ParentfileData;
                    LoadChildDataFile(moduleDirectory.TD);
                }

                // TP
                if (fileInfo.Name.Contains("TP"))
                {
                    moduleDirectory.TP = ParentfileData;
                    LoadChildDataFile(moduleDirectory.TP);
                }

                // Cours
                if (fileInfo.Name.Contains("Cours"))
                {
                    moduleDirectory.Cours = ParentfileData;
                    LoadChildDataFile(moduleDirectory.Cours);
                }

            }

            // Validation
            Validation(moduleDirectory);
             
            return moduleDirectory;
        }

        private static void LoadChildDataFile(FileData fileData)
        {
            string[] ChildsFiles = Directory.GetFileSystemEntries(fileData.FileInfo.FullName);
            foreach (var childFile in ChildsFiles)
            {
                FileInfo fileInfo = new FileInfo(childFile);
                fileData.ChildsFils.Add(new FileData() { FileInfo = fileInfo });
            }

            
        }

        private static void Validation(ModuleDirectory moduleDirectory)
        {
            DataFilesConfiguration dataFilesConfiguration = ConfigurationBLO.LoadConfiguration();

            // Check Directory that do not have to exist
            foreach (var rootDirectoty in moduleDirectory.RootDirectoty.ChildsFils)
            {
                if (dataFilesConfiguration
                    .ListRootDirectory
                    .Where(config => config == rootDirectoty.FileInfo.Name)
                    .Count() != 0)
                    rootDirectoty.Validation = Enumerations.ValisationStat.Valid;
                else
                {
                    rootDirectoty.Validation = Enumerations.ValisationStat.NotValid;
                    string msg = string.Format("Le répertoir {0} ne doit pas exister", rootDirectoty.Name);
                    moduleDirectory.AddErrorMessage(new ErrorMessage(msg));

                }
            }

            // Check Directory must have to exist
            foreach (var fileData in dataFilesConfiguration.ListRootDirectory)
            {
                FileData ExistantDirectory = moduleDirectory.RootDirectoty.ChildsFils
              .Where(d => d.Name.ToUpper()
              .Contains(fileData.ToUpper()))
              .FirstOrDefault();
                if (ExistantDirectory == null)
                {
                    string msg = string.Format("Le répertoir {0} n'existe pas", fileData);
                    moduleDirectory.AddErrorMessage(new ErrorMessage(msg));
                }
            }

            // Check Names of TP

            // Check Names of TD






        }
    }
}
