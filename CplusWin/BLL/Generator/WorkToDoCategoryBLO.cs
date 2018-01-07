using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
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
