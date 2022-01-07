// See https://aka.ms/new-console-template for more information

int N, quantia = 0, s = 0, r = 0, c = 0, total = 0;
string[] entrada;


N = int.Parse(Console.ReadLine());

for (int i = 0; i < N; i++)
{

    entrada = Console.ReadLine().Split(' ');
    quantia = int.Parse(entrada[0]);

    if ( quantia >= 1 && quantia <= 15)
    {
        if (entrada[1] == "C")
        {
            total += quantia;
            c += quantia;
        }
        else if (entrada[1] == "R")
        {
            total += quantia;
            r += quantia;

        }
        else
        {
            total += quantia;
            s += quantia;
        }
    }
}
    Console.WriteLine("Total: " + total + " cobaias");
    Console.WriteLine("Total de coelhos: " + c);
    Console.WriteLine("Total de ratos: " + r);
    Console.WriteLine("Total de sapos: " + s);
    Console.WriteLine("Percentual de coelhos: "+(((double)c/ total) * 100).ToString("F2")+ " %");
    Console.WriteLine("Percentual de ratos: " + (((double)r / total) * 100).ToString("F2") + " %");
    Console.WriteLine("Percentual de sapos: " + (((double)s / total) * 100).ToString("F2") + " %");