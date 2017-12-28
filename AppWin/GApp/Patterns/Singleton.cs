using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GApp.Patterns
{
    public static class Singleton<T>
    {
        private static readonly object Sync = new object();

        public static T GetSingleton(ref T singletonMember, Func<T> initializer)
        {
            if (singletonMember == null)
            {
                lock (Sync)
                {
                    if (singletonMember == null)
                        singletonMember = initializer();
                }
            }
            return singletonMember;
        }
    }
}
