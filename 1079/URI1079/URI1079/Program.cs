// See https://aka.ms/new-console-template for more information
int N;
double nota1=0.0,nota2=0.0,nota3=0.0;
string[] vet;

N=int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{
    vet = Console.ReadLine().Split(' ');

    nota1 = double.Parse(vet[0]);
    nota2 = double.Parse(vet[1]);
    nota3 = double.Parse(vet[2]);


    double md = (nota1 * 2 + nota2 * 3 + nota3 *5) / (2 + 3+5);

    Console.WriteLine(md.ToString("f1"));


}