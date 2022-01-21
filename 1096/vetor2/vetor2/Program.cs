// See https://aka.ms/new-console-template for more information

int N;
int[] vet;
int numerosPares=0;

N= int.Parse(Console.ReadLine());
vet= new int[N];

string[] s = Console.ReadLine().Split(' ');
for (int i=0; i<N; i++)
{
    vet[i] = int.Parse(s[i]);
}
for (int i=0; i < N; i++)
{
    if (vet[i]%2==0)
    {
        Console.Write(vet[i]);
        Console.Write(" ");
        numerosPares++; 
    }
}
Console.WriteLine(numerosPares);