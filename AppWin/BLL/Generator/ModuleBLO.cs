using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class ModuleBLO : BaseBLO<Module>{
	    
		public ModuleBLO(DbContext context) : base()
        {
            this.entityDAO = new ModuleDAO(context);
        }
		 
		public ModuleBLO() : base()
        {
           this.entityDAO = new ModuleDAO(new ModelContext());
        }
 
	}
}
