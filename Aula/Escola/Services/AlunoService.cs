using Escola.Models;
using System.ComponentModel.DataAnnotations;

namespace Escola.Services
{
    public class AlunoService
    {
        private List<Aluno> lista = new List<Aluno>
        {
            new Aluno { Nome = "João da Silva", Codigo = "0001", DataNascimento = new DateTime(2005, 5, 15), Email = "joao@email.com" },
            new Aluno { Nome = "Maria Oliveira", Codigo = "0002", DataNascimento = new DateTime(2006, 8, 22), Email = null },
            new Aluno { Nome = "Pedro Santos", Codigo = "0003", DataNascimento = new DateTime(2005, 12, 5), Email = "pedro@gmail.com" },
        };

        public List<Aluno> Consultar()
        {
            return lista.ToList(); // cópia da lista original
        }

        public bool Criar(Aluno aluno)
        {
            if (!Validar(aluno))
            {
                return false;
            }
            lista.Add(aluno);
            return true;
        }

        public bool Validar(Aluno aluno)
        {
            var context = new ValidationContext(aluno);
            var erros = new List<ValidationResult>();
            return Validator.TryValidateObject(aluno, context, erros);
        }

        public bool Excluir(string codigo)
        {
            var aluno = FindByCodigo(codigo);
            if (aluno == null)
            {
                return false;
            }
            return lista.Remove(aluno);
        }

        private Aluno? FindByCodigo(string codigo)
        {
            return lista.FirstOrDefault(a => a.Codigo == codigo);
        }
    }
}
