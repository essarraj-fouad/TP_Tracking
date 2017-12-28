using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Entities;

namespace TP_Tracking.DAL.Tests
{
    [TestClass()]
    public class TraineeDAOTests
    {
      
        [TestMethod()]
        public void SaveTest()
        {
            Trainee Trainee = new Trainee();
            Trainee.FirstName = "Madani";
            TraineeDAO.Instance.Save(Trainee);

            Trainee LoadedTrainee = TraineeDAO.Instance.getEntity();

            Assert.AreEqual(Trainee.Id, LoadedTrainee.Id);
        }
    }
}