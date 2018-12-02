using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1._0
{
    //ventana de juego
    public partial class Loteria: Form
    {
        Random alea = new Random();
        int l=0;
        //lista de enteros para guardar numeros enteros del 1, 52.
        List<int> lista = new List<int>();
        int[] carta = new int[32];
        public Loteria()
        {
            InitializeComponent();
        }
        //codigo random para que una carta y tabla salga aleatoriamente si se llega a repetir iniciar proceso otra vez asta que salga una diferente 
        private void button2_Click(object sender, EventArgs e)
        {
            // int carta1, carta2, carta3, carta4, carta5, carta6, carta7, carta8, carta9, carta10, carta11, carta12, carta13, carta14, carta15, carta16, carta17, carta18, carta19, carta20, carta21, carta22, carta23, carta24, carta25, carta26, carta27, carta28, carta29, carta30, carta31,carta32;
            
        
            for(int j = 0; j < 32; j++)
            {
                carta[j] = Convert.ToInt16( alea.Next(1, 54));
                while (lista.Contains(carta[j])) { carta[j] = alea.Next(1,54); }
                lista.Add(carta[j]);                  
            }
            pictureBox1.Image = Image.FromFile(string.Format("carta ({0}).jpg",carta[1]));
            pictureBox2.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[2]));
            pictureBox3.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[3]));
            pictureBox4.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[4]));
            pictureBox5.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[5]));
            pictureBox6.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[6]));
            pictureBox7.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[7]));
            pictureBox8.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[8]));
            pictureBox9.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[9]));
            pictureBox10.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[10]));
            pictureBox11.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[11]));
            pictureBox12.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[12]));

            pictureBox13.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[13]));
            pictureBox14.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[14]));
            pictureBox15.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[15]));
            pictureBox16.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[16]));
            pictureBox17.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[17]));
            pictureBox18.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[18]));
            pictureBox19.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[19]));
            pictureBox20.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[20]));
            pictureBox21.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[21]));
            pictureBox22.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[22]));
            pictureBox23.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[23]));
            pictureBox24.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[24]));
            pictureBox25.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[25]));
            pictureBox26.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[26]));
            pictureBox27.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[27]));
            pictureBox28.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[28]));
            pictureBox29.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[29]));
            pictureBox30.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[30]));
            pictureBox31.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[31]));
            pictureBox32.Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[0]));
            lista.Clear();

        }
        //precion de botton para que el juego inicie con la baraja.
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }   
        //temporizador para que cada carta salga en determinado tiempo 
        private void timer1_Tick(object sender, EventArgs e)
        {//codigo aleatorio de la baraja permite que no se repita una carta que ya aya pasado
                

               
                int num = 0;
               
                   num = Convert.ToInt32(alea.Next(1, 52));
                    while (lista.Contains(num)) { num = Convert.ToInt32(alea.Next(1, 54)); }
                    lista.Add(num);
          

              
               
                    baraja1.Image = Image.FromFile(string.Format("carta ({0}).jpg",num));
            l++;
            if (l == 0) { timer1.Enabled = false; }

                }
        //presionar sobre la imagen para especificar que esta esta correcta
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[1])) {
                c1.Visible = true;   
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[4]))
            {
                c2.Visible = true;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[3]))
            {
                c3.Visible = true;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[2]))
            {
                c4.Visible = true;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[8]))
            {
                c5.Visible = true;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[7]))
            {
                c6.Visible = true;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[6]))
            {
                c7.Visible = true;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[5]))
            {
                c8.Visible = true;
            }
        }

        private void pictureBox16_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[16]))
            {
                c9.Visible = true;
            }
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[15]))
            {
                c10.Visible = true;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[14]))
            {
                c11.Visible = true;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[13]))
            {
                c12.Visible = true;
            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[12]))
            {
                c13.Visible = true;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[11]))
            {
                c14.Visible = true;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[10]))
            {
                c15.Visible = true;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[9]))
            {
                c16.Visible = true;
            }
        }
    }
        }
    


