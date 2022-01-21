// See https://aka.ms/new-console-template for more information

// See https://aka.ms/new-console-template for more information


double[] alturas;
string[] sexo;
int N;
double menor = 100, maior = 0, media = 0;
int numHomens = 0, numMulher = 0;


N = int.Parse(Console.ReadLine());
alturas = new double[N];
sexo = new string[N];


for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');

    alturas[i] = double.Parse(s[0]);
    sexo[i] = s[1];
}

for (int i = 0; i < N; i++)
{
    if (alturas[i] < menor)
    {
        menor = alturas[i];

    }
    if (alturas[i] > maior)
    {
        maior = alturas[i];

    }
    if (sexo[i] == "F")
    {
        media += alturas[i];
        numMulher++;
    }
    else
    {
        numHomens++;
    }

}

Console.WriteLine("Menor altura = " + menor);
Console.WriteLine("Maior altura = " + maior);"F2
Console.WriteLine("Media das alturas das mulheres = " + (media / numMulher).ToString("F2"));
Console.WriteLine("Numero de homens = " + numHomens);
