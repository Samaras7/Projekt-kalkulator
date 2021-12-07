using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); //przycisk zamknij
        }

       //blokowanie textboxów pod kątem znaków
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (a == 46 && textBox1.Text.IndexOf('.') != -1) // porządek z kropkami, brak podwójnych, powielonych kropek
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(a) && a!=8 && a!=46) // 8 to kod bcksp, 46 to kropka, zablokowanie liter
            {
                e.Handled = true;
            }
        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (a == 46 && textBox1.Text.IndexOf('.') != -1) // porządek z kropkami, brak podwójnych, powielonych kropek
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(a) && a != 8 && a != 46) // 8 to kod bcksp, 46 to kropka, zablokowanie liter
            {
                e.Handled = true;
            }
        }
        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            char a = e.KeyChar;

            if (a == 46 && textBox1.Text.IndexOf('.') != -1) // porządek z kropkami, brak podwójnych, powielonych kropek
            {
                e.Handled = true;
                return;
            }

            if (!Char.IsDigit(a) && a != 8 && a != 46) // 8 to kod bcksp, 46 to kropka, zablokowanie liter
            {
                e.Handled = true;
            }
        }

       

        
        private double delta(double a, double b, double c)
        {
            double d = (b * b) - (4 * a * c);
            return d;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            double a, b, c;
            string s1 = textBox1.Text;
            a = double.Parse(s1);
            string s2 = textBox2.Text;
            b = double.Parse(s2);
            string s3 = textBox3.Text;
            c = double.Parse(s3);

            textBox5.Text = delta(a, b, c).ToString();
            
            
                      
        }
     
        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            System.Diagnostics.Process.Start("https://pl.wikipedia.org/wiki/Funkcja_kwadratowa");//link delta
        }

        
       
    }
}
