using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
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
