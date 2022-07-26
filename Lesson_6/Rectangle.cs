using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_6.Interface;

namespace Lesson_6
{
    internal class Rectangle : Point, IFigureObject
    {
        private double _length;
        private double _width;

        public Rectangle(double x, double y, bool visible, string color, double length, double width)
            : base(x, y, visible, color)
        {
            _length = length;
            _width = width;
        }


        public double GetSquare()
        {
            return _length * _width;
        }
        /// <summary>
        /// перемещение по горизонтали
        /// </summary>
        /// <param name="x"></param>
        public override void MoveGorisontal(double x)
        {
            SetNewPosition(X + x, Y);
        }
        /// <summary>
        /// перемещение по ветрикали
        /// </summary>
        /// <param name="y"></param>
        public override void MoveVertical(double y)
        {
            SetNewPosition(X, Y + y);
        }
        /// <summary>
        /// смена видимости фигуры
        /// </summary>
        /// <param name="visible"></param>
        public void ChangeVisible(bool visible)
        {
            Visible = visible;
        }
        /// <summary>
        /// вывод информации о фигуре
        /// </summary>
        public void StatusFigure()
        {
            Status();
            Console.WriteLine("x: {0} y: {1} length: {2}, width: {3}", X, Y, _length, _width);
        }
    }
}
