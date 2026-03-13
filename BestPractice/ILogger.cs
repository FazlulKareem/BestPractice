using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPractice
{
    public class ILogger
    {
        private static ILogger _instance;

        public static ILogger GetInstance()
        {
            if (_instance == null)
            {
                _instance = new ILogger();
            }
            return _instance;
        }
        static string logMessage()
        {
          return "This is a log message.";
        }
        static ILogger testt
        {
            get; set;
        }
        private ILogger()
        {
            // Private constructor to prevent instantiation
        }

        public static ILogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ILogger();
                }
                return _instance;
            }
        }

        public void Logs(string message)
        {
            Console.WriteLine($"Log: {message}");
        }

        public void testlog()
        {
            Console.WriteLine("This is a test log message.");
        }
   
         static void logMessage(string message)
        {
            ILogger.GetInstance().Logs(message);
        }


        //static void Main(string[] args)
        //{
        //    ILogger logger = ILogger.GetInstance();
        //    logger.Logs("This is a log message.");
        //    logger.testlog();
        //    ILogger.testt = ILogger.GetInstance();
        //     ILogger.testt.Logs("This is a log message from testt.");
        //     ILogger.testt.testlog();
        //    ILogger.logMessage();
        //    logger.Logs(ILogger.logMessage());

        //}
    }
}
