using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Pilha_Dinamica
{
    class Program
    {
        static Pilha pilha = new Pilha();

        static void Main(string[] args)
        {
            int opcao = 0;
            do
            {
                try
                {
                    Console.WriteLine("Digite uma opção: 1-Empilhar 2-Desempilhar 3-Topo 4-Listar 5-Sair");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {

                        case 1:
                            pilha = new Pilha();
                            Console.WriteLine("Digite um valor: ");
                            string valor = Console.ReadLine();
                            pilha.Empilhar(valor);
                            break;

                        case 2:
                            Console.WriteLine("valor: {0}", pilha.Desempilhar());
                            break;

                        case 3:
                            Console.WriteLine("Topo: {0}", pilha.RetornaTopo());
                            break;

                        case 4:
                            Console.WriteLine("Lista: {0}", pilha.RetornaDados());
                            break;

                        case 5:
                            break;

                        default:
                            Console.WriteLine("Valor incorreto!!");
                            break;
                    }
                }
                catch(Exception erro)
                {
                    Console.WriteLine(erro.Message);
                }
            } while (opcao != 5);
        }
    }
}
