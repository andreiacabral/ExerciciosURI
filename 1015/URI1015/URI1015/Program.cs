using System;

namespace URI1015
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] vet1, vet2;
            double x1, y1,x2,y2, resultado;

            vet1 = Console.ReadLine().Split(' ');
            vet2 = Console.ReadLine().Split(' ');

            x1 =double.Parse(vet1[0]);
            y1 = double.Parse(vet1[1]);
            x2 = double.Parse(vet2[0]);
            y2 = double.Parse(vet2[1]);

            resultado = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine(resultado.ToString("F4"));
        }
    }
}
