using Aula.Models;

Console.WriteLine("Digite o nome: ");
var nome = Console.ReadLine();

Console.WriteLine("Digite o e-mail: ");
var email = Console.ReadLine();

Console.WriteLine("Digite o código: ");
var codigo = Console.ReadLine();

Console.WriteLine("Digite a data de nascimento: ");
var data = DateTime.Parse(Console.ReadLine());

var aluno = new Aluno();

// $aluno->setNome($nome);
aluno.Nome = nome;
aluno.Email = email;
aluno.Codigo = codigo;
aluno.DataNascimento = data;

aluno.PrintDados();

var aluno2 = new Bolsista {
    Nome = "Aluno Bolsista",
    Email = "alahuakbar@gmail.com",
    DataNascimento = DateTime.Today.AddYears(-20),
    Codigo = "6969",
    PorcentagemDesconto = 50
};

aluno2.PrintDados();