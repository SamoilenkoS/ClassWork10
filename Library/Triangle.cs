using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class Triangle : IShape
    {
        private double _a;
        private double _b;
        private double _c;

        public double A
        {
            get => _a;
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException();
                }

                _a = value;
            }
        }

        public double B
        {
            get => _b;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _b = value;
            }
        }

        public double C
        {
            get => _c;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                _c = value;
            }
        }

        private Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public static Triangle Create(double a, double b, double c)
        {
            if(a > 0 && b > 0 && c > 0)
            {
                return new Triangle(a, b, c);
            }

            throw new ArgumentException();
        }

        public double GetPerimetr()
        {
            return A + B + C;
        }

        public double GetSquare()
        {
            return A * B * Math.Sin(C) / 2;
        }
    }
}
