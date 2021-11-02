using System;

namespace URI1011
{
    class Program
    {
        static void Main(string[] args)
        {
            double raio,volume,pi=3.14159;

            raio = double.Parse(Console.ReadLine());

            volume = (4 / 3.00) * pi * Math.Pow(raio, 3);

            Console.WriteLine("VOLUME = "+ volume.ToString("F3"));
        }
    }
}
