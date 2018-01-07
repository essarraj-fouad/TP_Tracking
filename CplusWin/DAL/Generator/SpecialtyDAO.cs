using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
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
