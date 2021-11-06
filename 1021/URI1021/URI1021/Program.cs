using System;

namespace URI1021
{
    class Program
    {
        static void Main(string[] args)
        {
            double NOTA100, NOTA50, NOTA20, NOTA10, NOTA5, NOTA2, MOEDA1, MOEDA050, MOEDA025, MOEDA10, MOEDA05, MOEDA01, N;

            N = double.Parse(Console.ReadLine());

            Console.WriteLine();

            if (0 < N && N < 1000000.00)
            {
            
                NOTA100 = (int)N / 100;
                N = N % 100;

                NOTA50 = (int)N / 50;
                N = N % 50;

                NOTA20 = (int)N / 20;
                N = N % 20;

                NOTA10 = (int)N / 10;
                N = N % 10;

                NOTA5 = (int)N / 5;
                N = N % 5;

                NOTA2 = (int)N / 2;
                N = N % 2;


                MOEDA1 = N / 1.00;
                N = N % 1.00;

                MOEDA050 = N / 0.50;
                N = N % 0.50;

                MOEDA025 = N / 0.25;
                N = N % 0.25;

                MOEDA10 = N / 0.10;
                N = N % 0.10;

                MOEDA05 = N / 0.05;
                N = N % 0.05;

                MOEDA01 = N / 0.01;
                N = N % 0.01;

                Console.WriteLine("NOTAS: ");
                Console.WriteLine(NOTA100.ToString("F0") + " nota(s) de R$ 100.00");
                Console.WriteLine(NOTA50.ToString("F0") + " nota(s) de R$ 50.00");
                Console.WriteLine(NOTA20.ToString("F0") + " nota(s) de R$ 20.00");
                Console.WriteLine(NOTA10.ToString("F0") + " nota(s) de R$ 10.00");
                Console.WriteLine(NOTA5.ToString("F0") + " nota(s) de R$ 5.00");
                Console.WriteLine(NOTA2.ToString("F0") + " nota(s) de R$ 2.00");

                Console.WriteLine("MOEDAS:");
                Console.WriteLine(MOEDA1.ToString("F0") + " moeda(s) de R$ 1.00");
                Console.WriteLine(MOEDA050.ToString("F0") + " moeda(s) de R$ 0.50");
                Console.WriteLine(MOEDA025.ToString("F0") + " moeda(s) de R$ 0.25");
                Console.WriteLine(MOEDA10.ToString("F0") + " moeda(s) de R$ 0.10");
                Console.WriteLine(MOEDA05.ToString("F0") + " moeda(s) de R$ 0.05");
                Console.WriteLine(MOEDA01.ToString("F0") + " moeda(s) de R$ 0.01");


            }
        }
    }
}
