using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldLibrary
{
    public class Messages
    {
        public void SendMessage(string msg)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }

            Console.WriteLine($"{msg} {DateTime.Now} Hello from the library!");
        }
    }
}
