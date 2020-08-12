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
            kreis.Radius = 12;
            // Kreisföäche abrufen
            double area = kreis.GetArea();
            Console.WriteLine($"Fläche = {area}");
            // Kreisumfang abrufen
            Console.WriteLine($"Umfang = {kreis.GetPerimeter()}");
            Console.ReadLine();
        }
    }
}
