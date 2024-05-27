using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Task2
{
    internal class TestDrawing : Control
    {
        protected override void OnRender(DrawingContext drawingContext)
        {
            base.OnRender(drawingContext);
            DrawShapes(drawingContext);
        }

        private void DrawShapes(DrawingContext drawingContext)
        {
            DrawPolygon(drawingContext, new Point(100, 50), new Point(150, 150), new Point(50, 150));
            DrawEllipse(drawingContext, new Point(200, 80), 50, 30);
            DrawFilledCircle(drawingContext, new Point(350, 75), 25);
            DrawFilledRectangle(drawingContext, new Point(450, 75), 50, 25);
            DrawSector(drawingContext, new Point(600, 100), 50);
            DrawConcentricCircles(drawingContext, new Point(50, 300), 30);
            DrawOverlappingRectangles(drawingContext, new Point(200, 300));
            DrawCheckerboard(drawingContext, new Point(400, 300), 40, 8);
        }

        private void DrawPolygon(DrawingContext drawingContext, params Point[] points)
        {
            StreamGeometry geometry = new StreamGeometry();
            using (StreamGeometryContext ctx = geometry.Open())
            {
                ctx.BeginFigure(points[0], true, true);
                ctx.PolyLineTo(points.Skip(1).ToArray(), true, true);
            }
            drawingContext.DrawGeometry(null, new Pen(Brushes.Black, 2), geometry);
        }

        private void DrawEllipse(DrawingContext drawingContext, Point center, double width, double height)
        {
            drawingContext.DrawEllipse(null, new Pen(Brushes.Black, 2), center, width, height);
        }

        private void DrawFilledCircle(DrawingContext drawingContext, Point center, double radius)
        {
            drawingContext.DrawEllipse(Brushes.Blue, new Pen(Brushes.Black, 2), center, radius, radius);
        }

        private void DrawFilledRectangle(DrawingContext drawingContext, Point topLeft, double width, double height)
        {
            drawingContext.DrawRectangle(Brushes.Blue, new Pen(Brushes.Black, 2), new Rect(topLeft, new Size(width, height)));
        }

        private void DrawSector(DrawingContext drawingContext, Point center, double radius)
        {
            PathGeometry geometry = new PathGeometry();
            PathFigure figure = new PathFigure { StartPoint = center };
            ArcSegment arc = new ArcSegment
            {
                Point = new Point(center.X + radius, center.Y),
                Size = new Size(radius, radius),
                SweepDirection = SweepDirection.Clockwise,
                IsLargeArc = true
            };
            LineSegment line = new LineSegment { Point = center };
            figure.Segments.Add(arc);
            figure.Segments.Add(line);
            geometry.Figures.Add(figure);

            drawingContext.DrawGeometry(Brushes.Yellow, new Pen(Brushes.Black, 2), geometry);
        }

        private void DrawConcentricCircles(DrawingContext drawingContext, Point center, double initialRadius)
        {
            double radius = initialRadius;
            for (int i = 0; i < 3; i++)
            {
                drawingContext.DrawEllipse(null, new Pen(Brushes.Black, 2), center, radius, radius);
                radius -= 10;
            }
        }

        private void DrawOverlappingRectangles(DrawingContext drawingContext, Point start, int count = 5)
        {
            for (int i = 0; i < count; i++)
            {
                drawingContext.DrawRectangle(null, new Pen(Brushes.Black, 2), new Rect(new Point(start.X + i * 20, start.Y + i * 20), new Size(40, 60)));
            }
        }

        private void DrawCheckerboard(DrawingContext drawingContext, Point topLeft, double size, int gridSize)
        {
            for (int row = 0; row < gridSize; row++)
            {
                for (int col = 0; col < gridSize; col++)
                {
                    bool isWhite = (row + col) % 2 == 0;
                    drawingContext.DrawRectangle(isWhite ? Brushes.White : Brushes.Black, null, new Rect(new Point(topLeft.X + col * size, topLeft.Y + row * size), new Size(size, size)));
                }
            }
        }
    }
}
