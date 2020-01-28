using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba2
{
    public class Circle : Shape
    {
        public float Radius { get; set; }

        public Circle(float x, float y, Color color, float radius)
            : base(x, y, color)
        {
            Radius = radius;
        }
        public override void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
    }
}
