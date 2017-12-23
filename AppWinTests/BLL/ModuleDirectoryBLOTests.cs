using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppWinTests;
using TP_Tracking.Entities;
using TP_Tracking.DAL;
using TP_Tracking.DAL.Tests;

namespace TP_Tracking.BLL.Tests
{
    [TestClass()]
    public class ModuleDirectoryBLOTests
    {
        [TestInitialize]
        public void InitializeModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkConfigurationDAO.CreateConfigurationFileExample();
        }
        [TestCleanup]
        public void CleanModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkConfigurationDAO.DeleteConfigurationFileExample();
        }

        [TestMethod()]
        public void ModuleDirectoryBLOTest()
        {
            ModuleDirectoryBLO ModuleDirectoryBLO = new ModuleDirectoryBLO();
            Assert.AreEqual(ModuleDirectoryBLO.ModuleDirectory.TP.ChildsFils.Count, 1);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            ModuleDirectoryBLO ModuleDirectoryBLO = new ModuleDirectoryBLO();
            ModuleDirectoryBLO.Validate();
            Assert.AreEqual(ModuleDirectoryBLO.ModuleDirectory.TP.ListErrorMessage.Count, 6);
        }

        [TestMethod()]
        public void SaveStateTest()
        {
            string m ="";
            try
            {
                ModuleDirectoryBLO ModuleDirectoryBLO = new ModuleDirectoryBLO();
                ModuleDirectoryBLO.SaveState();
            }
            catch (Exception e)
            {
                m = e.Message;
            }
            Assert.IsTrue(m.Contains(nameof(USBDeviceNotExistException)));
        }
    }
}