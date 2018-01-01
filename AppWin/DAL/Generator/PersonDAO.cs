using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
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
