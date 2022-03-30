using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password_Generator
{
    public partial class Form1 : Form
    {

        private List<String> stringaDaSalvare;
        private String pathFileSalvato;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnGeneraPassword_Click(object sender, EventArgs e)
        {
            if (lblNomeSito != null && lblNomeUtente != null && !lblNomeSito.Text.Equals("") && !lblNomeUtente.Text.Equals(""))
            {
                lblRisultatoPassword.Text = GeneraPassword();
                if (!lblRisultatoPassword.Text.Equals(""))
                {
                    lblRisultatoPassword.Visible = true;
                }
            }
        }

        private void btnSalvaPassword_Click(object sender, EventArgs e)
        {
            if (lblRisultatoPassword != null && lblRisultatoPassword.Visible && !lblRisultatoPassword.Equals(""))
            {
                SalvaPassword();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("Password Generator made by Andrea Antonio Perrelli." + System.Environment.NewLine + 
                "Check https://github.com/AndreaPerrelli/Password-Generator for further updates.", "About");

        }

        private String GeneraPassword()
        {
            Random rnd = new Random();
            List<String> numeri = new List<String> { "1", "2", "3", "4", "5", "6", "7", "8", "9", "0" };
            List<String> lettereAlfabetoMinuscole = new List<String> { "a", "b", "c", "d", "e", "f", "g", "h", "i", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "j", "y", "z", "k" };
            List<String> lettereAlfabetoMaisucole = new List<String> { "A", "B", "C", "D", "E", "F", "G", "H", "I", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "J", "Y", "Z", "K" };
            List<String> simboli = new List<String> { "#", "@", "]", "[", ",", ".", "-", "+", "*", "!", "£", "$", "%", "/", "(", ")", "=", "?", "^", "^" };
            int length = 32;
            String passwordGenerata = "";
            int sceltaListe = 1;
            int sceltaElementoLista = 0;

            for (int i = 0; i < length; i++)
            {
                switch (sceltaListe)
                {
                    case 1:
                        sceltaElementoLista = rnd.Next(numeri.Count);
                        passwordGenerata += numeri[sceltaElementoLista];
                        sceltaListe++;
                        break;
                    case 2:
                        sceltaElementoLista = rnd.Next(lettereAlfabetoMinuscole.Count);
                        passwordGenerata += lettereAlfabetoMinuscole[sceltaElementoLista];
                        sceltaListe++;
                        break;
                    case 3:
                        sceltaElementoLista = rnd.Next(lettereAlfabetoMaisucole.Count);
                        passwordGenerata += lettereAlfabetoMaisucole[sceltaElementoLista];
                        sceltaListe++;
                        break;
                    case 4:
                        sceltaElementoLista = rnd.Next(simboli.Count);
                        passwordGenerata += simboli[sceltaElementoLista];
                        sceltaListe = 1;
                        break;
                    default:
                        sceltaListe = 1;
                        break;

                }

            }

            stringaDaSalvare = new List<String> { Properties.Resources.lblNomeSito + txtboxNomeSito.Text, 
                                                  Properties.Resources.lblNomeUtente + txtboxNomeUtente.Text, 
                                                  Properties.Resources.lblPasswordOttenuta + passwordGenerata };


            return passwordGenerata;
        }
        private void SalvaPassword()
        {
            if(!File.Exists(pathFileSalvato))
            {
                File.Create(pathFileSalvato).Dispose();
                File.AppendAllText(pathFileSalvato, Environment.NewLine);
                foreach (var stringa in stringaDaSalvare)
                {
                    File.AppendAllText(pathFileSalvato, stringa + Environment.NewLine);
                }

                MessageBox.Show(Properties.Resources.salvataggioPassword + pathFileSalvato, "successo");
            } else
            {
                File.AppendAllText(pathFileSalvato, Environment.NewLine);
                foreach (var stringa in stringaDaSalvare)
                {
                    File.AppendAllText(pathFileSalvato, stringa + Environment.NewLine);
                }

                MessageBox.Show(Properties.Resources.salvataggioPassword + pathFileSalvato, "successo");
            }

        }
    }
}
