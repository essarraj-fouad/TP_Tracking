using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class TraineeWorkValidateErrorDAO : BaseDAO<TraineeWorkValidateError>{
        
		public TraineeWorkValidateErrorDAO(DbContext context) : base(context)
		{

        }

		public TraineeWorkValidateErrorDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
