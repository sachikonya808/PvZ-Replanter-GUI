using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PvZ_Replanter_GUI
{
    public class Logger
    {
        public static void LoggerMain(MainWindow mainWindow, string mLog)
        {
            mainWindow.LogMessage(mLog);
        }
    }
}
