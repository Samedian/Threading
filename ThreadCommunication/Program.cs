using System;
using System.Collections.Generic;
using System.Threading;

namespace ThreadCommunication
{
    class Program
    {
        static object locker = new object();
        static Queue<int> numbers = new Queue<int>();
        static int[] vec = { 7, 8, 1, 12, 35, 80, 2, 1, 90, 98, 12, 14, 2, 3, 3 };
        static void Main(string[] args)
        {
            new Thread(Write).Start();
            new Thread(Read).Start();
        }

        public static void Read()
        {
            while(true)
            {
                lock(locker)
                {
                    while(numbers.Count==0)
                    {
                        Monitor.Wait(locker);
                    }
                    Console.WriteLine(numbers.Dequeue());
                }
                Thread.Sleep(2000);
            }
        }

        public static void Write()
        {
            for (int i = 0; i < vec.Length; i++)
            {
                lock(locker)
                {
                    numbers.Enqueue(vec[i]);
                    Monitor.Pulse(locker);
                }
                Thread.Sleep(3000);
            }
        }
    }
}
