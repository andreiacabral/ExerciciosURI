// See https://aka.ms/new-console-template for more information
int MaiorValor=0, posicao=0,valor;

for (int i = 0; i < 10; i++)
{
    valor=int.Parse(Console.ReadLine());

    if (valor>MaiorValor)
    {
        MaiorValor = valor;
        posicao = i;
    }
}
Console.WriteLine(MaiorValor);
Console.WriteLine(posicao);