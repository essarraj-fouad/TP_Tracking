using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class WorkToDoDAO : BaseDAO<WorkToDo>{
        
		public WorkToDoDAO(DbContext context) : base(context)
		{

        }
   }
}
