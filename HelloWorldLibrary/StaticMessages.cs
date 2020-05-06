using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorldLibrary
{
    public static class StaticMessages
    {
        public static void SendStaticMessage(string msg)
        {
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i.ToString());
            }

            Console.WriteLine($"{msg} {DateTime.Now} Hello from the library!");
        }
    }
}

