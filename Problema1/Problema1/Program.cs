using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problema1
{
    class Program
    {
        static void Main(string[] args)
        {
            int inicio = 0;
            int final = 0;
            int aux = 0;
            Console.Write("Ingrese el inicio: ");
            inicio = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ingrese el final: ");
            final = Convert.ToInt32(Console.ReadLine());

            if (inicio < final)
            {
                aux = inicio;
                inicio = final;
                final = aux;
            }

            for (int i = inicio; i >= final; i--)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
