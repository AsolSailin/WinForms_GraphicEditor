//Garaeva Ruslana, Geometric Task 4, 220, 06.22

using System;
using System.IO;
using System.Drawing;
using System.Collections.Generic;

namespace WinForms_GraphicEditor
{
    class Figures
    {
        public List<Figure> figures;
        public Pen pen;

        public Figures()
        {
            figures = new List<Figure>();
        }

        public void Add(Figure figure)
        {
            figures.Add(figure);
        }

        public void Save(string path)
        {
            StreamWriter stream = null;

            try
            {
                stream = new StreamWriter(File.Open(path, FileMode.Create));

                foreach (var f in figures)
                {
                    stream.WriteLine(f);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Save Error!");
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        public void Load(string path)
        {
            StreamReader stream = null;
            string str;
            string[] str2;
            int r, g, b, w, x1, y1, x2;

            try
            {
                stream = new StreamReader(File.Open(path, FileMode.Open));

                while ((str = stream.ReadLine()) != null)
                {
                    str2 = str.Split(' ');
                    r = int.Parse(str2[1]);
                    g = int.Parse(str2[2]);
                    b = int.Parse(str2[3]);
                    w = int.Parse(str2[4]);
                    x1 = int.Parse(str2[5]);
                    y1 = int.Parse(str2[6]);
                    x2 = int.Parse(str2[7]);
                    var pen = new StrokeData(Color.FromArgb(r, g, b), w);

                    switch (str2[0])
                    {
                        case ("Line"):
                            figures.Add(new Line(pen, new Point(x1, y1),
                                new Point(x2, int.Parse(str2[8]))));
                            break;

                        case ("Triangle"):
                            figures.Add(new Triangle(pen, new Point(x1, y1),
                                new Point(x2, int.Parse(str2[8])),
                                new Point(int.Parse(str2[9]),
                                int.Parse(str2[10]))));
                            break;

                        case ("Rectangle"):
                            figures.Add(new Rectangle(pen, new Point(x1, y1), 
                                int.Parse(str2[8]), x2));
                            break;

                        case ("Circle"):
                            figures.Add(new Circle(pen, new Point(x1, y1), x2));
                            break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Load Error!");
            }
            finally
            {
                if (stream != null) stream.Close();
            }
        }

        public virtual void Draw(Graphics g)
        {
            foreach (var f in figures)
            {
                f.Draw(g);
            }
        }

        public void ClearList()
        {
            figures.Clear();
        }
    }
}