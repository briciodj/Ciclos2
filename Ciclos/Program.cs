using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CICLOS

            //CICLO FOR
            Console.WriteLine("utilizando el ciclo for ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("VALOR DEL CONTADOR i: {0}", i);
            }


            //CICLO DO WHILE
            Console.WriteLine("UTILIZANDO EL CICLO DO WHILE");
            int c = 0;
            do
            {
                Console.WriteLine("Valor del contador c: {0}", c);
                c++;
            }while (c < 5);



            //CICLO WHILE
            Console.WriteLine("UTILIZANDO EL CICLO WHILE");
            int n = 0;
            while (n < 5)
            {
                Console.WriteLine("Valor del contador n: {0}", n);
                n++;
            }
        }
    }
}
