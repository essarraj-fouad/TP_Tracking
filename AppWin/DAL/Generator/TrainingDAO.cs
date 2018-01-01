using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class TrainingDAO : BaseDAO<Training>{
        
		public TrainingDAO(DbContext context) : base(context)
		{

        }

		public TrainingDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
