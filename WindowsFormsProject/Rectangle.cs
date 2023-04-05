using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject
{
    [Serializable]
    public class Rectangle : Shape, IShape
    {
        public int Width { get; set; }

        public int Height { get; set; }

        public override void Paint(Graphics graphics)
        {
            if (Fill)
            {
                var brush = new SolidBrush(Color);
                using (brush)
                    graphics.FillRectangle(brush, Location.X, Location.Y, Width, Height);

            }

            Color borderRectangleColor = Selected ? Color.Red : Color;
            using (var pen = new Pen(borderRectangleColor))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Width, Height);

            }

        }
        public override bool PointInFigure(Point point)
        {
            return
             Location.X < point.X && point.X < Location.X + Width &&
             Location.Y < point.Y && point.Y < Location.Y + Height;
        }

        public override bool Cross(Rectangle frame)
        {
            return
            this.Location.X <= frame.Location.X + frame.Width && frame.Location.X <= this.Location.X + this.Width &&
            this.Location.Y <= frame.Location.Y + frame.Height && frame.Location.Y <= this.Location.Y + this.Height;
        }

        public override int Area()
        {
            return Width * Height;
        }

        public override string Type()
        {
            return "Rectangle";
        }

        public int CalculatePerimeter()
        {
            return (Width * 2) + (Height * 2);
        }
    }
}

