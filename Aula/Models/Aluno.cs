using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Aula.Models
{
    internal class Aluno
    {
        [Required, StringLength(8)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(80, MinimumLength = 10)]
        public string Nome { get; set; }
        private string email;
        public string Email
        {
            get
            {
                return this.email;
            }
            set //setEmail(string value)
            {
                this.email = value.ToLower().Trim();
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
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine("Data de Nascimento: {0:dd} de {0:MMMM} de {0:yyyy} ({0:dddd})", DataNascimento);
            Console.WriteLine($"Idade: {Idade} anos");
        }
    }
}
