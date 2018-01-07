using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class TaskBLO : BaseBLO<Task>{
	    
		public TaskBLO(DbContext context) : base()
        {
            this.entityDAO = new TaskDAO(context);
        }
		 
		public TaskBLO() : base()
        {
           this.entityDAO = new TaskDAO(new ModelContext());
        }
 
	}
}
