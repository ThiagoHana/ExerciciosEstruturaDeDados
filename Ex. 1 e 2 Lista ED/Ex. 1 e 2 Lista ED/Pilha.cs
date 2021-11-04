using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_e_2_Lista_ED
{
    class Pilha
    {
        Lista listaDaPilha;
        public Pilha()
        {
            listaDaPilha = new Lista();
        }

        public int Tamanho()
        {
            return listaDaPilha.Tamanho();
        }

        public void Empilha(string p_valor)
        {
            try
            {
                listaDaPilha.InsereNoFim(p_valor);
            }
            catch
            {
                throw new Exception("A pilha está cheia!");
            }
        }

        public string Desempilha()
        {
            try
            {
                return listaDaPilha.RemoveDaPosicao(listaDaPilha.Tamanho() - 1);
            }
            catch
            {
                throw new Exception("A pilha está vazia!");
            }
        }
    }
}
