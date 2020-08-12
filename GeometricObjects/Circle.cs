using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        public double XCoordinate;
        public double YCoordinate;
        private int _Radius;

        public int Radius
        {
            get 
            { 
                return _Radius; 
            }
            set 
            {
                if (value >= 0)
                {
                    _Radius = value;
                }
                else
                    Console.WriteLine("Unzulässiger negativer Wert.");
            }
        }

    }
}
