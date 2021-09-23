using System;
using System.Threading;

namespace SampleStopWatch
{
    class Program
    {
        static void main(string[] args)
        {
            NewStopWatch stopwatch = new NewStopWatch();

            stopwatch.Start();
            //stopwatch.Start(); //Simulate InvalidOperationException
            Thread.Sleep(4000);
            stopwatch.Stop();

            TimeSpan ts = stopwatch.Elapsed;
            
            Console.WriteLine($"Total Number of Seconds: {ts.Seconds}");

            stopwatch.Start();
            Thread.Sleep(6000);
            stopwatch.Stop();

             ts = stopwatch.Elapsed;

            Console.WriteLine($"Total Number of Seconds: {ts.Seconds}");
        }
    }

    class NewStopWatch
    {
        private DateTime start = new DateTime();
        public TimeSpan Elapsed = TimeSpan.Zero;
        private bool checkStartIfInitiated = false;

        public void Start()
        {
            if (checkStartIfInitiated == false)
            {
                start = DateTime.Now;
                Elapsed = TimeSpan.Zero;
                checkStartIfInitiated = true;
            }
            else
            {
                throw new InvalidOperationException("Previous call to Start() is iniatiated before.");
            }
        }

        public TimeSpan Stop()
        {
            if (checkStartIfInitiated)
            {
                Elapsed = DateTime.Now - start;
                checkStartIfInitiated = false;

                return Elapsed;
            }
            else
            {
                //Console.WriteLine("Start() is not iniatiated.");
                return TimeSpan.Zero;
                
            }

        }
    }
}
