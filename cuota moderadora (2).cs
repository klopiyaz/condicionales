using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su salario");
            double salario = double.Parse(Console.ReadLine());

            double smmlv = 877800;
            double valorcuota;
            double cuotamoderadora;

            if (salario < 2 * smmlv)
            {
                Console.WriteLine("Tarifa A");
                cuotamoderadora = smmlv / 30;
                valorcuota =(cuotamoderadora *11.5) / 100;
                Console.WriteLine("valor de cuota: " + valorcuota);
            }
            else if (2 * smmlv <= salario && salario <= 5 * smmlv)
            {
                Console.WriteLine("Tarifa B");
                cuotamoderadora = smmlv / 30;
                valorcuota = (cuotamoderadora * 17.3) / 100;
                Console.WriteLine("valor de cuota: " + valorcuota);
            }
            else if (salario > 5 * smmlv)
            {
                Console.WriteLine("Tarifa c");
                cuotamoderadora = smmlv / 30;
                valorcuota = (cuotamoderadora * 23.0) / 100;
                Console.WriteLine("valor de cuota: " + valorcuota);
            }


        }
    }
}
