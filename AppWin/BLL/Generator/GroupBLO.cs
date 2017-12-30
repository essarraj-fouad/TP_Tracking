using TP_Tracking.Entities;
using GApp.BLL;
using GApp.DAL;
using App.DAL;
using System.Data.Entity;
namespace App.BLL
{
	public partial class GroupBLO : BaseBLO<Group>{
	    
		public GroupBLO(DbContext context) : base()
        {
            this.entityDAO = new GroupDAO(context);
        }
		public GroupBLO() : base()
        {
           this.entityDAO = new GroupDAO(new ModelContext());
        }
 
	}
}
