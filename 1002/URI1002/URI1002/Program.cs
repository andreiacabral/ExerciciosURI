using System;
using System.Globalization;

namespace URI1002
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declração de variavel
            double raio, area;
            
            //entrada 
            raio = double.Parse(Console.ReadLine());

            //processamento]
            area = Math.PI * Math.Pow(raio,2);

            //saida 
            Console.WriteLine( "A="+area.ToString("F4"));
        }
    }
}
