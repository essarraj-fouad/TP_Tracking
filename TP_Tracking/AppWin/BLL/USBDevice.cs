using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Tracking.BLL
{
    public class USBDevice
    {
        public static string DeviceVolumeLabel = "Formateur";
       
        public static DriveInfo GetDeviceInfo()
        {
            DriveInfo driveFormateur = DriveInfo.GetDrives()
                         .Where(drive => drive.IsReady && drive.DriveType == DriveType.Removable)
                         .Where(drive => drive.VolumeLabel == "Formateur")
                         .FirstOrDefault();

            return driveFormateur;
        }

        internal static bool DeviceExist()
        {
            if (GetDeviceInfo() == null)
                return false;
            else
                return true;
        }
    }
}
