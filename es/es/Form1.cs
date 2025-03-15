using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
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

        struct puffo
        {
            public int x;
            public int y;

            public puffo(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        struct casa
        {
            public int x;
            public int y;
            public casa(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        struct albero
        {
            public int x;
            public int y;
            public albero(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        struct gargamella
        {
            public int x;
            public int y;
            public gargamella(int X, int Y)
            {
                x = X;
                y = Y;
            }
        }

        puffo puffo_c;
        casa casa_c;
        gargamella gargamella_c;
        int punti_puffo = 0;
        int punti_garga = 0;
        bool turno_puffo = true;
        int[] x_alberi = new int[10];
        int[] y_alberi = new int[10];
        bool it_albero = false;
        public Random rnd;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            dimensioni_campo();
            int radnomx_puffo = x_a_caso(pnl_campo.Width - pnl_puffo.Width);
            int randomy_puffo = y_a_caso(pnl_campo.Height - pnl_puffo.Height);
            int radnomx_casa = x_a_caso(pnl_campo.Height - pnl_casa.Height);
            int randomy_casa = y_a_caso(pnl_campo.Height - pnl_casa.Height);
            int randomx_garga = x_a_caso(pnl_campo.Width - pnl_garga.Width);
            int randomy_garga = y_a_caso(pnl_campo.Height - pnl_garga.Height);
            puffo_c = new puffo(radnomx_puffo, randomy_puffo);
            casa_c = new casa(radnomx_casa, randomy_casa);
            MessageBox.Show(puffo_c.x.ToString() + " " + puffo_c.y.ToString());
            MessageBox.Show(casa_c.x.ToString() + " " + casa_c.y.ToString());
            gargamella_c = new gargamella(randomx_garga, randomy_garga);
            lbl_garga_punti.Text = $"punti di gargamella{punti_garga}";
            lbl_puffo_punti.Text = $"punti del puffo {punti_puffo}";
            
            lbl_puffo_punti.Text = $"il punteggio del puffo è: {punti_puffo}";
            lbl_garga_punti.Text = $"il punteggio di gargamella è: {punti_garga}";
            aggiorna_albero();
            aggiona_casa();
            aggiona_puffo();
            aggiorna_garga();
        }

        private void aggiorna_albero()
        {
            for (int i = 0; i < 10; i++)
            {
                int randomx_alberi = x_a_caso(pnl_campo.Width - pnl_albero1.Width);
                int randomy_alberi = y_a_caso(pnl_campo.Height - pnl_puffo.Height);

                switch (i)
                {
                    case 0:
                        int randomx_albero1 = y_a_caso(pnl_campo.Width - pnl_albero1.Width);
                        int randomy_albero1 = y_a_caso(pnl_campo.Height - pnl_albero1.Height);
                        pnl_albero1.Location = new Point(50, 100);
                        x_alberi[i] = 50;
                        y_alberi[i] = 100;
                        break;
                    case 1:
                        int randomx_albero2 = y_a_caso(pnl_campo.Width - pnl_albero2.Width);
                        int randomy_albero2 = y_a_caso(pnl_campo.Height - pnl_albero2.Height);
                        pnl_albero2.Location = new Point(120, 200);
                        x_alberi[i] = 120;
                        y_alberi[i] = 200;
                        break;
                    case 2:
                        int randomx_albero3 = y_a_caso(pnl_campo.Width - pnl_albero3.Width);
                        int randomy_albero3 = y_a_caso(pnl_campo.Height - pnl_albero3.Height);
                        pnl_albero3.Location = new Point(300, 150);
                        x_alberi[i] = 300;
                        y_alberi[i] = 150;
                        break;
                    case 3:
                        int randomx_albero4 = y_a_caso(pnl_campo.Width - pnl_albero4.Width);
                        int randomy_albero4 = y_a_caso(pnl_campo.Height - pnl_albero4.Height);
                        pnl_albero4.Location = new Point(80, 250);
                        x_alberi[i] = 80;
                        y_alberi[i] = 250;
                        break;
                    case 4:
                        int randomx_albero5 = y_a_caso(pnl_campo.Width - pnl_albero5.Width);
                        int randomy_albero5 = y_a_caso(pnl_campo.Height - pnl_albero5.Height);
                        pnl_albero5.Location = new Point(200, 300);
                        x_alberi[i] = 200;
                        y_alberi[i] = 300;
                        break;
                    case 5:
                        int randomx_albero6 = y_a_caso(pnl_campo.Width - pnl_albero6.Width);
                        int randomy_albero6 = y_a_caso(pnl_campo.Height - pnl_albero6.Height);
                        pnl_albero6.Location = new Point(350, 50);
                        x_alberi[i] = 350;
                        y_alberi[i] = 50;
                        break;
                    case 6:
                        int randomx_albero7 = y_a_caso(pnl_campo.Width - pnl_albero7.Width);
                        int randomy_albero7 = y_a_caso(pnl_campo.Height - pnl_albero7.Height);
                        pnl_albero7.Location = new Point(180, 180);
                        x_alberi[i] = 180;
                        y_alberi[i] = 180;
                        break;
                    case 7:
                        int randomx_albero8 = y_a_caso(pnl_campo.Width - pnl_albero8.Width);
                        int randomy_albero8 = y_a_caso(pnl_campo.Height - pnl_albero8.Height);
                        pnl_albero8.Location = new Point(270, 90);
                        x_alberi[i] = 270;
                        y_alberi[i] = 90;
                        break;
                    case 8:
                        int randomx_albero9 = y_a_caso(pnl_campo.Width - pnl_albero9.Width);
                        int randomy_albero9 = y_a_caso(pnl_campo.Height - pnl_albero9.Height);
                        pnl_albero9.Location = new Point(60, 340);
                        x_alberi[i] = 60;
                        y_alberi[i] = 340;
                        break;
                    case 9:
                        int randomx_albero10 = y_a_caso(pnl_campo.Width - pnl_albero10.Width);
                        int randomy_albero10 = y_a_caso(pnl_campo.Height - pnl_albero10.Height);
                        pnl_albero10.Location = new Point(220, 220);
                        x_alberi[i] = 220;
                        y_alberi[i] = 220;
                        break;
                }
            }
        }
        private void dimensioni_campo()
        {
            pnl_casa.Width = 30;
            pnl_casa.Height = 30;
            pnl_puffo.Width = 30;
            pnl_puffo.Height = 30;
            pnl_campo.Width = 390;
            pnl_campo.Height = 390;
        }

        private void aggiorna_garga()
        {
            pnl_garga.Location = new Point(320, 320);
        }

        private void aggiona_casa()
        {
            pnl_casa.Location = new Point(casa_c.x, casa_c.y);
        }

        private void aggiona_puffo()
        {
            pnl_puffo.Location = new Point(puffo_c.x, puffo_c.y);
        }
        private int x_a_caso(int massimo)
        {
               
            int x = rnd.Next(0, massimo);
            return x;
        }

        private void aggiona_puffo_muovi(int x, int y)
        {
            int x_min = 0;
            int y_min = 0;
            int x_max = pnl_campo.Width - pnl_puffo.Width;
            int y_max = pnl_campo.Height - pnl_puffo.Height;
            int x_try = pnl_puffo.Location.X + x;
            int y_try = pnl_puffo.Location.Y + y;

            if (x_try >= x_min && x_try <= x_max)
            {
                if (y_try >= y_min && y_try <= y_max)
                {
                    pnl_puffo.Location = new Point(x_try, y_try);
                    controlla_casa(x_try, y_try);
                    controlla_albero(x_try, y_try);
                    turno_puffo = false;
                }
            }
        }

        private void aggiona_garga_muovi(int x, int y)
        {
            int x_min = 0;
            int y_min = 0;
            int x_max = pnl_campo.Width - pnl_puffo.Width;
            int y_max = pnl_campo.Height - pnl_puffo.Height;
            int x_try = pnl_garga.Location.X + x;
            int y_try = pnl_garga.Location.Y + y;

            if (x_try >= x_min && x_try <= x_max)
            {
                if (y_try >= y_min && y_try <= y_max)
                {
                    pnl_garga.Location = new Point(x_try, y_try);
                    controlla_puffo(x_try, y_try);
                    controlla_albero(x_try, y_try);
                    turno_puffo = true;
                }
            }
        }

        private void controlla_casa(int x, int y) {

            int puffo_sopra = pnl_puffo.Location.Y;
            int puffo_sotto = pnl_puffo.Location.Y + pnl_puffo.Height;
            int puffo_destra = pnl_puffo.Location.X + pnl_puffo.Width;
            int puffo_sinistra = pnl_puffo.Location.X;

            int casa_sopra = pnl_casa.Location.Y;
            int casa_sotto = pnl_casa.Location.Y + pnl_casa.Height;
            int casa_destra = pnl_casa.Location.X + pnl_casa.Width;
            int casa_sinistra = pnl_casa.Location.X;

            int x_nuova_casa;
            int y_nuova_casa;
            int x_nuova_puffo;
            int y_nuova_puffo;

            if (puffo_sopra <= casa_sotto && puffo_sotto >= casa_sopra &&
                puffo_destra >= casa_sinistra && puffo_sinistra <= casa_destra)
            {
                x_nuova_casa = x_a_caso(pnl_campo.Width - pnl_puffo.Width);
                y_nuova_casa = y_a_caso(pnl_campo.Height - pnl_puffo.Height);
                x_nuova_puffo = x_a_caso(pnl_campo.Width - pnl_puffo.Width);
                y_nuova_puffo = y_a_caso(pnl_campo.Height - pnl_puffo.Height);
                pnl_casa.Location = new Point(x_nuova_casa, y_nuova_casa);
                pnl_puffo.Location = new Point(x_nuova_puffo, y_nuova_puffo);
                punti_puffo += 10;
                lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
            }
        }

        private void controlla_albero(int x, int y)
        {
            int puffo_sopra = pnl_puffo.Location.Y;
            int puffo_sotto = pnl_puffo.Location.Y + pnl_puffo.Height;
            int puffo_destra = pnl_puffo.Location.X + pnl_puffo.Width;
            int puffo_sinistra = pnl_puffo.Location.X;

            int garga_sopra = pnl_garga.Location.Y;
            int garga_sotto = pnl_garga.Location.Y + pnl_garga.Height;
            int garga_destra = pnl_garga.Location.X + pnl_garga.Width;
            int garga_sinistra = pnl_garga.Location.X;

            if (turno_puffo)
            {
                for (int i = 0; i < 10; i++)
                {
                    int albero_sopra = y_alberi[i];
                    int albero_sotto = y_alberi[i] + pnl_albero1.Height;
                    int albero_destra = x_alberi[i] + pnl_albero1.Width;
                    int albero_sinistra = x_alberi[i];

                    if (puffo_sopra <= albero_sotto && puffo_sotto >= albero_sopra &&
                        puffo_destra >= albero_sinistra && puffo_sinistra <= albero_destra)
                    {
                        punti_puffo -= 10;
                        it_albero = true;
                        lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
                        return;
                    }
                }
            }
            else
            {
                for (int i = 0; i < 10; i++)
                {
                    int albero_sopra = y_alberi[i];
                    int albero_sotto = y_alberi[i] + pnl_albero1.Height;
                    int albero_destra = x_alberi[i] + pnl_albero1.Width;
                    int albero_sinistra = x_alberi[i];

                    if (garga_sopra <= albero_sotto && garga_sotto >= albero_sopra &&
                        garga_destra >= albero_sinistra && garga_sinistra <= albero_destra)
                    {
                        punti_garga -= 10;
                        it_albero = true;
                        lbl_garga_punti.Text = $"il punteggio di puffo è {punti_garga}";
                        return;
                    }
                }
            }
        }

        private void controlla_puffo(int x, int y)
        {

            int puffo_sopra = pnl_puffo.Location.Y;
            int puffo_sotto = pnl_puffo.Location.Y + pnl_puffo.Height;
            int puffo_destra = pnl_puffo.Location.X + pnl_puffo.Width;
            int puffo_sinistra = pnl_puffo.Location.X;

            int garga_sopra = pnl_garga.Location.Y;
            int garga_sotto = pnl_garga.Location.Y + pnl_puffo.Height;
            int garga_destra = pnl_garga.Location.X + pnl_puffo.Width;
            int garga_sinistra = pnl_garga.Location.X;

            int x_nuova_casa;
            int y_nuova_casa;
            int x_nuova_puffo;
            int y_nuova_puffo;

            if (garga_sopra <= puffo_sotto && garga_sotto >= puffo_sopra &&
                garga_destra >= puffo_sinistra && garga_sinistra <= puffo_destra)
            {
                x_nuova_casa = x_a_caso(pnl_campo.Width - pnl_garga.Width);
                y_nuova_casa = y_a_caso(pnl_campo.Height - pnl_garga.Height);
                x_nuova_puffo = x_a_caso(pnl_campo.Width - pnl_puffo.Width);
                y_nuova_puffo = y_a_caso(pnl_campo.Height - pnl_puffo.Height);
                pnl_garga.Location = new Point(x_nuova_casa, y_nuova_casa);
                pnl_puffo.Location = new Point(x_nuova_puffo, y_nuova_puffo);
                punti_puffo -= 10;
                punti_garga += 10;
                lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
                lbl_garga_punti.Text = $"il punteggio di gargamella è {punti_garga}";

            }
        }

        private int y_a_caso(int massimo)
        {
            int y = rnd.Next(0, massimo);
            return y;
        }
        private void btn_puffo_up_Click(object sender, EventArgs e)
        {
            if (turno_puffo && !it_albero)
            {
                aggiona_puffo_muovi(0, -10);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        }

        private void btn_puffo_down_Click(object sender, EventArgs e)
        {
            if (turno_puffo && !it_albero) {
                aggiona_puffo_muovi(0, 10);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }

        }

        private void btn_puffo_right_Click(object sender, EventArgs e)
        {
            if (turno_puffo && !it_albero) {
                aggiona_puffo_muovi(10, 0);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        } 

        private void btn_puffo_left_Click(object sender, EventArgs e)
        {
            if (turno_puffo && !it_albero) {
                aggiona_puffo_muovi(-10, 0);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        }

        private void btn_garga_up_Click(object sender, EventArgs e)
        {
            if (!turno_puffo && !it_albero) {
                aggiona_garga_muovi(0, -10);
            }
            else if (!turno_puffo && it_albero)
            {
                aggiona_garga_muovi(0, -10); 
            }
            else
            {
                it_albero = false;
            }
        }

        private void btn_garga_down_Click(object sender, EventArgs e)
        {
            if (!turno_puffo && !it_albero) {
                aggiona_garga_muovi(0, 10);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        }

        private void btn_garga_right_Click(object sender, EventArgs e)
        {
            if (!turno_puffo && !it_albero) {
                aggiona_garga_muovi(10, 0);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        }

        private void btn_garga_left_Click(object sender, EventArgs e)
        {
            if (!turno_puffo && !it_albero) {
                aggiona_garga_muovi(-10, 0);
            }
            else if (turno_puffo && it_albero)
            {
                it_albero = false;
            }
        }

       
    }
}
