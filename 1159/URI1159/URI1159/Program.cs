// See https://aka.ms/new-console-template for more information
int X,resultado;
int ePar;

X=int.Parse(Console.ReadLine());

while (X!=0)
{
    ePar = X %2;

    if (ePar == 0)
    {
        resultado = X;

        for (int i = 0; i <= 3; i++)
        {
            X += 2;
            resultado += X;

        }

    } 
    else
    {
        resultado = ++X;

        for (int i = 0; i <= 3; i++)
        {
            X += 2;
            resultado += X;

        }

    }

    Console.WriteLine(resultado);
    X=int.Parse (Console.ReadLine());
}

