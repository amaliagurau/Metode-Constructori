using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metode_Constructori
{
    public static class GeometryUtils
    {
        public static void Point(Point[] points, int dx, int dy)
        { 
            for(int i=0; i<points.Length; i++)
            {
                points[i].Move(dx, dy);
            }
        }

        public static void Move(Triangle Triunghi, int dx, int dy)
        {
            Triunghi.A.X = Triunghi.A.X + dx;
            Triunghi.B.X = Triunghi.B.X + dx;
            Triunghi.C.X = Triunghi.C.X + dx;
            Triunghi.A.Y = Triunghi.A.Y + dy;
            Triunghi.B.Y = Triunghi.B.Y + dy;
            Triunghi.C.Y = Triunghi.C.Y + dy;
        }

        public static void Move(Rectangle Dreptunghi, int dx, int dy)
        {
            Dreptunghi.A.X = Dreptunghi.A.X + dx;
            Dreptunghi.B.X = Dreptunghi.B.X + dx;
            Dreptunghi.C.X = Dreptunghi.B.X + dx;
            Dreptunghi.D.X = Dreptunghi.D.X + dx;
            Dreptunghi.A.Y = Dreptunghi.A.Y + dy;
            Dreptunghi.B.Y = Dreptunghi.B.Y + dy;
            Dreptunghi.C.Y = Dreptunghi.B.Y + dy;
            Dreptunghi.D.Y = Dreptunghi.D.Y + dy;
        }

        public static void Print(Point[] points)
        {
            for(int i=0; i<points.Length; i++)
            {
                Console.WriteLine($"X[{i}] =" + points[i].X);
                Console.WriteLine($"Y[{i}] =" + points[i].Y);
            }
        }

        public static void Print(Triangle Triunghi)
        {
            Console.WriteLine("A" + Triunghi.A.X + " " + Triunghi.A.Y);
            Console.WriteLine("B" + Triunghi.B.X + " " + Triunghi.B.Y);
            Console.WriteLine("C" + Triunghi.C.X + " " + Triunghi.C.Y);
        }

        public static void Print(Rectangle Dreptunghi)
        {
            Console.WriteLine("A" + Dreptunghi.A.X + " " + Dreptunghi.A.Y);
            Console.WriteLine("B" + Dreptunghi.B.X + " " + Dreptunghi.B.Y);
            Console.WriteLine("C" + Dreptunghi.C.X + " " + Dreptunghi.C.Y);
            Console.WriteLine("C" + Dreptunghi.D.X + " " + Dreptunghi.D.Y);
        }
    }
}
