using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class GroupDAO : BaseDAO<Group>{
        
		public GroupDAO(DbContext context) : base(context)
		{

        }
   }
}
