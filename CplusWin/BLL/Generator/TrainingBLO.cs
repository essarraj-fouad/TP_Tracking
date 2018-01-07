using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class TrainingBLO : BaseBLO<Training>{
	    
		public TrainingBLO(DbContext context) : base()
        {
            this.entityDAO = new TrainingDAO(context);
        }
		 
		public TrainingBLO() : base()
        {
           this.entityDAO = new TrainingDAO(new ModelContext());
        }
 
	}
}
