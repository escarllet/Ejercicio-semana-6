using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Numero_aleatorio_de_50_a_100
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            do
            {
                Random rand = new Random();
                int numero = rand.Next(50, 100);
                Console.WriteLine("Se ha generado un numero aleatorio, este numero es " + numero);
                Console.WriteLine("Desea terminar el programa? (S/N)");
                a = Console.ReadLine();

            } while (a != "S");
            Console.ReadKey();
        }
    }
}
