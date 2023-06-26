using System.Collections;

namespace CSharpFom
{
    public class Point
    {
        private int _x; private int _y;
        public Point(int x, int y)
        {
            _x = x; _y = y;
        }
        public int x { get { return _x; } }
        public int y { get { return _y; } }

        public override string ToString()
        {
            return $"x: {x} | y: {y}";
        }

        public override bool Equals(object? obj)
        {
            if (obj is Point p)
            {
                if (p.x == x && p.y == y) return true;
                else return false;
            }
            return false;
        }
    }

    public class Programm
    {

        static int Main(string[] args)
        {
            Point point = new Point(4, 9);
            Point point2 = new Point(4, 9);
            Point point3 = new Point(9, 9);
            Console.WriteLine(point);
            Console.WriteLine(point.x);
            Console.WriteLine(point.y);
            if (point.Equals(point2))
            {
                Console.WriteLine("point und point2 sind gleich");
            }
            else
            {
                Console.WriteLine("point und point2 sind nicht gleich");
            }
            if (point.Equals(point3))
            {
                Console.WriteLine("point und point3 sind gleich");
            }
            else
            {
                Console.WriteLine("point und point3 sind nicht gleich");
            }
            return 0;
        }

    }
}