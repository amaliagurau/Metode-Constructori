using System;

namespace Metode_Constructori
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 5);
            Point p2 = new Point(5, 5);
            Point p3 = new Point(5, 2);
            Point p4 = new Point(1, 2);
            Triangle Triunghi = new Triangle(p1, p2, p3);
            Triunghi.Print();
            Triunghi.Move(0, -1);
            Triunghi.Print();
           // Rectangle Dreptunghi = new Rectangle(p1, p3);
           // Dreptunghi.Move(1, 1);
           // Dreptunghi.Print();
            GeometryUtils.Print(Triunghi);
            GeometryUtils.Print(new Point[] { p1, p2, p3 });

        }
    }
}
