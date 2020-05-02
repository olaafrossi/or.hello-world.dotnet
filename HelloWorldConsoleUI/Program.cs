using System;
using HelloWorldLibrary;

namespace HelloWorldConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            NewUp();
            SendStatic();
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
