using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class NamedBaseEntityBLO : BaseBLO<NamedBaseEntity>{
	    
		public NamedBaseEntityBLO(DbContext context) : base()
        {
            this.entityDAO = new NamedBaseEntityDAO(context);
        }
		 
		public NamedBaseEntityBLO() : base()
        {
           this.entityDAO = new NamedBaseEntityDAO(new ModelContext());
        }
 
	}
}
