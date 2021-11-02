using System;

namespace URI1012
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C;
            string[] entrada;
            double triangulo, circulo, trapezio, quadrado, retangulo;


            entrada = Console.ReadLine().Split( ' ');

            A = double.Parse(entrada[0]);
            B = double.Parse(entrada[1]);
            C = double.Parse(entrada[2]);

            triangulo = (A * C) / 2;
            circulo = 3.14159 * Math.Pow(C, 2);
            trapezio = ((A + B) * C) / 2;
            quadrado = Math.Pow(B, 2);
            retangulo = (A * B);

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3"));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3"));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3"));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3"));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3"));

        }
    }
}
