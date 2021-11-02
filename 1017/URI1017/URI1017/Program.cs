using System;

namespace URI1017
{
    class Program
    {
        static void Main(string[] args)
        {
            int tempoGasto, velocidade;
            double litrosQtd;

            tempoGasto = int.Parse(Console.ReadLine());
            velocidade = int.Parse(Console.ReadLine());

            litrosQtd = (tempoGasto * velocidade) / 12.00;

            Console.WriteLine(litrosQtd.ToString("F3" ));
        }

    }
}
