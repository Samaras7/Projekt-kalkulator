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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                MessageBox.Show("Bardzo dziękuję za zaliczenie :) \n\n PS Dane z ankiety nie są  przechowywane, więc nie mają żadnego zastosowania");
            }
            else MessageBox.Show("Bardzo mi przykro, spróbuje za rok :C");
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                checkBox2.Checked = false; 
            }
        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                checkBox1.Checked = false;
            }
        }

        private void checkBox4_Click(object sender, EventArgs e)
        {
            if (checkBox4.Checked)
            {
                checkBox3.Checked = false;
            }
        }

        private void checkBox3_Click(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                checkBox4.Checked = false;
            }
        }

        private void checkBox6_Click(object sender, EventArgs e)
        {
            if (checkBox6.Checked)
            {
                checkBox5.Checked = false;
            }
        }

        private void checkBox5_Click(object sender, EventArgs e)
        {
            if(checkBox5.Checked)
                {
                checkBox6.Checked=false;
                }
        }


        
    }
}
