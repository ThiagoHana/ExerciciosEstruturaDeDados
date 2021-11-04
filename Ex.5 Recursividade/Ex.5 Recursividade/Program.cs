using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex._5_Recursividade
{
    class Program
    {
        static void Progressao(int numero, int razao, int repeticao)
        {          
            if(repeticao)
                Console.WriteLine($"{numero}");

            Console.WriteLine($"{numero += razao}");
            if (repeticao > 1)
                Progressao(numero, razao, repeticao - 1);
        }


        static void Main(string[] args)
        {
            Progressao(5, 2, 6);
            Console.ReadLine();
        }
    }
}
