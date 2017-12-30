using TP_Tracking.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class PersonDAO : BaseDAO<Person>{
        
		public PersonDAO(DbContext context) : base(context)
		{

        }
   }
}
