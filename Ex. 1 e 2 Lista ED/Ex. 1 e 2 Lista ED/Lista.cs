using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_e_2_Lista_ED
{
    class Lista
    {
        private const int CAPACIDADE = 10;
        private string[] dados = new string[CAPACIDADE];
        private int quantidade = 0;
        public int Tamanho()
        {
            return quantidade;
        }
        public void InsereNaPosicao(int p_posicao, string p_valor)
        {
            if (Tamanho() == CAPACIDADE)
                throw new Exception("A lista está cheia!!!\n\n");
            else if (p_posicao > Tamanho())
                throw new Exception("Não é possível inserir nesta posição");
            else
            {
                quantidade++;
                for (int i = Tamanho() - 1; i > p_posicao; i--)
                {
                    dados[i] = dados[i - 1];
                }
                dados[p_posicao] = p_valor;
            }
        }
        public string RemoveDaPosicao(int posicao)
        {
            if (Tamanho() == 0)
                throw new Exception("A lista está vazia!!!");
            else if (posicao > Tamanho() - 1)
                throw new Exception("Posição inválida!!!");
            else
            {
                string aux = dados[posicao];
                for (int i = posicao; i < Tamanho() - 1; i++)
                {
                    dados[i] = dados[i + 1];
                }
                quantidade--;
                return aux;
            }
        }
        public void InsereNoInicio(string p_valor)
        {
            InsereNaPosicao(0, p_valor);
        }
        public void InsereNoFim(string p_valor)
        {
            InsereNaPosicao(Tamanho(), p_valor);
        }
        public void ImprimeLista()
        {
            Console.WriteLine("\n\nImpressão dos dados da lista:\n");
            for (int i = 0; i < Tamanho(); i++)
            {
                Console.WriteLine(dados[i]);
            }
        }
    }
}
