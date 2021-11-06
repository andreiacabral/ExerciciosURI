using System;

namespace URI1020
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias,qtdeAnos,qtdMeses,qtdDias;

            dias = int.Parse(Console.ReadLine());

            qtdeAnos = dias / 365;
            dias = dias % 365;

            qtdMeses = dias / 30;
            dias = dias % 30;

            qtdDias = dias / 1;

            Console.WriteLine(qtdeAnos+ " ano(s)");
            Console.WriteLine(qtdMeses + " mes(es)");
            Console.WriteLine(qtdDias + " dia(s)");

        }
    }
}
