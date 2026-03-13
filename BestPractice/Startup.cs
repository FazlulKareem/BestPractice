using System;
using System.Collections.Generic;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BestPractice
{
    public class Startup
    {
        public delegate void Notify();
        class Process //Process class that raises an event
        {
            public event Notify ProcessCompleted;

            public void StartProcess()
            {
                Console.WriteLine("Process Started for fetch");

                // Raise event
                ProcessCompleted?.Invoke();
            }
            
        }
        public static class Logger
        {
            public static void Log(string message)
            {
                Console.WriteLine($"Log: {message}");
            }
        }
        public static class DataAccess
        {
            // Static constructor to initialize the DataAccess class
            static DataAccess()
            {
                Logger.Log("Data Access Layer Initialized for Git Hub for Pull purpose ");
            }

            public static void GetData()
            {
                Logger.Log("Fetching data from the database...");
                // Simulate data fetching
                System.Threading.Thread.Sleep(1000);
                Logger.Log("Data fetched successfully.");
            }
        }

        private static int add(int a, int b)
        {
            return a + b;
        }
        private static int mul(int a, int b) {
            return a * b;
        }

        private delegate int Operating(int a, int b);

        static void Main(string[] args)
        {
            Operating addoperating = add;
            Operating muloperating = mul;
            Console.WriteLine("Addition: " + addoperating(30, 5));
            Console.WriteLine("Multiplication: " + muloperating(35, 5));

            Operating opradd = new Operating(add);
            Operating oprmul = new Operating(mul);
            Console.WriteLine("Addition: " + opradd(18, 20));
            Console.WriteLine("Multiplication: " + oprmul(10, 10));



            DataAccess.GetData();
        }


            //    static void OnProcessCompleted()
            //    {
            //        Console.WriteLine("Process Completed!");
            //    }
            //    Process p = new Process();
            //    p.ProcessCompleted += OnProcessCompleted;
            //    p.StartProcess();

            //    Logger.Log("This is a log message.");
            //    ILogger.Instance.testlog();
            //    ILogger.Instance.Logs("This is another log message.");

            //}



        }

}
