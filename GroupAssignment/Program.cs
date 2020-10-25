using System;

namespace GroupAssignment
{



    class Program
    {
        private static Adressbook Adressbook = new GroupAssignment.Adressbook();
        static void Main(string[] args)
        {
            bool programIsRunning = true;
            while (programIsRunning)
            {
                Adressbook.UserChoice();

            }
            Console.ReadLine();
        }
    }
}
