using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cantidad_de_0_que_hay_del_1_al_100
{
    class Program
    {
        static void Main(string[] args)
        {
            int con1=0, con2 =0;
            for (int i = 1; i <=100; i++)
            {
                if (i%10 == 0 && i<100 )
                {
                    con1+= 1;
                }
                else if (i % 10 == 0 && i >= 100)
                {
                    con1 += 2;
                }
            }
            int a = con1 + con2;
            Console.WriteLine("la cantidad de ceros que hay del 1 al 100 es: "+a);
            Console.ReadKey();
        }
    }
}
