using System;

namespace MyFirstProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            int latime = 2;
            int lungime = 3;

            Console.WriteLine("Acest program va calcula aria unei camere");

            Console.WriteLine("Introduceti latimea: ");
            latime = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Introduceti lungimea: ");
            lungime = int.Parse(Console.ReadLine()); 

            int ariaCamerei = latime * lungime;

            Console.WriteLine("Aria dreptunghiului este" + ariaCamerei);
        }
    }
}