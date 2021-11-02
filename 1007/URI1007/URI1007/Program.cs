using System;

namespace URI1007
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            int A, B, C, D, DIFERENCA;
            // entrada
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());
            C = int.Parse(Console.ReadLine());
            D = int.Parse(Console.ReadLine());
            
            // processamento
            DIFERENCA = (A * B - C * D);
            
            // saida
            Console.WriteLine("DIFERENCA = " +DIFERENCA);

        }
    }
}
