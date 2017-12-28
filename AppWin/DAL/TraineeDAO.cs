using GApp.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL
{
    public class TraineeDAO : SingleBaseDAO<Trainee>
    {

        #region Signleton Pattern
        private static TraineeDAO instance;
        public static TraineeDAO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraineeDAO();
                return instance;
            }
        }
        #endregion

        public TraineeDAO()
        {
            this.SaveData = TP_TrakingDAO.Instance.SaveData;
            this.SetData = TP_TrakingDAO.Instance.getData().setTrainee;
            this.getEntity = TP_TrakingDAO.Instance.getData().getTrainee;
        }
    }
}
