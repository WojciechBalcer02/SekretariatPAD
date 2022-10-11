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
                
                if (kryterium.SelectedItem.Equals("zaczyna się od"))
                {
                   while (!sr.EndOfStream)
                {
                        textRead = sr.ReadLine();
                        String imiona = textRead.Split(' ')[0].ToLower();
                        if (imiona.StartsWith(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }
                        
                } 
                }
                else if (kryterium.SelectedItem.Equals("zawiera"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String imiona = textRead.Split(' ')[0].ToLower();
                        if (imiona.Contains(filter.ToLower()))
                        {

                            richTextBox1.Text += textRead + "\n";
                        }
                    }
                }
                else if (kryterium.SelectedItem.Equals("równe"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String imiona = textRead.Split(' ')[0].ToLower();
                        if (imiona.Equals(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }
                    }



                }
                // MessageBox.Show("wybrałeś imie");
            }
            else if (daneUcznia.SelectedItem.Equals("Nazwisko"))
            {
                if (kryterium.SelectedItem.Equals("zaczyna się od"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String nazwisko = textRead.Split(' ')[1].ToLower();
                        if (nazwisko.StartsWith(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }

                    }
                }
                else if (kryterium.SelectedItem.Equals("zawiera"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String nazwisko = textRead.Split(' ')[1].ToLower();
                        if (nazwisko.Contains(filter.ToLower()))
                        {

                            richTextBox1.Text += textRead + "\n";
                        }
                    }
                }
                else if (kryterium.SelectedItem.Equals("równe"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String nazwisko = textRead.Split(' ')[1].ToLower();
                        if (nazwisko.Equals(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }
                    }



                }
            }
            else if (daneUcznia.SelectedItem.Equals("Klasa"))
            {
                if (kryterium.SelectedItem.Equals("zaczyna się od"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String klasa = textRead.Split(' ')[2].ToLower();
                        if (klasa.StartsWith(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }

                    }
                }
                else if (kryterium.SelectedItem.Equals("zawiera"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String klasa = textRead.Split(' ')[2].ToLower();
                        if (klasa.Contains(filter.ToLower()))
                        {

                            richTextBox1.Text += textRead + "\n";
                        }
                    }
                }
                else if (kryterium.SelectedItem.Equals("równe"))
                {
                    while (!sr.EndOfStream)
                    {
                        textRead = sr.ReadLine();
                        String klasa = textRead.Split(' ')[2].ToLower();
                        if (klasa.Equals(filter.ToLower()))
                        {
                            richTextBox1.Text += textRead + "\n";
                        }
                    }



                }
            }
            sr.Close();
        }
    }
}
