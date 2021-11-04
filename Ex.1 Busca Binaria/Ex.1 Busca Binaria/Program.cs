using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Busca_Binaria
{
    class Program
    {
        static int BuscaBinaria(int[] vetor, int codigo)
        {
            int comeco = 0;
            int fim = vetor.Length - 1;
            do
            {
                int meio = (comeco + fim) / 2;
                if (codigo == vetor[meio])
                    return meio; // achouuuu
                else if (codigo < vetor[meio])
                    fim = meio - 1;
                else
                    comeco = meio + 1;
            }
            while (comeco <= fim);

            return -1;
        }


        static int BuscaBinariaRecursiva(int[] vetor, int codigo, int comeco, int fim)
        {
            int meio = (comeco + fim) / 2;
            if (comeco > fim)
                return -1;
            else if (codigo == vetor[meio])
                return meio; // achouuuu
            else if (codigo < vetor[meio])
                return BuscaBinariaRecursiva(vetor, codigo, comeco, meio - 1);
            else
                return BuscaBinariaRecursiva(vetor, codigo, meio + 1, fim);
        }


        static void Main(string[] args)
        {
            int[] vetor = { 4, 6, 7, 15, 22, 24, 29, 2, 4, 33, 50, 76, 80 };
            Array.Sort(vetor);
            int codigo;

            do
            {
                Console.WriteLine("Digite sua pesquisar ou -1 para sair: ");
                int.TryParse(Console.ReadLine(), out codigo);

                //int posicao = BuscaBinaria(vetor, codigo);                                
                int posicao = BuscaBinariaRecursiva(vetor, codigo, 0, vetor.Length - 1);

                if (posicao == -1)
                    Console.WriteLine("Não achei!");
                else
                {
                    Console.WriteLine("Encontre na posição {0}", posicao);
                }
            }
            while (codigo != -1);

        }
    }
}
