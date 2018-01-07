using App.Entities;
using GApp.BLL;
using App.DAL;
using System.Data.Entity;
namespace  App.BLL
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
