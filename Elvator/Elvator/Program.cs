using System;

namespace Elvator
{
    class Program
    {
        static void Main(string[] args)
        {
            int ElvaPerson;
            int Elvalimit=8;
            Console.WriteLine("Enter Value?");

            ElvaPerson = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You have entered = " + ElvaPerson);

            if (ElvaPerson <= Elvalimit)
            {
                Console.WriteLine("Sucess");
            }
            else
            {
                Console.WriteLine("Exceeded allowed number of people");
            }
            Console.ReadKey();
            
        }
    }
}
