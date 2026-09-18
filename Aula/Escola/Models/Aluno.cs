/*
 class Aluno {
    private string $nome;

    // Método Set: define ou altera o valor com segurança
    public function setNome(string $nome): void {
        $this->nome = trim($nome);
    }

    // Método Get: recupera o valor do atributo
    public function getNome(): string {
        return $this->nome;
    }
    private string $email;

    // Método Set: define ou altera o valor com segurança
    public function setEmail(string $email): void {
        $this->email = trim($email);
    }

    // Método Get: recupera o valor do atributo
    public function getEmail(): string {
        return $this->email;
    }
}
 */

using System.ComponentModel.DataAnnotations;

namespace Escola.Models
{
    public class Aluno
    {
        [Required, StringLength(10)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 6)]
        public string Nome { get; set; }
        private string email;
        [EmailAddress]
        public string Email
        {
            get { return this.email; }
            set
            {
                this.email = value?.ToLower().Trim();
            }
        }
        public DateTime DataNascimento { get; set; }

        [Range(15, 100)]
        public int Idade
        {
            get
            {
                var hoje = DateTime.Today;
                var idade = hoje.Year - DataNascimento.Year;
                var hojeAnoNascimento = hoje.AddYears(-idade);
                if (DataNascimento > hojeAnoNascimento)
                {
                    idade--;
                }
                return idade;

            }
        }


        public virtual void PrintDados()
        {
            Console.WriteLine("Codigo: {0}", Codigo);
            Console.WriteLine("Nome: {0}", Nome);
            Console.WriteLine("E-mail: {0}", Email);
            Console.WriteLine("Data de Nascimento: {0:dd} de {0:MMMM} de {0:yyyy} ({0:dddd})",
                DataNascimento);
            Console.WriteLine("Idade: {0} anos", Idade);
        }
    }
}
