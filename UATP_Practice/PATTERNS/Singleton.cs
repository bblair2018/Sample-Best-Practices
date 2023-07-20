using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace UATP_Practice.PATTERNS
{
    public class Logger
    {
        private static Logger instance;

        // ----------------------------------------------------------------------------------------------------------------------------------
        // In the Singleton pattern example, private static readonly object syncRoot = new object(); is a private static field that serves as 
        // the synchronization object or lock object.The purpose of syncRoot is to provide a mutually exclusive lock for thread synchronization
        // when creating the Singleton instance.It ensures that only one thread at a time can enter the critical section of code where the
        // instance is created, preventing multiple instances from being created concurrently.
        // ----------------------------------------------------------------------------------------------------------------------------------
        private static readonly object syncRoot = new object();

        // ------------------------------------------------------------------------------------
        // 
        // ------------------------------------------------------------------------------------
        private Logger()
        {
            // Private constructor to prevent instantiation from outside the class
        }

        // ------------------------------------------------------------------------------------
        // 
        // ------------------------------------------------------------------------------------

        /// <summary>
        /// The purpose of syncRoot is to provide a lock object that threads can acquire before entering the critical section of code where the instance creation occurs. 
        /// By using a lock statement, only one thread can enter the critical section at a time, preventing race conditions and ensuring thread safety.
        /// </summary>
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }

        public void Log(string message)
        {
            // Logic to log the message to a file, database, or external service
            Console.WriteLine($"Logging message: {message}");
        }
    }

    // ----------------------------------------------------------------------------------------------------------------------------------
    // The Singleton pattern ensures that a class has only one instance and provides a global point of access to that instance. 
    // ----------------------------------------------------------------------------------------------------------------------------------

}
