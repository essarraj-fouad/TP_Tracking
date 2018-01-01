using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class TraineeDirectoryDAO : BaseDAO<TraineeDirectory>{
        
		public TraineeDirectoryDAO(DbContext context) : base(context)
		{

        }
   }
}
