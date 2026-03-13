using lab3Deys.Creators;
using lab3Deys.Factories;
using System.Windows;
using System.Windows.Controls;

namespace lab3Deys
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Loaded += MainWindow_Loaded;
            
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            RedrawFigures();
        }

        private void ColorComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (FiguresPanel == null || ColorComboBox == null)
                return;

            RedrawFigures();
        }

        private void RedrawFigures()
        {
            if (FiguresPanel == null || ColorComboBox == null)
                return;

            FiguresPanel.Children.Clear();

            if (ColorComboBox.SelectedItem is not ComboBoxItem selectedItem)
                return;
            CircleCreator circleCreator;
            SquareCreator squareCreator;
            TriangleCreator triangleCreator;

            switch (selectedItem.Content.ToString())
            {
                case "Красный":
                    circleCreator = new RedCircleCreator();
                    squareCreator = new RedSquareCreator();
                    triangleCreator = new RedTriangleCreator();
                    break;

                case "Синий":
                    circleCreator = new BlueCircleCreator();
                    squareCreator = new BlueSquareCreator();
                    triangleCreator = new BlueTriangleCreator();
                    break;

                case "Зелёный":
                    circleCreator = new GreenCircleCreator();
                    squareCreator = new GreenSquareCreator();
                    triangleCreator = new GreenTriangleCreator();
                    break;

                default:
                    return;
            }

            var circle = circleCreator.CreateCircle();
            var square = squareCreator.CreateSquare();
            var triangle = triangleCreator.CreateTriangle();

            FiguresPanel.Children.Add(circle.CreateUIElement());
            FiguresPanel.Children.Add(square.CreateUIElement());
            FiguresPanel.Children.Add(triangle.CreateUIElement());


            //IFigureFactory factory;

            //switch (selectedItem.Content.ToString())
            //{
            //    case "Красный":
            //        factory = new RedFactory();
            //        break;

            //    case "Синий":
            //        factory = new BlueFactory();
            //        break;

            //    case "Зелёный":
            //        factory = new GreenFactory();
            //        break;

            //    default:
            //        return;
            //}

            //var circle = factory.CreateCircle();
            //var square = factory.CreateSquare();
            //var triangle = factory.CreateTriangle();

            //FiguresPanel.Children.Add(circle.CreateUIElement());
            //FiguresPanel.Children.Add(square.CreateUIElement());
            //FiguresPanel.Children.Add(triangle.CreateUIElement());
        }

    }
}