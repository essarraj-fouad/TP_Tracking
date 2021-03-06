﻿using App.Entities;
using GApp.DAL;
using Microsoft.EntityFrameworkCore;
namespace App.DAL
{
    public partial class NamedBaseEntityDAO : BaseDAO<NamedBaseEntity>{
        
		public NamedBaseEntityDAO(DbContext context) : base(context)
		{

        }

		public NamedBaseEntityDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
