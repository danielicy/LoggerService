using Common;
using LogServer.Service;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace LogServer
{
    class Program
    {
        static void Main(string[] args)
        {
           

            ServiceHost host = new ServiceHost(typeof(LoggerService));
            host.Open();
            Console.WriteLine("LoggerService is UP and listening at: " + host.Description.Endpoints[0].Address.ToString());
            do
            {
                
            }
            while (true);
            
        }
    }
}
