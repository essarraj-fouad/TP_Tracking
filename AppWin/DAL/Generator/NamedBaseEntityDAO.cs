using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class NamedBaseEntityDAO : BaseDAO<NamedBaseEntity>{
        
		public NamedBaseEntityDAO(DbContext context) : base(context)
		{

        }

		public NamedBaseEntityDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
