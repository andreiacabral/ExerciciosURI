// See https://aka.ms/new-console-template for more information


double nota=0, nota2=0,contadorErros=0,contadorNota=1,entrada,media=0;



while (contadorNota < 3)
{
    entrada = double.Parse(Console.ReadLine());


    if (entrada >= 0 && entrada <= 10)
    {
        if (contadorNota==1)
        {
            nota = entrada;
            contadorNota++;
        }
        else if (contadorNota==2)
        {
            nota2 = entrada;
            contadorNota++;
        }
        media = (nota + nota2) / 2;

    }
    else
    {
        contadorErros++;
        Console.WriteLine("nota invalida");
    }
}
Console.WriteLine("media = "+media);

