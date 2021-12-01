using System;

namespace Library
{
    public class Rectangle : IShape
    {
        private const string ErrorMessage = 
            "Value should be greater than zero!";
        private double _a;
        private double _b;

        public double A
        {
            get
            {
                return _a;
            }
            set
            {
                if(value <= 0)
                {
                    throw new ArgumentException(ErrorMessage);
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
                    throw new ArgumentException(ErrorMessage);
                }

                _b = value;
            }
        }

        public double Perimetr => GetPerimetr();

        public double Square => GetSquare();

        private Rectangle(double a, double b)
        {
            A = a;
            B = b;
        }

        public static Rectangle Create(double a, double b)
        {
            if(a > 0 && b > 0)
            {
                return new Rectangle(a, b);
            }

            throw new ArgumentException(ErrorMessage);
        }

        public static Rectangle operator *(Rectangle rectangle, double n)
        {
            return new Rectangle(rectangle.A * n, rectangle.B * n);
        }

        public double GetPerimetr()
        {
            return (A + B) * 2;
        }

        public double GetSquare()
        {
            return A * B;
        }

        public void IncreaseSize(double n)
        {
            A *= n;
            B *= n;
        }

        public override string ToString()
        {
            return $"{A}:{B}";
        }
    }
}
