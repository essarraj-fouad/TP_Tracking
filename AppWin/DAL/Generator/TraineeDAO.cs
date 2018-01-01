using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class TraineeDAO : BaseDAO<Trainee>{
        
		public TraineeDAO(DbContext context) : base(context)
		{

        }

		public TraineeDAO() : base(new ModelContext())
		{
        }
   }
}
