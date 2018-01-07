using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
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
