
using LoggerClient.LoggerService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LoggerClient
{
    class Program
    {
       static LoggerServiceClient loggerproxy = new LoggerServiceClient();

        static void Main(string[] args)
        {
            Message message = new Message { UserName = "John", Level = SeverityLevel.Debug, TimeStamp = DateTime.Now, Content = "I read the news today, oh boy " };           
            loggerproxy.Log(message);
            Thread.Sleep(3000);
             message = new Message { UserName = "Paul", Level = SeverityLevel.Debug, TimeStamp = DateTime.Now, Content = "About a lucky man who made the grade " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
             message = new Message { UserName = "George", Level = SeverityLevel.Error, TimeStamp = DateTime.Now, Content = "And though the news was rather sad " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
             message = new Message { UserName = "ringo", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "Well I just had to laugh " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
             message = new Message { UserName = "John", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "I saw the photograph." };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "Paul", Level = SeverityLevel.Debug, TimeStamp = DateTime.Now, Content = "He blew his mind out in a car " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "George", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "He didn't notice that the red lights had changed " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "ringo", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "A crowd of people stood and stared " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "Paul", Level = SeverityLevel.Debug, TimeStamp = DateTime.Now, Content = "They'd seen his face before " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "George", Level = SeverityLevel.Critical, TimeStamp = DateTime.Now, Content = "Nobody was really sure " };//critical!!
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "ringo", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "If he was from the House of Lords" };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "John", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "I saw a film today, oh boy" };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "Paul", Level = SeverityLevel.Debug, TimeStamp = DateTime.Now, Content = "The English army had just won the war " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "George", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "A crowd of people turned away " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "ringo", Level = SeverityLevel.Info, TimeStamp = DateTime.Now, Content = "But I just had to look " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
            message = new Message { UserName = "ringo", Level = SeverityLevel.Critical, TimeStamp = DateTime.Now, Content = "Having read the book " };
            loggerproxy.Log(message);
            Thread.Sleep(3000);
        }
    }
}
