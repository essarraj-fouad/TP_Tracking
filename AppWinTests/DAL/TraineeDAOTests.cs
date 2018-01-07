using Microsoft.VisualStudio.TestTools.UnitTesting;
using App.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App.Entities;

namespace App.DAL.Tests
{
    [TestClass()]
    public class TraineeDAOTests
    {
      
        [TestMethod()]
        public void SaveTest()
        {
            TraineeDAO traineeDAO = new TraineeDAO();
          
            Trainee Trainee = new Trainee();
            Trainee.FirstName = "Madani";
            traineeDAO.Insert(Trainee);

            Trainee LoadedTrainee = traineeDAO.FindByReference(Trainee.Reference);

            Assert.AreEqual(Trainee.Id, LoadedTrainee.Id);
        }
    }
}