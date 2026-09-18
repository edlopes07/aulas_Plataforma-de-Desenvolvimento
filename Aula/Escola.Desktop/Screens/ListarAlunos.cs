using Escola.Models;
using Escola.Services;

namespace Escola.Desktop.Screens
{
    public partial class ListarAlunos : Form
    {
        private readonly AlunoService service;

        public ListarAlunos(AlunoService service)
        {
            InitializeComponent();
            this.service = service;
            CarregarDados();
        }

        private void CarregarDados()
        {
            var alunos = service.Consultar();
            CarregarTabela(alunos);
        }

        private void CarregarTabela(List<Aluno> alunos)
        {
            dataGridView1.Rows.Clear();
            foreach (var item in alunos)
            {
                dataGridView1.Rows.Add(
                    item.Codigo,
                    item.Nome,
                    item.Idade,
                    item.DataNascimento.ToString("dd/MM/yyyy"),
                    item.Email);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                lblErro.Text = "Selecione um aluno na tabela antes de excluir.";
                lblErro.Visible = true;
                return;
            }

            var linha = dataGridView1.SelectedRows[0];
            var codigo = linha.Cells["Codigo"].Value.ToString();

            var sucesso = service.Excluir(codigo);

            if (sucesso)
            {
                lblErro.Visible = false;
                CarregarDados();
            }
            else
            {
                lblErro.Text = "Não foi possível excluir o aluno selecionado.";
                lblErro.Visible = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
