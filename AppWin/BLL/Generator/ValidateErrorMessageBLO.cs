using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
{
	public partial class ValidateErrorMessageBLO : BaseBLO<ValidateErrorMessage>{
	    
		public ValidateErrorMessageBLO(DbContext context) : base()
        {
            this.entityDAO = new ValidateErrorMessageDAO(context);
        }
		public ValidateErrorMessageBLO() : base()
        {
           this.entityDAO = new ValidateErrorMessageDAO(new ModelContext());
        }
 
	}
}
