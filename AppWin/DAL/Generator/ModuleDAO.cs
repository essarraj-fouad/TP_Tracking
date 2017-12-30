using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class ModuleDAO : BaseDAO<Module>{
        
		public ModuleDAO(DbContext context) : base(context)
		{

        }
   }
}
