using System;
using System.Threading;
using System.Collections.Generic;

namespace ThreadEx
{
    class Program
    {
        [Obsolete]
        static void Main(string[] args)
        {
            //Thread thread = Thread.CurrentThread;
            //Console.WriteLine(thread);          //main thread

            Program obj = new Program();

            Thread thread1 = new Thread(new ThreadStart(obj.Print1));
            Thread thread2 = new Thread(new ThreadStart(obj.Print2));


            Console.WriteLine("Thread(1)State: "+ thread1.ThreadState);
            Console.WriteLine("Thread(2)State: "+ thread2.ThreadState);


            // Running state 
            thread1.Start();
            thread2.Start();


            Console.WriteLine("Thread(1)State: " + thread1.ThreadState);
            Console.WriteLine("Thread(2)State: " + thread2.ThreadState);

        }
        public void Print1()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Inside Function Print 1");

                if (i == 5)
                    Thread.Sleep(6000);

            }
        }

        public void Print2()
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Inside Function Print 2");
                if(i==2)
                   Thread.Sleep(6000);

            }
        }
    }
}
