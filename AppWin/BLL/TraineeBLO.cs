using GApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;
using GApp.Entities;
using TP_Tracking.DAL;

namespace TP_Tracking.BLL
{
    public class TraineeBLO : SingleBaseBLO<Trainee>
    {

        #region Signleton Pattern
        private static TraineeBLO instance;
        public static TraineeBLO Instance
        {
            get
            {
                if (instance == null)
                    instance = new TraineeBLO();
                return instance;
            }
        }
        #endregion

        public TraineeBLO()
        {
            EntityDao = TraineeDAO.Instance;
        }

        /// <summary>
        /// Save Trainee
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override int Save(Trainee entity)
        {
            WorkBLO.Instance
                .TraineeDirectory
                .Trainee = entity as Trainee;
            return base.Save(entity);
        }
        /// <summary>
        /// Fin current trainne
        /// </summary>
        /// <param name="work_directory_trainee"></param>
        /// <returns></returns>
        public Trainee Find(Trainee work_directory_trainee)
        {
            // if current trainee null , create it by work_directory_trainee
            return work_directory_trainee;
        }

        public Trainee getEntity()
        {
            return this.EntityDao.GetData();
        }



    }
}
