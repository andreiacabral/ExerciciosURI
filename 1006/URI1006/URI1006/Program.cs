using System;
using System.Globalization;

namespace URI1006
{
    class Program
    {
        static void Main(string[] args)
        {
           //declaração de variavel
           double A, B, C, MEDIA;

           //entrada
           A = double.Parse(Console.ReadLine());
           B = double.Parse(Console.ReadLine());
           C = double.Parse(Console.ReadLine());

           //processamento de variavel
           A = A * 2;
           B = B * 3;
           C = C * 5;
           MEDIA = (A + B + C) / 10;

           //saida 
           Console.WriteLine("MEDIA = "+ MEDIA.ToString("F1"),CultureInfo.InvariantCulture);
        }
    }
}
