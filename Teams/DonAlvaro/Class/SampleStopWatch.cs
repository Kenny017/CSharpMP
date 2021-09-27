using System;
using System.Threading;

namespace SampleStopWatch
{
    /**
    Design a class called StopWatch. The job of this class is to simulate a stopwatch. 
    It should provide two methods: Start and Stop. We call the start method first, and the stop method
    next. Then we ask the stopwatch about the duration between start and stop. Duration
    should be a value in TimeSpan. Display the duration on the console.
    We should be able to use a stopwatch multiple times. So we may start and stop it and then
    start and stop it again. Make sure the duration value each time is calculated properly.

    We should not be able to start a stopwatch twice in a row(because that may overwrite the initial
    start time). So the class should throw an InvalidOperationException if its started twice.

    The aim of this exercise is to make you understand that a class should be always in a valid
    state. We use encapsulation and information hiding to achieve that. The class should not reveal
    its implementation detail. It only reveals a little bit, like a blackbox. From the outside, you 
    shouldn't not be able to misuse a class because you shouldn't be able to see the implementation detail

    **/

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
