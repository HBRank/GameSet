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
    //ventana de juego
    public partial class Loteria: Form
    {
        Random alea = new Random();
        int l=0;
      
        List<int> lista = new List<int>();//lista de enteros para guardar numeros enteros del 1, 52.
        int[] carta = new int[32];
        List<PictureBox> ListaP1 = new List<PictureBox>();//lsita de picturebox que almacena las imagens del cpu 
        int scorep = 0, scoreCPU = 0;//las puntuaciones del jugador y de la maquina.
        List<Panel> panel = new List<Panel>();//lista de paneles para "marcar las imagenes" .

        public Loteria()
        {
            InitializeComponent();


        }
        //codigo random para que una carta y tabla salga aleatoriamente si se llega a repetir iniciar proceso otra vez hasta que salga una diferente 
        private void tabla_Click(object sender, EventArgs e)
        {
        
            for(int j = 0; j < 32; j++)
            {
                carta[j] = Convert.ToInt16( alea.Next(1, 54));
                while (lista.Contains(carta[j])) { carta[j] = alea.Next(1,54); }
                lista.Add(carta[j]);                  
            }
            for (int j = 1; j < 17; j++)
            {
                panel.Add((Panel)Controls.Find("panel" + j, true)[0]);

            }
            for (int j = 0; j <16; j++)
            {
                
                   ListaP1.Add((PictureBox)Controls.Find("pictureBox"+j ,true)[0]);
                ListaP1[j].Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[j]));
            }
            for (int j = 16; j < 32; j++)
            {
                ListaP1.Add((PictureBox)Controls.Find("pictureBox" + j, true)[0]);
                ListaP1[j].Image = Image.FromFile(string.Format("carta ({0}).jpg", carta[j]));
            }
           
            lista.Clear();

        }
        //precion de botton para que el juego inicie con la baraja.
        private void inicioj_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }
        public int writeScore(int a)
        {
            string line = File.ReadAllLines("scores.txt")[a];
            int sc = Convert.ToInt32(line);
            sc++;
            string[] lines = File.ReadAllLines("scores.txt");
            string allString = "";
            lines[a] = Convert.ToString(sc);
            for (int i = 0; i < lines.Length; i++)
            {
                allString += lines[i]+"\n";
            }
            File.WriteAllText("scores.txt",allString);
            return 0;
        }
        //temporizador para que cada carta salga en determinado tiempo 
        private void timer1_Tick(object sender, EventArgs e)
        {//codigo aleatorio de la baraja permite que no se repita una carta que ya paso.
                

               
                int num = 0;
               
                   num = Convert.ToInt32(alea.Next(1, 52));
                    while (lista.Contains(num)) { num = Convert.ToInt32(alea.Next(1, 54)); }
                    lista.Add(num);
          
     
                    baraja1.Image = Image.FromFile(string.Format("carta ({0}).jpg",num));
           int g = 0;
           for(int j = 16; j < 32   ; j++)//cilco para verificar si la carta que esta siendo mostrada esta en las cartas del cpu
            {
                
                if (carta[j] == num)
                {
                    panel[g].Visible = true;
                    scoreCPU++;
                }
                g++;
            }
            l++;
            if (l == 54) { timer1.Enabled = false; }//Condicional para detener el timer cuando las cartas acaben.
            if (scoreCPU == 16)//Condicional para saber si algun jugador a ganado.
            {
                timer1.Enabled = false;
                MessageBox.Show("Ganador: CPU");
                this.Close();
                timer1.Enabled = false;

            }
            if (scorep==16)
            {
               
                MessageBox.Show("Ganador: Jugador");
                this.Close();
                writeScore(3);
                timer1.Enabled = false;
            }
        }
        //presionar sobre la imagen para especificar que esta esta correcta.
        private void pictureBox0_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[0]))
            {
                c1.Visible = true;
                scorep++;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[1]))
            {
                c2.Visible = true;
                scorep++;
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[2]))
            {
                c3.Visible = true;
                scorep++;
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[3]))
            {
                c4.Visible = true;
                scorep++;
            }
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[4]))
            {
                c5.Visible = true;
                scorep++;
            }
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[5]))
            {
                c6.Visible = true;
                scorep++;
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[6]))
            {
                c7.Visible = true;
                scorep++;
            }
        }

        private void pictureBox7_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[7]))
            {
                c8.Visible = true;
                scorep++;
            }
        }

        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[8]))
            {
                c9.Visible = true;
                scorep++;
            }
        }

        private void pictureBox9_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[9]))
            {
                c10.Visible = true;
                scorep++;
            }
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[10]))
            {
                c11.Visible = true;
                scorep++;
            }
        }

        private void pictureBox11_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[11]))
            {
                c12.Visible = true;
                scorep++;

            }
        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[12]))
            {
                c13.Visible = true;
                scorep++;
            }
        }

        private void pictureBox13_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[13]))
            {
                c14.Visible = true;
                scorep++;
            }
        }

        private void pictureBox14_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[14]))
            {
                c15.Visible = true;
                scorep++;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox15_Click(object sender, EventArgs e)
        {
            if (lista.Contains(carta[15]))
            {
                c16.Visible = true;
                scorep++;
            }
        }

 
   

    }
        }