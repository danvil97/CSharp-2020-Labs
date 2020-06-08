using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colors
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ColorUpdate();            
        }
        ToolTip ttColor = new ToolTip();
        string curColor;
        public void ColorUpdate()
        {
            pictureBox_Color.BackColor = Color.FromArgb(trackBar_red.Value, trackBar_green.Value, trackBar_blue.Value);
            curColor = "#" + trackBar_red.Value.ToString("X") + trackBar_green.Value.ToString("X") + trackBar_blue.Value.ToString("X");
            Clipboard.SetText(curColor);
        }

        private void trackBar_red_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }
        

        private void trackBar_green_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }

        private void trackBar_blue_Scroll(object sender, EventArgs e)
        {
            ColorUpdate();
        }

        private void pictureBox_Color_MouseHover(object sender, EventArgs e)
        {            
            ttColor.SetToolTip(pictureBox_Color,curColor);
        }
    }
}
