using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.BLL.Tests
{
    [TestClass()]
    public class TraineeBLOTests
    {
        [TestMethod()]
        public void SaveTest()
        {
            Trainee t = new Trainee();
            new TraineeBLO().Save(t);

          
        }
    }
}