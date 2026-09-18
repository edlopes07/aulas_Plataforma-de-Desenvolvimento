namespace Escola.Models
{
    internal class Bolsista : Aluno
    {
        public int PorcentagemDesconto { get; set; }

        public override void PrintDados()
        {
            base.PrintDados();
            Console.WriteLine("Desconto: {0}%", PorcentagemDesconto);
        }
    }
}
