using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2__3_e_4.Fila.ED
{
    class Fila
    {
        const int capacidade = 5;
        private int quantidade = 0;
        private int começo = 0;
        private int fim = 0;
        private string[] dados = new string[capacidade];

        public int Tamanho()
        {
            return quantidade;
        }

        public void Enfileirar(string valor)
        {
            if(Tamanho() == capacidade)
                throw new Exception("A fila esta cheia!!");
            else
            {
                dados[fim] = valor;
                fim = (fim + 1) % capacidade;
                quantidade++;
            }
        }

        public string Desenfileira()
        {
            if (Tamanho() == 0)
                throw new Exception("A fila esta vazia!!");
            else
            {
                string valor = dados[começo];
                começo = (começo + 1) % capacidade;
                quantidade--;
                return valor;
            }
        }

        public string RetornaInicio()
        {
            string valor;

            if (Tamanho() == 0)
                throw new Exception(" A fila esta vazia!!");
            else
               valor = dados[começo];

            return valor;
        }

        public string RetornaFim()
        {
            string valor;

            if (Tamanho() == 0)
                throw new Exception("Fila vazia!!");
            if (fim == 0)
                return dados[dados.Length - 1] ;
            else
            {
                valor = dados[fim - 1];
                return valor;
            }
        }

        public void ListarFila()
        {
            int local = começo;
            int qtd = Tamanho();

            while (qtd > 0)
            {
                  Console.WriteLine( dados[local]);
                  local = (local + 1) % capacidade;
                qtd--;
            }
            
        }
    }
}
