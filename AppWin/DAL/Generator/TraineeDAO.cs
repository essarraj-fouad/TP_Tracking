using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class TraineeDAO : BaseDAO<Trainee>{
        
		public TraineeDAO(DbContext context) : base(context)
		{

        }
   }
}
