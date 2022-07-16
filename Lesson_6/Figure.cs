using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6
{
    enum Colors
    {
        red = 1,
        black,
        blue,
        green,
        yellow,
        non_color
    }

    internal class Figure
    {
        protected bool Visible;
        private Colors Color_Figure;

        public Figure(bool visible, string color)
        {
            Visible = visible;
            ChengeColor(color);
        }

        public virtual void MoveGorisontal(double x) { }
        public virtual void MoveVertical(double y) { }

        /// <summary>
        /// input red, black, blue, green, yellow
        /// </summary>
        /// <param name="color"></param>
        public bool ChengeColor(string color)
        {
            switch (color)
            {
                case "red":
                    Color_Figure = Colors.red;
                    return true;
                case "black":
                    Color_Figure = Colors.black;
                    return true;
                case "blue":
                    Color_Figure = Colors.blue;
                    return true;
                case "green":
                    Color_Figure = Colors.green;
                    return true;
                case "yellow":
                    Color_Figure = Colors.yellow;
                    return true;
                default:
                    Color_Figure = Colors.non_color;
                    return false;
            }
        }
        protected void Status()
        {
            Console.WriteLine("Visible: {0}  Color:{1}", Visible, Color_Figure);
        }
    }
}
