using App.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
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
