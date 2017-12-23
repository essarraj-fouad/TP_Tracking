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
    public class WorkConfigurationDAOTests
    {

        [TestMethod()]
        public void WorkConfigurationDAOTest()
        {
            string messageException = "";
            try
            {
                WorkConfigurationDAO workConfigurationDAO = new WorkConfigurationDAO();
                Assert.Fail(string.Format("Exception {0} not thrown", typeof(ConfigurationFileNotExistException)));
            }
            catch (Exception ex)
            {

                messageException = ex.Message;
            }
            Assert.IsTrue(messageException.Contains(nameof(ConfigurationFileNotExistException)));
        }

        [TestMethod()]
        public void LoadConfigurationTest()
        {
            // Create configuration file 
            WorkConfigurationDAO.CreateConfigurationFileExample();
            WorkConfigurationDAO workConfigurationDAO = new WorkConfigurationDAO();
            Assert.IsNotNull(workConfigurationDAO.getWorkToDoConfiguration());
            WorkConfigurationDAO.DeleteConfigurationFileExample();
        }

       
    }
}