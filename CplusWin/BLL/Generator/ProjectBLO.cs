using App.Entities;
using GApp.BLL;
using App.DAL;
using System.Data.Entity;
namespace  App.BLL
{
	public partial class ProjectBLO : BaseBLO<Project>{
	    
		public ProjectBLO(DbContext context) : base()
        {
            this.entityDAO = new ProjectDAO(context);
        }
		 
		public ProjectBLO() : base()
        {
           this.entityDAO = new ProjectDAO(new ModelContext());
        }
 
	}
}
