using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.DAL;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL
{
    public class ModuleDirectoryBLO
    {
        private TraineeDirectoryDAO traineeDirectoryDAO;
        private ValidateTraineeDirectoryBLO validateTraineeDirectoryDAO;

        public TraineeDirectory TraineeDirectory {
            get
            {
                return traineeDirectoryDAO.ModuleDirectory;
            }
        }

        public ModuleDirectoryBLO()
        {
            traineeDirectoryDAO = new TraineeDirectoryDAO();
            validateTraineeDirectoryDAO = new ValidateTraineeDirectoryBLO(traineeDirectoryDAO.ModuleDirectory);
            this.Validate();
        }

        /// <summary>
        /// Validate Repertories 
        /// </summary>
        /// <returns></returns>
        public void Validate()
        {
            validateTraineeDirectoryDAO.Validation();
        }
        /// <summary>
        /// Save Job State
        /// </summary>
        public void SaveState()
        {
            traineeDirectoryDAO.SaveModuleDirectoryStat();
        }

        public static void CreateConfigurationFileExample()
        {
            ValidateTraineeDirectoryBLO.CreateConfigurationFileExample();
        }
    }
}
