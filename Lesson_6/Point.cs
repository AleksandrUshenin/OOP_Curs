using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class Point : Figure
    {
        private double _x;
        private double _y;

        public double X { get { return _x; } }
        public double Y { get { return _y; } }

        public Point(double x, double y, bool visivle, string color) : base(visivle, color)
        {
            _x = x;
            _y = y;
        }

        protected void SetNewPosition(double x, double y)
        {
            _x = x;
            _y = y;
        }
    }
}
