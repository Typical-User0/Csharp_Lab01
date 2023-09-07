
namespace TestProject2
{


    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestRect()
        {
            Rectangle rectangle1 = new Rectangle(3.0, 4.0);
            Console.WriteLine($"Тест 1: Периметр = {rectangle1.Perimeter}, Площадь = {rectangle1.Area}");

            Rectangle rectangle2 = new Rectangle(5.5, 7.2);
            Console.WriteLine($"Тест 2: Периметр = {rectangle2.Perimeter}, Площадь = {rectangle2.Area}");
        }

        [TestMethod]
        public void TestFigure()
        {
            Point point1 = new Point(0, 0);
            Point point2 = new Point(0, 3);
            Point point3 = new Point(4, 0);

            Figure triangle = new Figure(point1, point2, point3);
            triangle.Name = "Треугольник";
            triangle.PerimeterCalculator();
        }
    }
}