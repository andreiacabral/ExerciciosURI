// See https://aka.ms/new-console-template for more information
int N;
double[] vet;
double maior=0;
int posicao=0;

N = int.Parse(Console.ReadLine());
vet = new double[N];

string[] s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(s[i]);
}
for(int i = 0; i < N; i++)
{
    if(vet[i] > maior)
    {
        maior = vet[i];
        posicao = i;
    }
}
Console.WriteLine(maior.ToString("F1")) ;
Console.WriteLine(posicao); 


