using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
{
	public partial class WorkBLO : BaseBLO<Work>{
	    
		public WorkBLO(DbContext context) : base()
        {
            this.entityDAO = new WorkDAO(context);
        }
		public WorkBLO() : base()
        {
           this.entityDAO = new WorkDAO(new ModelContext());
        }
 
	}
}
