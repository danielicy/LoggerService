using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace LogServer.Service
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ILoggerService" in both code and config file together.
    [ServiceContract]
    public interface ILoggerService
    {
        [OperationContract]
        void Log(Message msg);
    }
}
