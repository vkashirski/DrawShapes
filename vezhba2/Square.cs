using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba2
{
    public class Square : Shape
    {
        public float Width { get; set; }

        public float Height { get; set; }

        public Square(float x, float y, float width, float height, Color color)
            : base(x, y, color)
        {
            Width = width;
            Height = height;
        }

        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, X - Width / 2, Y - Width / 2, Width, Height);
            b.Dispose();
        }
    }
}
