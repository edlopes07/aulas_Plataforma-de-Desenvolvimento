using Escola.Desktop.Screens;
using Escola.Services;

namespace Escola.Desktop
{
    public partial class Form1 : Form
    {
        private readonly AlunoService service;

        public Form1()
        {
            InitializeComponent();
            this.service = new AlunoService();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var tela = new ListarAlunos(service);
            tela.ShowDialog(this);
        }

        private void primaryButton1_Click(object sender, EventArgs e)
        {
            var tela = new CadastrarAluno(service);
            tela.ShowDialog(this);
        }
    }
}
