// See https://aka.ms/new-console-template for more information

using ClasseComAtributos2;

Funcionario funcionario1, funcionario2;

funcionario1 = new Funcionario();
funcionario2 = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");
Console.WriteLine("nome: ");
funcionario1.Nome=Console.ReadLine();
Console.WriteLine("salario: ");
funcionario1.Salario=double.Parse(Console.ReadLine());

Console.WriteLine("Dados do primeiro funcionário:");
Console.WriteLine("nome: ");
funcionario2.Nome = Console.ReadLine();
Console.WriteLine("salario: ");
funcionario2.Salario = double.Parse(Console.ReadLine());

double media = (funcionario1.Salario + funcionario2.Salario) / 2.0;

Console.WriteLine("Salario medio = "+ media.ToString());