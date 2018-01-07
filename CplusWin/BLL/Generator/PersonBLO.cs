using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
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
