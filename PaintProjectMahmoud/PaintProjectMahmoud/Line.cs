using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintProjectMahmoud
{
   public class Line:Shape
   {
        int X1, Y1, X2, Y2;

        public Line() { }
        public Line(int x1, int y1, int x2, int y2, ShapeType type, Pen p, SolidBrush b) : base(x1, y1, x2, y2, type, p, b)
        {
            X1 = x1;
            X2 = x2;
            Y1 = y1;
            Y2 = y2;

            TopLeftCorner = new Point(x1, y1);
            LowerRightCorner = new Point(x2, y2);

            if ((X1 > X2 && Y2 < Y1) || (X1 < X2 && Y1 > Y2))//   \/
            {
                TopLeftCorner = new Point(X2, Y2);
                LowerRightCorner = new Point(X1, Y1);                
            }
            
        }      
        public override void DRAW(Graphics G)
        {
            if (X1 < X2 && Y1 < Y2)
                G.DrawLine(P1, TopLeftCorner, LowerRightCorner);
            else if (X2 < X1 && Y2 > Y1)
            {
                G.DrawLine(P1, TopLeftCorner.X, TopLeftCorner.Y, LowerRightCorner.X, LowerRightCorner.Y);
            }
            else if (X1 > X2 && Y2 < Y1)
            {                                
                G.DrawLine(P1, TopLeftCorner, LowerRightCorner);               
            }
            else if(X1<X2 && Y1>Y2)
            {
                G.DrawLine(P1, TopLeftCorner.X, TopLeftCorner.Y, LowerRightCorner.X, LowerRightCorner.Y);
            }
        }
        public override bool is_Inside(Point P)
        {
            if (X1 < X2 && Y1 < Y2)
            {
                return base.is_Inside(P);
            }
            else if (X2 < X1 && Y2 > Y1)
            {
                if (P.X <= TopLeftCorner.X && P.X >= LowerRightCorner.X && P.Y >= TopLeftCorner.Y && P.Y <= LowerRightCorner.Y)
                    return true;
            }
            else if (X1 > X2 && Y2 < Y1)
            {                             
                return base.is_Inside(P);
            }
            else if (X2 < X1 && Y2 > Y1)
            {
                if (P.X <= TopLeftCorner.X && P.X >= LowerRightCorner.X && P.Y >= TopLeftCorner.Y && P.Y <= LowerRightCorner.Y)
                    return true;
            }
            else if (X1 < X2 && Y1 > Y2)
            {
                if (P.X <= TopLeftCorner.X && P.X >= LowerRightCorner.X && P.Y >= TopLeftCorner.Y && P.Y <= LowerRightCorner.Y)
                    return true;
            }

                return false;
        }

        public override void Select(Graphics G)
        {
            if (X1 < X2 && Y1 < Y2)
                base.Select(G);
            else if (X2 < X1 && Y2 > Y1)
            {
                Pen P = new Pen(Color.Red);
                G.DrawRectangle(P, LowerRightCorner.X, TopLeftCorner.Y, Width, Height);
                P = new Pen(Color.Blue, 3);
                G.DrawLine(P, LowerRightCorner.X + Width / 2, TopLeftCorner.Y, LowerRightCorner.X + Width / 2 + 3, TopLeftCorner.Y);
                G.DrawLine(P, TopLeftCorner.X, TopLeftCorner.Y + Height / 2, TopLeftCorner.X, TopLeftCorner.Y + Height / 2 + 3);
                G.DrawLine(P, TopLeftCorner.X - Width / 2, LowerRightCorner.Y, TopLeftCorner.X - Width / 2 - 3, LowerRightCorner.Y);
                G.DrawLine(P, LowerRightCorner.X, LowerRightCorner.Y - Height / 2, LowerRightCorner.X, LowerRightCorner.Y - Height / 2 - 3);
            }
            else if (X1 > X2 && Y2 < Y1)
            {
                base.Select(G);                
            }
            else if (X1 < X2 && Y1 > Y2)
            {
                Pen P = new Pen(Color.Red);
                G.DrawRectangle(P, LowerRightCorner.X, TopLeftCorner.Y, Width, Height);
                P = new Pen(Color.Blue, 3);
                G.DrawLine(P, LowerRightCorner.X + Width / 2, TopLeftCorner.Y, LowerRightCorner.X + Width / 2 + 3, TopLeftCorner.Y);
                G.DrawLine(P, TopLeftCorner.X, TopLeftCorner.Y + Height / 2, TopLeftCorner.X, TopLeftCorner.Y + Height / 2 + 3);
                G.DrawLine(P, TopLeftCorner.X - Width / 2, LowerRightCorner.Y, TopLeftCorner.X - Width / 2 - 3, LowerRightCorner.Y);
                G.DrawLine(P, LowerRightCorner.X, LowerRightCorner.Y - Height / 2, LowerRightCorner.X, LowerRightCorner.Y - Height / 2 - 3);
            }
        }

        public override void DRAW_Fill(Graphics G)
        {
            throw new NotImplementedException();
        }

        public override Shape CopyShape()
        {
            Line L= new Line(TopLeftCorner.X, TopLeftCorner.Y, LowerRightCorner.X, LowerRightCorner.Y, this.Type1, new Pen(P1.Color, P1.Width), new SolidBrush(B1.Color));
            L.X1 = this.X1;
            L.Y1 = this.Y1;
            L.X2 = this.X2;
            L.Y2 = this.Y2;

            return L;
        }
    }
}
