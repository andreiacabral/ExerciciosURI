// See https://aka.ms/new-console-template for more information


int alcool=0, gasolina=0, disel=0, entrada=0;

while (entrada!=4)
{
    entrada = int.Parse(Console.ReadLine());

    if (entrada==1)
    {
        alcool++;
    }
    else if (entrada == 2)
    {
        gasolina++;
    }

    else if (entrada == 3)
    {
        disel++;
    }
}
Console.WriteLine("MUITO OBRIGADO");
Console.WriteLine("Alcool: "+alcool);
Console.WriteLine("Gasolina: "+gasolina);
Console.WriteLine("Disel: "+disel);