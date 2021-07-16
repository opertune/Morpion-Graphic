using System;
using System.Windows.Forms;

namespace Morpion
{
    public partial class Form1 : Form
    {
        int player = 1, coup = 0;

        public Form1()
        {
            InitializeComponent();
            lblJoueur.Text = "Joueur " + player;
        }

        public bool check()
        {
            if (btnChoix1.Text == "X" && btnChoix2.Text == "X" && btnChoix3.Text == "X" ||
                btnChoix4.Text == "X" && btnChoix5.Text == "X" && btnChoix6.Text == "X" ||
                btnChoix7.Text == "X" && btnChoix8.Text == "X" && btnChoix9.Text == "X" ||
                btnChoix1.Text == "X" && btnChoix5.Text == "X" && btnChoix9.Text == "X" ||
                btnChoix3.Text == "X" && btnChoix5.Text == "X" && btnChoix7.Text == "X" ||
                btnChoix1.Text == "X" && btnChoix4.Text == "X" && btnChoix7.Text == "X" ||
                btnChoix2.Text == "X" && btnChoix5.Text == "X" && btnChoix8.Text == "X" ||
                btnChoix3.Text == "X" && btnChoix6.Text == "X" && btnChoix9.Text == "X" ||
                btnChoix1.Text == "O" && btnChoix2.Text == "O" && btnChoix3.Text == "O" ||
                btnChoix4.Text == "O" && btnChoix5.Text == "O" && btnChoix6.Text == "O" ||
                btnChoix7.Text == "O" && btnChoix8.Text == "O" && btnChoix9.Text == "O" ||
                btnChoix1.Text == "O" && btnChoix5.Text == "O" && btnChoix9.Text == "O" ||
                btnChoix3.Text == "O" && btnChoix5.Text == "O" && btnChoix7.Text == "O" ||
                btnChoix1.Text == "O" && btnChoix4.Text == "O" && btnChoix7.Text == "O" ||
                btnChoix2.Text == "O" && btnChoix5.Text == "O" && btnChoix8.Text == "O" ||
                btnChoix3.Text == "O" && btnChoix6.Text == "O" && btnChoix9.Text == "O")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void vainqueur()
        {
            if (check())
            {
                if (player == 1)
                {
                    player = 2;
                }
                else
                {
                    player = 1;
                }
               lblResult.Text = "Joueur " + player + " gagne !";
                btnChoix1.Enabled = false;
                btnChoix2.Enabled = false;
                btnChoix3.Enabled = false;
                btnChoix4.Enabled = false;
                btnChoix5.Enabled = false;
                btnChoix6.Enabled = false;
                btnChoix7.Enabled = false;
                btnChoix8.Enabled = false;
                btnChoix9.Enabled = false;
            }
            if (coup == 9)
            {
                lblResult.Text = "Match nul";
                btnChoix1.Enabled = false;
                btnChoix2.Enabled = false;
                btnChoix3.Enabled = false;
                btnChoix4.Enabled = false;
                btnChoix5.Enabled = false;
                btnChoix6.Enabled = false;
                btnChoix7.Enabled = false;
                btnChoix8.Enabled = false;
                btnChoix9.Enabled = false;
            }
        }
        private void btnChoix1_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix1.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix1.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            vainqueur();
        }

        private void btnChoix2_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix2.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix2.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix3_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix3.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix3.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            vainqueur();
        }

        private void btnChoix4_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix4.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix4.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix5_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix5.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix5.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix6_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix6.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix6.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix7_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix7.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix7.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix8_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix8.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix8.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }

        private void btnChoix9_Click(object sender, EventArgs e)
        {
            if (player == 1)
            {
                btnChoix9.Text = "X";
                player++;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }
            else
            {
                btnChoix9.Text = "O";
                player--;
                coup++;
                lblJoueur.Text = "Joueur " + player;
            }

            vainqueur();
        }
        private void btnRestart_Click(object sender, EventArgs e)
        {
            btnChoix1.Text = "";
            btnChoix2.Text = "";
            btnChoix3.Text = "";
            btnChoix4.Text = "";
            btnChoix5.Text = "";
            btnChoix6.Text = "";
            btnChoix7.Text = "";
            btnChoix8.Text = "";
            btnChoix9.Text = "";
            lblResult.Text = "";
            coup = 0;
            player = 1;
            lblJoueur.Text = "Joueur " + player;

            btnChoix1.Enabled = true;
            btnChoix2.Enabled = true;
            btnChoix3.Enabled = true;
            btnChoix4.Enabled = true;
            btnChoix5.Enabled = true;
            btnChoix6.Enabled = true;
            btnChoix7.Enabled = true;
            btnChoix8.Enabled = true;
            btnChoix9.Enabled = true;
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
