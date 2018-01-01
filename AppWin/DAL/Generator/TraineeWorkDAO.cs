using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class TraineeWorkDAO : BaseDAO<TraineeWork>{
        
		public TraineeWorkDAO(DbContext context) : base(context)
		{

        }

		public TraineeWorkDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
