using System;

namespace URI1010
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLARAÇÃO DE VARIAVEL
            string[] peca1,peca2;
            double TOTAL;
            //INICIO
            peca1 = Console.ReadLine().Split(' ');
            peca2 = Console.ReadLine().Split(' ');
            
            //PREOCESSAMENTO
            TOTAL = (int.Parse(peca1[1]) * double.Parse(peca1[2])+(int.Parse(peca2[1])*double.Parse(peca2[2])));
            //SAIDA
            Console.WriteLine("VALOR A PAGAR: R$ " + TOTAL.ToString("F2"));
        }
    }
}
