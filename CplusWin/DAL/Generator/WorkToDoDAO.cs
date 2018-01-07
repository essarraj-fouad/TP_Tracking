using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class WorkToDoDAO : BaseDAO<WorkToDo>{
        
		public WorkToDoDAO(DbContext context) : base(context)
		{

        }

		public WorkToDoDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
