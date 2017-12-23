using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWinTests
{
    public class TestTraking_Test
    {
        public static void CreateModuleDirectory()
        {
            if (!Directory.Exists("TP"))
                Directory.CreateDirectory("TP");
            if (!Directory.Exists("TP/TP1"))
                Directory.CreateDirectory("TP/TP1");
        }

        public static void DeleteModuleDirectory()
        {
            Directory.Delete("TP", true);
        }

    }
}
