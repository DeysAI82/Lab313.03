using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;
using System.Windows.Shapes;

namespace lab3Deys.Figure
{
    public class Triangle : Figure
    {
        public override UIElement CreateUIElement(double size = 80)
        {
            return new Polygon
            {
                Points = new PointCollection
                {
                    new Point(size / 2, 0),
                    new Point(0, size),
                    new Point(size, size)
                },
                Fill = new SolidColorBrush(Color),
                Width = size,
                Height = size,
                Stretch = Stretch.Fill,
                Margin = new Thickness(10)
            };
        }
    }
}
