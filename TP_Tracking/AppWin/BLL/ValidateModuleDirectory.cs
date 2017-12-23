using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ValidateModuleDirectory
    {
        #region Validation moduleDirectory 
        /// <summary>
        /// Validation moduleDirectory
        /// </summary>
        /// <param name="moduleDirectory"></param>
        public  static void Validation(ModuleDirectory moduleDirectory)
        {
            ModuleDirectoryBLO.dataFilesConfiguration = ConfigurationBLO.LoadConfiguration();

            // Check root Directory
            CheckFileMustExist(moduleDirectory.RootDirectoty, ModuleDirectoryBLO.dataFilesConfiguration.ListRootDirectory);
            CheckFileMustNotExist(moduleDirectory.RootDirectoty, ModuleDirectoryBLO.dataFilesConfiguration.ListRootDirectory);

            // Check TD 
            CheckFileMustExist(moduleDirectory.TD, ModuleDirectoryBLO.dataFilesConfiguration.ListTD);
            CheckFileMustNotExist(moduleDirectory.TD, ModuleDirectoryBLO.dataFilesConfiguration.ListTD);


            // Check TP
            CheckFileMustExist(moduleDirectory.TP, ModuleDirectoryBLO.dataFilesConfiguration.ListTP);
            CheckFileMustNotExist(moduleDirectory.TP, ModuleDirectoryBLO.dataFilesConfiguration.ListTP);


            // check Cours
            CheckFileMustExist(moduleDirectory.Cours, ModuleDirectoryBLO.dataFilesConfiguration.ListCours);
            CheckFileMustNotExist(moduleDirectory.Cours, ModuleDirectoryBLO.dataFilesConfiguration.ListCours);

        }

        private static void CheckFileMustExist(FileData ParentFileData, List<string> ListChildName)
        {
            foreach (var configurationFileName in ListChildName)
            {
                FileData chilFile = ParentFileData.ChildsFils
              .Where(tdChildFile => tdChildFile.Name.ToUpper()
              .Contains(configurationFileName.ToUpper()))
              .FirstOrDefault();
                if (chilFile == null)
                {
                    string msg = string.Format("Le répertoir {0} n'existe pas", configurationFileName);
                    ErrorMessage errorMessage = new ErrorMessage(msg);
                    ParentFileData.AddErrorMessage(errorMessage);
                }
            }
        }
        private static void CheckFileMustNotExist(FileData ParentFileData, List<string> ListChildName)
        {
            foreach (var chilFile in ParentFileData.ChildsFils)
            {
                if (ListChildName
                    .Where(configFileName => configFileName.ToUpper() == chilFile.FileInfo.Name.ToUpper())
                    .Count() != 0)
                    chilFile.Validation = Enumerations.ValisationStat.Valid;
                else
                {
                    string msg = string.Format("Le nom du répertoir {0} n'est pas valide", chilFile.Name);
                    ErrorMessage errorMessage = new ErrorMessage(msg);

                    chilFile.Validation = Enumerations.ValisationStat.NotValid;
                    chilFile.AddErrorMessage(errorMessage);
                    // moduleDirectory.AddErrorMessage(errorMessage);

                }
            }
        }
        #endregion
    }
}
