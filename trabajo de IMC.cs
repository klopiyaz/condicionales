using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp34
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese su estatura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if (imc < 18)
            {
                Console.WriteLine("bajo peso...");
            }
            else if (18 <= imc && imc <= 25)
            {
                Console.WriteLine("peso ideal...");
            }
            else if (25 <= imc && imc <= 29)
            {
                Console.WriteLine("sobrepeso...");
            }
            else if (30 <= imc && imc <= 35)
            {
                Console.WriteLine("obesidad...");
            }
            else
            {
                Console.WriteLine("obesidad morbida");
            }
            Console.WriteLine("IMC es: " + imc);
        }
    }
}
