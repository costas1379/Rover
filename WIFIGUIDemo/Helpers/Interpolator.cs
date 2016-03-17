namespace WIFIGUIDemo.Helpers
{
    using System.Collections.Generic;
    using System.Linq;

    public static class Interpolator
    {
        public static Vector2 Trilaterate(IList<Vector2Distance> vectors)
        {
            Vector2Distance[] availableVectors = vectors.Where(r => r.R > 0).Take(3).ToArray();

            if (availableVectors.Length < 3)
            {
                return null;
            }

            return Trilaterate(availableVectors[0], availableVectors[1], availableVectors[2]) 
                ?? Trilaterate(availableVectors[1], availableVectors[0], availableVectors[2])
                ?? Trilaterate(availableVectors[0], availableVectors[2], availableVectors[1])
                ?? Trilaterate(availableVectors[2], availableVectors[0], availableVectors[1])
                ?? Trilaterate(availableVectors[1], availableVectors[2], availableVectors[0])
                ?? Trilaterate(availableVectors[2], availableVectors[1], availableVectors[0]);
        }

        private static Vector2 Trilaterate(Vector2Distance p1, Vector2Distance p2, Vector2Distance p3)
        {
            double va = ((p2.R * p2.R - p3.R * p3.R) - (p2.X * p2.X - p3.X * p3.X) - (p2.Y * p2.Y - p3.Y * p3.Y)) / 2d;
            double vb = ((p2.R * p2.R - p1.R * p1.R) - (p2.X * p2.X - p1.X * p1.X) - (p2.Y * p2.Y - p1.Y * p1.Y)) / 2d;
            double temp1 = vb * (p3.X - p2.X) - va * (p1.X - p2.X);
            double temp2 = (p1.Y - p2.Y) * (p3.X - p2.X) - (p3.Y - p2.Y) * (p1.X - p2.X);
            double y = temp1 / temp2;
            double x = (va - y * (p3.Y - p2.Y)) / (p3.X - p2.X);

            if (double.IsNaN(x) || double.IsNaN(y))
            {
                return null;
            }

            return new Vector2(x, y);
        }
    }
}
