using System;

namespace URI1014
{
    class Program
    {
        static void Main(string[] args)
        {
            //declaração
            double conbustivelGasto,consumo;
            int distancia;

            //entrada
            distancia = int.Parse(Console.ReadLine());
            consumo = double.Parse(Console.ReadLine());
            
           
            //processamento
            conbustivelGasto = distancia / consumo;


            //saida
            Console.WriteLine(conbustivelGasto.ToString("F3")+ " km/l");
        }
    }
}
