// See https://aka.ms/new-console-template for more information
int N;
N = int.Parse(Console.ReadLine());

if (N < 10000)
{
    for (int i = 0; i <= 10000; i++)
    {
        if (i%N==2)
        {
            Console.WriteLine(i);
        }

    }

}

