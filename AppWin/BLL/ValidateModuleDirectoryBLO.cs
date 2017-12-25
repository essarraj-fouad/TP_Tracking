using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    /// <summary>
    /// Validate Trainee directory with WorkToDo configuration
    /// </summary>
    public class ValidateTraineeDirectoryBLO
    {
        WorkToDoDAO workToDoDAO;
        TraineeDirectory moduleDirectory;

        public ValidateTraineeDirectoryBLO(TraineeDirectory traineeDirectory)
        {
            this.moduleDirectory = traineeDirectory;
            this.workToDoDAO = new WorkToDoDAO(new UserBLO().getUserXmlDataBaseDirecrory());
        }
        /// <summary>
        /// Validation trainee directory
        /// </summary>
        public void Validation()
        {

            WorkToDoXMLDataBaseObject WorkToDoData = workToDoDAO.getData();

            // The work to do for the root directory have the workCategory with reference == "root"
            var rootDirectoryWorkToDo = WorkToDoData.WorksToDo
                .Where(w => w.WorkCategory?.Reference == "root")
                .OrderBy(w => w.Ordre).ToList<WorkToDo>();

            CheckFileMustExist(moduleDirectory, rootDirectoryWorkToDo);
            CheckFileMustNotExist(moduleDirectory, rootDirectoryWorkToDo);

            foreach (var WorkToDoFileData in moduleDirectory.ChildsWorkToDoFileData)
            {
                var CategoryItemWorksTodo = WorkToDoData.WorksToDo
               .Where(w => w.WorkCategory?.Reference == WorkToDoFileData.Reference)
               .OrderBy(w => w.Ordre).ToList<WorkToDo>();

                CheckFileMustExist(WorkToDoFileData, CategoryItemWorksTodo);
                CheckFileMustNotExist(WorkToDoFileData, CategoryItemWorksTodo);
            }

        }

        public static void CreateConfigurationFileExample()
        {
            WorkToDoDAO.CreateConfigurationFileExample();
            
        }

        private void CheckFileMustExist(WorkToDoFileData ParentFileData, List<WorkToDo> WorksTodo)
        {
            foreach (var workToDo in WorksTodo)
            {
                WorkToDoFileData chilFile = ParentFileData.ChildsWorkToDoFileData
              .Where(tdChildFile => tdChildFile.FileName.ToUpper()
              .Contains(workToDo.Title.Split(" -".ToArray<char>()).First().ToUpper()))
              .FirstOrDefault();
                if (chilFile == null)
                {
                    string msg = string.Format(" {0} n'existe pas", workToDo);
                    ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);
                    ParentFileData.AddErrorMessage(errorMessage);
                }else
                {
                    chilFile.WorkToDo = workToDo;
                }
            }
        }
        private void CheckFileMustNotExist(WorkToDoFileData ParentFileData, List<WorkToDo> ListChildName)
        {
            foreach (var chilFile in ParentFileData.ChildsWorkToDoFileData)
            {
                if (ListChildName
                    .Where(configFileName =>
                    chilFile.FileInfo.Name.ToUpper().Contains( 
                        configFileName.Title.Split(" -".ToArray<char>()).First().ToUpper() )
                    .Count() != 0)
                    chilFile.Validation = Enumerations.ValisationStat.Valid;
                else
                {
                    string msg = string.Format("Le nom du répertoir {0} n'est pas valide", chilFile.FileName);
                    ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);

                    chilFile.Validation = Enumerations.ValisationStat.NotValid;
                    chilFile.AddErrorMessage(errorMessage);
                    // moduleDirectory.AddErrorMessage(errorMessage);

                }
            }
        }
    }
}
