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

        private void iniciarSopa_Click(object sender, EventArgs e)
        {
            SopaL SopaL = new SopaL();
            SopaL.Show();
            this.Close();
        }
         

        private void iniciarTmb_Click(object sender, EventArgs e)
        {
            Timbiriche Form2 = new Timbiriche();
            Form2.Show();
            this.Close();
        }

        private void iniciarLot_Click(object sender, EventArgs e)
        {
           
            Loteria Loteria = new Loteria();
            Loteria.Show();
            this.Close();
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

        private void Inicio_FormClosed(object sender, FormClosedEventArgs e)
        {
           
        }
    }
}
