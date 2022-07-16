
namespace Lesson_6
{
    class Program
    {
        public static void Main(string[] args)
        {
            var figure1 = FigureBilder.CreateCircle(5, 5, 3, "red", true);
            var figure2 = FigureBilder.CreateRactangle(1, 1, 10, 4, "black", true);

            Circle circle1 = new Circle(5, 5, true, "red", 4);
            double square = circle1.GetSquare();
            circle1.MoveGorisontal(10);
            circle1.MoveVertical(15);
            circle1.StatusFigure();

            circle1 = new Circle(4, 4, false, "blue", 2);
            circle1.MoveGorisontal(-2);
            circle1.MoveVertical(-6);

            Console.ReadKey();
        }
    }
}