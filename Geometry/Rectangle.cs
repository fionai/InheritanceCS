﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Drawing;

namespace Geometry
{
    internal class Rectangle:Shape, IHaveDiagonal
    {
        double width;
        double height;
        public double Width
        {
            get => width;
            set => width = FilterSize(value);

        }
        public double Height
        {
            get => height;
            set => height = FilterSize(value);
        }
        public Rectangle
            (
            double width, double height,
            int startX, int startY, int lineWidth, Color color
            ):base( startX, startY, lineWidth, color )
        {
            Width = width;
            Height = height;
        }
        public double GetDiagonal()
        {
            return Math.Sqrt( Width * Width + Height * Height );
        }
        public override double GetArea()
        {
            return Width * Height;
        }
        public override double GetPerimeter()
        {
            return (Width + Height) * 2;
        }
        public override void Draw(PaintEventArgs e)
        {
            Pen pen = new Pen(Color, LineWidth);
            e.Graphics.DrawRectangle(pen, StartX, StartY, (float)Width, (float)Height);
        }
        public void DrawDiagonal(PaintEventArgs e) 
        {
            Pen pen = new Pen(Color, 1);
            e.Graphics.DrawLine
                (
                pen, 
                StartX, StartY, 
                (int)(StartX + Width), (int)(StartY + Height)
                );
        }
        public override void Info(PaintEventArgs e)
        {
            Console.Write($"Ширина: {Width} ");
            Console.Write($"Высота: {Height} ");
            Console.Write($"Диагональ: {GetDiagonal()}\n");
            base.Info(e);
            DrawDiagonal(e);
        }
    }
}
