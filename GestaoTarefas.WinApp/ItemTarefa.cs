using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoTarefas.WinApp
{
    public class ItemTarefa
    {
        public string Titulo { get; internal set; }
        public bool Concluido { get; private set; }
       
        public override string ToString()
        {
            return Titulo;

        }

        internal bool Exists(Func<object, bool> p)
        {
            throw new NotImplementedException();
        }
    }
}
