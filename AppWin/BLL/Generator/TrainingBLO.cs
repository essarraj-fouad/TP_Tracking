using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class TrainingBLO : BaseBLO<Training>{
	    
		public TrainingBLO(DbContext context) : base()
        {
            this.entityDAO = new TrainingDAO(context);
        }
		 
		public TrainingBLO() : base()
        {
           this.entityDAO = new TrainingDAO(new ModelContext());
        }
 
	}
}
