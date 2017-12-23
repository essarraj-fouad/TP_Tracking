using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ValidateModuleDirectoryBLO
    {
        WorkConfigurationDAO workConfigurationDAO;
        ModuleDirectory moduleDirectory;

        public ValidateModuleDirectoryBLO(ModuleDirectory moduleDirectory)
        {
            this.moduleDirectory = moduleDirectory;
            this.workConfigurationDAO = new WorkConfigurationDAO();
        }
        /// <summary>
        /// Validation moduleDirectory
        /// </summary>
        /// <param name="moduleDirectory"></param>
        public void Validation()
        {
            // Check root Directory
            CheckFileMustExist(moduleDirectory.RootDirectoty, workConfigurationDAO.getWorkToDoConfiguration().ListRootDirectory);
            CheckFileMustNotExist(moduleDirectory.RootDirectoty, workConfigurationDAO.getWorkToDoConfiguration().ListRootDirectory);

            // Check TD 
            CheckFileMustExist(moduleDirectory.TD, workConfigurationDAO.getWorkToDoConfiguration().ListTD);
            CheckFileMustNotExist(moduleDirectory.TD, workConfigurationDAO.getWorkToDoConfiguration().ListTD);


            // Check TP
            CheckFileMustExist(moduleDirectory.TP, workConfigurationDAO.getWorkToDoConfiguration().ListTP);
            CheckFileMustNotExist(moduleDirectory.TP, workConfigurationDAO.getWorkToDoConfiguration().ListTP);


            // check Cours
            CheckFileMustExist(moduleDirectory.Cours, workConfigurationDAO.getWorkToDoConfiguration().ListCours);
            CheckFileMustNotExist(moduleDirectory.Cours, workConfigurationDAO.getWorkToDoConfiguration().ListCours);

        }

        public static void CreateConfigurationFileExample()
        {
            WorkConfigurationDAO.CreateConfigurationFileExample();
            
        }

        private void CheckFileMustExist(FileData ParentFileData, List<WorkToDo> ListChildName)
        {
            foreach (var configurationFileName in ListChildName)
            {
                FileData chilFile = ParentFileData.ChildsFils
              .Where(tdChildFile => tdChildFile.Name.ToUpper()
              .Contains(configurationFileName.Title.ToUpper()))
              .FirstOrDefault();
                if (chilFile == null)
                {
                    string msg = string.Format("Le répertoir {0} n'existe pas", configurationFileName);
                    ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);
                    ParentFileData.AddErrorMessage(errorMessage);
                }
            }
        }
        private void CheckFileMustNotExist(FileData ParentFileData, List<WorkToDo> ListChildName)
        {
            foreach (var chilFile in ParentFileData.ChildsFils)
            {
                if (ListChildName
                    .Where(configFileName => configFileName.Title.ToUpper() == chilFile.FileInfo.Name.ToUpper())
                    .Count() != 0)
                    chilFile.Validation = Enumerations.ValisationStat.Valid;
                else
                {
                    string msg = string.Format("Le nom du répertoir {0} n'est pas valide", chilFile.Name);
                    ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);

                    chilFile.Validation = Enumerations.ValisationStat.NotValid;
                    chilFile.AddErrorMessage(errorMessage);
                    // moduleDirectory.AddErrorMessage(errorMessage);

                }
            }
        }
    }
}
