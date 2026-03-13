using System.Windows.Media;
using lab3Deys.Figure;

namespace lab3Deys.Factories
{
    public class GreenFactory : IFigureFactory
    {
        public Circle CreateCircle() => new Circle { Color = Colors.Green };

        public Square CreateSquare() => new Square { Color = Colors.Green };

        public Triangle CreateTriangle() => new Triangle { Color = Colors.Green };
    }
}