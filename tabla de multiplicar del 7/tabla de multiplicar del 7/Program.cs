using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tabla_de_multiplicar_del_7
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0,a;
            while (i<=12)
            {
                a = 7 * i;
                Console.WriteLine("7 x "+i+" = "+a);
                i++;
            }
            Console.ReadKey();
        }
    }
}
