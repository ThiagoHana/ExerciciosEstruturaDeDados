using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAs
{
    class Program
    {
        static int[] MontaDuplas(int total)
        {
            Random gerador = new Random();
            int[] vetor2 = new int[total];

            for (int n = 0; n < vetor2.Length; n++)
            {
                bool existe;

                do
                {
                    existe = false;
                    vetor2[n] = gerador.Next(0, total);

                    for (int j = 0; j < n; j++)
                    {
                        if (vetor2[j] == vetor2[n])
                        {
                            existe = true;
                            break;
                        }
                    }
                } while (existe);
            }
            return vetor2;
        }

        static List<string> DuplasTrios( List<int> vetor)
        {
            List<string> Duplas = new List<string>();

            int[] AAleatorio = MontaDuplas(vetor.Count);
            
            if (vetor.Count % 2 != 0)
            {
                Duplas.Add($"{AAleatorio[0]}, {AAleatorio[1]}, {AAleatorio[2]}");

                int n = 1, p = 3;
                while (p < AAleatorio.Length)
                {
                    Duplas.Add($"{AAleatorio[p]}, {AAleatorio[p + 1]}");
                    p += 2;
                    n++;
                }
            }
            else
            {
                int n = 0, p = 0;
                while (p < AAleatorio.Length)
                {
                    Duplas.Add($"{AAleatorio[p]}, {AAleatorio[p + 1]}");
                    p += 2;
                    n++;
                }
            }

            return Duplas;
        }

        static List<int> Ra = new List<int>();
        static int qtd = 0;

        static void Main(string[] args)
        {
            for (int n = 0; n < Ra.Count; n++)
            {
                do
                {
                    try
                    {
                        Console.Write("Digite os RAs: ");
                        Ra.Add(Convert.ToInt32(Console.ReadLine()));
                        qtd++;
                    }
                    catch
                    {
                        Console.WriteLine("Opa meu bom, acho que tem coisa errada kkk...");
                    }
                } while (true);
            }

            int j = 0;
            foreach (var Total in DuplasTrios(Ra))
            {
                Console.WriteLine($"Dupla[{j + 1}]: {Total}");
                j++;
            }

            Console.ReadLine();
        }
    }
}
