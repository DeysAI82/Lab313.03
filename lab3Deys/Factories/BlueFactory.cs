using System.Windows.Media;
using lab3Deys.Figure;

namespace lab3Deys.Factories
{
    public class BlueFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Blue };

        public Square CreateSquare() => new Square { Color = Colors.Blue };

        public Triangle CreateTriangle() => new Triangle { Color = Colors.Blue };
    }
}