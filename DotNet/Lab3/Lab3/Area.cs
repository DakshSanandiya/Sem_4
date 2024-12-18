using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3
{
    interface Area
    {
        double AreaOfCircle(double r);

        double AreaOfSquare(double l);

        double AreaOfTriangle(double b, double h);
    }

    class Shape : Area
    {
        public double AreaOfCircle(double r)
        {
            return Math.PI * r * r;
        }
        public double AreaOfSquare(double l)
        {
            return l * l;
        }
        public double AreaOfTriangle(double b, double h)
        {
            return (b * h) / 2;
        }

    }

}