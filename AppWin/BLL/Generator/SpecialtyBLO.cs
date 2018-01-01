using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
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
