using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle kreis1 = new Circle();
            kreis1.Radius = 12;
            Circle kreis2 = new Circle();
            kreis2.Radius = 23;
            if (kreis1.Bigger(kreis2) == -1) 
            {
                Console.WriteLine("kreis1 < kreis2");
            }
            Console.ReadLine();
        }
    }
}
