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
    public partial class SopaL : Form
    {
        
        List<CheckBox> lista = new List<CheckBox>();
        int correct = 0;
        int Nline = 0;
        string[] nom = new string[10];
        
        Random letras = new Random();


        public SopaL()
        {

            InitializeComponent();
            // 16/11/18 - Insertamos un GridView ,cambiamos la configuracion para que no se pudiera escribir
            char[,] Palabras = new char[20, 20];

            Sopa.RowCount = 20;
            Sopa.ColumnCount = 20;
            Palabras = AsignarPalabras();



            /*
            for (int f = 0; f < Sopa.RowCount; f++)
            {
                for (int c = 0; c < Sopa.ColumnCount; c++)
                {

                    Sopa[f, c].Value = Convert.ToChar(letras.Next(65, 90));



                }
            }*/

            for (int f = 0; f < Sopa.RowCount; f++) { 
                 for (int c= 0; c<Sopa.ColumnCount; c++) {
                    if (Palabras[c, f]!= '\0'){
                        Sopa[f, c].Value = Palabras[c, f];

                    }

             } }
            leerPalabras(Sopa,Palabras);
        }

        

        public char[,] AsignarPalabras()
        {
           
            char[,] SopaS = new char[20, 20];

            //Añade las palabras verticales.
            int s = 0;
            int z = 0;

            string line;
            char[] myChar;

            Random co = new Random();
            Random fi = new Random();
      
            int fil =0;
            int col=0;
            for (z = 0; z < 5; z++)
            {


                int distancia = 0;
              
                line = File.ReadAllLines(@"c:\lul\test.txt")[z];

                myChar = line.ToCharArray();

                s = Convert.ToInt32(myChar.Length);
                distancia = 20 - s;
                fil = Convert.ToInt32(fi.Next(0, distancia));
                col = Convert.ToInt32(co.Next(0, 19));
                int col1= col;
                int fil1 = fil;

                for (int cont = 0; cont < s; cont++)
                {
                    if (SopaS[fil1, col1] != default(char))
                    {
                        fil= Convert.ToInt32(fi.Next(0, distancia));
                        col = Convert.ToInt32(co.Next(0, 19));
                        col1 = col;
                        fil1 = fil;
                        cont = 0;

                    }
                    else
                    {
                        fil1++;
                    }
                    
                }

                    for (int cont = 0; cont < s; cont++)
                {
                    SopaS[fil, col] = myChar[cont];
                    fil++;
                }

                col = 0;
                fil = 0;
                col1 = 0;
                    fil1 = 0;
                line.Remove(0, line.Length);
                Array.Clear(myChar, 0, s);
                s = 0;
            }
              
            //Añadir las palabras horizontales.
            
            Random c = new Random();
            Random f = new Random();
            int f1 = 0, c1 =0;
            for (z =5; z < 10; z++)
            {


                int distancia = 0;
               
                line = File.ReadAllLines(@"c:\lul\test.txt")[z];
                
                myChar = line.ToCharArray();

                s = Convert.ToInt32(myChar.Length);
                distancia = 20 - s;
                c1 = Convert.ToInt32(c.Next(0, distancia));
                f1 = Convert.ToInt32(f.Next(0, 19));
                int col1 = c1;
                int fil1 = f1;
                
                for (int cont = 0; cont < s; cont++)
                {
                    if (SopaS[fil1, col1] != default(char))
                    {
                      
                        f1 = Convert.ToInt32(c.Next(0, 19));
                        c1 = Convert.ToInt32(c.Next(0, distancia));
                        col1 = c1;
                        fil1 = f1;
                        cont = -1;

                    }
                    else
                    {
                        col1++;
                    }

                }
              
                for (int cont = 0; cont < s; cont++)
                {
                    SopaS[f1, c1] = myChar[cont];
                    c1++;
                }

                col = 0;
                fil = 0;
                col1 = 0;
                fil1 = 0;
                line.Remove(0, line.Length);
                Array.Clear(myChar, 0, s);
                s = 0;
            }





            //Crea una lista de checkbox 
            

            int x = 40;
            int y = 50;
            //
            for (int k = 0; k < 10; k++)
            {
                CheckBox check = new CheckBox();

                check.Name = string.Format("Lp{0}", k);

                check.Location = new Point(x, y);
                y =y+35;
                check.Enabled = false;
                this.Controls.Add(check);

                lista.Add(check);
            }
            //
            string[] nom = new string[10];
            for (z = 0; z < 10; z++) {
                
                line = File.ReadAllLines(@"c:\lul\test.txt")[z];
                nom[z] = line;
                line.Remove(0, line.Length);
                lista[z].Text = nom[z];
            }

            
            







            return SopaS;
        }
        public void leerPalabras(DataGridView d, char[,] matriz)
        {
            StringBuilder a = new StringBuilder();
            
        
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            int f = Sopa.CurrentCell.ColumnIndex;
            int c = Sopa.CurrentCell.RowIndex;
            MessageBox.Show("Lul:");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
       

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        

        private void Sopa_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Lpalabra1_MouseCaptureChanged(object sender, EventArgs e)
        {
            
        }

        private void Sopa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
            {
               
            }
            else
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Red;
                string line;
                char[] myChar;
                int x = Sopa.Rows[e.RowIndex].Index;
                int y = Sopa.Rows[e.ColumnIndex].Index;
                char c = Convert.ToChar(Sopa[y, x].Value);

                if (correct == 0)
                {
                    if (c == 'I') { Nline = 0; }
                    if (c == 'F') {Nline = 2; }

                    if (c == 'Q') { Nline = 3; }
                    if (c == 'D') { Nline = 4; }

                    if (c == 'M') { Nline = 6; }
                    if (c == 'E') { Nline = 7; }
                    if (c == 'C') { Nline = 5; }

                }else if (Nline==2) {

                    if (c == 'L') { Nline = 1; }

                }
                else if (Nline==4)
                {
                    if (c == 'S') { Nline = 8; }
                  
                }else if (Nline == 7)
                {
                    if (c == 'T')  { Nline = 9; }
                }
                line = File.ReadAllLines(@"c:\lul\test.txt")[Nline];

                myChar = line.ToCharArray();

                int s = Convert.ToInt32(myChar.Length);

                if (c == myChar[correct])
                {
                    
                    correct++;
                }
                

                if (correct == s)
                {

                    lista[Nline].Checked = true;
                    
                    MessageBox.Show("Correct");
                    correct = 0;
                    Nline = 0;
                    s = 0;
                    
                }
            }
            

        }

        private void Sopa_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor == Color.Red)
            {
                Sopa.Rows[e.RowIndex].Cells[e.ColumnIndex].Style.BackColor = Color.Silver;
            }

        }
          
    }
}
