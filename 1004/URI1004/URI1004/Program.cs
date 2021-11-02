using System;

namespace URI1004
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            int A, B,PROD;
            
            //entrada
            A= int.Parse(Console.ReadLine());
            B = int.Parse(Console.ReadLine());

            // processamento
            PROD = A * B;

            //saida
            Console.WriteLine("PROD = " + PROD);
        }
    }
}
