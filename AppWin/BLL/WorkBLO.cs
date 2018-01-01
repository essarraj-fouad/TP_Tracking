using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using TP_Tracking.DAL;
using TP_Tracking.DAL.XML;
using TP_Tracking.Entities;
using TP_Tracking.Enumerations;

namespace TP_Tracking.BLL
{
    public partial class TraineeDirectoryBLO2
    {
        #region Signleton Pattern
        private static TraineeDirectoryBLO2 instance;
        public static TraineeDirectoryBLO2 Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraineeDirectoryBLO2();
                return instance;
            }
        }
        #endregion

        private TraineeDirectoryFileDAO traineeDirectoryFileDAO;

        private TraineeDirectoryBLO2()
        {
            this.traineeDirectoryFileDAO = new TraineeDirectoryFileDAO();
            this.Validation();
        }

        public TraineeDirectory TraineeDirectory
        {
            get
            {
                return traineeDirectoryFileDAO.TraineeDirectory;
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
        /// Save work State to Trainee Directory or Former Directory
        /// </summary>
        public UserCategory SaveWorksState()
        {
            string ModuleName = new TraineeBLO().getModuleName();
            return traineeDirectoryFileDAO.SaveWorksState(ModuleName);
        }

        public static void CreateConfigurationFileExample()
        {
            WorkToDoXmlDAO.CreateConfigurationFileExample();
        }

        /// <summary>
        /// Reload Data and Validation
        /// </summary>
        public void ReloadData()
        {
            this.traineeDirectoryFileDAO.Load();
            this.Validation();
        }

        public string DataFileName {
        get {
                return "";

            }
        }
    }
}
