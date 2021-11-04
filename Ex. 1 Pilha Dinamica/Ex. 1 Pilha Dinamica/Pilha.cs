using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Pilha_Dinamica
{
    class Pilha
    {
        private Nodo topo = null;
        int quantidade = 0;

        public int Quantidade
        {
            get { return Quantidade; }
        }

        public void Empilhar(string valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = valor;
            novoNodo.Anterior = topo;
            topo = novoNodo;
            quantidade++;
        }

        public string Desempilhar()
        {
            if (Quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                string retorno = topo.Valor;
                topo = topo.Anterior;
                quantidade--;
                return retorno;
            }
        }

        public string RetornaTopo()
        {
            if (Quantidade == 0)
                throw new Exception("A pilha está vazia!");
            else
            {
                return topo.Valor;
            }
        }

        public string RetornaDados()
        {
            string final = "";
            Nodo aux = topo;

            while(aux != null)
            {
                final += aux.Valor + " - ";
                aux = aux.Anterior;
            }
            return final;
        }
    }
}
