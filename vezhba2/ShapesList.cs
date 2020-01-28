using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba2
{
    public class ShapesList
    {
        public List<Shape> shapes;
        
        public ShapesList()
        {
            shapes = new List<Shape>();
        }

        public void Draw(Graphics g)
        {
            foreach (Shape s in shapes)
            {
                s.Draw(g);
            }
        }

        public void Add(Shape s)
        {
            shapes.Add(s);
        }
    }
}
