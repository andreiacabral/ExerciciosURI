// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

int N;
int[,] mat;


string[] s = Console.ReadLine().Split(' ');
N = int.Parse(s[0]);
mat = new int[N, N];

for (int i = 0; i < N; i++)
{
    s = Console.ReadLine().Split(' ');
    for (int j = 0; j < N; j++)
    {
        mat[i, j] = int.Parse(s[j]);
    }
}
int[] vet = new int[N];

for (int i = 0; i < N; i++)
{
    int soma=0;
    for (int j = 0; j < N; j++)
    {
     soma += mat[i,j];
      
    }
    Console.WriteLine(soma);
}