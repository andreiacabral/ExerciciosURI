using System;

namespace URI1008
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECRARAÇÃO
            int id, numHoras;
            double valorHora, salario;
            //ENTRADA
            id = int.Parse(Console.ReadLine());
            numHoras = int.Parse(Console.ReadLine());
            valorHora = double.Parse(Console.ReadLine());
            //PROCESAMENTO
            salario = numHoras * valorHora;
            //SAIDA
            Console.WriteLine("NUMBER = "+ id);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2"));
        }
    }
}
