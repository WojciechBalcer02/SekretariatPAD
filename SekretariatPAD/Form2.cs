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

namespace SekretariatPAD
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            string path = @"uczen.txt";
            StreamWriter sw;
            String tekstdozapisu = name.Text + " " + lastname.Text + " " + classname.Text;
            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
                MessageBox.Show("utworzono plik");
            }
            else
            {
                sw = new StreamWriter(path, true);
                MessageBox.Show("Dodano nowego ucznia");
            }
            sw.WriteLine(tekstdozapisu);
            sw.Close();
            
        }

        private void Form2_Shown(object sender, EventArgs e)
        {
            
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
