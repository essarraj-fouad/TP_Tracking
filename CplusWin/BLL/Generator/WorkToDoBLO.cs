using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class WorkToDoBLO : BaseBLO<WorkToDo>{
	    
		public WorkToDoBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkToDoDAO(context);
        }
		 
		public WorkToDoBLO() : base()
        {
           this.entityDAO = new WorkToDoDAO(new ModelContext());
        }
 
	}
}
