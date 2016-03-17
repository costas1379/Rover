namespace WIFIGUIDemo.Helpers
{
    public class Vector2Distance : Vector2
    {
        public double R { get; set; }

        protected Vector2Distance(double x, double y) : base(x, y)
        {
        }

        public Vector2Distance(double x, double y, double r) : base(x, y)
        {
            this.R = r;
        }
    }
}