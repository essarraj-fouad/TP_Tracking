using App.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class TaskDAO : BaseDAO<Task>{
        
		public TaskDAO(DbContext context) : base(context)
		{

        }

		public TaskDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
