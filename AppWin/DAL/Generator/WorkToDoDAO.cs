using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
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
