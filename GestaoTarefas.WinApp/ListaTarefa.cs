using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoTarefas.WinApp
{
    public partial class ListaTarefa : Form
    {
        private RepositorioTarefa repositorioTarefa;
        
        public ListaTarefa()
        {
            repositorioTarefa = new RepositorioTarefa();
            InitializeComponent();
            CarregarTarefas();

        }

        private void CarregarTarefas()
        {
            List<Tarefa> tarefas = repositorioTarefa.SelecionarTodos();
            listListagemTarefa.Items.Clear();

            foreach(Tarefa t in tarefas)
            {
                listListagemTarefa.Items.Add(t);
            }
        }
        private void btnIncerir_Click(object sender, EventArgs e)
        {
            CadastrarTarefa tela = new CadastrarTarefa();
            tela.Tarefa = new Tarefa();

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Inserir(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {

            Tarefa tarefaSelecionada = (Tarefa)listListagemTarefa.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Exclusão de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult resultado = MessageBox.Show("Deseja realmente excluir a tarefa?",
                "Exclusão de Tarefas", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Excluir(tarefaSelecionada);
                CarregarTarefas();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)

        {
            Tarefa tarefaSelecionada = (Tarefa)listListagemTarefa.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Edição de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            CadastrarTarefa tela = new CadastrarTarefa();

            tela.Tarefa = tarefaSelecionada;

            DialogResult resultado = tela.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                repositorioTarefa.Editar(tela.Tarefa);
                CarregarTarefas();
            }
        }

        private void btnCadastrarIten_Click(object sender, EventArgs e)

        {
            Tarefa tarefaSelecionada = (Tarefa)listListagemTarefa.SelectedItem;

            if (tarefaSelecionada == null)
            {
                MessageBox.Show("Selecione uma tarefa primeiro",
                "Cadastro de iten de Tarefas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            CadastrarItem tela =new CadastrarItem(tarefaSelecionada);
            if(tela.ShowDialog() == DialogResult.OK)
            {
                List<ItemTarefa> itens = tela.ItensAdicionados;
                repositorioTarefa.CadastraItem(tarefaSelecionada, itens);

                CarregarTarefas();
            }
        }

        
    }
}
