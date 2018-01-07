using App.Entities;
using GApp.BLL;
using App.DAL;
using System.Data.Entity;
namespace  App.BLL
{
	public partial class TraineeBLO : BaseBLO<Trainee>{
	    
		public TraineeBLO(DbContext context) : base()
        {
            this.entityDAO = new TraineeDAO(context);
        }
		 
		public TraineeBLO() : base()
        {
           this.entityDAO = new TraineeDAO(new ModelContext());
        }
 
	}
}
