using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class SpecialtyBLO : BaseBLO<Specialty>{
	    
		public SpecialtyBLO(DbContext context) : base()
        {
            this.entityDAO = new SpecialtyDAO(context);
        }
		 
		public SpecialtyBLO() : base()
        {
           this.entityDAO = new SpecialtyDAO(new ModelContext());
        }
 
	}
}
