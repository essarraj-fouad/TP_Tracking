using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
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
