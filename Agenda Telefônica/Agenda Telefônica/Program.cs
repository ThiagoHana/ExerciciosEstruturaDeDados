using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Telefônica
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;

            Lista minhaLista = new Lista();
            do
            {
                try
                {
                    Console.WriteLine("1- Cadastrar contato \n" +
                    "2- Pesquisar contatos pelo nome ou parte dele \n" +
                    "3- Alterar um contato pesquisando pelo telefone\n " +
                    "4- Alterar um contato pesquisando pelo nome \n " +
                    "5- Remover um contato pelo telefone " +
                    "6- Remover um contato pelo nome\n " +
                    "9- Sair");

                    opcao = Convert.ToInt32(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            {
                                Contato c = new Contato();
                                Console.WriteLine("Digite o nome:");
                                c.nome = Console.ReadLine();

                                Console.WriteLine("Digite o telefone:");
                                c.telefone = Console.ReadLine();

                                if (minhaLista.BuscaPorTelefone(c.telefone) != null)
                                    Console.WriteLine("Telefone repetido.");
                                else
                                    minhaLista.InserirNoInicio(c);
                            }
                            break;
                        case 2:
                            {
                                ListaPorNome(minhaLista);
                            }
                            break;
                        case 3:
                            {
                                Console.WriteLine("Digite o telefone:");
                                string telefone = Console.ReadLine();
                                AlteraNomeDoContato(telefone, minhaLista);
                            }
                            break;
                        case 4:
                            {
                                ListaPorNome(minhaLista);
                                Console.WriteLine("Digite o telefone que deseja alterar:");
                                string telefone = Console.ReadLine();
                                AlteraNomeDoContato(telefone, minhaLista);
                            }
                            break;
                        case 5:
                            {
                                ExcluiPorTelefone(minhaLista);
                            }
                            break;
                        case 6:
                            {
                                ListaPorNome(minhaLista);
                                ExcluiPorTelefone(minhaLista);
                            }
                            break;
                        case 9:
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
            } while (opcao != 9);
        }

        private static void ExcluiPorTelefone(Lista minhaLista)
        {
            Console.WriteLine("Digite o telefone:");
            string telefone = Console.ReadLine();
            Contato c = minhaLista.BuscaPorTelefone(telefone, out int posicao);

            if (posicao == -1)
                Console.Write("Contato não encontrado");
            else
            {
                minhaLista.RemoverDaPosicao(posicao);
                Console.WriteLine("Removido: " + c.ToString());
            }
        }

        private static void AlteraNomeDoContato(string telefone, Lista minhaLista)
        {
            Contato contato = minhaLista.BuscaPorTelefone(telefone);
            if (contato == null)
                Console.WriteLine("Não existe um contato com este telefone.");
            else
            {
                Console.WriteLine("Digite o novo nome:");
                contato.nome = Console.ReadLine();
            }
        }

        private static void ListaPorNome(Lista minhaLista)
        {
            Console.WriteLine("Digite o nome para pesquisar:");
            string nome = Console.ReadLine();
            foreach (Contato c in minhaLista.Listar())
            {
                if (c.nome.ToUpper().Contains(nome.ToUpper()))
                    Console.WriteLine(c.ToString());
            }
        }
    }
}
