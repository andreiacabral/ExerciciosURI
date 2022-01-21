// See https://aka.ms/new-console-template for more information
int N;
int[] vet;
int media = 0, quantidade = 0;

N = int.Parse(Console.ReadLine());
vet = new int[N];

string[] s = Console.ReadLine().Split(new char[] { ' ' });

for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(s[i]);
}
for (int i = 0; i < N; i++)
{
    if (vet[i] % 2 == 0)
    {
        media += vet[i];
        quantidade++;
    }
}

media = media / quantidade;
Console.WriteLine(media.ToString("F1"));
