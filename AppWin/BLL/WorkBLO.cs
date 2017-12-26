using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.DAL;
using TP_Tracking.Entities;
using TP_Tracking.Enumerations;

namespace TP_Tracking.BLL
{
    public partial class WorkBLO
    {
        private WorkDAO workDAO;
        private WorkToDoBLO workToDoBLO;
    
        public WorkBLO()
        {
            this.workDAO = new WorkDAO();
            this.workToDoBLO = new WorkToDoBLO();
            this.Validation();
        }
        public TraineeDirectory TraineeDirectory
        {
            get
            {
                return workDAO.TraineeDirectory;
            }
        }

        /// <summary>
        /// get the root Works of Trainee directory
        /// </summary>
        /// <returns></returns>
        public List<Work> getRootWorks()
        {
            return this.TraineeDirectory.WorksChilds;
        }
        /// <summary>
        /// Find the root work directory for a workCategory reference
        /// </summary>
        /// <param name="WorkCategoryReference"></param>
        /// <returns></returns>
        private Work FindRootWorkByCategoryReference(string WorkCategoryReference)
        {
            return getRootWorks()
                 .Where(w => w.Reference == WorkCategoryReference).FirstOrDefault();
        }

        /// <summary>
        /// Save Job State
        /// </summary>
        public UserCategory SaveState()
        {
            string ModuleName =  workToDoBLO.getData().ModuleName;
            return workDAO.SaveModuleDirectoryStat(ModuleName);
        }

        public static void CreateConfigurationFileExample()
        {
            WorkToDoDAO.CreateConfigurationFileExample();
        }
    }
}
