using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    //да се добавят още LINQ функции, но не такива тах Math.Min, Math.Abs ,a като _shapes.OrderBy(x => x.Area()).ToList();
    //да се направи custum ligrary
    //да се добавят делегати и събития(delegates)
    //да се обработи повече Interface

    public partial class FormScene : Form
    {
        List<Shape> _shapes = new List<Shape>();  //имаме полиморфизъм

        private Rectangle _frameRectangle;
        private Square _frameSquare;
        private Triangle _frameTriangle;

        private Point _mouseDownLocation;
        private Point _changingPoint;

        bool _mouseCapture;

        int xPosition;
        int yPosition;

        public FormScene()
        {
            InitializeComponent();

            SetStyle(
                ControlStyles.UserPaint |
                ControlStyles.AllPaintingInWmPaint |
                ControlStyles.OptimizedDoubleBuffer,
                true);
        }
        protected override void OnPaint(PaintEventArgs e)  //от тук чертаем фигурите
        {
            base.OnPaint(e); //базова функция           

            foreach (var shape in _shapes)
            {
                shape.Paint(e.Graphics);   //имаме полиморфизъм
            }

            if (_mouseCapture)
            {
                if (_frameRectangle != null)
                {
                    _frameRectangle.Paint(e.Graphics);
                }
                else if (_frameSquare != null)
                {
                    _frameSquare.Paint(e.Graphics);
                }
                else if (_frameTriangle != null)
                {
                    _frameTriangle.Paint(e.Graphics);
                }
            }
        }
        private void FormScene_MouseDown(object sender, MouseEventArgs e)
        {
            _mouseCapture = true;
            _mouseDownLocation = e.Location;

            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonMove.Checked)
                {
                    foreach (var s in _shapes)
                        s.Selected = false;

                    foreach (var shape in _shapes)
                        if (shape.PointInFigure(e.Location))
                        {
                            shape.Selected = true;
                            xPosition = e.X - shape.Location.X;
                            yPosition = e.Y - shape.Location.Y;
                            _mouseCapture = true;
                            return;
                        }
                }
                else if (radioButtonRectangle.Checked)
                {
                    _mouseDownLocation = e.Location;

                    _frameRectangle = new Rectangle
                    {
                        Color = Color.LightBlue
                    };


                    for (int i = 0; i < _shapes.Count(); i++)
                        _shapes[i].Selected = false;

                    for (int i = _shapes.Count() - 1; i >= 0; i--)
                        if (_shapes[i].PointInFigure(e.Location))
                        {
                            _shapes[i].Selected = true;
                            break;
                        }
                }
                else if (radioButtonSquare.Checked)
                {
                    _mouseDownLocation = e.Location;

                    _frameSquare = new Square
                    {
                        Color = Color.LightBlue
                    };

                    for (int i = 0; i < _shapes.Count(); i++)
                        _shapes[i].Selected = false;

                    for (int i = _shapes.Count() - 1; i >= 0; i--)
                        if (_shapes[i].PointInFigure(e.Location))
                        {
                            _shapes[i].Selected = true;
                            break;
                        }
                }
                else if (radioButtonTriangle.Checked)
                {
                    _mouseDownLocation = e.Location;

                    _frameTriangle = new Triangle
                    {
                        Color = Color.LightBlue
                    };

                    for (int i = 0; i < _shapes.Count(); i++)
                        _shapes[i].Selected = false;

                    for (int i = _shapes.Count() - 1; i >= 0; i--)
                        if (_shapes[i].PointInFigure(e.Location))
                        {
                            _shapes[i].Selected = true;
                            break;
                        }
                }
            }
            else if (e.Button == MouseButtons.Right)
            {
                foreach (var shape in _shapes)
                {
                    shape.Selected = false;
                }

                for (int i = _shapes.Count() - 1; i >= 0; i--)
                {
                    if (_shapes[i].PointInFigure(e.Location))
                    {
                        _shapes[i].Selected = true;
                        break;
                    }
                }
            }

            Invalidate();
        }
        private void FormScene_MouseMove(object sender, MouseEventArgs e)
        {
            if (!_mouseCapture)
                return;

            if ((radioButtonRectangle.Checked && _frameRectangle == null) || (radioButtonSquare.Checked && _frameSquare == null) || (radioButtonTriangle.Checked && _frameTriangle == null))
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (radioButtonMove.Checked)
                {
                    _changingPoint.X = e.X - xPosition;
                    _changingPoint.Y = e.Y - yPosition;

                    foreach (var shape in _shapes)
                    {
                        if (shape.Selected)
                            shape.Location = _changingPoint;
                    }

                    Invalidate();
                }
                else if (radioButtonRectangle.Checked)
                {
                    _frameRectangle.Location = new Point
                    {
                        X = Math.Min(_mouseDownLocation.X, e.Location.X),
                        Y = Math.Min(_mouseDownLocation.Y, e.Location.Y)
                    };

                    _frameRectangle.Width = Math.Abs(_mouseDownLocation.X - e.Location.X);
                    _frameRectangle.Height = Math.Abs(_mouseDownLocation.Y - e.Location.Y);
                }
                else if (radioButtonSquare.Checked)
                {
                    _frameSquare.Location = new Point
                    {
                        X = Math.Min(_mouseDownLocation.X, e.Location.X),
                        Y = _mouseDownLocation.Y
                    };

                    _frameSquare.Side = Math.Abs(_mouseDownLocation.X - e.Location.X);

                }
                else if (radioButtonTriangle.Checked)
                {
                    _frameTriangle.Location = _mouseDownLocation;
                    _frameTriangle.Side = Math.Abs(_mouseDownLocation.X - e.Location.X);
                    _frameTriangle.Side = Math.Abs(_mouseDownLocation.Y - e.Location.Y);
                }
            }

            Invalidate();
        }

        private void FormScene_MouseUp(object sender, MouseEventArgs e)
        {
            if (!_mouseCapture)
                return;

            if ((radioButtonRectangle.Checked && _frameRectangle == null) || (radioButtonSquare.Checked && _frameSquare == null) || (radioButtonTriangle.Checked && _frameTriangle == null))
                return;

            if (e.Button == MouseButtons.Left)
            {

                if (radioButtonRectangle.Checked)
                {
                    _frameRectangle.Color = Color.LightPink;

                    for (int i = 0; i < _shapes.Count(); i++)
                    {
                        _shapes[i].Selected = false;
                    }

                    _shapes.Add(_frameRectangle);
                    _frameRectangle.Selected = true;
                }
                else if (radioButtonSquare.Checked)
                {
                    _frameSquare.Color = Color.LightPink;

                    for (int i = 0; i < _shapes.Count(); i++)
                    {
                        _shapes[i].Selected = false;
                    }

                    _shapes.Add(_frameSquare);
                    _frameSquare.Selected = true;
                }
                else if (radioButtonTriangle.Checked)
                {
                    _frameTriangle.Color = Color.LightPink;

                    for (int i = 0; i < _shapes.Count(); i++)
                    {
                        _shapes[i].Selected = false;
                    }

                    _shapes.Add(_frameTriangle);
                    _frameTriangle.Selected = true;
                }
            }

            _mouseCapture = false;

            Invalidate();
        }
        private void FormScene_DoubleClick(object sender, EventArgs e)
        {
            foreach (var shape in _shapes)
            {
                if (shape.Selected)  
                {
                    //тук можем да го направим с полиморфизъм, вместо с if, else if -oве

                    if (shape.Type() == "Rectangle")
                    {
                        var fp = new RectangleScene();

                        fp.Rectangle = (Rectangle)shape;
                        fp.ShowDialog();

                        break;
                    }
                    else if (shape.Type() == "Square")
                    {
                        var fp = new SquareScene();

                        fp.Square = (Square)shape;
                        fp.ShowDialog();

                        break;
                    }
                    else if (shape.Type() == "Triangle")
                    {
                        var fp = new TriangleScene();

                        fp.Triangle = (Triangle)shape;
                        fp.ShowDialog();

                        break;
                    }
                }
            }

            Invalidate();
        }
        private void FormScene_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode != Keys.Delete)
            {
                return;
            }

            for (int i = _shapes.Count() - 1; i >= 0; i--)
            {
                if (_shapes[i].Selected)
                {
                    _shapes.RemoveAt(i);
                }
            }

            CalculateArea();

            Invalidate();
        }
        private void CalculateArea()
        {
            double area = 0;

            for (int i = 0; i < _shapes.Count(); i++)
            {
                area += _shapes[i].Area();

                AreaToolStripStatusLabel.Text = area.ToString();
            }
        }
        private void FormScene_FormClosing(object sender, FormClosingEventArgs e)
        {
            var formatter = new BinaryFormatter();

            if (File.Exists("data"))
            {
                File.Delete("data");
            }

            using (var fileStream = new FileStream("data", FileMode.CreateNew))
            {
                formatter.Serialize(fileStream, _shapes);
            }
        }
        private void FormScene_Load(object sender, EventArgs e)   //от тук се запазва файла
        {
            if (!File.Exists("data"))
                return;

            IFormatter formatter = new BinaryFormatter();

            using (var fileStream = new FileStream("data", FileMode.Open))
            {
                _shapes = (List<Shape>)formatter.Deserialize(fileStream);
            }
        }
        
    }
}
