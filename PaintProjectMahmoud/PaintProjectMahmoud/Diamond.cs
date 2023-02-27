using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PaintProjectMahmoud
{
    public class Diamond:Shape
    {
        public Diamond(int x1, int y1, int x2, int y2, ShapeType type, Pen p, SolidBrush b) : base(x1, y1, x2, y2, type,p,b)
        {

        }

        public Diamond() { }

        public override Shape CopyShape()
        {          
           return new Diamond(TopLeftCorner.X,TopLeftCorner.Y,LowerRightCorner.X,LowerRightCorner.Y,this.Type1,new Pen(P1.Color,P1.Width),new SolidBrush(B1.Color));
        }

        public override void DRAW(Graphics G)
        {
            Point[] points = new Point[]
            {
               new Point(TopLeftCorner.X+Width/2,TopLeftCorner.Y),
               new Point(LowerRightCorner.X,LowerRightCorner.Y-Height/2),
               new Point(TopLeftCorner.X+Width/2,LowerRightCorner.Y),
               new Point(TopLeftCorner.X,TopLeftCorner.Y+Height/2)
            };

            G.DrawPolygon(P1, points);            
        }

        public override void DRAW_Fill(Graphics G)
        {
            Point[] points = new Point[]
            {
               new Point(TopLeftCorner.X+Width/2,TopLeftCorner.Y),
               new Point(LowerRightCorner.X,LowerRightCorner.Y-Height/2),
               new Point(TopLeftCorner.X+Width/2,LowerRightCorner.Y),
               new Point(TopLeftCorner.X,TopLeftCorner.Y+Height/2)
            };            

            G.FillPolygon(B1, points);
        }
    }
}
