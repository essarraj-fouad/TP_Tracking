using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class TraineeDAO : BaseDAO<Trainee>{
        
		public TraineeDAO(DbContext context) : base(context)
		{

        }

		public TraineeDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
