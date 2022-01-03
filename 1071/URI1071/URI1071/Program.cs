// See https://aka.ms/new-console-template for more information

int x, y, menor=0, maior=0, resultado = 1,numeroImpar,numeroAtual,cont=0;

x = int.Parse(Console.ReadLine());
y = int.Parse(Console.ReadLine());


if (x > y )
{
    maior = x;
    menor = y;

}
else if (y > x)
{
    maior = y;
    menor = x;
}

else if (x == y)
{
    resultado = 0;
}

if (resultado != 0)
{

    numeroAtual = ++menor;
    cont = numeroAtual;
    resultado = 0;
    do
    {
     numeroImpar = numeroAtual %2;
        if (numeroImpar!=0)
        {
            resultado += numeroAtual;
        }
        numeroAtual++;
        cont++;

    } while (cont<maior);
}
Console.WriteLine(resultado);
