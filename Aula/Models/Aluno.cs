using System;
using System.Collections.Generic;
using System.Text;

namespace Aula.Models
{
    internal class Aluno
    {
        public string Codigo { get; set; }
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

        public virtual void PrintDados()
        {
            Console.WriteLine($"Nome: {Nome}");
            Console.WriteLine($"E-mail: {Email}");
            Console.WriteLine($"Código: {Codigo}");
            Console.WriteLine("Data de Nascimento: {0:dd} de {0:MMMM} de {0:yyyy} ({0:dddd})", DataNascimento);
        }
    }
}
