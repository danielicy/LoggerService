using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace LoggerService
{
   [ServiceContract]
    public interface ILoggerService
    {

        [OperationContract]
        void Log(Message value);       
        
    }
}
