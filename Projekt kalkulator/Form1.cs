using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            SoundPlayer sp = new SoundPlayer();
            if (checkBox1.Checked)
            {

                sp.SoundLocation = @"\cello.wav";

                
                
            }

            else
            {
                sp.Stop();
            }
            

        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 openForm = new Form2();
            openForm.Show();
            //otwarcie nowego formularza po kliknięciu przycisku
        }

        private void Silnia_przycisk_Click(object sender, EventArgs e)
        {
            Form3 openForm = new Form3();
            openForm.Show();
        }

        

        private void WyłączenieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void zielonyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Green;

        }

        private void niebieskiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void BiałyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.White;
        }

        private void instrukcjaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Przykro nam, musisz sobie radzić"); 
        }

        private void oAutorzeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Autor woli pozostać anonimowy");
        }

        private void AnkietaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 openForm=new Form4();
            openForm.Show();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            pictureBox2.ImageLocation = openFileDialog1.FileName;
           
            openFileDialog1.ShowDialog();
            pictureBox2.ImageLocation = openFileDialog1.FileName;
            

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}
