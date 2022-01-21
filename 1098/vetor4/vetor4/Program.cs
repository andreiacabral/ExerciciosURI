// See https://aka.ms/new-console-template for more information

int N;
double[] vet;
double media = 0, soma;

N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(s[i]);

}
for (int i = 0; i < N; i++)
{
    media += vet[i];

}

media = media / N;

Console.WriteLine(media);

for (int i = 0; i < N; i++)
{
    if (vet[i]<media)
    {
        Console.WriteLine(vet[i]);
    }
}

