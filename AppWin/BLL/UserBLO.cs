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
        private FormerDAO formerDAO;
        public UserBLO()
        {
            this.formerDAO = new FormerDAO();
        }
        /// <summary>
        /// Get the UserCagrory that use the application
        /// </summary>
        /// <returns></returns>
        public UserCategory GetUserCagegory()
        {
            if (this.formerDAO.isFormerDeviceExist())
                return UserCategory.Former;
            else
                return UserCategory.Trainee;
        }
    }
}
