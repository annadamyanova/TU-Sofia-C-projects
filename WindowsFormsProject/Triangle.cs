using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject
{
    [Serializable]
    public class Triangle : Shape
    {
        public int Side { get; set; }
        private Point Location2 { get; set; }
        private Point Location3 { get; set; }

        public override void Paint(Graphics graphics)
        {
            int X1 = Location.X + Side / 2;
            int Y1 = Convert.ToInt32(Location.Y + Math.Sqrt(Side * Side + (Side / 2) * (Side / 2)));
            var point1 = new Point(X1, Y1);
            int X2 = Location.X - Side / 2;
            int Y2 = Convert.ToInt32(Location.Y + Math.Sqrt(Side * Side + (Side / 2) * (Side / 2)));
            var point2 = new Point(X2, Y2);
            Location2 = point1;
            Location3 = point2;
            var Points = new Point[3] { Location, Location2, Location3 };

            var brush = new SolidBrush(Color);
            using (brush)
            {
                graphics.FillPolygon(brush, Points);
            }

            Color borderTriangleColor = Selected ? Color.Red : Color;
            using (var pen = new Pen(borderTriangleColor))
            {
                graphics.DrawPolygon(pen, Points);
            }
               
        }
        public override bool PointInFigure(Point point)
        {
            double A = AreaForPointInShape(Location3.X, Location3.Y, Location.X, Location.Y, Location2.X, Location2.Y);
            //ABP
            double A1 = AreaForPointInShape(Location3.X, Location3.Y, Location.X, Location.Y, point.X, point.Y);
            //APC
            double A2 = AreaForPointInShape(Location3.X, Location3.Y, point.X, point.Y, Location2.X, Location2.Y);
            //PBC
            double A3 = AreaForPointInShape(point.X, point.Y, Location.X, Location.Y, Location2.X, Location2.Y);
            return A == A1 + A2 + A3;
        }
        private double AreaForPointInShape(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return Math.Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        public override bool Cross(Rectangle shape)
        {
            return
                 this.Location.X <= shape.Location.X + shape.Width && shape.Location.X <= this.Location.X + this.Side &&
                 this.Location.Y <= shape.Location.Y + shape.Height && shape.Location.Y <= this.Location.Y + this.Side;
        }
        public override int Area()
        {
            return (int)Math.Round(Math.Sqrt(3) / 4 * Side * Side); 
            // (Side * Height) / 2,
            // Math.Sqrt(semiperimeter * (semiperimeter - side1) * (semiperimeter - side2) * (semiperimeter - side3));
        }
        public override string Type()
        {
            return "Triangle";
        }
    }
}
