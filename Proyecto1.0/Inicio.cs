using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Proyecto1._0
{
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
            scores();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SopaL SopaL = new SopaL();
            SopaL.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Timbiriche Form2 = new Timbiriche();
            Form2.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           
            Loteria Loteria = new Loteria();
            Loteria.Show();
        }
        public void scores()
        {
            string[] line = File.ReadAllLines("scores.txt");
            label3.Text = line[0];
            label4.Text = line[2];
            label5.Text = line[3];
            label6.Text = line[4];
            label7.Text = line[5];
            label8.Text = line[6];
            label9.Text = line[7];
            label10.Text = line[8];
            label11.Text = line[9];
            label12.Text = line[10];

        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
     
        }
    }
}
