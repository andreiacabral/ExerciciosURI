// See https://aka.ms/new-console-template for more information8*-69+9+


int N;

N=int.Parse(Console.ReadLine());

if (5<N &&N<2000)
{
   for(int i = 1; i <= N; i++)
    {
        if (i%2==0)
        {
            
            Console.WriteLine(i+"^2  = "+Math.Pow(i,2));

        }
    }

}