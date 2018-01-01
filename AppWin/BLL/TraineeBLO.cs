using GApp.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;
using GApp.Entities;
using TP_Tracking.DAL;
using GApp.Patterns;
using TP_Tracking.DAL.XML;

namespace TP_Tracking.BLL
{
    public partial class TraineeBLO  
    {
 
        public TraineeBLO()
        {
            this.entityDAO = TraineeXmlDAO.Instance;
        }

        /// <summary>
        /// Save Trainee
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        public override int Save(Trainee entity)
        {
            TraineeDirectoryBLO2.Instance
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
            Trainee trainee = this.FindAll().FirstOrDefault();
            if (trainee == null)
            {
                this.Save(work_directory_trainee);
            }
            trainee = this.FindAll().FirstOrDefault();
            return trainee;
        }

        public string getModuleName()
        {
          Module m =  new ModuleBLO().FindAll().FirstOrDefault();
            if (m == null)
                throw new Exception("Le nom du module n'exist pas dans la base de données");
            return m.Name;
        }
    }
}
