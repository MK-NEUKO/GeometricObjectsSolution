﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricObjects
{
    public class Circle
    {
        private double _XCoordinate;

        public double XCoordinate
        {
            get { return _XCoordinate; }
            set { _XCoordinate = value; }
        }

        private double _YCoordinate;
      
        public double YCoordinate
        {
            get { return _YCoordinate; }
            set { _YCoordinate = value; }
        }

        private int _Radius;

        public int Radius
        {
            get 
            { return _Radius; }
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

        //Methoden
        public double GetArea()
        {
            double area = Math.Pow(Radius, 2) * Math.PI;
            return area;
        }

        public double GetPerimeter()
        {
            double perimeter = 2 * Radius * Math.PI;
            return perimeter;
        }

        public void Move(double dx, double dy)
        {
            XCoordinate += dx;
            YCoordinate += dy;
        }

        public void Move(double dx, double dy, int dRadius)
        {
            Move(dx, dy);
            Radius += dRadius;
        }

        public int Bigger(Circle kreis)
        {
            if (kreis == null || Radius > kreis.Radius)
            {
                return 1;
            }
            if (Radius < kreis.Radius)
            {
                return -1;
            }
            else
                return 0;
        }


    }
}
