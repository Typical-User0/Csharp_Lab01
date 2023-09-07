namespace ConsoleApp6
{


    public class Point
    {
        public int X;
        public int Y;

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    public class Figure
    {
        private Point[] points;
        public string Name { get; set; }

        public Figure(Point point1, Point point2, Point point3)
        {
            points = new Point[] { point1, point2, point3 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            points = new Point[] { point1, point2, point3, point4 };
        }

        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            points = new Point[] { point1, point2, point3, point4, point5 };
        }

        private double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow(B.X - A.X, 2) + Math.Pow(B.Y - A.Y, 2));
        }

        public void PerimeterCalculator()
        {
            double perimeter = 0;
            int numPoints = points.Length;

            for (int i = 0; i < numPoints; i++)
            {
                int nextIndex = (i + 1) % numPoints;
                perimeter += LengthSide(points[i], points[nextIndex]);
            }

            Console.WriteLine($"Название фигуры: {Name}");
            Console.WriteLine($"Периметр фигуры: {perimeter}");
        }
    }

    class Program
    {
        static void Main()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 4);
            Point point3 = new Point(3, 0);

            Figure triangle = new Figure(point1, point2, point3);
            triangle.Name = "Треугольник";
            triangle.PerimeterCalculator();

            Point point4 = new Point(0, 0);
            Point point5 = new Point(0, 4);
            Point point6 = new Point(3, 4);
            Point point7 = new Point(3, 0);

            Figure quadrilateral = new Figure(point4, point5, point6, point7);
            quadrilateral.Name = "Четырехугольник";
            quadrilateral.PerimeterCalculator();
        }
    }
}