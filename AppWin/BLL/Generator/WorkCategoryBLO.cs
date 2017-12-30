using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
{
	public partial class WorkCategoryBLO : BaseBLO<WorkCategory>{
	    
		public WorkCategoryBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkCategoryDAO(context);
        }
		public WorkCategoryBLO() : base()
        {
           this.entityDAO = new WorkCategoryDAO(new ModelContext());
        }
 
	}
}
