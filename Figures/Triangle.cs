//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    class Triangle : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;
        public Point C;
        Point[] points;

        public Triangle(StrokeData pencil, Point a, Point b, Point c) 
            : base(a, pencil)
        {
            B = b;
            C = c;
            points = new[] { A, B, C };
        }

        public override void Draw(Graphics g)
        {
            var p = new Pen(pen.Color, pen.Width);
            g.DrawPolygon(p, points);
        }

        public override string ToString()
        {
            return "Triangle " + pen.Color.R + " " + pen.Color.G + " " +
                pen.Color.B + " " + pen.Width + " " + A.X + " " + A.Y + " " +
                B.X + " " + B.Y + " " + C.X + " " + C.Y;
                

            //return "Triangle >> Point_1:" + A.ToString() + 
            //    " Point_2:" + B.ToString() + " Point_3:" + 
            //    C.ToString() + " " + pen.Color + 
            //    " Pen_width [" + pen.Width + "]";
        }
    }
}