using ClasseComAtributos1;


Pessoa pessoa = new Pessoa(),pessoa2 = new Pessoa();


Console.WriteLine("Dados da primeira pessoa:");
Console.Write("Nome: ");
pessoa.Nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine("Dados da segunda pessoa:");
Console.Write("Nome: ");
pessoa2.Nome = Console.ReadLine();
Console.Write("Idade: ");
pessoa2.Idade = int.Parse(Console.ReadLine());

if (pessoa.Idade > pessoa2.Idade)
{
    Console.WriteLine("Pessoa mais velha: " );
    Console.WriteLine(pessoa.Nome);
}
else
{
    Console.WriteLine("Pessoa mais velha: ");
    Console.WriteLine(pessoa2.Nome);
}


