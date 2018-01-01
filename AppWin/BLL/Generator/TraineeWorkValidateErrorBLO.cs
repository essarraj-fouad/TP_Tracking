using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class TraineeWorkValidateErrorBLO : BaseBLO<TraineeWorkValidateError>{
	    
		public TraineeWorkValidateErrorBLO(DbContext context) : base()
        {
            this.entityDAO = new TraineeWorkValidateErrorDAO(context);
        }
		 
		public TraineeWorkValidateErrorBLO() : base()
        {
           this.entityDAO = new TraineeWorkValidateErrorDAO(new ModelContext());
        }
 
	}
}
