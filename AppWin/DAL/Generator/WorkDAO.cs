using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class WorkDAO : BaseDAO<Work>{
        
		public WorkDAO(DbContext context) : base(context)
		{

        }
   }
}
