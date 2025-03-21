using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace es
{
    public partial class Form1 : Form
    {
        // fare uno struct solo,una sola funzione per il movimento a cui passo il panel



        int punti_puffo = 0;
        int punti_garga = 0;
        bool turno_puffo = true;
        public Random rnd;
        Panel[] alberi;

        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            dimensioni_campo();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            alberi = new Panel [] { pnl_albero1, pnl_albero2, pnl_albero3, pnl_albero4, pnl_albero5, pnl_albero6, pnl_albero7, pnl_albero8, pnl_albero9, pnl_albero10 };
            crea(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
            crea(pnl_puffo, coord_a_caso(pnl_puffo.Width), coord_a_caso(pnl_puffo.Height));
            crea(pnl_garga, coord_a_caso(pnl_garga.Width), coord_a_caso(pnl_garga.Height));
            crea_alberi(alberi);
            crea_alberi(alberi);
            aggiorna(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
            aggiorna(pnl_puffo,coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
            aggiorna(pnl_garga, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
            lbl_garga_punti.Text = $"punti di gargamella{punti_garga}";
            lbl_puffo_punti.Text = $"punti del puffo {punti_puffo}";

            lbl_puffo_punti.Text = $"il punteggio del puffo è: {punti_puffo}";
            lbl_garga_punti.Text = $"il punteggio di gargamella è: {punti_garga}";
        }


        public void crea_alberi(Panel[] cosa)
        {
            for (int i = 0; i < cosa.Length; i++)
            {
                int x = coord_a_caso(cosa[i].Width);
                int y = coord_a_caso(cosa[i].Height);
                cosa[i].Location = new Point(x, y);
            }
        }

        public  void crea(Panel cosa, int x, int y)
        {
            cosa.Location = new Point(x, y);
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
        private int coord_a_caso(int min)
        {
            int massimo = pnl_campo.Width - min;
            int x = rnd.Next(0, massimo);
            return x;
        }

        private void aggiorna(Panel cosa, int x, int y)
        {
            int x_min = 0;
            int y_min = 0;
            int x_max = pnl_campo.Width - cosa.Width;
            int y_max = pnl_campo.Height - cosa.Height;
            int x_try = cosa.Location.X + x;
            int y_try = cosa.Location.Y + y;

            if (x_try >= x_min && x_try <= x_max)
            {
                if (y_try >= y_min && y_try <= y_max)
                {
                    cosa.Location = new Point(x_try, y_try);
                    controlla(cosa, x_try, y_try);
                    controlla_albero(cosa, x_try, y_try);
                    controlla_puffo(cosa, x_try, y_try);
                    controlla_albero(cosa,  x_try, y_try);
                    turno_puffo = false;
                }
            }
        }

        

        

        private void controlla(Panel panel, int x, int y)
        {
            int casa_sopra = pnl_casa.Location.Y;
            int casa_sotto = pnl_casa.Location.Y + pnl_casa.Height;
            int casa_destra = pnl_casa.Location.X + pnl_casa.Width;
            int casa_sinistra = pnl_casa.Location.X;

            int sopra = panel.Location.Y;
            int sotto = panel.Location.Y + panel.Height;
            int destra = panel.Location.X + panel.Width;
            int sinistra = panel.Location.X;

            if (sopra <= casa_sotto && sotto >= casa_sopra &&
                destra >= casa_sinistra && sinistra <= casa_destra)
            {
                if (turno_puffo)
                {
                    punti_puffo += 10;
                    lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
                }
                else
                {
                    punti_garga -= 10;
                    lbl_garga_punti.Text = $"il punteggio di gargamella è {punti_garga}";
                }


                crea(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
                crea(pnl_puffo, coord_a_caso(pnl_puffo.Width), coord_a_caso(pnl_puffo.Height));
                crea(pnl_garga, coord_a_caso(pnl_garga.Width), coord_a_caso(pnl_garga.Height));
                crea_alberi(alberi);
            }
        }

       
        private void controlla_albero(Panel panel, int x, int y)
        {
            //uno solo per tutti e due

            


            

            //salvare solo questo for
            for (int i = 0; i < 10; i++)
            {
                int sopra = panel.Location.Y;
                int sotto = panel.Location.Y + panel.Height;
                int destra = panel.Location.X + panel.Width;
                int sinistra = panel.Location.X;

                int albero_sopra = alberi[i].Width;
                int albero_sotto = alberi[i].Width + alberi[i].Height;
                int albero_destra = alberi[i].Height + alberi[i].Width;
                int albero_sinistra = alberi[i].Height;

                if (sopra > albero_sotto && sotto < albero_sopra &&
                    destra < albero_sinistra && sinistra > albero_destra)
                {
                    if(turno_puffo)
                    {
                        punti_puffo -= 10;
                        lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
                        crea(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
                        crea(pnl_puffo, coord_a_caso(pnl_puffo.Width), coord_a_caso(pnl_puffo.Height));
                        crea(pnl_garga, coord_a_caso(pnl_garga.Width), coord_a_caso(pnl_garga.Height));
                        crea_alberi(alberi);
                        return;
                    }
                    else
                    {
                        punti_garga -= 10;
                        lbl_garga_punti.Text = $"il punteggio di gargamella è {punti_puffo}";
                        crea(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
                        crea(pnl_puffo, coord_a_caso(pnl_puffo.Width), coord_a_caso(pnl_puffo.Height));
                        crea(pnl_garga, coord_a_caso(pnl_garga.Width), coord_a_caso(pnl_garga.Height));
                        crea_alberi(alberi);
                        return;
                    }
                }
            }
        }
        //unica per garga e casa
        private void controlla_puffo(Panel panel,int x, int y)
        {

            int puffo_sopra = pnl_puffo.Location.Y;
            int puffo_sotto = pnl_puffo.Location.Y + pnl_puffo.Height;
            int puffo_destra = pnl_puffo.Location.X + pnl_puffo.Width;
            int puffo_sinistra = pnl_puffo.Location.X;

            int sopra = pnl_garga.Location.Y;
            int sotto = pnl_garga.Location.Y + pnl_garga.Height;
            int destra = pnl_garga.Location.X + pnl_garga.Width;
            int sinistra = pnl_garga.Location.X;

            if (sopra <= puffo_sotto && sotto >= puffo_sopra &&
                destra >= puffo_sinistra && sinistra <= puffo_destra)
            {
                punti_puffo -= 10;
                punti_garga += 10;
                crea(pnl_casa, coord_a_caso(pnl_casa.Width), coord_a_caso(pnl_casa.Height));
                crea(pnl_puffo, coord_a_caso(pnl_puffo.Width), coord_a_caso(pnl_puffo.Height));
                crea(pnl_garga, coord_a_caso(pnl_garga.Width), coord_a_caso(pnl_garga.Height));
                crea_alberi(alberi);
                lbl_puffo_punti.Text = $"il punteggio del puffo è {punti_puffo}";
                lbl_garga_punti.Text = $"il punteggio di gargamella è {punti_garga}";

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (turno_puffo)
                    {
                        muovi(0, -10); // Muovi il puffo in alto
                    }
                    break;
                case Keys.A:
                    if (turno_puffo)
                    {
                        muovi(-10, 0); // Muovi il puffo a sinistra
                    }
                    break;
                case Keys.S:
                    if (turno_puffo)
                    {
                        muovi(0, 10); // Muovi il puffo in basso
                    }
                    break;
                case Keys.D:
                    if (turno_puffo)
                    {
                        muovi(10, 0); // Muovi il puffo a destra
                    }
                    break;
                case Keys.I:
                    if (!turno_puffo)
                    {
                        muovi(0, -10); // Muovi Gargamella in alto
                    }
                    break;
                case Keys.J:
                    if (!turno_puffo)
                    {
                        muovi(-10, 0); // Muovi Gargamella a sinistra
                    }
                    break;
                case Keys.K:
                    if (!turno_puffo)
                    {
                        muovi(0, 10); // Muovi Gargamella in basso
                    }
                    break;
                case Keys.L:
                    if (!turno_puffo)
                    {
                        muovi(10, 0); // Muovi Gargamella a destra
                    }
                    break;
            }
        }



        private void btn_puffo_up_Click(object sender, EventArgs e)
        {
            if (turno_puffo) {
                muovi(0, -10);
            }
        }

        private void btn_puffo_down_Click(object sender, EventArgs e)
        {
            if (turno_puffo)
            {
                muovi(0, 10);
            }
        }

        private void btn_puffo_right_Click(object sender, EventArgs e)
        {
            if (turno_puffo)
            {
                muovi(10, 0);
            }
        } 

        private void btn_puffo_left_Click(object sender, EventArgs e)
        {
            if (turno_puffo)
            {
                muovi(-10, 0);
            }
            
        }

        private void btn_garga_up_Click(object sender, EventArgs e)
        {
            if (!turno_puffo)
            {
                muovi(0, -10);
            }
        }

        private void btn_garga_down_Click(object sender, EventArgs e)
        {
            if (!turno_puffo)
            {
                muovi(0, 10);
            }
        }

        private void btn_garga_right_Click(object sender, EventArgs e)
        {
            if (!turno_puffo)
            {
                muovi(10, 0);
            }
        }

        private void btn_garga_left_Click(object sender, EventArgs e)
        {
            if (!turno_puffo)
            {
                muovi(-10, 0);
            }
            
        }

        private void muovi(int x, int y)
        {
            if(turno_puffo)
            {
                aggiorna(pnl_puffo , x, y);
                turno_puffo = false;
            }
            else
            {
                aggiorna(pnl_garga, x, y);
                turno_puffo = true;
            }
        }
       
    }
}
