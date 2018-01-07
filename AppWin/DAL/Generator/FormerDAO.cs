﻿using App.Entities;
using GApp.DAL;
using System.Data.Entity;
namespace App.DAL
{
    public partial class FormerDAO : BaseDAO<Former>{
        
		public FormerDAO(DbContext context) : base(context)
		{

        }

		public FormerDAO() : base(null)
		{
			this.Context = new ModelContext();
        }
   }
}
