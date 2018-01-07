using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class GroupDAO : BaseDAO<Group>{
        
		public GroupDAO(DbContext context) : base(context)
		{

        }

		public GroupDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
