using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._3_Recursividade
{
    class Program
    {
        static void Tabuada(int numero, int vezes)
        {
            Console.WriteLine($"{numero} x {vezes} = {numero * vezes}");
            if (vezes < 10)
                Tabuada(numero, vezes + 1);
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Digite um numero: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            Tabuada(numero, 0);
            Console.ReadLine();
        }
    }
}
