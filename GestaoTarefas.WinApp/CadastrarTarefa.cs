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
    public partial class CadastrarTarefa : Form
    {
        private Tarefa tarefa;

        public CadastrarTarefa()
        {
            InitializeComponent();
        }

       public Tarefa Tarefa
        {
            get { 

                 return tarefa; 
                    
                }

            set { 
                
                tarefa = value;
                txtNumero.Text = tarefa.Numero.ToString();
                txtTitulo.Text = tarefa.Titulo;


            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            tarefa.Titulo = txtTitulo.Text;
        }
    }
}
