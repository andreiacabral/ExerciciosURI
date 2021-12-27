// See https://aka.ms/new-console-template for more information
using System.Globalization;

int repeteCalculo = 1;
double nota1 = 0, nota2 = 0, media;
bool nota1Invalida = true, nota2Invalida = true, repeteInvalido = true;

while (repeteCalculo == 1)
{
    while (nota1Invalida)
    {
        nota1 = double.Parse(Console.ReadLine());

        if (nota1 <= 10 && nota1 >= 0)
        {
            nota1Invalida = false;
        }
        else
        {
            Console.WriteLine("nota invalida");
        }
    }

    while (nota2Invalida)
    {
        nota2 = double.Parse(Console.ReadLine());

        if (nota2 <= 10 && nota2 >= 0)
        {
            nota2Invalida = false;
        }
        else
        {
            Console.WriteLine("nota invalida");
        }
    }

    media = (nota1 + nota2) / 2;

    Console.WriteLine("media = " + media.ToString("F2", CultureInfo.InvariantCulture));
    while (repeteInvalido)
    {
        Console.WriteLine("novo calculo (1-sim 2-nao)");
        repeteCalculo = int.Parse(Console.ReadLine());

        if (repeteCalculo == 1 || repeteCalculo == 2)
        {
            repeteInvalido = false;
        }

    }

    nota1Invalida = true;
    nota2Invalida = true;
    repeteInvalido = true;
}

