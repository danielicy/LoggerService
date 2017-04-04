using Common;
using LogServer.Managers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LogServer.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "LoggerService" in both code and config file together.
    public class LoggerService : ILoggerService
    {
        private LoggerManager loggerManager;

        public void Log(Message msg)
        {
            LoggerManager.GetInstance().AddMessage(msg);
        }
    }
}
