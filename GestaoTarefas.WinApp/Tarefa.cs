using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace GestaoTarefas.WinApp
{
    public class Tarefa
    {
        List<ItemTarefa> itens =new List<ItemTarefa>();
        public Tarefa()
        {
            DateTime _dataCriacao = DateTime.Now;
        }

        public Tarefa(int n, string t) : this()
        {
            Numero = n;
            Titulo = t;
        }

        public int Numero { get; set; }
        public string Titulo { get; set; }
        public DateTime DataCriacao { get; set; }
        public List<ItemTarefa> Itens { get; set; }
        public override string ToString()
        {
            return "Id: " + Numero + Environment.NewLine +
                "Tutulo: " + Titulo + Environment.NewLine;

        }
        public void AdicionarItem(ItemTarefa item)
        {
            if (item.Exists(x => x.Equals(item)) == false)
                itens.Add(item);

        }
    }
}
