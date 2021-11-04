using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefônica
{
    class Nodo
    {
        public Contato Dado { get; set; }
        public Nodo Proximo { get; set; }

        /// <summary>
        /// Construtor sem parâmetros
        /// </summary>
        public Nodo()
        {
            Proximo = null;
        }
    }
}
