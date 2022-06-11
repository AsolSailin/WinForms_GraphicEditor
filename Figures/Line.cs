//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    class Line : Figure
    {
        public Point A
        {
            get { return basePoint; }
            set { basePoint = value; }
        }
        public Point B;

        public Line(StrokeData pencil, Point a, Point b) 
            : base(a, pencil)
        {
            B = b;
        }

        public override void Draw(Graphics g)
        {
            var p = new Pen(pen.Color, pen.Width);
            g.DrawLine(p, basePoint, B);
        }

        public override string ToString()
        {
            return "Line " + pen.Color.R + " " + pen.Color.G + " " + 
                pen.Color.B + " " + pen.Width + " " + A.X + " " + 
                A.Y + " " + B.X + " " + B.Y;

            //return "Line >> Start_point:" + A.ToString() + " End_point:" + B.ToString() +
            //    " " + pen.Color + " Pen_width [" + pen.Width + "]";
        }
    }
}