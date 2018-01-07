using App.Entities;
using GApp.BLL;
using App.DAL;
using System.Data.Entity;
namespace  App.BLL
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
