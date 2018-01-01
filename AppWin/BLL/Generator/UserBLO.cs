using TP_Tracking.Entities;
using GApp.BLL;
using TP_Tracking.DAL;
using System.Data.Entity;
namespace  TP_Tracking.BLL
{
	public partial class UserBLO : BaseBLO<User>{
	    
		public UserBLO(DbContext context) : base()
        {
            this.entityDAO = new UserDAO(context);
        }
		 
		public UserBLO() : base()
        {
           this.entityDAO = new UserDAO(new ModelContext());
        }
 
	}
}
