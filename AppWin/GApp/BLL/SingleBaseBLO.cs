using GApp.BLL;
using GApp.DAL;
using GApp.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace GApp.BLL
{
    public class SingleBaseBLO<T> where T : BaseEntity
    {
        protected SingleBaseDAO<T> EntityDao;

        public SingleBaseBLO()
        {
          
        }
        public virtual int Save(T entity)
        {
            EntityDao.SetData(entity);
            EntityDao.SaveData();
            return 1;
        }

        public virtual T Find()
        {
            return EntityDao.getEntity();
        }
        
    }
}
