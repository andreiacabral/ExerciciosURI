using System;

namespace URI1005
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração de variavel
            double A, B,MEDIA;
            
            //entrada de variavel
            A = double.Parse(Console.ReadLine());
            B = double.Parse(Console.ReadLine());



            //processamento
            A = A * 3.5;
            B = B * 7.5;

            MEDIA = (A + B) / 11;

            //saida
            Console.WriteLine("MEDIA = " +MEDIA.ToString("F5"));
        }
    }
}
