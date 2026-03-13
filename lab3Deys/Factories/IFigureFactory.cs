using lab3Deys.Figure;

namespace lab3Deys.Factories
{
    public interface IFigureFactory
    {
        Circle CreateCircle();
        Square CreateSquare();
        Triangle CreateTriangle();
    }
}