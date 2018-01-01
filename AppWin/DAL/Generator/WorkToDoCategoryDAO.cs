using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class WorkToDoCategoryDAO : BaseDAO<WorkToDoCategory>{
        
		public WorkToDoCategoryDAO(DbContext context) : base(context)
		{

        }

		public WorkToDoCategoryDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
