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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        // ograniczenie textboxa pod kątem znaków
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
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
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

     

        private void button2_Click(object sender, EventArgs e)
        {

           int a, i, wynik=1;
           string s1 = textBox1.Text;
            a = int.Parse(s1);
            if (a > 0)
            {
                for (i = 1; i <= a; i++)
                {
                    wynik *= i;
                }
                textBox2.Text = wynik.ToString();
            }
            else if (a==0)textBox2.Text = "0";
            else MessageBox.Show("Liczba powinna być nieujemna");
            
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://pl.wikipedia.org/wiki/Silnia");//link delta
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
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

      

    }
}
