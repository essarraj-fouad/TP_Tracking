using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class PersonBLO : BaseBLO<Person>{
	    
		public PersonBLO(DbContext context) : base()
        {
            this.entityDAO = new PersonDAO(context);
        }
		 
		public PersonBLO() : base()
        {
           this.entityDAO = new PersonDAO(new ModelContext());
        }
 
	}
}
