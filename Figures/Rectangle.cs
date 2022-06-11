//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    class Rectangle : Figure
    {
        public int Height;
        public int Width;

        public Rectangle(StrokeData pencil, Point point, int height, int width) 
            : base(point, pencil)
        {
            Height = height;
            Width = width;
        }

        public override void Draw(Graphics g)
        {
            var p = new Pen(pen.Color, pen.Width);
            g.DrawRectangle(p, basePoint.X, basePoint.Y, Width, Height);
        }

        public override string ToString()
        {
            return "Rectangle " + pen.Color.R + " " + pen.Color.G + " " +
                pen.Color.B + " " + pen.Width + " " + basePoint.X + " " +
                basePoint.Y + " " + Width + " " + Height;
            
            //return "Rectangle >> Start_point:" + basePoint.ToString() + 
            //    " Width=" + Width.ToString() + " Height=" + Height.ToString() +
            //    " " + pen.Color + " Pen_width [" + pen.Width + "]";
        }
    }
}