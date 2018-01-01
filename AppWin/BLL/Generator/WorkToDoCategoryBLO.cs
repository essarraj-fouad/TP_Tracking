using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class WorkToDoCategoryBLO : BaseBLO<WorkToDoCategory>{
	    
		public WorkToDoCategoryBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkToDoCategoryDAO(context);
        }
		 
		public WorkToDoCategoryBLO() : base()
        {
           this.entityDAO = new WorkToDoCategoryDAO(new ModelContext());
        }
 
	}
}
