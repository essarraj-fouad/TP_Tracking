using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class TraineeDirectoryBLO2 : BaseBLO<Work>{
	    
		public TraineeDirectoryBLO2(DbContext context) : base()
        {
            this.entityDAO = new WorkDAO(context);
        }
		 
		// public WorkBLO() : base()
        // {
        //   this.entityDAO = new WorkDAO(new ModelContext());
        // }
 
	}
}
