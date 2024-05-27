using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Task1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DrawShapes();
        }

        private void DrawShapes()
        {
            DrawPolygon(100, 50, 150, 150, 50, 150);
            DrawEllipse(200, 50, 100, 60);
            DrawFilledCircle(350, 50, 50);
            DrawFilledRectangle(450, 50, 100, 50);
            DrawSector(600, 100, 50);
            DrawConcentricCircles(50, 300, 30);
            DrawOverlappingRectangles(200, 300);
            DrawCheckerboard(400, 300, 40, 8);
        }

        private void DrawPolygon(double x1, double y1, double x2, double y2, double x3, double y3)
        {
            Polygon triangle = new Polygon
            {
                Points = new PointCollection(new Point[]
                {
                    new Point(x1, y1),
                    new Point(x2, y2),
                    new Point(x3, y3)
                }),
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            canvas.Children.Add(triangle);
        }

        private void DrawEllipse(double left, double top, double width, double height)
        {
            Ellipse ellipse = new Ellipse
            {
                Width = width,
                Height = height,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(ellipse, left);
            Canvas.SetTop(ellipse, top);
            canvas.Children.Add(ellipse);
        }

        private void DrawFilledCircle(double left, double top, double diameter)
        {
            Ellipse filledCircle = new Ellipse
            {
                Width = diameter,
                Height = diameter,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(filledCircle, left);
            Canvas.SetTop(filledCircle, top);
            canvas.Children.Add(filledCircle);
        }

        private void DrawFilledRectangle(double left, double top, double width, double height)
        {
            Rectangle filledRectangle = new Rectangle
            {
                Width = width,
                Height = height,
                Fill = Brushes.Blue,
                Stroke = Brushes.Black,
                StrokeThickness = 2
            };
            Canvas.SetLeft(filledRectangle, left);
            Canvas.SetTop(filledRectangle, top);
            canvas.Children.Add(filledRectangle);
        }

        private void DrawSector(double centerX, double centerY, double radius)
        {
            System.Windows.Shapes.Path sector = new System.Windows.Shapes.Path
            {
                Fill = Brushes.Yellow,
                Stroke = Brushes.Black,
                StrokeThickness = 2,
                Data = Geometry.Parse($"M {centerX},{centerY} A {radius},{radius} 0 1 1 {centerX + radius},{centerY + radius} L {centerX},{centerY}")
            };
            canvas.Children.Add(sector);
        }

        private void DrawConcentricCircles(double x, double y, double radius)
        {
            for (int i = 0; i < 3; i++)
            {
                Ellipse circle = new Ellipse
                {
                    Width = radius * 2,
                    Height = radius * 2,
                    Stroke = Brushes.Black,
                    StrokeThickness = 2
                };
                Canvas.SetLeft(circle, x - radius);
                Canvas.SetTop(circle, y - radius);
                canvas.Children.Add(circle);
                radius -= 10;
            }
        }

        private void DrawOverlappingRectangles(double x, double y)
        {
            for (int i = 0; i < 5; i++)
            {
                Rectangle rect = new Rectangle
                {
                    Width = 40,
                    Height = 60,
                    Stroke = Brushes.Black,
                    StrokeThickness = 2
                };
                Canvas.SetLeft(rect, x + i * 20);
                Canvas.SetTop(rect, y + i * 20);
                canvas.Children.Add(rect);
            }
        }

        private void DrawCheckerboard(double x, double y, double size, int gridSize)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    Rectangle rect = new Rectangle
                    {
                        Width = size,
                        Height = size,
                        Fill = (row + col) % 2 == 0 ? Brushes.White : Brushes.Black
                    };
                    Canvas.SetLeft(rect, x + col * size);
                    Canvas.SetTop(rect, y + row * size);
                    canvas.Children.Add(rect);
                }
            }
        }
    }
}
