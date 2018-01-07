using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
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
