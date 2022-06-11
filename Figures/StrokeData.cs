//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System.Drawing;

namespace WinForms_GraphicEditor
{
    public struct StrokeData
    {
        public Color Color;
        public float Width;

        public StrokeData(Color color, float width)
        {
            Color = color;
            Width = width;
        }
    }
}
