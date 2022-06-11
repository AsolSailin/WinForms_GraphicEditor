//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    class Figure
    {
        protected Point basePoint;
        protected StrokeData pen;

        public Figure(Point point, StrokeData pencil)
        {
            pen = pencil;
            basePoint = point;
        }

        public virtual void Draw(Graphics g)
        {
            
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
