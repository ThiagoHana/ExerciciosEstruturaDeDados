using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._2__3_e_4_Pilha_Dinamica
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcao = "";
            Fila minhafila = new Fila();

            do
            {
                try
                {
                    Console.WriteLine(Environment.NewLine + "Digite: 1-Enfileirar 2-Desenfileirar " +
                    "3-Tamanho 4-Listar 9-Sair");
                    opcao = Console.ReadLine();

                    switch (opcao)
                    {
                        case "1":
                            Aluno alunos = new Aluno();

                            Console.WriteLine("Digite o RA:");
                            alunos.Ra = Convert.ToInt32(Console.ReadLine());

                            Console.WriteLine("Digite um nome:");
                            alunos.Nome = Console.ReadLine();

                            minhafila.Enfileirar(alunos);
                            break;

                        case "2":
                            Aluno alunoDesenfileirado = minhafila.Desenfileira();
                            Console.WriteLine("Desenfileirado: {0} {1}", alunoDesenfileirado.Ra, alunoDesenfileirado.Nome);
                            break;

                        case "3":
                            Console.WriteLine("Tamanho da fila:{0}", minhafila.Tamanho());
                            break;

                        case "4":
                            Console.WriteLine("{0}", minhafila.Listar());
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
    }
}
