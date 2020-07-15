using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ingrase A: ");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrase B: ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("ingrase C: ");
            int c = int.Parse(Console.ReadLine());

            double discriminante = (b * b) - (4 * a * c);
            Console.WriteLine("El discriminante es: " + discriminante);

            if (discriminante == 0)
            {
                Console.WriteLine("unica solucion");
            }
            else if (discriminante > 0)
            {
                Console.WriteLine("existen dos soluciones");
            }
            else if (discriminante < 0)
            {
                Console.WriteLine("no tiene solucion");
            }
        }
    }
}
