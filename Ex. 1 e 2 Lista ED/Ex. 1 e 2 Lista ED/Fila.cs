using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_e_2_Lista_ED
{
    class Fila
    {
        Lista listaDaFila = new Lista();

        public int Tamanho()
        {
            return listaDaFila.Tamanho();
        }


        public void Enfileirar(string p_valor)
        {
            try
            {
                listaDaFila.InsereNoFim(p_valor);
            }
            catch
            {
                throw new Exception("A fila está cheia!!!!");
            }
        }


        public string Desenfileira()
        {
            try
            {
                return listaDaFila.RemoveDaPosicao(0);
            }
            catch
            {
                throw new Exception("A fila está vazia!");
            }
        }
    }
}
