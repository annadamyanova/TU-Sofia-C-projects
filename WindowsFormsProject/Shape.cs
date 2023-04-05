using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsProject
{
    [Serializable]
    public abstract class Shape
    {
        public Point Location { get; set; }  //

        [NonSerialized]
        private bool _selected;

        public bool Selected
        {
            get { return _selected; }
            set { _selected = value; }
        }
        public bool Fill { get; set; } = true;
        public Color Color { get; set; } = Color.Blue;


        public abstract void Paint(Graphics graphics);  //абстрактни методи
        public abstract bool PointInFigure(Point point);
        public abstract bool Cross(Rectangle frame);
        public abstract int Area();
        public virtual string Type()    //виртуален метод
        {
            throw new NotImplementedException();
        }

    }
}
