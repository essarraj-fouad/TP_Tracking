using App.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class TraineeWorkNoteDAO : BaseDAO<TraineeWorkNote>{
        
		public TraineeWorkNoteDAO(DbContext context) : base(context)
		{

        }

		public TraineeWorkNoteDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
