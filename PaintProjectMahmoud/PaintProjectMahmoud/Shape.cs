using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace PaintProjectMahmoud
{
    public enum ShapeType { Filled, Empty}
        

    public abstract class Shape
    {
        Point topLeftCorner, lowerRightCorner;
        int width, height;
        ShapeType Type;
        Pen P;
        SolidBrush B;

        public Shape() { }

        public Shape(int x1, int y1, int x2, int y2, ShapeType type,Pen p, SolidBrush b)
        {
            topLeftCorner = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            lowerRightCorner = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
            width = Math.Abs(x2 - x1);
            height = Math.Abs(y2 - y1);
            Type1 = type;
            P = new Pen(p.Color,p.Width);
            B1 = new SolidBrush(b.Color);
        }
        public abstract void DRAW(Graphics G);        
        public abstract void DRAW_Fill(Graphics G);

        public virtual void Select(Graphics G)
        {
            Pen P = new Pen(Color.Red);
            G.DrawRectangle(P, topLeftCorner.X, topLeftCorner.Y, width, height);
            P = new Pen(Color.Blue,3);
            G.DrawLine(P, topLeftCorner.X + width / 2, topLeftCorner.Y, topLeftCorner.X + width / 2 + 3, topLeftCorner.Y);
            G.DrawLine(P, topLeftCorner.X, topLeftCorner.Y + height / 2, topLeftCorner.X, topLeftCorner.Y + height / 2 + 3);
            G.DrawLine(P, LowerRightCorner.X - width / 2, LowerRightCorner.Y, LowerRightCorner.X - width / 2 - 3, lowerRightCorner.Y);
            G.DrawLine(P, lowerRightCorner.X, lowerRightCorner.Y - height / 2, lowerRightCorner.X, lowerRightCorner.Y - height / 2 - 3);
        }

        public virtual bool is_Inside(Point P)
        {
            if (P.X >= topLeftCorner.X && P.X <= lowerRightCorner.X && P.Y >= topLeftCorner.Y && P.Y <= lowerRightCorner.Y)
                return true;          
            return false;
        }

        public void move(int dx, int dy)
        {
            topLeftCorner.X += dx;
            topLeftCorner.Y += dy;
            lowerRightCorner.X += dx;
            lowerRightCorner.Y += dy;
        }

        public abstract Shape CopyShape();
        

        public Point TopLeftCorner { get => topLeftCorner; set => topLeftCorner = value; }
        public Point LowerRightCorner { get => lowerRightCorner; set => lowerRightCorner = value; }
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public ShapeType Type1 { get => Type; set => Type = value; }
        public Pen P1 { get => P; set => P = value; }
        public SolidBrush B1 { get => B; set => B = value; }
    }

    
}