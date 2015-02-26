using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PaintOnEntireScreen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            g = pnl_Draw.CreateGraphics();
            currentColor = colors[1];
        }

        Graphics g;
        Color cc;
        bool stopDrawing = false;

        Dictionary<Keys, int> keys2char = new Dictionary<Keys, int>()
        {
            {Keys.D1, 1},
            {                Keys.D2, 2            },
            {                Keys.D3, 3            },
            {                Keys.D4, 4            },
            {                Keys.D5, 5            },
            {                Keys.D6, 6            },
            {                Keys.D7, 7            },
            {                Keys.D8, 8            },
            {                Keys.D9, 9            },
            {                Keys.D0, 0            }
        };

        public Color currentColor
        {
            get { return cc; }
            set { cc = value; label1.Text = cc.Name; }
        }

        public Color[] colors = { Color.White, Color.Green, Color.Red, Color.Blue, Color.Violet, Color.Black };

        int? oldX = null;
        int? oldY = null;

        private void pnl_Draw_MouseMove(object sender, MouseEventArgs e)
        {
            if (!stopDrawing)
            {
                Pen pen = new Pen(currentColor, 10);
                g.DrawLine(pen, new Point(oldX ?? e.X, oldY ?? e.Y), new Point(e.X, e.Y));
            }
            oldX = e.X;
            oldY = e.Y;
        }

        private void pnl_Draw_MouseEnter(object sender, EventArgs e)
        {
            //label1.Text = "entered";
        }

        private void pnl_Draw_MouseLeave(object sender, EventArgs e)
        {
            //label1.Text = "out";
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode >= Keys.D0 && e.KeyCode <= Keys.D9 && keys2char[e.KeyCode] < colors.Length)
                currentColor = colors[keys2char[e.KeyCode]];
            else
                if (e.KeyCode == Keys.Space)
                    g.Clear(pnl_Draw.BackColor);
                else
                    if (e.KeyCode == Keys.Tab)
                        stopDrawing = !stopDrawing;
        }
    }
}
