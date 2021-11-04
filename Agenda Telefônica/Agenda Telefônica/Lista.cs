using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefônica
{
    public class Lista
    {
        Nodo primeiro = null; // ponteiro para o primeiro elemento da lista
        int qtd = 0;

        public int Quantidade
        {
            get { return qtd; }
        }

        private void InserirNaPosicao(Nodo anterior, Contato valor)
        {
            Nodo novo = new Nodo();
            novo.Dado = valor;
            if (anterior == null) // indica que é o primeiro da lista
            {
                novo.Proximo = primeiro;
                primeiro = novo;
            }
            else
            {
                novo.Proximo = anterior.Proximo;
                anterior.Proximo = novo;
            }
            qtd++;
        }
        /// <summary>
        /// Insere um valor no início da lista
        /// </summary>
        /// <param name="valor"></param>
        public void InserirNoInicio(Contato valor)
        {
            InserirNaPosicao(null, valor);
        }

        public void InserirNoFim(Contato valor)
        {
            if (qtd == 0)
                InserirNoInicio(valor);
            else
            {
                Nodo aux = primeiro;
                while (aux.Proximo != null)
                    aux = aux.Proximo;

                InserirNaPosicao(aux, valor);
            }
        }
        /// <summary>
        /// Insere em uma posição, iniciando do 0
        /// </summary>
        /// <param name="valor">valor</param>
        /// <param name="posicao">posicao iniciando do 1</param>
        public void InserirNaPosicao(Contato valor, int posicao)
        {
            if (posicao > qtd || posicao < 0)
                throw new Exception("Não é possível inserir.");
            if (posicao == 0)
                InserirNoInicio(valor);
            else
            {
                //descobre qual é o nodo anterior ao que será incluído
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;
                InserirNaPosicao(aux, valor);
            }
        }
       
        public Contato RemoverDaPosicao(int posicao)
        {
            Contato devolve = null;

            if (posicao >= qtd || posicao < 0 || qtd == 0)
                throw new Exception("Não é possível remover.");
            if (posicao == 0)
                primeiro = primeiro.Proximo;

            else
            {
                //descobre qual é o nodo anterior que será excluido
                Nodo aux = primeiro;
                for (int i = 1; i < posicao; i++)
                    aux = aux.Proximo;

                devolve = aux.Proximo.Dado;

                aux.Proximo = aux.Proximo.Proximo;
            }
            qtd--;

            return devolve;
        }

        public Contato BuscaPorTelefone(string telefone, out int posicao)
        {
            Nodo aux = primeiro;
            posicao = 0;

            while (aux != null)
            {
                if (aux.Dado.telefone == telefone)
                    return aux.Dado;
                aux = aux.Proximo;
                posicao++;
            }

            posicao = -1;
            return null;
        }

        public Contato BuscaPorTelefone(string telefone)
        {
            return BuscaPorTelefone(telefone, out int posicao);
        }

        public Contato[] Listar()
        {
            Contato[] vetor = new Contato[qtd];
            Nodo aux = primeiro;
            int posicao = 0;
            while (aux != null)
            {
                vetor[posicao++] = aux.Dado;
                aux = aux.Proximo;
            }
            return vetor;
        }
    }
}
