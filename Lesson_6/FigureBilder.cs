using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    internal class FigureBilder
    {
        /// <summary>
        /// создать круг 
        /// </summary>
        /// <param name="position_x"></param>
        /// <param name="position_y"></param>
        /// <param name="radius"></param>
        /// <param name="color"></param>
        /// <param name="visible"></param>
        /// <returns></returns>
        public static Circle CreateCircle(double position_x, double position_y, double radius, string color, bool visible)
        {
            return new Circle(position_x, position_y, visible, color, radius);
        }

        /// <summary>
        /// создать прямоугольник 
        /// </summary>
        /// <param name="position_x"></param>
        /// <param name="position_y"></param>
        /// <param name="length"></param>
        /// <param name="width"></param>
        /// <param name="color"></param>
        /// <param name="visible"></param>
        /// <returns></returns>
        public static Rectangle CreateRactangle(double position_x, double position_y, double length, double width,
            string color, bool visible)
        {
            return new Rectangle(position_x, position_y, visible, color, length, width);
        }
    }
}
