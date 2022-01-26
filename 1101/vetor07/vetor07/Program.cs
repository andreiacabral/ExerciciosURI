// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
// See https://aka.ms/new-console-template for more information


int[] A;
int[] B;
int[] C;
int N;

N = int.Parse(Console.ReadLine());
A = new int[N];
B = new int[N];
C = new int[N];

string[] s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(s[i]);
}
s = Console.ReadLine().Split(' ');
for (int i = 0; i < N; i++)
{
    B[i] = int.Parse(s[i]);
}

for (int i = 0; i < N; i++)
{
    C[i] = B[i] + A[i];

}
for (int i = 0; i < N; i++)
{
    Console.Write(C[i] + " ");
}