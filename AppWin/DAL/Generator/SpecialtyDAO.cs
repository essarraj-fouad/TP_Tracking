using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class SpecialtyDAO : BaseDAO<Specialty>{
        
		public SpecialtyDAO(DbContext context) : base(context)
		{

        }

		public SpecialtyDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
