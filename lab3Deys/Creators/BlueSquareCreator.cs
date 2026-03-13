using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using lab3Deys.Figure;

namespace lab3Deys.Creators
{
    public class BlueSquareCreator : SquareCreator
    {
        public override Square CreateSquare()
        {
            return new Square { Color = Colors.Blue };
        }
    }
}