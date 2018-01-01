using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class WorkCategoryDAO : BaseDAO<WorkCategory>{
        
		public WorkCategoryDAO(DbContext context) : base(context)
		{

        }
   }
}
