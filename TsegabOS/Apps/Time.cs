using System;
using Cosmos.System.Audio;
using System.Threading;

namespace TsegabOS.Apps
{
    public class Time
    {
        public static void Time1()
        {
            Console.WriteLine("Enter the duration of the timer in seconds:");
            int seconds = int.Parse(Console.ReadLine());

            for(int i = seconds; i >= 0; i--)
            {
                Console.WriteLine(i);
                Thread.Sleep(1000);
                if(i == 0)
                {
                    Console.WriteLine("Time's up!");
                    Console.Beep();
                    Console.Beep();
                }
            }
        }
    }
}
