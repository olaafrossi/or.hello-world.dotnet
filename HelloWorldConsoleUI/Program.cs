using System;
using HelloWorldLibrary;
using System.Diagnostics;

namespace HelloWorldConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch.StartNew();
            NewUp();
            Console.WriteLine(Stopwatch.GetTimestamp());
            // breakup the methods

            Stopwatch.StartNew();
            SendStatic();
            Console.WriteLine(Stopwatch.GetTimestamp());
        }

        static void NewUp()
        {
            Messages myMessages = new Messages();
            myMessages.SendMessage("Hello, Nice to see you");
        }

        static void SendStatic()
        {
            StaticMessages.SendStaticMessage("Hello, Nice to see you");
        }
    }
}
