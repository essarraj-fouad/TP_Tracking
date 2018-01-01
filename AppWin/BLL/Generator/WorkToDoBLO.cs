using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class WorkToDoBLO : BaseBLO<WorkToDo>{
	    
		public WorkToDoBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkToDoDAO(context);
        }

       

        // public WorkToDoBLO() : base()
        // {
        //   this.entityDAO = new WorkToDoDAO(new ModelContext());
        // }

    }
}
