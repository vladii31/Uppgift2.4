using System;

namespace uppgift_2._4
{
    class Program
    {
        static void Main(string[] args)
        {

            double x = double.Parse(Console.ReadLine());
            double z = double.Parse(Console.ReadLine());
            double a = double.Parse(Console.ReadLine());
            double b = x + z + a;
            double l = b / 3;
            Console.WriteLine("medellönet blir " + l + "kr");
            Console.ReadKey();


        }
    }
}