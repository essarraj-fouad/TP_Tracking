using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class TraineeDirectoryDAO : BaseDAO<TraineeDirectory>{
        
		public TraineeDirectoryDAO(DbContext context) : base(context)
		{

        }
   }
}
