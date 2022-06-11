//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    class Circle : Figure
    {
        public int Radius;

        public Circle(StrokeData pencil, Point point, int radius) 
            : base(point, pencil)
        {
            Radius = radius;
        }

        public override void Draw(Graphics g)
        {
            var p = new Pen(pen.Color, pen.Width);
            g.DrawEllipse(p, basePoint.X - Radius, 
                basePoint.Y - Radius, Radius * 2, Radius * 2);
        }

        public override string ToString()
        {
            return "Circle " + pen.Color.R + " " + pen.Color.G + " " +
                pen.Color.B + " " + pen.Width + " " + basePoint.X + " " + 
                basePoint.Y + " " + Radius;

            //return "Circle >>" + " Center_point:" + basePoint.ToString() + 
            //    " Radius=" + Radius.ToString() + " " + pen.Color +
            //    " Pen_width [" + pen.Width + "]";
        }
    }
}