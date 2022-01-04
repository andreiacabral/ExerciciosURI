// See https://aka.ms/new-console-template for more information

int N, X;


N = int.Parse(Console.ReadLine());

if (N < 10000)
{
    for (int i = 0; i < N; i++)
    {
        X = int.Parse(Console.ReadLine());
        if (X > Math.Pow(-10, 7) && X < Math.Pow(10, 7))
        {
            bool positive = X > 0;
            bool nullValue = X == 0;
            bool even = X % 2 == 0;

            if (nullValue)
            {
                Console.WriteLine("NULL");
            }
            else
            {
                if (even)
                {
                    Console.Write("EVEN ");
                }
                else 
                {
                    Console.Write("ODD ");
                }

                if (positive)
                {
                    Console.WriteLine("POSITIVE");

                }
                else
                {
                    Console.WriteLine("NEGATIVE ");
                }
              

            }
        }
    }

}