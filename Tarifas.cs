using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");
            int salario = int.Parse(Console.ReadLine());

            int smmlv = 877800;

            if (salario < 2 * smmlv)
            {
                Console.WriteLine("Tarifa A");
            }
            else if (2 * smmlv <= salario && salario <= 4 * smmlv)
            {
                Console.WriteLine("Tarifa B");
            }
            else if (salario > 4 * smmlv)
            {
                Console.WriteLine("Tarifa c");
            }


        }
    }
}
