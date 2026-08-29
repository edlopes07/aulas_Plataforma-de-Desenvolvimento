//using Aula.Models;
//using Aula.Services;

//Console.WriteLine("Digite o nome: ");
//var nome = Console.ReadLine();

//Console.WriteLine("Digite o e-mail: ");
//var email = Console.ReadLine();

//Console.WriteLine("Digite o código: ");
//var codigo = Console.ReadLine();

//Console.WriteLine("Digite a data de nascimento: ");
//var data = DateTime.Parse(Console.ReadLine());

//var aluno = new Aluno();

//// $aluno->setNome($nome);
//aluno.Nome = nome;
//aluno.Email = email;
//aluno.Codigo = codigo;
//aluno.DataNascimento = data;

//aluno.PrintDados();

//var aluno2 = new Bolsista {
//    Nome = "Aluno Bolsista",
//    Email = "alahuakbar@gmail.com",
//    DataNascimento = DateTime.Today.AddYears(-20),
//    Codigo = "6969",
//    PorcentagemDesconto = 50
//};

//aluno2.PrintDados();

using Aula.Services;
using Aula.Models;

var service = new AlunoService();

while (true)
{
    Console.WriteLine("1 - Consultar alunos");
    Console.WriteLine("2 - Criar alunos");
    Console.Write("Digite a opção: ");

    var opcao = int.Parse(Console.ReadLine());

    if (opcao == 1)
    {
        var alunos = service.Consultar();
        Console.WriteLine("=============================");
        foreach (var aluno in alunos)
        {
            aluno.PrintDados();
            Console.WriteLine("=============================");
        }
    }
    else if (opcao == 2)
    {
        Console.WriteLine("Digite o nome: ");
        var nome = Console.ReadLine();

        Console.WriteLine("Digite o e-mail: ");
        var email = Console.ReadLine();

        Console.WriteLine("Digite o código: ");
        var codigo = Console.ReadLine();

        Console.WriteLine("Digite a data de nascimento: ");
        var data = DateTime.Parse(Console.ReadLine());

        var aluno = new Aluno();

        aluno.Nome = nome;
        aluno.Email = email;
        aluno.Codigo = codigo;
        aluno.DataNascimento = data;
        var sucesso = service.Criar(aluno);
        if (sucesso)
        {
            Console.WriteLine("Aluno cadastrado com sucesso!");
        }
        else
        {
            Console.WriteLine("Falha na criação do aluno!");
        }
    }
}
