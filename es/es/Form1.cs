using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        
        struct punto
        {
            public int x;
            public int y;

            public punto(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        punto puffo;

        public Form1()
        {
            InitializeComponent();
            int radnomx = x_a_caso();
            int randomy = y_a_caso();
            puffo = new punto(radnomx, randomy);
            aggiona_puffo();
        }
        
        private void aggiona_puffo()
        {
            pnl_puffo.Location = new Point(puffo.x, puffo.y);
        }
        static private int x_a_caso()
        {
            Random rnd = new Random(Environment.TickCount);
            int x = rnd.Next(0, 391);
            return x;
        }

        private void aggiona_puffo_muovi(int new_x, int new_y)
        {
            int x_min = 0;
            int y_min = 0;
            int x_max = 390 - pnl_puffo.Width;
            int y_max = 390 - pnl_puffo.Height;
            int x_try = pnl_puffo.Location.X + new_x;
            int y_try = pnl_puffo.Location.Y + new_y;

            if(x_try > x_min && x_try< x_max)
            {

            }
        }

        static private int y_a_caso()
        {
            Random rnd = new Random(Environment.TickCount);
            int y = rnd.Next(0, 391);
            return y;
        }
        private void btn_puffo_up_Click(object sender, EventArgs e)
        {
            aggiona_puffo_muovi(10, 0);
        }

        private void btn_puffo_down_Click(object sender, EventArgs e)
        {

        }

        private void btn_puffo_right_Click(object sender, EventArgs e)
        {

        }

        private void btn_puffo_left_Click(object sender, EventArgs e)
        {

        }
    }
}
