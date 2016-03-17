namespace WIFIGUIDemo.Helpers
{
    using System;

    public class Vector2
    {
        public double X { get; set; }
        public double Y { get; set; }

        public Vector2(double x, double y)
        {
            this.X = x;
            this.Y = y;
        }

        public static Vector2 operator +(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X + b.X, a.Y + b.Y);
        }

        public static Vector2 operator -(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X - b.X, a.Y - b.Y);
        }

        public static Vector2 operator /(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X / b.X, a.Y / b.Y);
        }

        public static Vector2 operator /(Vector2 a, double b)
        {
            return new Vector2(a.X / b, a.Y / b);
        }

        public static Vector2 operator *(Vector2 a, Vector2 b)
        {
            return new Vector2(a.X * b.X, a.Y * b.Y);
        }

        public static Vector2 operator *(Vector2 a, double b)
        {
            return new Vector2(a.X * b, a.Y * b);
        }

        public double Norm()
        {
            return Math.Sqrt(Math.Pow(X, 2) + Math.Pow(Y, 2));
        }

        public double Dot(Vector2 other)
        {
            return X * other.X + Y * other.Y;
        }

        public Vector2 Cross(Vector2 other)
        {
            return new Vector2(
                x: Y * other.Y - Y * other.Y,
                y: X * other.X - X * other.X
                );
        }
    }
}