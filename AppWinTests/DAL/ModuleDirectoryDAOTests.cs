using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using TP_Tracking.Entities;
using AppWinTests;

namespace TP_Tracking.DAL.Tests
{
    [TestClass()]
    public class ModuleDirectoryDAOTests
    {
        [TestInitialize]
        public void InitializeModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
        }
        [TestCleanup]
        public void CleanModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
        }


        [TestMethod()]
        public void ModuleDirectoryDAOTest()
        {
            ModuleDirectoryDAO moduleDirectoryDAO = new ModuleDirectoryDAO();
            Assert.AreEqual(moduleDirectoryDAO.ModuleDirectory.TP.ChildsFils.Count , 1);
        }

        [TestMethod()]
        public void LoadTest()
        {
            ModuleDirectoryDAO moduleDirectoryDAO = new ModuleDirectoryDAO();
            moduleDirectoryDAO.Load();
            Assert.AreEqual(moduleDirectoryDAO.ModuleDirectory.TP.ChildsFils.Count, 1);
        }

        [TestMethod()]
        public void SaveModuleDirectoryStatTest()
        {
            string messageException = "";
            try
            {
                ModuleDirectoryDAO moduleDirectoryDAO = new ModuleDirectoryDAO();
                moduleDirectoryDAO.SaveModuleDirectoryStat();
            }
            catch (Exception ex)
            {

                messageException = ex.Message;
            }
            Assert.IsTrue(messageException.Contains(nameof(USBDeviceNotExistException)));
           
        }
    }
}