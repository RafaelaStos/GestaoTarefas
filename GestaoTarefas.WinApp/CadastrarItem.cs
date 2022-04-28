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
    public partial class CadastrarItem : Form
    {
        private readonly Tarefa tarefa;

        public CadastrarItem(Tarefa tarefa)
        {
            InitializeComponent();
            this.tarefa = tarefa;
            labelTituloTarefa.Text = tarefa.Titulo;

            foreach (ItemTarefa item in tarefa.Itens)
            {
                lisItem.Items.Add(item);
            }
        }

        public List<ItemTarefa> ItensAdicionados
        {
            get
            {
                return lisItem.Items.Cast<ItemTarefa>().ToList();
            }
        }
    }
}
