using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class ValidateErrorMessageDAO : BaseDAO<ValidateErrorMessage>{
        
		public ValidateErrorMessageDAO(DbContext context) : base(context)
		{

        }
   }
}
