// See https://aka.ms/new-console-template for more information


string[] nomes;
double[] nota1;
double[] nota2;
int N;


N = int.Parse(Console.ReadLine());
nomes = new string[N];
nota1 = new double[N];
nota2 = new double[N];

for (int i = 0; i < N; i++)
{
   string[] s = Console.ReadLine().Split(' ');

    nomes[i] = s[0];
    nota1[i] =double.Parse(s[1]);
    nota2[i] =double.Parse(s[2]);
}
Console.WriteLine("Alunos aprovados:");
for (int i = 0; i < N; i++)
{
    if ((nota1[i]+nota2[i])/2>=6)
    {
        Console.WriteLine(nomes[i]);
    }
}
