using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
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
