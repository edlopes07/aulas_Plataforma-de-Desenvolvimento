using System;
using System.Collections.Generic;
using System.Text;

namespace Aula.Models
{
    internal class Bolsista : Aluno
    {
        public int PorcentagemDesconto { get; set; }

        public override void PrintDados()
        {
            base.PrintDados();
            Console.WriteLine($"Desconto: {PorcentagemDesconto}%");
        }
    }
}
