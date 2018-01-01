using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class FormerBLO : BaseBLO<Former>{
	    
		public FormerBLO(DbContext context) : base()
        {
            this.entityDAO = new FormerDAO(context);
        }
		 
		public FormerBLO() : base()
        {
           this.entityDAO = new FormerDAO(new ModelContext());
        }
 
	}
}
