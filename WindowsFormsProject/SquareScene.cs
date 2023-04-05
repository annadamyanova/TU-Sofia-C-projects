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
    public partial class SquareScene : Form
    {
        public Square Square { get; set; }
        public SquareScene()
        {
            InitializeComponent();
        }

        private void SquareScene_Load(object sender, EventArgs e)
        {
            ColorButton.BackColor = Square.Color;

            AreaToolStripLabel.Text = Square.Area().ToString();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Square.Color = colorDialog.Color;
                ColorButton.BackColor = colorDialog.Color;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Square.Color = ColorButton.BackColor;

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
