// See https://aka.ms/new-console-template for more information


int x, y;

string[] vet = Console.ReadLine().Split(' ');
x = int.Parse(vet[0]);
y = int.Parse(vet[1]);

while (x!=0 && y!=0)
{

    if (x>0 && y>0)
    {
        Console.WriteLine("primeiro");
    }
    if (x>0 && y<0)
    {
        Console.WriteLine("quarto");
    }
    if (x<0 &&  y<0)
    {
        Console.WriteLine("terceiro");
    }
    if (x<0 && y>0)
    {
        Console.WriteLine("segundo");
    }


    vet = Console.ReadLine().Split(' ');
    x = int.Parse(vet[0]);
    y = int.Parse(vet[1]);
}


