// See https://aka.ms/new-console-template for more information
using System.Globalization;
double idade = 0, soma = 0, cont = 0;
double media=0;

idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);



while (idade >=0)
{
    soma = soma + idade;
    cont = cont + 1;
    idade = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
}
media = soma / cont;
Console.WriteLine(media.ToString("F2", CultureInfo.InvariantCulture));
Console.WriteLine();