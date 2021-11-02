using System;

namespace URI1013
{
    class Program
    {
        static void Main(string[] args)
        {
            int valorA, valorB, valorC;
            int resultado, MaiorAB;

            string[] vet = Console.ReadLine().Split(' ');

            valorA = int.Parse(vet[0]);
            valorB = int.Parse(vet[1]);
            valorC = int.Parse(vet[2]);

            MaiorAB = (valorA + valorB + Math.Abs(valorA - valorB)) / 2;
            resultado = (MaiorAB + valorC + Math.Abs(MaiorAB - valorC)) / 2;

            Console.WriteLine(resultado + " eh o maior");

        }
    }
}
