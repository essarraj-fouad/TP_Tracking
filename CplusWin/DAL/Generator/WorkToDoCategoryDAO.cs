﻿using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class WorkToDoCategoryDAO : BaseDAO<WorkToDoCategory>{
        
		public WorkToDoCategoryDAO(DbContext context) : base(context)
		{

        }

		public WorkToDoCategoryDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
