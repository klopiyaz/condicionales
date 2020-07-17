using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp35
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
                Console.WriteLine("copago de 3400$");
            }
            else if (2 * smmlv <= salario && salario <= 5 * smmlv)
            {
                Console.WriteLine("Tarifa B");
                Console.WriteLine("copago de 13500$");
            }
            else if (salario > 5 * smmlv)
            {
                Console.WriteLine("Tarifa c");
                Console.WriteLine("copago de 35600$");
            }
        }
    }
}
