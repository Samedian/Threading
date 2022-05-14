using System;
using System.Diagnostics;

namespace ProcessThread
{
    class Program
    {
        static void SearchGoogle(string t)
        {
            Process.Start("http://google.com/search?q=" + t);
        }
        static void Main(string[] args)
        {
            Process notepad = new Process();
            notepad.StartInfo.FileName = "notepad.exe";
            notepad.StartInfo.Arguments = "ProcessExample.txt";
            notepad.Start();
            Console.Read();

        }
    }
}
