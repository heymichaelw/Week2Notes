using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Shape
    {
        public double height;
        public double width;
        public double radius;
        private string shapetype;

        public Shape()
        {

        }

        //circle constructor
        public Shape(double _radius)
        {
            radius = _radius;
        }

        //square constructor
        public Shape(double _height, double _width)
        {
            height = _height;
            width = _width;
        }

        public virtual double Area()
        {
            return Double.PositiveInfinity;
        }
    }
}
