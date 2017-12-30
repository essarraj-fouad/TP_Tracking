using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
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
