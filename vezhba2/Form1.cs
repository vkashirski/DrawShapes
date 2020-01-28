using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace vezhba2
{
    public partial class Form1 : Form
    {
        private SHAPE_TYPE SELECTED_SHAPETYPE;
        private ShapesList shapes;
        private Color currentColor;
        private enum SHAPE_TYPE
        {
            CIRCLE,
            SQUARE
        }
        public Form1()
        {
            InitializeComponent();
            currentColor = Color.Black;
            shapes = new ShapesList();
            this.DoubleBuffered = true;
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(SELECTED_SHAPETYPE == SHAPE_TYPE.CIRCLE)
            {
                Circle c = new Circle(e.X, e.Y, currentColor, 40);
                shapes.Add(c);
            }
            if (SELECTED_SHAPETYPE == SHAPE_TYPE.SQUARE)
            {
                Square s = new Square(e.X, e.Y, 80, 80, currentColor);
                shapes.Add(s);
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            shapes.Draw(e.Graphics);
        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SELECTED_SHAPETYPE = SHAPE_TYPE.CIRCLE;
        }

        private void squareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SELECTED_SHAPETYPE = SHAPE_TYPE.SQUARE;
        }

        private void pickAColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == System.Windows.Forms.DialogResult.OK)
            {
                currentColor = colorDialog.Color;
            }
        }
    }
}
