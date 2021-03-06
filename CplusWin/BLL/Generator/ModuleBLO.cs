﻿using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class ModuleBLO : BaseBLO<Module>{
	    
		public ModuleBLO(DbContext context) : base()
        {
            this.entityDAO = new ModuleDAO(context);
        }
		 
		public ModuleBLO() : base()
        {
           this.entityDAO = new ModuleDAO(new ModelContext());
        }
 
	}
}
