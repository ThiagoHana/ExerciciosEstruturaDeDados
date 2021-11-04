using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_e_2_Lista_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao;
            Console.WriteLine("Digite P para simular a pilha ou F para simular a fila:");
            opcao = Console.ReadLine().ToUpper();

            if (opcao == "P")
                SimulaPilha();
            else
                SimulaFila();
        }

        static void SimulaFila()
        {
            Fila minhafila = new Fila();
            string opcao = "", valor;
            Console.WriteLine("Fila circular\n");
            do
            {
                try
                {
                    Console.WriteLine("\n\nDigite: \n1->Enfileirar \n2->Desenfileirar \n3-> Tamanho \n9->Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor para enfileirar:");
                            valor = Console.ReadLine();
                            minhafila.Enfileirar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Desenfileirado: {0}", minhafila.Desenfileira());
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}", minhafila.Tamanho());
                            break;
                        case "9":
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida!!!");
                            break;
                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        }

        static void SimulaPilha()
        {
            Pilha minhaPilha = new Pilha();
            int opcao = 0;
            string valor;

            do
            {
                try
                {
                    Console.Write("\n\n Escolha: \n1-> empilha \n2->desempilha " +
                    " \n3->topo \n4-> tamanho \n9-> sair : ");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Console.Write(">>Digite o valor que deseja empilhar: ");
                        valor = Console.ReadLine();
                        minhaPilha.Empilha(valor);
                    }
                    else if (opcao == 2)
                    {
                        valor = minhaPilha.Desempilha();
                        Console.WriteLine(">>Desempilhado: {0} \n\n", valor);
                    }
                    else if (opcao == 4)
                    {
                        Console.WriteLine(">>Tamanho da pilha: {0}", minhaPilha.Tamanho());
                    }
                    else if (opcao == 9)
                    {

                    }
                }
                catch (Exception erro)
                {
                    Console.WriteLine("ERRO: " + erro.Message);
                }
            }
            while (opcao != 9);
        }
    }
}
