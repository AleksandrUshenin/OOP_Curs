using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Lesson_6.Interface;

namespace Lesson_6
{
    internal class Circle : Point, IFigureObject
    {
        private double _r;
        private readonly double Pi = 3.14;

        public Circle(double x, double y, bool visible, string color, double radius) : base(x, y, visible, color)
        {
            _r = radius;
        }


        /// <summary>
        /// получкние площади фигуры
        /// </summary>
        /// <returns></returns>
        public double GetSquare()
        {
            return _r * _r * Pi;
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
            Console.WriteLine("x: {0} y: {1} radius{2}", X, Y, _r);
        }
    }
}
