using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2__3_e_4.Fila.ED
{
    class Pilha
    {
        private const int CAPACIDADE = 5; //define o tamanho maximo desta uma pilha. 
        private string[] dados = new string[CAPACIDADE]; // vetor para guardar os dados da pilha. 
        private int topo = -1; // variável que irá indicar a posição no vetor do topo da pilha. 
                               // este método informa o tamanho da pilha 
        public int Tamanho()
        {
            return topo + 1; // lembre-se que o vetor inicia da posição zero... 
        }
        // este método retorna true se a pilha estiver vazia 
        public bool Vazia()
        {
            return Tamanho() == 0;
        }
        // este método empilha um valor string na pilha 
        public void Empilha(string p_valor)
        {
            if (Tamanho() != CAPACIDADE)
            {
                topo++;
                dados[topo] = p_valor;
            }
            else
            {
                throw new Exception("A pilha está cheia!!!");
            }
        }
        // este método desempilha um valor da pilha 
        public string Desempilha()
        {
            if (Vazia() == true)
            {
                throw new Exception("A pilha está vazia!!!");
            }
            else
            {
                topo--;
                return dados[topo + 1];
            }
        }
        // este método devolve o valor que está no topo 
        public string RetornaTopo()
        {
            if (Vazia() == true)
                throw new Exception("A pilha está vazia!!!");
            else
                return dados[topo];
        }
    }
}
