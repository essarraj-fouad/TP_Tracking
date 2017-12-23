using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.DAL.Tests
{
    [TestClass()]
    public class FormerDAOTests
    {
        [TestMethod()]
        public void GetFormerDeviceInfoTest()
        {
            FormerDAO uSBDeviceDAO = new FormerDAO();
            uSBDeviceDAO.GetFormerDeviceInfo();
            uSBDeviceDAO.isFormerDeviceExist();
        }
    }
}