//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System;
using System.Linq;
using System.Text;
using System.Data;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace WinForms_GraphicEditor
{
    public partial class GraphicEditor : Form
    {
        private Point start;
        private Point end;
        private string draw;
        private Figures figures;
        private Figure figure;
        Pen pencil = new Pen(Color.Black, 1.0F);

        public GraphicEditor()
        {
            figures = new();
            InitializeComponent();
            typeof(Panel).InvokeMember("DoubleBuffered",
                BindingFlags.SetProperty | BindingFlags.Instance |
                BindingFlags.NonPublic,
                null, paper, new object[] { true });
        }

        private void GraphicEditor_MouseUp(object sender, MouseEventArgs e) // отпустить кнопку мышки
        {
            end.X = e.X; 
            end.Y = e.Y;

            if (figure != null)
            {
                figures.Add(figure);
            }

            paper.Invalidate();
        }

        private void GraphicEditor_MouseDown(object sender, MouseEventArgs e) // нажать кнопку мышки
        {
            if (e.Button == MouseButtons.Left)
            {
                start.X = e.X;
                start.Y = e.Y;
            }
        }

        private void GraphicEditor_MouseMove(object sender, MouseEventArgs e) // рисование
        {
            if (e.Button == MouseButtons.Left)
            {
                end.X = e.X; 
                end.Y = e.Y;
                UpdateFigure();
                paper.Invalidate();
            }
        }

        private void UpdateFigure()
        {
            var pen = new StrokeData(pencil.Color, pencil.Width);
            switch (draw)
            {
                case "Line":
                    figure = new Line(pen, start, end);
                    break;
                case "Rectangle":
                    figure = new Rectangle(pen, start, Math.Abs(end.Y - start.Y),
                        Math.Abs(end.X - start.X));
                    break;
                case "Triangle":
                    figure = new Triangle(pen, new Point { X = start.X, Y = end.Y },
                        new Point { X = (start.X + end.X) / 2, Y = start.Y }, end);
                    break;
                case "Circle":
                    figure = new Circle(pen, start, Math.Abs(end.X - start.X));
                    break;
            }
        }

        private void GraphicEditor_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphic = e.Graphics;
            figures.Draw(graphic);
            figure?.Draw(graphic);
        }

        private void btn_Line_Click(object sender, EventArgs e)
        {
            draw = "Line";
        }

        private void btn_Rectangle_Click(object sender, EventArgs e)
        {
            draw = "Rectangle";
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            draw = "Circle";
        }

        private void btn_Triangle_Click(object sender, EventArgs e)
        {
            draw = "Triangle";
        }

        private void btn_Color_Click(object sender, EventArgs e)
        {
            if(colorDialog.ShowDialog() == DialogResult.OK)
            {
                pencil.Color = colorDialog.Color;
            }
        }

        private void trackBar_LineWidth_Scroll(object sender, EventArgs e)
        {
            pencil.Width = trackBar_LineWidth.Value;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = "TXT(*.TXT)|*.txt";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                figures.Save(saveFileDialog.FileName);
            }
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            openFileDialog.Filter = "TXT(*.TXT)|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                figures.ClearList();
                figure = null;
                figures.Load(openFileDialog.FileName);
                paper.Invalidate();
            }
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            figures.ClearList();
            figure = null;
            paper.Invalidate();
        }
    }
}
