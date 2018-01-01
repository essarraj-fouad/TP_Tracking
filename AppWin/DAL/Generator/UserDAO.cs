using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace TP_Tracking.DAL
{
    public partial class UserDAO : BaseDAO<User>{
        
		public UserDAO(DbContext context) : base(context)
		{

        }
   }
}
