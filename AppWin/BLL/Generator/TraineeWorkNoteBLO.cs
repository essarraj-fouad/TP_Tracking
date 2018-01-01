using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
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
