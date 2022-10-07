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
            String filter = szukaj.Text.ToString();

            /*while (textRead != null)
            {
                richTextBox1.Clear();
                if(daneUcznia.SelectedIndex==0 && textRead.Split(' ')[0].ToLower().StartsWith(filter.ToLower())){
                
                richTextBox1.Text += textRead + "\n";
                }
                textRead = sr.ReadLine();

            }*/
            richTextBox1.Clear();
            
            if (daneUcznia.SelectedItem.Equals("Imię"))
            {
                
                //imiona += textRead.Split(' ')[0];
                    /*if (imiona.StartsWith(filter.ToLower()))
                    {

                    }*/
                if (kryterium.SelectedItem.Equals("równe"))
                {
                   while (!sr.EndOfStream)
                {
                        textRead = sr.ReadLine();
                        String imiona = textRead.Split(' ')[0];
                        if (imiona.StartsWith(filter))
                        {
                            
                            richTextBox1.Text += imiona + "\n";
                        }
                        else
                        {
                            MessageBox.Show("nie działa");
                        }
                } 
                }
                else if (kryterium.SelectedItem.Equals("zawiera"))
                {
                    while (!sr.EndOfStream)
                    {
                        String imiona = textRead.Split(' ')[0];
                        textRead = sr.ReadLine();
                        richTextBox1.Text += imiona + "\n";
                    }
                }
                else if (kryterium.SelectedItem.Equals("zaczyna się od"))
                {
                    while (!sr.EndOfStream)
                    {
                        String imiona = textRead.Split(' ')[0];
                        textRead = sr.ReadLine();
                        richTextBox1.Text += imiona + "\n";
                    }



                }
                // MessageBox.Show("wybrałeś imie");
            }
            else if (daneUcznia.SelectedItem.Equals("Nazwisko"))
            {
                String nazwiska = textRead.Split(' ')[1];
                MessageBox.Show("wybrałeś nazwisko");
            }
            else if (daneUcznia.SelectedItem.Equals("Klasa"))
            {
                String klasy = textRead.Split(' ')[2];
                MessageBox.Show("wybrałeś klase");
            }
            sr.Close();
        }
    }
}
