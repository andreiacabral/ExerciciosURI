int x=0,impar=1;

x = int.Parse(Console.ReadLine());

if (x>=1 && x<= 1000)
{
    do
    {
        Console.WriteLine(impar);
        impar +=2;

    } while (impar<=x);
}
