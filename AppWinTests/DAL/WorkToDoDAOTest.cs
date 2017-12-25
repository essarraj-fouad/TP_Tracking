using Microsoft.VisualStudio.TestTools.UnitTesting;
using TP_Tracking.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.Exceptions;

namespace TP_Tracking.DAL.Tests
{
    [TestClass()]
    public class WorkToDoDAO_Test
    {

        [TestMethod()]
        public void WorkToDoDAOTest()
        {
            string messageException = "";
            try
            {
                WorkToDoDAO WorkToDoDAO = new WorkToDoDAO("./");
                Assert.Fail(string.Format("Exception {0} not thrown", typeof(ConfigurationFileNotExistException)));
            }
            catch (Exception ex)
            {

                messageException = ex.Message;
            }
            Assert.IsTrue(messageException.Contains(nameof( ConfigurationFileNotExistException)));
        }

        [TestMethod()]
        public void LoadConfigurationTest()
        {
            WorkToDoDAO.CreateConfigurationFileExample();
            // Create configuration file 

            WorkToDoDAO workToDoDAO = new WorkToDoDAO("./");
            Assert.IsNotNull(workToDoDAO.getData());
            DAL.WorkToDoDAO.DeleteConfigurationFileExample();
        }

       
    }
}