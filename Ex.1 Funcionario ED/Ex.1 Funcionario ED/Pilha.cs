using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Funcionario_ED
{
    class Pilha
    {
        private const int Capacidade = 5;
        private Funcionario[] dadosA = new Funcionario[Capacidade];
        private int Topo = -1;

        //retorna o tamanho da pilha
        public int Tamanho()
        {
            return Topo = + 1;
        }

        //Empilha o valor do nome e salario
        public void Empilha(Funcionario nome)
        {
            if (Tamanho() != Capacidade)
            {
                Topo++;
                dadosA[Topo] = nome;
            }

            else
                throw new Exception("A pilha está cheia!!!");
        }

        // Desempilha o valor do nome e salario
        public Funcionario Desempilha()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha está vazia!!!");

            else
            {
                Funcionario retorno = dadosA[Topo];
                dadosA[Topo] = null;
                Topo--;
                return dadosA[Topo + 1];
            }
        }

        //retorna o topo da pilha
        public Funcionario RetornaTopo()
        {
            if (Tamanho() == 0)
                throw new Exception("A pilha esta vazia!!!");
            else
                return dadosA[Topo];
        }
    }
}
