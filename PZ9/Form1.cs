using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PZ9
{
    public partial class Form1 : Form
    {
        Graphics Graph;
        Pen myPen;
        SolidBrush bg;
        SolidBrush figure;
        int radius = 30;
        Random randNum = new Random();
        List<Molecule> Arr = new List<Molecule>();
        int num = 1;
        int sp = 5;

        public Form1()
        {
            InitializeComponent();
        }


        void DrawCircle(int x, int y)
        {
            int xc, yc;
            xc = x - radius;
            yc = y - radius;
            Graph.FillEllipse(figure, xc, yc, radius, radius);
            Graph.DrawEllipse(myPen, xc, yc, radius, radius);
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            Graph = pictureBoxDisplay.CreateGraphics();
            myPen = new Pen(Color.Black);
            bg = new SolidBrush(Color.LightGray);
            figure = new SolidBrush(Color.Black);
            Arr = new List<Molecule>();
            num = 1;
            Graph.FillRectangle(bg, 0, 0, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
            int x, y, vx, vy;
            for (int i = 0; i < (int)numericUpDownMolCount.Value; i++)
            {
                x = randNum.Next(radius, pictureBoxDisplay.Width - radius);
                y = randNum.Next(radius, pictureBoxDisplay.Height - radius);
                vx = randNum.Next(1, 5);
                vy = randNum.Next(1, 5);
                if (randNum.Next(1, 2) == 1)
                {
                    vx = -vx;
                }
                if (randNum.Next(1, 2) == 1)
                {
                    vy = -vy;
                }
                if (num == 1)
                {
                    Arr.Add(new Molecule(radius, x, y, vx, vy, pictureBoxDisplay.Width, pictureBoxDisplay.Height, num));
                    num++;
                    DrawCircle(x, y);
                }
                else
                {
                    if (Arr.Last().Check(radius, x, y, Arr))
                    {
                        Arr.Add(new Molecule(radius, x, y, vx, vy, pictureBoxDisplay.Width, pictureBoxDisplay.Height, num));
                        num++;
                        DrawCircle(x, y);
                    }
                    else
                    {
                        i--;
                    }
                }
            }
            timer1.Interval = 50;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Task> task = new List<Task>();
            Molecule[] ArrK = new Molecule[Arr.Count];
            Arr.CopyTo(ArrK);
            foreach (var i in Arr)
            {
                task.Add(new Task(() => i.Update(ArrK)));
                task.Last().Start();
            }
            Task.WaitAll(task.ToArray());
            Graph.FillRectangle(bg, 0, 0, pictureBoxDisplay.Width, pictureBoxDisplay.Height);
            foreach (var i in Arr)
            {
                i.svx = i.vx;
                i.svy = i.vy;
                i.sx = i.x;
                i.sy = i.y;
                DrawCircle(i.x, i.y);
            }
        }

        private void trackBarTemp_Scroll(object sender, EventArgs e)
        {
            foreach (var i in Arr)
            {
                i.ChangeSpeed(trackBarTemp.Value - sp);
                sp = trackBarTemp.Value;
            }
        }


    }
}
