using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class TraineeWorkBLO : BaseBLO<TraineeWork>{
	    
		public TraineeWorkBLO(DbContext context) : base()
        {
            this.entityDAO = new TraineeWorkDAO(context);
        }
		 
		public TraineeWorkBLO() : base()
        {
           this.entityDAO = new TraineeWorkDAO(new ModelContext());
        }
 
	}
}
