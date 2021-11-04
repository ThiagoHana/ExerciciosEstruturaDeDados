using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._1_Recursividade
{
    class Program
    {
        static int Potencia(int valor_base, int expoente)
        {
            if (expoente == 0)
                return 1;
            if (expoente >= 2)
                return valor_base * Potencia(valor_base, expoente -1);
            else
                return valor_base;
        }



        static void Main(string[] args)
        {
            Console.WriteLine(Potencia(2, 3));
            Console.ReadLine();
        }
    }
}
