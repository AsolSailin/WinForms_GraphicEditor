//Garaeva Ruslana, Geometric Task 4, 220, .06.22

namespace WinForms_GraphicEditor
{
    partial class GraphicEditor
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_Line = new System.Windows.Forms.Button();
            this.btn_Circle = new System.Windows.Forms.Button();
            this.btn_Triangle = new System.Windows.Forms.Button();
            this.btn_Rectangle = new System.Windows.Forms.Button();
            this.panel_Figures = new System.Windows.Forms.Panel();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.paper = new System.Windows.Forms.Panel();
            this.panel_Navigation = new System.Windows.Forms.Panel();
            this.label = new System.Windows.Forms.Label();
            this.btn_Load = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Color = new System.Windows.Forms.Button();
            this.trackBar_LineWidth = new System.Windows.Forms.TrackBar();
            this.colorDialog = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.panel_Figures.SuspendLayout();
            this.panel_Navigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LineWidth)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Line
            // 
            this.btn_Line.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Line.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Line.Location = new System.Drawing.Point(12, 23);
            this.btn_Line.Name = "btn_Line";
            this.btn_Line.Size = new System.Drawing.Size(75, 23);
            this.btn_Line.TabIndex = 4;
            this.btn_Line.Text = "Line";
            this.btn_Line.UseVisualStyleBackColor = false;
            this.btn_Line.Click += new System.EventHandler(this.btn_Line_Click);
            // 
            // btn_Circle
            // 
            this.btn_Circle.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Circle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Circle.Location = new System.Drawing.Point(174, 23);
            this.btn_Circle.Name = "btn_Circle";
            this.btn_Circle.Size = new System.Drawing.Size(75, 23);
            this.btn_Circle.TabIndex = 6;
            this.btn_Circle.Text = "Circle";
            this.btn_Circle.UseVisualStyleBackColor = false;
            this.btn_Circle.Click += new System.EventHandler(this.btn_Circle_Click);
            // 
            // btn_Triangle
            // 
            this.btn_Triangle.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Triangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Triangle.Location = new System.Drawing.Point(255, 23);
            this.btn_Triangle.Name = "btn_Triangle";
            this.btn_Triangle.Size = new System.Drawing.Size(75, 23);
            this.btn_Triangle.TabIndex = 7;
            this.btn_Triangle.Text = "Triangle";
            this.btn_Triangle.UseVisualStyleBackColor = false;
            this.btn_Triangle.Click += new System.EventHandler(this.btn_Triangle_Click);
            // 
            // btn_Rectangle
            // 
            this.btn_Rectangle.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Rectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Rectangle.Location = new System.Drawing.Point(93, 23);
            this.btn_Rectangle.Name = "btn_Rectangle";
            this.btn_Rectangle.Size = new System.Drawing.Size(75, 23);
            this.btn_Rectangle.TabIndex = 8;
            this.btn_Rectangle.Text = "Rectangle";
            this.btn_Rectangle.UseVisualStyleBackColor = false;
            this.btn_Rectangle.Click += new System.EventHandler(this.btn_Rectangle_Click);
            // 
            // panel_Figures
            // 
            this.panel_Figures.BackColor = System.Drawing.Color.Lavender;
            this.panel_Figures.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Figures.Controls.Add(this.btn_Line);
            this.panel_Figures.Controls.Add(this.btn_Triangle);
            this.panel_Figures.Controls.Add(this.btn_Rectangle);
            this.panel_Figures.Controls.Add(this.btn_Clear);
            this.panel_Figures.Controls.Add(this.btn_Circle);
            this.panel_Figures.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_Figures.Location = new System.Drawing.Point(145, 0);
            this.panel_Figures.Name = "panel_Figures";
            this.panel_Figures.Size = new System.Drawing.Size(655, 69);
            this.panel_Figures.TabIndex = 9;
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Location = new System.Drawing.Point(539, 23);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(104, 23);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // paper
            // 
            this.paper.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.paper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.paper.Location = new System.Drawing.Point(145, 69);
            this.paper.Name = "paper";
            this.paper.Size = new System.Drawing.Size(655, 381);
            this.paper.TabIndex = 10;
            this.paper.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicEditor_Paint);
            this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseDown);
            this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseMove);
            this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseUp);
            // 
            // panel_Navigation
            // 
            this.panel_Navigation.BackColor = System.Drawing.Color.Lavender;
            this.panel_Navigation.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel_Navigation.Controls.Add(this.label);
            this.panel_Navigation.Controls.Add(this.btn_Load);
            this.panel_Navigation.Controls.Add(this.btn_Save);
            this.panel_Navigation.Controls.Add(this.btn_Color);
            this.panel_Navigation.Controls.Add(this.trackBar_LineWidth);
            this.panel_Navigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Navigation.Location = new System.Drawing.Point(0, 0);
            this.panel_Navigation.Name = "panel_Navigation";
            this.panel_Navigation.Size = new System.Drawing.Size(145, 450);
            this.panel_Navigation.TabIndex = 0;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.BackColor = System.Drawing.Color.GhostWhite;
            this.label.Location = new System.Drawing.Point(43, 115);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(62, 15);
            this.label.TabIndex = 14;
            this.label.Text = "Line width";
            this.label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Load
            // 
            this.btn_Load.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Load.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Load.Location = new System.Drawing.Point(22, 406);
            this.btn_Load.Name = "btn_Load";
            this.btn_Load.Size = new System.Drawing.Size(104, 23);
            this.btn_Load.TabIndex = 13;
            this.btn_Load.Text = "Load";
            this.btn_Load.UseVisualStyleBackColor = false;
            this.btn_Load.Click += new System.EventHandler(this.btn_Load_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Save.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Save.Location = new System.Drawing.Point(22, 377);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(104, 23);
            this.btn_Save.TabIndex = 12;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Color
            // 
            this.btn_Color.BackColor = System.Drawing.Color.MediumPurple;
            this.btn_Color.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Color.Location = new System.Drawing.Point(22, 23);
            this.btn_Color.Name = "btn_Color";
            this.btn_Color.Size = new System.Drawing.Size(104, 45);
            this.btn_Color.TabIndex = 10;
            this.btn_Color.Text = "Line color";
            this.btn_Color.UseVisualStyleBackColor = false;
            this.btn_Color.Click += new System.EventHandler(this.btn_Color_Click);
            // 
            // trackBar_LineWidth
            // 
            this.trackBar_LineWidth.BackColor = System.Drawing.Color.GhostWhite;
            this.trackBar_LineWidth.Cursor = System.Windows.Forms.Cursors.NoMoveHoriz;
            this.trackBar_LineWidth.Location = new System.Drawing.Point(22, 85);
            this.trackBar_LineWidth.Name = "trackBar_LineWidth";
            this.trackBar_LineWidth.Size = new System.Drawing.Size(104, 45);
            this.trackBar_LineWidth.TabIndex = 9;
            this.trackBar_LineWidth.Scroll += new System.EventHandler(this.trackBar_LineWidth_Scroll);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            // 
            // GraphicEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.paper);
            this.Controls.Add(this.panel_Figures);
            this.Controls.Add(this.panel_Navigation);
            this.Name = "GraphicEditor";
            this.Text = "GraphicEditor";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphicEditor_Paint);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.GraphicEditor_MouseUp);
            this.panel_Figures.ResumeLayout(false);
            this.panel_Navigation.ResumeLayout(false);
            this.panel_Navigation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_LineWidth)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_Line;
        private System.Windows.Forms.Button btn_Circle;
        private System.Windows.Forms.Button btn_Triangle;
        private System.Windows.Forms.Button btn_Rectangle;
        private System.Windows.Forms.Panel panel_Figures;
        private System.Windows.Forms.Panel paper;
        private System.Windows.Forms.Panel panel_Navigation;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button btn_Load;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Button btn_Color;
        private System.Windows.Forms.TrackBar trackBar_LineWidth;
        private System.Windows.Forms.ColorDialog colorDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
    }
}

