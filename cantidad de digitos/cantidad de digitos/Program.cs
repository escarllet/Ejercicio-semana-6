using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantidad_de_digitos
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
                int f;
                string b;
                b = Convert.ToString(a);
                f = b.Length;
                Console.WriteLine("Su numero tiene "+f+ " digitos");
            }
            else
            {
                Console.WriteLine("Error: no ha digitado un numero o el numero no es positivo");
            }


            Console.ReadKey();
        }
    }
}
