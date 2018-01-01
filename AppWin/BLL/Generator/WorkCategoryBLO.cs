using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class WorkCategoryBLO : BaseBLO<WorkCategory>{
	    
		public WorkCategoryBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkCategoryDAO(context);
        }
		 
		// public WorkCategoryBLO() : base()
        // {
        //   this.entityDAO = new WorkCategoryDAO(new ModelContext());
        // }
 
	}
}
