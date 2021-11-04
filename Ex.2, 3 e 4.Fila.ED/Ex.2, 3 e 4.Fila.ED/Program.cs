using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2__3_e_4.Fila.ED
{
    class Program
    {
        static void Main(string[] args)
        {
            Fila minhafila = new Fila();
            string opcao = "", valor;

            do
            {
                try
                {
                    Console.WriteLine("Digite: \n1- Enfileira \n2- Desenfilerira \n3- Tamanho\n" +
                                      "4- Inicio da fila \n5- Fim da fila \n6- Listar \n7- Inverter \n9- Sair \n");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Console.WriteLine("Digite um valor Para enfileirar: ");
                            valor = Console.ReadLine();
                            minhafila.Enfileirar(valor);
                            break;
                        case "2":
                            Console.WriteLine("Desenfileirado: {0}", minhafila.Desenfileira());
                            break;
                        case "3":
                            Console.WriteLine("Tamanho da fila: {0}", minhafila.Tamanho());
                            break;
                        case "4":
                            Console.WriteLine("Inicio da fila: {0}", minhafila.RetornaInicio());
                            break;
                        case "5":
                            Console.WriteLine("Fim da fila: {0}", minhafila.RetornaFim());
                            break;
                        case "6":
                            minhafila.ListarFila();
                            break;
                        case "7":
                            Pilha pilha = new Pilha();

                            while (minhafila.Tamanho() > 0)
                                pilha.Empilha(minhafila.Desenfileira());

                            while (pilha.Tamanho() > 0)
                                minhafila.Enfileirar(pilha.Desempilha());
                            break;
                        case "9":
                            Console.WriteLine("Saindo!!");
                            break;
                        default:
                            Console.WriteLine("Opção Invalida");
                            break;
                    }
                }
                catch(Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != "9");
        }
    }
}
