using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace secondassignment
{
    internal class Program
    {
        static void Main(string[] args)
        { //perimeter and area  of the circle 
            double r, per_circle,area;
            double pi = 3.14;
            Console.WriteLine("Input the radius of the circle:");
            r=Convert.ToDouble(Console.ReadLine());
            per_circle = 2 * pi * r;
            Console.WriteLine("Perimeter of the circle  :{0}",per_circle);
            area = pi * r * r;
            Console.WriteLine("area of the circle  :{0}", area);
            Console.Read();
      

        }
    }
}
