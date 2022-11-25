using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace graphicswithpermanentcontrol
{
    public partial class UserControl1 : UserControl
    {

        public UserControl1()
        {
            InitializeComponent();
        }
        public int w;
        public int h;
        public Graphics g;
        public Pen p;
        public Brush b;
        public Font f;
        public int X = 0;
        public int Y = 0;
        public int pX = 0;
        public int pY = 0;
        public int currentX = 0;
        public int currentY = 0;
        public int previewsX = 0;
        public int previewsY = 0;
        public int lastX = 0;
        public int lastY = 0;
        public Image img;
        public string mode = "NONE";
        public bool ISTHEFIRSTUSER = true;
        public string textuldeafisat = ".";
        public Point[] points = new Point[2];
        public void SetMode(string s) { mode = s; }
        public TextBox t = new TextBox();
        public bool EnterInDebugMode = false;
        public string debugtext = "";

        

        public void SetDebugModeOnOff(string onoff)
        {
            if (onoff == "ON") { this.EnterInDebugMode = true; }
            else if (onoff == "OFF") { this.EnterInDebugMode = false; } 
            if (this.EnterInDebugMode == true)
            {
                ParentForm.Controls.Add(t);
                t.Left = this.Left+this.Width + 10;
                t.Top = this.Top;
                t.Width = 50;
                t.Height = 100;
                t.Multiline = true;
                t.Visible = true;

            }
            else if(this.EnterInDebugMode == false)
            {
                t.Visible = false;
            }
        
        }
        


      

        void deseneaza(int x1, int y1, int x2, int y2, int sizew, int sizeh, string ps){


            if (mode == "NONE")
            {
                g.DrawEllipse(p, x1, y1, sizew, sizeh);
            }
            else if (mode == "DOT")
            {
               
                g.DrawEllipse(p, x2, y2, sizew, sizeh);
                
            }

            else if (mode == "LINE")
            {
                g.DrawLine(p, x1, y1, x2, y2);
            }

            else if (mode == "SQUARE")
            {
                g.DrawRectangle(p, x1, y1, x2, y2);
            }

            else if (mode == "ARC")
            {
                points[0] = new Point(x1, y1);
                points[1] = new Point(x2, y2);
                g.DrawCurve(p, points);
            }

            else if (mode == "CIRCLE")
            {
                g.DrawEllipse(p, x2, y2, 10, 10);
            }

            else if (mode == "ELIPSE")
            {
                g.DrawEllipse(p, x2, y2, x1, y1);
            }

            else if (mode == "TEXT")
            {
                g.DrawString(ps, f, b, x2, y1);
            }
            setthedebugtext();
          this.Refresh();
          }




       

        private void UserControl1_Enter(object sender, EventArgs e)
        {
            setthedebugtext();
        }

       

        public void setthedebugtext()
        {

            this.textuldeafisat = this.currentX.ToString() + "\r\n" +
                " " + this.currentY.ToString() + "\r\n" +
                " " + this.previewsX.ToString() + "\r\n" +
                " " + this.previewsY.ToString() + "\r\n" +
                " " + this.lastX.ToString() + "\r\n" +
                " " + this.lastY.ToString();
            t.Text = this.textuldeafisat;
        
        }
       

        private void UserControl1_MouseDown_1(object sender, MouseEventArgs e)
        {
            previewsX = e.X;
            previewsY = e.Y;
            setthedebugtext();
        }

        private void UserControl1_MouseUp_1(object sender, MouseEventArgs e)
        {
            lastX = e.X;
            lastY = e.Y;
            setthedebugtext();
        }

        private void UserControl1_MouseMove_1(object sender, MouseEventArgs e)
        {
            currentX = e.X;
            currentY = e.Y;
            setthedebugtext();
        }

        private void UserControl1_MouseEnter(object sender, EventArgs e)
        {

        }

        private void UserControl1_Paint_1(object sender, PaintEventArgs e)
        {
            try
            {
                //verifiy first if img , w , h and g exists
                e.Graphics.DrawImage(img, 0, 0, w, h);
                setthedebugtext();
            }
            catch { }
        }

        

        private void UserControl1_Load(object sender, EventArgs e)
        {
            //g = CreateGraphics();

            p = new Pen(Color.Red);
            b = new SolidBrush(Color.Red);
            f = this.Font;

            setthedebugtext();
        }

        private void UserControl1_MouseClick(object sender, MouseEventArgs e)
        {
            if (this.ISTHEFIRSTUSER == true)
            {
                w = this.Width;
                h = this.Height;
                img = new Bitmap(w, h);
                g = Graphics.FromImage(img);
                this.ISTHEFIRSTUSER = false;
            }

            X = e.X;
            Y = e.Y;

            deseneaza(pX, pY, X, Y, 2, 2, this.textuldeafisat);

            pX = X;
            pY = Y;
            setthedebugtext();
        }

        
    }
}

