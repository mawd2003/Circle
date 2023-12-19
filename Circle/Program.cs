using System;

namespace Circle
{
    public class Circle
    {
        double PI = 3.14;
        private double radius;

        public double Radius
        {
            get { return radius; }

            set
            {
                if (value > 0)
                {
                    radius = value;
                }
            }
        }

        public Circle() { }

        public Circle(double Radius)
        {
            radius = Radius;
        }

        public double S()
        {
            double result = PI * radius * radius;
            return result;
        }

        public double A()
        {
            double Result = 2 * PI * radius;
            return Result;
        }
    }
    class main
    {
        public static void Main()
        {
            Console.WriteLine("Enter Radius :");
            double r = Convert.ToDouble(Console.ReadLine());
            Circle circle = new Circle(r);
            double a = circle.A();
            double s = circle.S();
            Console.WriteLine("Mohit : {0}", a);
            Console.WriteLine("Masahat : {0}", s);
            Console.ReadKey();

        }
    }
}

