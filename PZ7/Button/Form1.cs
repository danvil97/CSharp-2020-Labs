using System;
using System.Drawing;
using System.Windows.Forms;

namespace Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private Point lMousePos;
        private Size lFormSize;
        private int DDx = 0;
        private int DDy = 0;
        private Point cur;

        private void MouseEnter(object sender, EventArgs e)
        {
            Point cursor = buttonPushMe.Parent.PointToClient(Cursor.Position);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lFormSize = ClientSize;
            buttonPushMe.Left = (ClientSize.Width - buttonPushMe.Width) / 2;
            buttonPushMe.Top = (ClientSize.Height - buttonPushMe.Height) / 2;
        }

        private void WindowMouseMove(object sender, MouseEventArgs e)
        {
            cur = new Point(e.X, e.Y);
            if (lMousePos == cur) return;

            int x = cur.X - buttonPushMe.Location.X;
            int y = cur.Y - buttonPushMe.Location.Y;
            int x2 = lMousePos.X - buttonPushMe.Location.X;
            int y2 = lMousePos.Y - buttonPushMe.Location.Y;

            double l = Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2));
            double l2 = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            if (l2 < l) return;
            double sp = SystemInformation.MouseSpeed /5;
            int dx = (int)(sp * x / l);
            int dy = (int)(sp * y / l);

            int nX = buttonPushMe.Location.X - dx;
            int nY = buttonPushMe.Location.Y - dy;

            if (buttonPushMe.Location.X - dx < 0 || buttonPushMe.Location.X - dx > ClientSize.Width - buttonPushMe.Width)
            {
                nX = buttonPushMe.Location.X + dx + (dx < 0 ? -20 : 20);
            }
            if (buttonPushMe.Location.Y - dy < 0 || buttonPushMe.Location.Y - dy > ClientSize.Height - buttonPushMe.Height)
            {
                nY = buttonPushMe.Location.Y + dy + (dy < 0 ? -20 : 20);
            }

            buttonPushMe.Location = new Point(nX, nY);
            lMousePos = cur;
        }

        private void buttonPushMe_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Поздравляем! Вы смогли нажать на кнопку!");
            buttonPushMe.Top = (ClientSize.Height - buttonPushMe.Height) / 2;
            buttonPushMe.Left = (ClientSize.Width - buttonPushMe.Width) / 2;
        }

        private void WindowResizing(object sender, EventArgs e)
        {
            DDx = lFormSize.Width - ClientSize.Width;
            DDy = lFormSize.Height - ClientSize.Height;
            lFormSize = ClientSize;
            if (DDx > 0 || DDy > 0)
            {
                buttonPushMe.Left = (buttonPushMe.Right > ClientSize.Width ? ClientSize.Width - buttonPushMe.Width - 20 : buttonPushMe.Left);
                buttonPushMe.Left = (buttonPushMe.Left < 0 ? 20 : buttonPushMe.Left);
                buttonPushMe.Top = (buttonPushMe.Top < 0 ? 20 : buttonPushMe.Top);
                buttonPushMe.Top = (buttonPushMe.Bottom > ClientSize.Height ? ClientSize.Height - buttonPushMe.Height - 20 : buttonPushMe.Top);
            }
        }
    }
}