using System;

namespace URI1003
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variaveis
            int A, B, SOMA;   

            //entrada de variaveis
            A = int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            //processamento 
            SOMA = A + B;
            
            //saida
            Console.WriteLine("SOMA = " +SOMA);
        }
    }
}
