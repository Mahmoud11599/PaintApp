using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.IO;
using System.Xml.Serialization;

namespace PaintProjectMahmoud
{
    public enum ShapeName{ Rectangle, Triangle, RightTriangle, Diamond, Hexagon, Oval, Trapezoidal, Line}
    public partial class Panel : Form
    {
        Graphics G,G2;
        Pen P = new Pen(Color.Black,2);
        SolidBrush B = new SolidBrush(Color.Black);
        List<Shape> MyList = new List<Shape>();
        int x1, y1, x2, y2;
        int index = 0;
        bool is_Move;
        bool Fill=false;
        bool Delete;
        ShapeName ShapeN;
        bool Fill_It;
        bool ChangeColor;
        bool reSize;
        bool paste,copy;
        Shape temp;
        bool curserMoving=true;
        bool mouseMove;
        bool erase=false;
        Bitmap Bimage;

        public static int Number1 = 0, Number2 = 0;
        
      
        public Panel()
        {
            InitializeComponent();
            G = panel1.CreateGraphics();
            G.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            P.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            P.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            Bimage = new Bitmap(panel1.Width, panel1.Height);
            G2 = Graphics.FromImage(Bimage);
            G2.Clear(Color.White);
        }

        public void Redraw()
        {           
            G.Clear(Color.White);
            G.DrawImage(Bimage, 0, 0, Bimage.Width, Bimage.Height);
            foreach (Shape i in MyList)
                if (i.Type1 == ShapeType.Empty)
                {
                    i.DRAW(G);
                    i.DRAW(G2);
                }
                else
                {
                    i.DRAW_Fill(G);
                    i.DRAW_Fill(G2);
                }
          
        }

        private void xmlToolStripMenuItem_Click(object sender, EventArgs e)
        {
           // try
          //  {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "XMLFILE|.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter Write = new StreamWriter(dlg.FileName);
                    if (dlg.FilterIndex == 1)
                    {                        
                        XmlSerializer ser = new XmlSerializer(typeof(List<Shape>));
                        ser.Serialize(Write, MyList);
                    }
                    Write.Close();
                }
           // }
          //  catch (Exception Ex)
           // {
           //     MessageBox.Show(Ex.Message);
           // }

        }

        private void DiamondButton_Click(object sender, EventArgs e)
        {
            ShapeN = ShapeName.Diamond;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void HexagonButton_Click(object sender, EventArgs e)
        {
            ShapeN = ShapeName.Hexagon;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;



            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void LineButton_Click(object sender, EventArgs e)
        {
            ShapeN = ShapeName.Line;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;



            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void TrapezoidalButton_Click(object sender, EventArgs e)
        {
            ShapeN = ShapeName.Trapezoidal;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;



            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void DrawFillButton_Click(object sender, EventArgs e)
        {
            if (DrawFillButton.BackColor == Button.DefaultBackColor)
            {                
                DrawFillButton.BackColor = Color.LightSteelBlue;
                Fill = true;
            }
            else
            {
                DrawFillButton.BackColor = Button.DefaultBackColor;
                Fill = false;
            }

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;
        }

        private void button2_Click(object sender, EventArgs e)
        {            
            ShapeN = ShapeName.Triangle;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
           Redraw();            
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            x1 = e.X;
            y1 = e.Y;
            if (!curserMoving)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    if (MyList[i].is_Inside(new Point(x1, y1)))
                    {
                        MyList[i].Select(G);
                        index = i;
                        // is_Move = true;
                        break;
                    }
                }
            }
            else 
            {
                mouseMove = true;                
            }

            if (copy)
            {
                for (int i = 0; i < MyList.Count; i++)
                {
                    if (MyList[i].is_Inside(new Point(x1, y1)))
                    {
                        temp = MyList[i].CopyShape();                        
                        break;
                    }
                }
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            int dx = x2 - x1;
            int dy = y2 - y1;
            mouseMove = false;

            if (!Delete && !Fill_It && !ChangeColor && !reSize && !paste && !curserMoving) 
            {
                Shape MyShape;
                ShapeType T;
                if (Fill)
                    T = ShapeType.Filled;
                else
                    T = ShapeType.Empty;

                switch (ShapeN)
                {
                    case ShapeName.Rectangle:
                        MyShape = new Rectangle(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Triangle:
                        MyShape = new Triangle(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.RightTriangle:
                        MyShape = new RightTriangle(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Diamond:
                        MyShape = new Diamond(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Hexagon:
                        MyShape = new Hexagon(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Line:
                        T = ShapeType.Empty;
                        MyShape = new Line(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Oval:
                        MyShape = new Oval(x1, y1, x2, y2, T, P,B);
                        break;
                    case ShapeName.Trapezoidal:
                        MyShape = new Trapezoidal(x1, y1, x2, y2, T, P,B);
                        break;

                    default:
                        MyShape = new Rectangle(x1, y1, x2, y2, T, P,B);
                        break;
                }

                if (MyList.Count>0 && is_Move && index!=-1)
                {
                    MyList[index].move(dx, dy);
                    G2.Clear(Color.White);
                    Redraw();                   
                }
                else
                {
                    Redraw();
                    if (Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2)) > 10)
                    {
                        if (Fill && ShapeN != ShapeName.Line)
                        {
                            MyShape.DRAW_Fill(G);
                            MyShape.DRAW_Fill(G2);
                        }
                        else
                        {
                            MyShape.DRAW(G);
                            MyShape.DRAW(G2);
                        }
                        MyList.Add(MyShape);
                    }
                }
            }
            else if(Delete)
            {
                if (MyList.Count>0 && index != -1 && MyList[index].is_Inside(new Point(x1, y1)))
                {
                    MyList.Remove(MyList[index]);
                    G2.Clear(Color.White);
                    index = -1;
                }
                Redraw();
            }
            else if(Fill_It)
            {
                if (MyList.Count > 0 && index != -1 &&MyList[index].is_Inside(new Point(x1, y1)))
                {
                    if (!(MyList[index] is Line))
                    {
                        MyList[index].Type1 = ShapeType.Filled;
                        G2.Clear(Color.White);
                        index = -1;
                    }
                }
                Redraw();
            }
            else if(ChangeColor)
            {
                if (MyList.Count > 0 && index != -1 && MyList[index].is_Inside(new Point(x1, y1)))
                {
                    DialogResult result = colorDialog1.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        MyList[index].B1.Color = MyList[index].P1.Color = colorDialog1.Color;
                        G2.Clear(Color.White);
                        index = -1;
                    }
                }
                Redraw();
            }
            else if(reSize)
            {
                if (MyList.Count > 0 && index != -1 && MyList[index].is_Inside(new Point(x1, y1)))
                {

                    Resize R = new Resize(MyList[index].Width, MyList[index].Height);
                    R.ShowDialog();

                    if (Number1 != 0 && Number2 != 0)
                    {
                        if (!(MyList[index] is Line))
                        {
                            MyList[index].Width = Number1;
                            MyList[index].Height = Number2;
                            MyList[index].LowerRightCorner = new Point(MyList[index].TopLeftCorner.X + Number1, MyList[index].TopLeftCorner.Y + Number2);
                        }
                        else
                        {
                            int X1 = MyList[index].LowerRightCorner.X;
                            int Y1 = MyList[index].LowerRightCorner.Y;
                            int X2 = MyList[index].TopLeftCorner.X;
                            int Y2 = MyList[index].TopLeftCorner.Y;
                            
                            if (X1 < X2 && Y1 > Y2)
                            {
                                MyList[index].Width = Number1;
                                MyList[index].Height = Number2;
                                MyList[index].TopLeftCorner = new Point(MyList[index].LowerRightCorner.X + Number1, MyList[index].LowerRightCorner.Y - Number2);

                            }
                            else
                            {
                              MyList[index].Width = Number1;
                              MyList[index].Height = Number2;
                              MyList[index].LowerRightCorner = new Point(MyList[index].TopLeftCorner.X + Number1, MyList[index].TopLeftCorner.Y + Number2);
                            }
                            
                        }                        
                        
                        Number1 = 0;
                        Number2 = 0;
                    }
                    G2.Clear(Color.White);
                    index = -1;
                }
                Redraw();

            }
            else if(paste)
            {
                
                if (temp != null)
                {
                    int X1 = temp.LowerRightCorner.X;
                    int Y1 = temp.LowerRightCorner.Y;
                    int X2 = temp.TopLeftCorner.X;
                    int Y2 = temp.TopLeftCorner.Y;

                    if (!(temp is Line && X1 < X2 && Y1 > Y2))
                    {                    
                        temp.TopLeftCorner = new Point(x1, y1);
                        temp.LowerRightCorner = new Point(temp.TopLeftCorner.X + temp.Width, temp.TopLeftCorner.Y + temp.Height);
                        MyList.Add(temp);                        
                    }
                    else 
                    {                        
                        temp.TopLeftCorner = new Point(x2, y2);
                        temp.LowerRightCorner = new Point(temp.TopLeftCorner.X - temp.Width, temp.TopLeftCorner.Y + temp.Height);
                        MyList.Add(temp);
                    }
                    Redraw();
                    temp = null;
                }
                else
                {
                    MessageBox.Show("Please Copy a Shape first");
                }

            }
        }

        private void RectangleButton_Click(object sender, EventArgs e)
        {            
            ShapeN = ShapeName.Rectangle;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;


            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void color1_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Blue;
        }

        private void color6_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Red;
        }

        private void color9_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Green;
        }

        private void color2_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Yellow;
        }

        private void color5_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Magenta;
        }

        private void color8_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.DarkOrange;
        }

        private void color3_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Aqua;
        }

        private void color4_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Black;
        }

        private void color7_Click(object sender, EventArgs e)
        {
            P.Color = B.Color = Color.Purple;
        }

        private void ColorsButton_Click(object sender, EventArgs e)
        {
            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
                P.Color = B.Color = colorDialog1.Color;
        }

        private void Size1_Click(object sender, EventArgs e)
        {
            P.Width = 6;
        }

        private void Size2_Click(object sender, EventArgs e)
        {
            P.Width = 4;
        }

        private void Size3_Click(object sender, EventArgs e)
        {
            P.Width = 2;
        }

        private void TrashButton_Click(object sender, EventArgs e)
        {
            if (Delete)
            {
                Delete = false;
                TrashButton.Image = Properties.Resources.Trash;
            }
            else
            {
                Delete = true;
                TrashButton.Image = Properties.Resources.TrashEnabled;
            }            


            if(Delete) TrashButton.Image = Properties.Resources.TrashEnabled;
            if(!Delete) TrashButton.Image = Properties.Resources.Trash;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;


            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Fill Butoon
            Fill_It = false;           
            FillButton.Image = Properties.Resources.Fill;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;


        }

        private void FillButton_Click(object sender, EventArgs e)
        {
            if (Fill_It)
            {
                Fill_It = false;
                FillButton.Image = Properties.Resources.Fill;
            }
            else
            {
                Fill_It = true;
                FillButton.Image = Properties.Resources.FillEnabled;
            }


            if (Fill_It) FillButton.Image = Properties.Resources.FillEnabled;
            if (!Fill_It) FillButton.Image = Properties.Resources.Fill;


            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;


            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Change Color
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

        }

        private void ChangeColorButton_Click(object sender, EventArgs e)
        {
            
            if (ChangeColor)
            {
                ChangeColor = false;
                ChangeColorButton.BackColor = Button.DefaultBackColor;
            }
            else
            {
                ChangeColor = true;
                ChangeColorButton.BackColor = Color.IndianRed;
            }


            if (ChangeColor) ChangeColorButton.BackColor = Color.IndianRed;
            if (!ChangeColor) ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;


            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;


            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;          
            FillButton.Image = Properties.Resources.Fill;
        }

        private void MoveButton_Click(object sender, EventArgs e)
        {
            if (is_Move)
            {
                is_Move = false;
                MoveButton.BackColor = Button.DefaultBackColor;
            }
            else
            {
                is_Move = true;
                MoveButton.BackColor = Color.IndianRed;
                panel1.Cursor = Cursors.SizeAll;
            }


            if (is_Move) MoveButton.BackColor = Color.IndianRed;
            if (!is_Move) MoveButton.BackColor = Button.DefaultBackColor;


            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;


            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

        }

        private void CopyButton_Click(object sender, EventArgs e)
        {
            if (MyList.Count > 0)
            {
                if (copy)
                {
                    copy = false;
                    CopyButton.FlatAppearance.BorderColor = Color.Black;
                }
                else
                {
                    copy = true;
                    CopyButton.FlatAppearance.BorderColor = Color.IndianRed;
                }               

                if(copy) CopyButton.FlatAppearance.BorderColor = Color.IndianRed;
                if(!copy) CopyButton.FlatAppearance.BorderColor = Color.Black;

            }
            else
            {
                MessageBox.Show("There is no shapes to be copyed");
            }


            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;


            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;

            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;           


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (is_Move)
            {
                panel1.Cursor = Cursors.SizeAll;
            }
            else if (Delete || reSize || ChangeColor || Fill_It) 
            {
                panel1.Cursor = Cursors.Hand;
            }
            else
            {
                panel1.Cursor = Cursors.Cross;
            }
        }

        private void CopyButton_MouseHover(object sender, EventArgs e)
        {            
            
        }

        private void CopyButton_MouseLeave(object sender, EventArgs e)
        {
            
            
        }

        private void PenButton_Click(object sender, EventArgs e)
        {
            if (curserMoving)
            {
                curserMoving = false;
                PenButton.Image = Properties.Resources.Pen;
            }
            else
            {
                curserMoving = true;
                PenButton.Image = Properties.Resources.PenEnabled;                
            }


            if (curserMoving) PenButton.Image = Properties.Resources.PenEnabled;
            if (!curserMoving) PenButton.Image = Properties.Resources.Pen;



            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //copy butoon
            copy = false;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fileToolStripMenuItem.ForeColor = Color.Black;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (curserMoving && mouseMove)
            {
                G.DrawLine(P, new Point(x1, y1), e.Location);
                G2.DrawLine(P, new Point(x1, y1), e.Location);
                x1 = e.X;
                y1 = e.Y;
            }
        }

        private void EraseButton_Click(object sender, EventArgs e)
        {
            if (erase)
            {
                erase = false;
                EraseButton.Image = Properties.Resources.Erase;
                P.Color = Color.Black;
                curserMoving = false;
            }
            else
            {
                erase = true;
                EraseButton.Image = Properties.Resources.EraseEnabled;
                P.Color = Color.White;
                curserMoving = true;
            }


            if (erase) EraseButton.Image = Properties.Resources.EraseEnabled;
            if (!erase) EraseButton.Image = Properties.Resources.Erase;


           
            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //copy butoon
            copy = false;


            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;

            //Pen Button            
            PenButton.Image = Properties.Resources.Pen;


        }

        private void ShapesGroupBox_Enter(object sender, EventArgs e)
        {
            if (erase)
            {
                P.Color = Color.Black;
                erase = false;
            }
        }

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PNG Image|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FilterIndex == 1)                       
                        Bimage.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);                    
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bimage = new Bitmap(dlg.FileName);
                    G2 = Graphics.FromImage(Bimage);
                    G.DrawImage(Bimage, 0, 0, Bimage.Width, Bimage.Height);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            G.Clear(Color.White);
            G2.Clear(Color.White);            
            MyList.Clear();
        }

        private void xMLToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "XMLFILE|*.xml";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    StreamReader Reader = new StreamReader(dlg.FileName);
                    if (dlg.FilterIndex == 1)
                    {
                        XmlSerializer SER = new XmlSerializer(typeof(List<Shape>));
                        MyList.AddRange((List<Shape>)SER.Deserialize(Reader));
                    }                   
                    Reader.Close();                   
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }

        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog dlg = new SaveFileDialog();
                dlg.Filter = "PNG Image|*.png";
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    if (dlg.FilterIndex == 1)
                        Bimage.Save(dlg.FileName, System.Drawing.Imaging.ImageFormat.Png);
                }
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dlg = new OpenFileDialog();

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    Bimage = new Bitmap(dlg.FileName);
                    G2 = Graphics.FromImage(Bimage);
                    G.DrawImage(Bimage, 0, 0, Bimage.Width, Bimage.Height);
                }
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
            }
        }

        private void ClipBoardGroupBox_Enter(object sender, EventArgs e)
        {
            if (erase)
            {
                P.Color = Color.Black;
                erase = false;
            }
        }

        private void PasteButton_Click(object sender, EventArgs e)
        {
            if (paste)
            {
                paste = false;
                PasteButton.FlatAppearance.BorderColor = Color.Black;
                PasteButton.ImageAlign = ContentAlignment.TopCenter;
            }
            else
            {
                paste = true;
                PasteButton.FlatAppearance.BorderColor = Color.IndianRed;
            }

            if (paste) PasteButton.FlatAppearance.BorderColor = Color.IndianRed;
            if (!paste) PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

                        
        }

        private void ResizeButton_Click(object sender, EventArgs e)
        {

            if (reSize)
            {
                reSize = false;
                ResizeButton.BackColor = Button.DefaultBackColor;
            }
            else
            {
                reSize = true;
                ResizeButton.BackColor = Color.IndianRed;
            }


            if (reSize) ResizeButton.BackColor = Color.IndianRed;
            if (!reSize) ResizeButton.BackColor = Button.DefaultBackColor;


            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RectangleButton.Text = "";
            TriangleButton.Text = "";
            DiamondButton.Text = "";
            RightTriangleButton.Text = "";
            TrapezoidalButton.Text = "";
            OvalButton.Text = "";
            LineButton.Text = "";
            HexagonButton.Text = "";
            ColorsButton.Text = "";
            TrashButton.Text = "";
            RectangleButton.Image = Properties.Resources.Rectangle;
            TriangleButton.Image = Properties.Resources.Triangle;            
            RightTriangleButton.Image = Properties.Resources.RightTriangle;
            DiamondButton.Image = Properties.Resources.Diamond;
            HexagonButton.Image = Properties.Resources.Hexagon;
            LineButton.Image = Properties.Resources.Line;
            OvalButton.Image = Properties.Resources.Oval;
            TrapezoidalButton.Image = Properties.Resources.Trapezoidal;
            ColorsButton.Image = Properties.Resources.Colors;
            Size1.Image = Properties.Resources.Size1;
            Size2.Image = Properties.Resources.Size2;
            Size3.Image = Properties.Resources.Size3;
            TrashButton.Image = Properties.Resources.Trash;
            FillButton.Image = Properties.Resources.Fill;
            CopyButton.Image = Properties.Resources.Copy;
            CopyButton.ImageAlign = ContentAlignment.MiddleLeft;
            PasteButton.Image = Properties.Resources.Paste;
            PasteButton.ImageAlign = ContentAlignment.TopCenter;
            PenButton.Image = Properties.Resources.Pen;
            EraseButton.Image = Properties.Resources.Erase;
        }

        private void button4_Click(object sender, EventArgs e)
        {            
            ShapeN = ShapeName.RightTriangle;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ShapeN = ShapeName.Oval;

            //Erase Button
            erase = false;
            EraseButton.Image = Properties.Resources.Erase;

            //Pen Button
            curserMoving = false;
            PenButton.Image = Properties.Resources.Pen;

            //copy butoon
            copy = false;
            CopyButton.FlatAppearance.BorderColor = Color.Black;

            //Move Button
            is_Move = false;
            MoveButton.BackColor = Button.DefaultBackColor;

            //Past Button
            paste = false;
            PasteButton.FlatAppearance.BorderColor = Color.Black;


            //Trash Button
            Delete = false;
            TrashButton.Image = Properties.Resources.Trash;

            //Resize Button
            reSize = false;
            ResizeButton.BackColor = Button.DefaultBackColor;

            //Fill Button
            Fill_It = false;
            FillButton.Image = Properties.Resources.Fill;

            //Change Colore
            ChangeColor = false;
            ChangeColorButton.BackColor = Button.DefaultBackColor;
        }
    }
}
