using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace classes_demo_cs
{
    class Program
    {
        // Class: 
        // A class is a blueprint for creating objects.
        // It defines properties and methods that the created objects will have.

        static void Main(string[] args)
        {
            try
            {
                Messages messages = new Messages();
                messages.DisplayMessage();
                messages.Waiting();
                messages.Goodbye();
            }
            catch (Exception Issue)
            {
                Console.WriteLine($"ERROR: {Issue.Message}");
            }
        }
    }

    class Messages
    {
        public void DisplayMessage()
        {
            Console.WriteLine("Hello, World!");
        }

        public void Waiting()
        { 
            Console.WriteLine("I am waiting for something.");
        }

        public void Goodbye()
        {
            Console.WriteLine("Goodbye, World!");
        }
    }
}
