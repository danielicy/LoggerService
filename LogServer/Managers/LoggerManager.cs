using Common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace LogServer.Managers
{
    public class LoggerManager
    {
        private  static List<Message> _messageContainer = new List<Message>();
        private static LoggerManager singleton = null;
        private static readonly object singletonLock = new object();
        private Timer _timer;

        /// <summary>
        /// Returns a singleton <see cref="LoggerManager">LoggerManager</see>
        /// </summary>
        /// <returns>a singleton <see cref="LoggerManager">LoggerManager</see></returns>
        public static LoggerManager GetInstance()
        {
            //critical section, which ensures the singleton
            //is thread safe
            lock (singletonLock)
            {
                if (singleton == null)
                {
                    singleton = new LoggerManager();
                }
                return singleton;
            }
        }

        /// <summary>
        /// ctor
        /// </summary>
        public LoggerManager()
        {
            SetUpTimer();           
        }

        private void SetUpTimer()
        {
            _timer = new Timer();
            _timer.Elapsed += _timer_Elapsed;
            _timer.Interval = Convert.ToDouble(ConfigurationManager.AppSettings["loggerInterval"]);
            _timer.Start();
        }

        /// <summary>
        /// writes message to file every X seconds
        /// X is defined in app.config 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void _timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            ProcessMesagges();
        }

        /// <summary>
        /// adds message to message list
        /// if message is critical it gets written to file immediatly
        /// </summary>
        /// <param name="msg"></param>
        public void AddMessage(Message msg)
        {
            try
            {
                _messageContainer.Add(msg);
                Console.WriteLine(string.Format("{0} - {1} :Message: {2}, Severity: {3}", msg.TimeStamp, msg.UserName, msg.Content, msg.Level));

                if (msg.Level == SeverityLevel.Critical)
                    ProcessMesagges();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Failed adding new message to list");
            }
              
        }

        /// <summary>
        /// writes message list to file
        /// </summary>
        private void ProcessMesagges()
        {
            string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "LogFile.log");

            using (System.IO.StreamWriter file =  new System.IO.StreamWriter(path,true))
            {
                foreach (Message msg in _messageContainer.OrderBy(t => t.Level).OrderBy(t => t.Level))
                {

                    file.WriteLine(string.Format("{0} - {1} :Message: {2}, Severity: {3}", msg.TimeStamp, msg.UserName, msg.Content, msg.Level)) ;
                    
                }

                //notifies console on messages written to log
                if(_messageContainer.Count > 0)
                Console.WriteLine(string.Format("Wrote messages to file"));
            }
            _messageContainer.Clear();
        }
    }
}
