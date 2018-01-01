using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class ValidateErrorMessageBLO : BaseBLO<ValidateErrorMessage>{
	    
		public ValidateErrorMessageBLO(DbContext context) : base()
        {
            this.entityDAO = new ValidateErrorMessageDAO(context);
        }
		 
		// public ValidateErrorMessageBLO() : base()
        // {
        //   this.entityDAO = new ValidateErrorMessageDAO(new ModelContext());
        // }
 
	}
}
