using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class TraineeDirectoryBLO : BaseBLO<TraineeDirectory>{
	    
		public TraineeDirectoryBLO(DbContext context) : base()
        {
            this.entityDAO = new TraineeDirectoryDAO(context);
        }
		 
		// public TraineeDirectoryBLO() : base()
        // {
        //   this.entityDAO = new TraineeDirectoryDAO(new ModelContext());
        // }
 
	}
}
