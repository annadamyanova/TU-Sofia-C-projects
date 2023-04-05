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
    public partial class TriangleScene : Form
    {
        public Triangle Triangle { get; set; }
        public TriangleScene()
        {
            InitializeComponent();
        }

        private void TriangleScene_Load(object sender, EventArgs e)
        {
            ColorButton.BackColor = Triangle.Color;

            AreaToolStripLabel.Text = Triangle.Area().ToString();
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            var colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Triangle.Color = colorDialog.Color;
                ColorButton.BackColor = colorDialog.Color;
            }
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            Triangle.Color = ColorButton.BackColor;

            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
