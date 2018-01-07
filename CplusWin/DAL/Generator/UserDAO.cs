using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class UserDAO : BaseDAO<User>{
        
		public UserDAO(DbContext context) : base(context)
		{

        }

		public UserDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
