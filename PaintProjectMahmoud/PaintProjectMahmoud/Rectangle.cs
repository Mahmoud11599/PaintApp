﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintProjectMahmoud
{
    public class Rectangle:Shape
    {
        public Rectangle() { }

        public Rectangle(int x1, int y1, int x2, int y2, ShapeType type, Pen p, SolidBrush b) : base(x1, y1, x2, y2, type, p, b)
        { 
        
        }

        public override Shape CopyShape()
        {

            Rectangle R = new Rectangle(TopLeftCorner.X, TopLeftCorner.Y, LowerRightCorner.X, LowerRightCorner.Y, this.Type1, new Pen(P1.Color, P1.Width), new SolidBrush(B1.Color));           
            return R;

        }

        public override void DRAW(Graphics G)
        {
            G.DrawRectangle(P1, TopLeftCorner.X, TopLeftCorner.Y, Width, Height);
        }

        public override void DRAW_Fill(Graphics G)
        {            
            G.FillRectangle(B1, TopLeftCorner.X, TopLeftCorner.Y, Width, Height);
        }
    }
}
