using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefônica
{
    public class Contato
    {
        public string nome { get; set; }
        public string telefone { get; set; }

        public override string ToString()
        {
            return nome.PadRight(40) + telefone;
        }
    }
}
