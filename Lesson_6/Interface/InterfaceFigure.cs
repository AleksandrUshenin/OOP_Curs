using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson_6.Interface
{
    internal interface IFigureColor
    {
        bool ChengeColor(string color);
    }
    internal interface IFigureVisible
    {
        void ChangeVisible(bool visible);
    }
    internal interface IFigureGetSquare
    {
        double GetSquare();
    }
    internal interface IMove
    {
        void MoveGorisontal(double x);
        void MoveVertical(double y);
    }
    internal interface IFigureObject : IMove, IFigureGetSquare, IFigureColor, IFigureVisible
    {
        void StatusFigure();
    }
}
