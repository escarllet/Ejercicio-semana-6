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
            string b;
            int sum=0;
            for (int i = 1; i <=100; i++)
            {
                b = Convert.ToString(i);
                char buscaremos = '0';
                int cont = 0;
                foreach (char v in b)
                {
                    if (v == buscaremos) ++cont;
                }
                sum += cont;
            }               
            Console.WriteLine(sum);
  
            Console.ReadKey();

        }
    }
}
