using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
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
