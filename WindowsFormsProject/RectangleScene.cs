using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProject
{
    public partial class RectangleScene : Form
    {
        public Rectangle Rectangle { get; set; }
        public RectangleScene()
        {
            InitializeComponent();
        }

        private void RectangleScene_Load(object sender, EventArgs e)
        {
            ColorButton.BackColor = Rectangle.Color;

            AreaToolStripLabel.Text = Rectangle.Area().ToString();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Rectangle.Color = colorDialog.Color;
                ColorButton.BackColor = colorDialog.Color;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Rectangle.Color = ColorButton.BackColor;

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
