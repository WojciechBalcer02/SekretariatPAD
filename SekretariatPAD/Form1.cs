using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
