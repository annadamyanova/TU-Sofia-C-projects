using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject
{
    [Serializable]
    public class Square : Shape, IShape
    {
        public int Side { get; set; }

        public override void Paint(Graphics graphics)
        {
            var brush = new SolidBrush(Color);
            using (brush)
            {
                graphics.FillRectangle(brush, Location.X, Location.Y, Side, Side);
            }

            Color borderSquareColor = Selected ? Color.Red : Color;
            using (var pen = new Pen(borderSquareColor))
            {
                graphics.DrawRectangle(pen, Location.X, Location.Y, Side, Side);
            }
        }
        public override bool PointInFigure(Point point)
        {
            return Location.X <= point.X && point.X <= Location.X + Side
                && Location.Y <= point.Y && point.Y <= Location.Y + Side;
        }
        public override bool Cross(Rectangle shape)
        {
            return
                this.Location.X <= shape.Location.X + shape.Width && shape.Location.X <= this.Location.X + this.Side &&
                this.Location.Y <= shape.Location.Y + shape.Height && shape.Location.Y <= this.Location.Y + this.Side;
        }
        public override int Area()
        {
            return (int)Math.Sqrt(Side);
        } 
        public override string Type()
        {
            return "Square";
        }

        public int CalculatePerimeter()
        {
            return Side * 4;
        }
    }
}
