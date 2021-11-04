using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_Lista_ED
{
    class Program
    {
        static bool ValidaAlunoUnico(int ra, Lista minhaLista)
        {
            Aluno resultado = minhaLista.Localiza(ra);
            if (resultado != null)
            {
                Console.WriteLine("*** Este RA já está sendo usado!!! ***");
                return false;
            }
            else
                return true;
        }

        static void Main(string[] args)
        {
            string opcao = "";
            int posicao;
            Lista minhaLista = new Lista();

            Console.WriteLine("Sistema em C# para testar a execução de uma lista estática\n");

            do
            {
                try
                {
                    Console.WriteLine("\nDigite: \n 1-> Inserir no início \n " +
                    "2-> Inserir no fim \n " +
                    "3-> Inserir em uma posição (lembre-se que inicia do do zero!)\n " +
                    "4-> Tamanho \n " +
                    "5-> Listar \n " +
                    "6-> Remover elemento de uma posição \n " +
                    "7 > Consultar o primeiro elemento \n" +
                    "8 > Consultar o último elemento \n" +
                    "9 > Consultar um aluno \n" +
                    "10-> Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            {
                                Console.WriteLine("Digite o um nome para inserir no início:");
                                string nome = Console.ReadLine();

                                Console.WriteLine("Digite o RA:");
                                int ra = Convert.ToInt32(Console.ReadLine());

                                if (ValidaAlunoUnico(ra, minhaLista) == true)
                                    minhaLista.InsereNoInicio(new Aluno(ra, nome));
                            }
                            break;

                        case "2":
                            {
                                Console.WriteLine("Digite o um nome para inserir no fim:");
                                string nome = Console.ReadLine();

                                Console.WriteLine("Digite o RA:");
                                int ra = Convert.ToInt32(Console.ReadLine());

                                if (ValidaAlunoUnico(ra, minhaLista) == true)
                                    minhaLista.InsereNoFim(new Aluno(ra, nome));
                            }
                            break;

                        case "3":
                            {
                                Console.WriteLine("Digite o um nome para inserir no início:");
                                string nome = Console.ReadLine();

                                Console.WriteLine("Digite o RA:");
                                int ra = Convert.ToInt32(Console.ReadLine());

                                if (ValidaAlunoUnico(ra, minhaLista) == true)
                                {
                                    Console.WriteLine("Digite a posição:");
                                    posicao = Convert.ToInt32(Console.ReadLine());
                                    minhaLista.InsereNaPosicao(posicao, new Aluno(ra, nome));
                                }
                            }
                            break;

                        case "4":
                            Console.WriteLine("Tamanho da lista:{0}", minhaLista.Tamanho());
                            break;

                        case "5":
                            minhaLista.ImprimeLista();
                            break;

                        case "6":
                            Console.WriteLine("Digite a posição que deseja remover:");
                            posicao = Convert.ToInt32(Console.ReadLine());
                            Aluno removido = minhaLista.RemoveDaPosicao(posicao);
                            Console.WriteLine("Removido:{0} {1}", removido.RA, removido.Nome);
                            break;

                        case "7":
                            Console.WriteLine("Primeiro da lista: " + minhaLista.RetornaPrimeiro().Nome);
                            break;

                        case "8":
                            Console.WriteLine("Último da lista: " + minhaLista.RetornaUltimo().Nome);
                            break;

                        case "9":
                            {
                                Console.WriteLine("Digite o RA :");
                                int ra = Convert.ToInt32(Console.ReadLine());

                                Aluno resultado = minhaLista.Localiza(ra);
                                if (resultado == null)
                                    Console.WriteLine("Não localizado!");
                                else
                                    Console.WriteLine("Localizado: " + resultado.Nome);
                            }
                            break;

                        case "10":
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
            } while (opcao != "10");
        }
    }
}
