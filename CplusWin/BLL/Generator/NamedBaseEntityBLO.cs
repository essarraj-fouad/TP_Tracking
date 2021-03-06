﻿using App.Entities;
using GApp.BLL;
using App.DAL;
using Microsoft.EntityFrameworkCore;
namespace  App.BLL
{
	public partial class NamedBaseEntityBLO : BaseBLO<NamedBaseEntity>{
	    
		public NamedBaseEntityBLO(DbContext context) : base()
        {
            this.entityDAO = new NamedBaseEntityDAO(context);
        }
		 
		public NamedBaseEntityBLO() : base()
        {
           this.entityDAO = new NamedBaseEntityDAO(new ModelContext());
        }
 
	}
}
