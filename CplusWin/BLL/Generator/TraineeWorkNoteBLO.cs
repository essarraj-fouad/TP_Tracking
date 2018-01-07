using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class TraineeWorkNoteBLO : BaseBLO<TraineeWorkNote>{
	    
		public TraineeWorkNoteBLO(DbContext context) : base()
        {
            this.entityDAO = new TraineeWorkNoteDAO(context);
        }
		 
		public TraineeWorkNoteBLO() : base()
        {
           this.entityDAO = new TraineeWorkNoteDAO(new ModelContext());
        }
 
	}
}
