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
    public partial class WorkBLO
    {
        /// <summary>
        /// Validation trainee directory
        /// </summary>
        public void Validation()
        {
            WorkToDoDAO_DB workToDoData = this.workToDoBLO.getData();

            var rootWorkToDo = workToDoBLO.FindByCategoryReference("root");

            CheckFileMustExist(this.workDAO.TraineeDirectory, rootWorkToDo);
            CheckFileMustNotExist(this.workDAO.TraineeDirectory, rootWorkToDo);

            foreach (WorkCategory workCategory in workToDoData.WorkCategories)
            {
                if (workCategory.Reference == "root") continue;
                var WorksToDo = workToDoBLO.FindByCategoryReference(workCategory.Reference);
                var rootWorkByCategoryReference = this.FindRootWorkByCategoryReference(workCategory.Reference);
                CheckFileMustExist(rootWorkByCategoryReference, WorksToDo);
                CheckFileMustNotExist(rootWorkByCategoryReference, WorksToDo);
            }
        }
        /// <summary>
        /// Chekc fil must exist in Wrok directory
        /// </summary>
        /// <param name="workDirectory"></param>
        /// <param name="WorksTodo"></param>
        private void CheckFileMustExist(Work workDirectory, List<WorkToDo> WorksTodo)
        {
            if (workDirectory != null)
                foreach (var workToDo in WorksTodo)
                {
                    if (workToDo.Title.Contains("TD 7")){
                        int i = 1;
                    }
    
                    Work ValideWork = workDirectory.WorksChilds
                  .Where(w => isWrokValide(w, workToDo))
                  .FirstOrDefault();

                    if (ValideWork == null)
                    {
                        string msg = string.Format("Le travail : {0} n'existe pas", workToDo);
                        ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);
                        workDirectory.AddErrorMessage(errorMessage);
                    }
                    else
                    {
                        ValideWork.WorkToDo = workToDo;
                        ValideWork.Validation = Enumerations.ValisationStat.Valid;
                    }
                }
        }
        private void CheckFileMustNotExist(Work workDirectory, List<WorkToDo> WorksTodo)
        {
            if (workDirectory != null)
                foreach (var work in workDirectory.WorksChilds)
                {
                    if (WorksTodo
                        .Where(configFileName => isWrokValide(work, configFileName))
                        .Count() != 0)
                        work.Validation = Enumerations.ValisationStat.Valid;
                    else
                    {
                        string msg = string.Format("Le nom du répertoir {0} n'est pas valide", work.FileName);
                        ValidateErrorMessage errorMessage = new ValidateErrorMessage(msg);

                        work.Validation = Enumerations.ValisationStat.NotValid;
                        work.AddErrorMessage(errorMessage);
                        // moduleDirectory.AddErrorMessage(errorMessage);

                    }
                }
        }

        private bool isWrokValide(Work work, WorkToDo workToDo)
        {

            string work_reference = work.FileName.Split('-').FirstOrDefault();
            string workToDo_reference = workToDo.Title.Split('-').FirstOrDefault();

            if (work_reference.Replace(" ", string.Empty).ToUpper() == workToDo_reference.Replace(" ", string.Empty).ToUpper())
                return true;
            else
                return false;
        }
    }
}
