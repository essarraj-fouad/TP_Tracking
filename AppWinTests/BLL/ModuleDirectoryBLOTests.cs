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
using TP_Tracking.DAL.XML;

namespace TP_Tracking.BLL.Tests
{
    [TestClass()]
    public class WorkBLOTests
    {
        [TestInitialize]
        public void InitializeModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkToDoXmlDAO.CreateConfigurationFileExample();
        }
        [TestCleanup]
        public void CleanModuleDirectoryForTest()
        {
            TestTraking_Test.CreateModuleDirectory();
            WorkToDoXmlDAO.DeleteConfigurationFileExample();
        }

        [TestMethod()]
        public void ModuleDirectoryBLOTest()
        {
            TraineeDirectoryBLO2 ModuleDirectoryBLO = TraineeDirectoryBLO2.Instance;
            Assert.AreEqual(ModuleDirectoryBLO.TraineeDirectory.WorksChilds.Count, 2);
        }

        [TestMethod()]
        public void ValidateTest()
        {
            TraineeDirectoryBLO2 ModuleDirectoryBLO = TraineeDirectoryBLO2.Instance;
            ModuleDirectoryBLO.Validation();
            Assert.AreEqual(ModuleDirectoryBLO.TraineeDirectory.WorksChilds.Count, 2);
        }

        [TestMethod()]
        public void SaveStateTest()
        {

            TraineeDirectoryBLO2 ModuleDirectoryBLO = TraineeDirectoryBLO2.Instance;
                ModuleDirectoryBLO.SaveWorksState();
            
        }
    }
}