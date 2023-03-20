using NLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NloggerDemo
{
    public class Nlogger_Start
    {
        public Logger logging= LogManager.GetCurrentClassLogger();  // need to create this class for nlogger to call the methods and save the data in .txt file

        public void LogDebug(string message)
        {
            logging.Debug(message);
        }

        public void LogInfo(string message) 
        {
            logging.Info(message);
        }

        public void LogWarn(string message) 
        {
            logging.Warn(message);
        }

        public void LogError(string message) 
        {
            logging.Error(message);
        }
    }
}
