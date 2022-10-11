using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SekretariatPAD
{
    public partial class Sekretariat : Form
    {
        public Form2 form2;
        public Form form1;
        int liczba;
        String textObrazka;
        public Sekretariat()
        {
            InitializeComponent();
            
            Random rnd = new Random();

            
            liczba = rnd.Next(7);

            textW.Text = "Wpisz znaki które widzisz na poniższym obrazku, aby kontynuować";

            zobaczZdj.Image = imageList1.Images[liczba];
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            if (liczba == 0)
            {
                textObrazka = @"^mxyxw$";
            }
            else if(liczba == 1)
            {
                textObrazka = @"^b5nmm$";
            }
            else if (liczba == 2)
            {
                textObrazka = @"^74853$";
            }
            else if (liczba == 3)
            {
                textObrazka = @"^cg5dd$";
            }
            else if (liczba == 4)
            {
                textObrazka = @"^x3deb$";
            }
            else if (liczba == 5)
            {
                textObrazka = @"^befbd$";
            }
            else if (liczba == 6)
            {
                textObrazka = @"^c7gb3$";
            }

            String nazwa = @"^admin$";
            String haslo = @"^Qwerty1@34$";
            Regex rn = new Regex(nazwa);
            Regex rh = new Regex(haslo);
            Regex ro = new Regex(textObrazka);


             


            if ((rn.IsMatch(user.Text)) && (rh.IsMatch(password.Text)) && (ro.IsMatch(napisZdj.Text)))
            {

                blad.Text = "dobrze";
                this.Hide();
                form2 = new Form2();
                form2.Show();

            }
            else
            {
                blad.Text = "Błąd źle podana nazwa, hasło lub weryfikacja czy nie jesteś robotem";
                blad.ForeColor = Color.Red;
                
            }
        }

        private void losujObraz_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Random rnd = new Random();
            liczba = rnd.Next(7);
            zobaczZdj.Image = imageList1.Images[liczba];
        }
    }
}
