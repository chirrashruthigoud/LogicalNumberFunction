﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalFunction
{
    public class StopWatch
    {
        public static void StopWatchProgram()
        {
            Console.WriteLine("Press Enter the Stop Watch Time : ");
            int second = Convert.ToInt32(Console.ReadLine());

            Stopwatch stopwatch = new Stopwatch();
            Console.WriteLine("Stop Watch is Started ");
            stopwatch.Start();

            // ... This takes 10 seconds to finish.
            for (int i = 0; i < second; i++)
            {
                System.Threading.Thread.Sleep(100);
            }

            // Stop.
            stopwatch.Stop();

            // Write hours, minutes and seconds.
            Console.WriteLine("Time elapsed: {0:hh\\:mm\\:ss}", stopwatch.Elapsed);
        }
    }
}
