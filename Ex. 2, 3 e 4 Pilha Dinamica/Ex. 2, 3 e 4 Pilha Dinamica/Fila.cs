using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2__3_e_4_Pilha_Dinamica
{
    class Fila
    {
        private int quantidade = 0; 
        private Nodo primeiro;
        private Nodo proximo;

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileirar(Aluno p_valor)
        {
            Nodo novoNodo = new Nodo();
            novoNodo.Valor = p_valor;

            if (quantidade == 0)
                primeiro = novoNodo;
            else
                proximo.Proximo = novoNodo;

            proximo = novoNodo;
            quantidade++;
        }

        public Aluno Desenfileira()
        {
            if (Tamanho() == 0)
            {
                throw new Exception("A fila está vazia!");
            }
            else
            {
                Aluno valor = primeiro.Valor;
                primeiro = primeiro.Proximo;
                quantidade--;
                return valor;
            }
        }

        public string Listar()
        {
            string retorno = "";
            Nodo aux = primeiro;

            while (aux != null)
            {
                retorno += aux.Valor.Ra + "-" + aux.Valor.Nome + "  ;  ";
                aux = aux.Proximo;
            }

            return retorno;
        }
    }
}
