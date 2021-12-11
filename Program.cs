using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Упражнение_7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cube MS;
            Console.WriteLine("Введите длину ребра куба:");
            int a = Convert.ToInt32(Console.ReadLine());
            MS = new Cube(a);
            Console.WriteLine("Объем Куба = " + MS.V(a) + " Площадь поверхности = " + MS.S(a));

            Console.ReadKey();
        }
    }
    class Cube
    {
        public int A { get; set; }

        public Cube(int a)
        {
            A = a;
        }
        public int S(int g)
        {
            return 6 * g * g;
        }
        public int V(int g)
        {
            return g * g * g;
        }

    }
}
