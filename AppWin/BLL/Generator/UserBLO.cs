using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
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
