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
            Circle kreis = new Circle();
            kreis.XCoordinate = -100;
            kreis.YCoordinate = 90;
            Console.WriteLine($"Koordinaten bevor Move() = {kreis.XCoordinate}, + {kreis.YCoordinate}");
            kreis.Move(120, -200);
            Console.WriteLine($"Koordinaten nach Move(120, -200) = {kreis.XCoordinate}, + {kreis.YCoordinate}");
            Console.ReadLine();
        }
    }
}
