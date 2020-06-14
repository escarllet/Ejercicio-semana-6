using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace identifique_si_es_primo
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.WriteLine("Digite un numero positivo");
            a = Convert.ToInt32(Console.ReadLine());
            if (a>=0)
            {
                if ((a!=1)&&(a == 2 || a % 2 != 0) && (a == 3 || a % 3 != 0) && (a == 5 || a % 5 != 0) && (a == 7 || a % 7 != 0))
                {
                    Console.WriteLine("Su numero es primo");
                }
                else
                {
                    Console.WriteLine("Su numero no es primo");
                }
            }
            else
            {
                Console.WriteLine("Error: Porfavor ingrese un numero positivo");
            }

            Console.ReadKey();
        }
    }
}
