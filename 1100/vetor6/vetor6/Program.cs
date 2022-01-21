// See https://aka.ms/new-console-template for more information
int N, posicao = 0, idade = 0;
int[] idades;
string[] nome;

N = int.Parse(Console.ReadLine());

idades = new int[N];
nome = new string[N];

string[] s;
for (int i = 0; i < N; i++)
{
    s = Console.ReadLine().Split(' ');
    nome[i] = s[0];
    idades[i] = int.Parse(s[1]);


}

for (int i = 0; i < N; i++)
{
    if (idades[i] > idade)
    {
        idade = idades[i];
        posicao = i;

    }

}
Console.WriteLine("Pessoa mais velha: " + nome[posicao]);
