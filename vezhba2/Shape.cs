﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vezhba2
{
    public abstract class Shape
    {
        public float X { get; set; }
        public float Y { get; set; }
        public Color Color { get; set; }

        public Shape(float x, float y, Color color)
        {
            X = x;
            Y = y;
            Color = color;
        }

        public abstract void Draw(Graphics g);
    }
}
