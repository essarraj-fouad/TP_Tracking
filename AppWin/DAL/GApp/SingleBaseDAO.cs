using GApp.Entities;
using System;

namespace GApp.DAL
{
    public abstract class SingleBaseDAO<T> where T : BaseEntity
    {
        /// <summary>
        /// Save Data methode
        /// </summary>
        public Action SaveData;
        public Action<T> SetData { get; set; }
        public Func<T> GetData { get; set; }

        public virtual int Save(T t)
        {
            SetData(t);
            SaveData();
            return 0;
        }

    }
}