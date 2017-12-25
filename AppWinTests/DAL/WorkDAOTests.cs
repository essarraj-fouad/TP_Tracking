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
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL.Tests
{
    [TestClass()]
    public class WorkDAOTests
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
            WorkDAO workDAO = new WorkDAO();
            Assert.AreEqual(workDAO.TraineeDirectory.WorksChilds.Count ,2);
        }

        [TestMethod()]
        public void LoadTest()
        {
            WorkDAO workDAO = new WorkDAO();
            workDAO.Load();
            Assert.AreEqual(workDAO.TraineeDirectory.WorksChilds.Count, 2);
        }

        [TestMethod()]
        public void SaveModuleDirectoryStatTest()
        {
           
            
                WorkDAO moduleDirectoryDAO = new WorkDAO();
                moduleDirectoryDAO.SaveModuleDirectoryStat();
            
            
           
        }
    }
}