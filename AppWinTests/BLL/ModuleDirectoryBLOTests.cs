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
    public class WorkBLOTests
    {
        [TestInitialize]
        public void InitializeModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkToDoDAO.CreateConfigurationFileExample();
        }
        [TestCleanup]
        public void CleanModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkToDoDAO.DeleteConfigurationFileExample();
        }

        [TestMethod()]
        public void ModuleDirectoryBLOTest()
        {
            WorkBLO ModuleDirectoryBLO = WorkBLO.Instance;
            Assert.AreEqual(ModuleDirectoryBLO.TraineeDirectory.WorksChilds.Count, 2);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            WorkBLO ModuleDirectoryBLO = WorkBLO.Instance;
            ModuleDirectoryBLO.Validation();
            Assert.AreEqual(ModuleDirectoryBLO.TraineeDirectory.WorksChilds.Count, 2);
        }

        [TestMethod()]
        public void SaveStateTest()
        {

            WorkBLO ModuleDirectoryBLO = WorkBLO.Instance;
                ModuleDirectoryBLO.SaveState();
            
        }
    }
}