using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sprawdzian_bruh
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string slowo;
        int k;
        string wynik;

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                button1.Text = "Deszyfruj";
                label1.Text = "Tekst do deszyfrowania:";
            }
            if (radioButton1.Checked)
            {
                button1.Text = "Szyfruj";
                label1.Text = "Tekst do szyfrowania:";
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked) {
                button1.Text = "Deszyfruj";
                label1.Text = "Tekst do deszyfrowania:";
            }
            if (radioButton1.Checked)
            {
                button1.Text = "Szyfruj";
                label1.Text = "Tekst do szyfrowania:";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            wynik = "";
            if (radioButton2.Checked)
            {
                k = k * -1;
            }

            

            for (int i = 0; i < slowo.Length; i++)
            {
                if (slowo[i] >= 97 && slowo[i] <= 122)
                {
                    if (checkBox1.Checked)
                    {
                        if (slowo[i] + (k % 26) <= 122 && slowo[i] + (k % 26) >= 97)
                        {
                            wynik += Convert.ToChar(slowo[i] + (k % 26));
                        }
                        else
                        {
                            if (radioButton2.Checked || k < 0)
                            {
                                wynik += Convert.ToChar(slowo[i] + (26 + (k % 26)));
                            }
                            else
                            {
                                wynik += Convert.ToChar(slowo[i] - (26 - (k % 26)));
                            }
                        }
                    }
                    else
                    {
                        wynik += slowo[i];
                    }
                    
                    
                }

                if (slowo[i] >= 65 && slowo[i] <= 90)
                {
                    if (checkBox2.Checked)
                    {
                        if (slowo[i] + (k % 26) <= 90 && slowo[i] + (k % 26) >= 65)
                        {
                            wynik += Convert.ToChar(slowo[i] + (k % 26));
                        }
                        else
                        {
                            if (radioButton2.Checked || k < 0)
                            {
                                wynik += Convert.ToChar(slowo[i] + (26 + (k % 26)));
                            }
                            else
                            {
                                wynik += Convert.ToChar(slowo[i] - (26 - (k % 26)));
                            }
                        }
                    }
                    else
                    {
                        wynik += slowo[i];
                    }
                    
                }
                if (slowo[i] >= 48 && slowo[i] <= 57)
                {
                    if (checkBox3.Checked)
                    {
                        if (slowo[i] + (k % 26) <= 57 && slowo[i] + (k % 26) >= 48)
                        {
                            wynik += Convert.ToChar(slowo[i] + (k % 10));
                        }
                        else
                        {
                            if (radioButton2.Checked || k < 0)
                            {
                                wynik += Convert.ToChar(slowo[i] + (10 + (k % 10)));
                            }
                            else
                            {
                                wynik += Convert.ToChar(slowo[i] - (10 - (k % 10)));
                            }
                        }
                    }
                    else
                    {
                        wynik += slowo[i];
                    }
                    
                }
                


                //wynik[i]
            }

            
            MessageBox.Show(wynik);
            //Message Szyfr;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            slowo = textBox1.Text;
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void zamknijToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            k = Convert.ToInt32(numericUpDown1.Value);
        }

        string szyfruj (string slowo)
        {
            
            return wynik;
        }
    }
}
