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
        string path = @"uczen.txt";
        StreamReader sr;
        String I;
        String N;
        String K;
        public Form2()
        {
            InitializeComponent();
            
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void add_Click(object sender, EventArgs e)
        {
            
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

        private void search_Click(object sender, EventArgs e)
        {
            
            if (File.Exists(path))
            {
                sr = new StreamReader(path);
            }
            else
            {
                MessageBox.Show("Pliku nie ma");
            }
            String textRead = sr.ReadLine();
            //richTextBox1.Text = textRead;

            while (textRead != null)
            {
                if(daneUcznia.SelectedIndex==0 && textRead.ToLower().Split(' ')[0].Contains(szukaj.Text)){
                textRead = sr.ReadLine();
                richTextBox1.Text += textRead+"/n";
                }
                
            }

            /*if (daneUcznia.SelectedItem.Equals("Imie"))
            {
                I = szukaj.Text;
                
                if (true)
                {
                    richTextBox1.Text = I;
                }
                
            }
            else if (daneUcznia.SelectedItem.Equals("Nazwisko"))
            {
                N = szukaj.Text;
            }
            else if (daneUcznia.SelectedItem.Equals("Klasa"))
            {
                K = szukaj.Text;
            }*/
            sr.Close();
        }
    }
}
