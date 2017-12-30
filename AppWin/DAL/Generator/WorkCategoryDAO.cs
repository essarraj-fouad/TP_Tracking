using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class WorkCategoryDAO : BaseDAO<WorkCategory>{
        
		public WorkCategoryDAO(DbContext context) : base(context)
		{

        }
   }
}
