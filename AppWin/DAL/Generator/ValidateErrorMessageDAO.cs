using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class ValidateErrorMessageDAO : BaseDAO<ValidateErrorMessage>{
        
		public ValidateErrorMessageDAO(DbContext context) : base(context)
		{

        }
   }
}
