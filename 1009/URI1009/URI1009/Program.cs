using System;
using System.Globalization;

namespace URI1009
{
    class Program
    {
        static void Main(string[] args)
        {
            //DECLRAÇAO DE VARIAVEL
            string nome;
            double salario, comissao;

            //ENTRADA
            nome = Console.ReadLine();
            salario = double.Parse(Console.ReadLine());
            comissao = double.Parse(Console.ReadLine());

            //PROCESSAMENTO
            salario = salario + (comissao * 0.15);

            //SAIDA
            Console.WriteLine("TOTAL = R$ " + salario.ToString("F2"));
        }
    }
}
