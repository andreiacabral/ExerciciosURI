// See https://aka.ms/new-console-template for more information

int N, X, dentroIntervalo=0, foraIntervalo=0;

N = int.Parse(Console.ReadLine());

if (N < 10000)
{
    for (int i = 0; i < N; i++)
    {
        X = int.Parse(Console.ReadLine());
        if (X > Math.Pow(-10, 7) && X < Math.Pow(10, 7))
        {
            if (X >= 10 && X <= 20)
            {
                dentroIntervalo++;
            }
            else
            {
                foraIntervalo++;
            }
        }

    }
    Console.WriteLine(dentroIntervalo+" in"  );
    Console.WriteLine(foraIntervalo + " out");
}
