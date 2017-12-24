using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP_Tracking.DAL;
using TP_Tracking.Enumerations;

namespace TP_Tracking.BLL
{
    public class UserBLO
    {
        private UserDAO userDAO;
        public UserBLO()
        {
            this.userDAO = new UserDAO();
        }
        /// <summary>
        /// Get the UserCagrory that use the application
        /// </summary>
        /// <returns></returns>
        public UserCategory GetUserCagegory()
        {
            if (this.userDAO.isFormerDeviceExist())
                return UserCategory.Former;
            else
                return UserCategory.Trainee;
        }

        /// <summary>
        /// get XmlDataBase directory that contain the XML DataBase
        /// </summary>
        /// <returns></returns>
        public string getUserXmlDataBaseDirecrory()
        {
            string path = "";
            if (this.userDAO.isFormerDeviceExist())
                path = this.userDAO.GetFormerDeviceInfo().Name + "/";
            else
                path = "./";
            return path;
        }
    }
}
