using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculadora10
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Caluladora 10#");
            Console.WriteLine("Implementacion feature-division");

            Console.Write("Ingrese valor 1:  ");
            string val1 = Console.ReadLine();

            Console.Write("Ingrese valor 2:  ");
            string val2 = Console.ReadLine();

            Console.WriteLine("la division es =" + Convert.ToInt32(val1) / Convert.ToInt32(val2));

            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadLine();

        }
    }
}
