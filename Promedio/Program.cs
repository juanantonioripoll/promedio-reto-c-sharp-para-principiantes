using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Promedio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, num4;
            Console.WriteLine("Introduce el primer número");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el segundo número");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el tercer número");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Introduce el cuarto número");
            num4 = Convert.ToInt32(Console.ReadLine());
            int result = (num1 + num2 + num3 + num4) / 4;
            Console.WriteLine("El promedio de {0}, {1}, {2}, {3} es: {4}", num1, num2, num3, num4, result);
            Console.ReadLine();
        }
    }
}
