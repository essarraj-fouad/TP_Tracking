using App.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class ProjectDAO : BaseDAO<Project>{
        
		public ProjectDAO(DbContext context) : base(context)
		{

        }

		public ProjectDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
