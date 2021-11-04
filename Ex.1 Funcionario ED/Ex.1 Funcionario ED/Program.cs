using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Funcionario_ED
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            string valor;
            int salario;
            Pilha MinhaPilha = new Pilha();

            do
            {
                try
                {
                    Console.WriteLine("Escolha: \n\n1-empilha \n2-desempilha \n3-topo \n4-tamanho");
                    opcao = Convert.ToInt32(Console.ReadLine());

                    if (opcao == 1)
                    {
                        Funcionario pilha = new Funcionario();

                        Console.WriteLine("Digite o nome que deseja empilhar");
                        pilha.SetNome(Console.ReadLine());
                        valor = Console.ReadLine();
                        MinhaPilha.Empilha(pilha);

                        Console.WriteLine("Digite o valor que deseja empilhar");
                        pilha.SetSalario(Convert.ToDouble(Console.ReadLine()));
                        MinhaPilha.Empilha(pilha);
                    }

                    else if (opcao == 2)
                    {
                        Funcionario pilha = MinhaPilha.Desempilha();
                        Console.WriteLine("Desempilhado: {0} - R$ {1} \n\n", pilha.GetNome(), pilha.GetSalario());
                    }

                    else if (opcao == 3)
                    {
                        Funcionario pilha = MinhaPilha.RetornaTopo();
                        Console.WriteLine("Valor no topo: {0} - R$ {1} \n\n", pilha.GetNome(), pilha.GetSalario());
                    }

                    else if (opcao == 4)
                    {
                        
                        Console.WriteLine("tamanho da pilha: {0} \n\n", MinhaPilha.Tamanho());
                    }

                    else if (opcao == 5)
                    {
                        Pilha aux = new Pilha();
                        while(MinhaPilha.Tamanho() > 0)
                        {
                            Funcionario pilha = MinhaPilha.Desempilha();
                            Console.WriteLine("Desempilhado: {0} - R$ {1} \n\n", pilha.GetNome(), pilha.GetSalario());
                            aux.Empilha(pilha);
                        }
                        while(aux.Tamanho() > 0)
                        {
                            MinhaPilha.Empilha(aux.Desempilha());
                        }
                    }

                    else if (opcao == 5)
                    {
                        double soma = 0;
                        Pilha aux = new Pilha();
                        while (MinhaPilha.Tamanho() > 0)
                        {
                            Funcionario pilha = MinhaPilha.Desempilha();
                            soma += pilha.GetSalario();
                            aux.Empilha(pilha);
                        }
                        while (aux.Tamanho() > 0)
                        {
                            MinhaPilha.Empilha(aux.Desempilha());
                        }
                        Console.WriteLine("Soma: R$: {0}", soma);
                    }

                    else if(opcao == 7)
                    {
                        Pilha aux = new Pilha();
                        while (MinhaPilha.Tamanho() > 1)
                        {
                            aux.Empilha(MinhaPilha.Desempilha()); 
                        }
                        Funcionario pilha = MinhaPilha.Desempilha();
                        Console.WriteLine("Base: {0} R$: {1}", pilha.GetNome(),pilha.GetSalario());

                        while (aux.Tamanho() > 0)
                        {
                            MinhaPilha.Empilha(aux.Desempilha());
                        }
                    }

                    else if (opcao == 9)
                    {
                        //Adeus
                    }
                }
                catch(Exception erro)
                {
                    Console.WriteLine("Erro: " + erro.Message);
                }
            } while (opcao != 9);
        }
    }
}
