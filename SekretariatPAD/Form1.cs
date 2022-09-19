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
        public Sekretariat()
        {
            InitializeComponent();
            textW.Text = "Wpisz znaki które widzisz na poniższym obrazku, aby kontynuować";
        }

        private void user_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            String nazwa = @"^admin$";
            String haslo = @"^Qwerty1@34$";
            Regex rn = new Regex(nazwa);
            Regex rh = new Regex(haslo);
            if ((rn.IsMatch(user.Text)) && rh.IsMatch(password.Text))
            {
                blad.Text = "dobrze";
            }
            else
            {
                blad.Text = "Błąd źle podana nazwa, hasło lub weryfikacja czy nie jesteś robotem";
                blad.ForeColor = Color.Red;
            }
        }
    }
}
