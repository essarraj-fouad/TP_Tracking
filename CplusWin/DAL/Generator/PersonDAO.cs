using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class PersonDAO : BaseDAO<Person>{
        
		public PersonDAO(DbContext context) : base(context)
		{

        }

		public PersonDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
