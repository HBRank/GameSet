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
    public partial class Form2 : Form
    {
        int p = 0;
        int[,] matrz = new int[3, 3];
               
        int P1Score= 0,P2Score=0;
        public Form2()
        {

            InitializeComponent();
            JugadorP.BackColor = Color.Blue;

        }
        public void Turno()
        {


        }

        //
        //Primera casilla
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 1;
            if (p == 1)
            {      
                button1.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
            }
            else
            {
                button1.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }

            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 2;
            matrz[0, 1] = matrz[0, 1] + 8;
            if (p == 1)
            {
                button13.BackColor = Color.Black;
                if (matrz[0, 0] == 15)
                {
                    panel1.Visible = true; panel1.BackColor = Color.DarkRed;
                }
                else
                {
                    P1Score++;
                    p = 0;
                }
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button13.BackColor = Color.Black;
               
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 4;
            matrz[1, 0] = matrz[1, 0] + 1;
            if (p == 1)
            {  
                button4.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
                if (matrz[1, 0] == 15) { panel4.Visible = true; panel4.BackColor = Color.DarkRed; p = 1; }

            }
            else
            {
                button4.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[1, 0] == 15 ) { panel4.Visible = true; panel4.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 8;
            if (p == 1)
            {
                button18.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
            }
            else
            {
                button18.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    p = 1;
                }

            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //Segunda Casilla.
        //
        private void button2_Click(object sender, EventArgs e)
        {
            matrz[0, 1] = matrz[0, 1] + 1;
            if (p == 1)
            {
                button2.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        p = 0;
                    }
                }
            else
            {
                button2.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; }
                    else
                    {
                        p = 1;
                    }
                }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            matrz[0, 1] = matrz[0, 1] + 2;
            matrz[0, 2] = matrz[0, 2] + 8;
            if (p == 1)
            {
                button19.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; }
                    else
                    {
                        P1Score++;
                        p = 0;
                    }
                
                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button19.BackColor = Color.Black;
                if (matrz[0, 1] == 15) {panel2.Visible = true; panel2.BackColor = Color.DarkBlue; }
                    else
                    {
                        P1Score++;
                        p = 1;
                    }

                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            matrz[0, 1] = matrz[0, 1] + 4;
            matrz[1, 1] = matrz[1, 1] + 1;
            if (p == 1)
            {
                button5.BackColor = Color.Black;
                if (matrz[0, 1] == 15) {panel2.Visible = true; panel2.BackColor = Color.DarkRed;}
                    else
                    {
                       
                        p = 0;
                    }
                if (matrz[1, 1]==15) { panel5.Visible = true;panel5.BackColor = Color.DarkRed;p = 1; }
                }
            else
            {
                button5.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue;}
                    else { p = 1; }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkBlue;p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //Tercera casilla
        //
        private void button3_Click(object sender, EventArgs e)
        {
            matrz[0, 2] = matrz[0, 2] + 1;
            if (p == 1)
            { 
                button3.BackColor = Color.Black;
                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkRed;}
                    else
                    {
                        p = 0;
                    }
            }
            else
            {
                button3.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkBlue; }
                    else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            matrz[0, 2] = matrz[0, 2] + 2;
            if (p == 1)
            {
                button21.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkRed;  }
                    else
                    {
                        p = 0;
                    }
            }
            else
            {
                button21.BackColor = Color.Black;
                if (matrz[0, 2] == 15) {panel3.Visible = true; panel3.BackColor = Color.DarkBlue;}
                    else { p = 1; }

            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            matrz[0, 2] = matrz[0, 2] + 4;
            matrz[1, 2] = matrz[1, 2] + 1;
            if (p == 1)
            {
                button6.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkRed; }
                else
                { p = 0;
                }
                if (matrz[1, 2] == 15) { panel6.Visible = true;panel6.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button6.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                {
                    panel3.Visible = true; panel3.BackColor = Color.DarkBlue;
                }
                else { p = 1; }
                if (matrz[1, 2] == 15) { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //CuartaCasilla
        //
        private void button14_Click(object sender, EventArgs e)
        {
            matrz[1, 0] = matrz[1, 0] + 2;
            matrz[1, 1] = matrz[1, 1] + 8;
            if (p == 1)
            {
                button14.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {  panel4.Visible = true; panel4.BackColor = Color.DarkRed; }
                    else
                    {
                        p = 0;
                    }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button14.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {   panel4.Visible = true; panel4.BackColor = Color.DarkBlue; }
                    else { p = 1; }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            matrz[1, 0] = matrz[1, 0] + 4;
            matrz[2, 0] = matrz[2, 0] + 1;
            if (p == 1)
            {
                button7.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {    panel4.Visible = true; panel4.BackColor = Color.DarkRed; }
                    else
                    {

                        p = 0;
                    }
                if (matrz[2, 0] == 15) { panel7.Visible = true; panel7.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button7.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {    panel4.Visible = true; panel4.BackColor = Color.DarkBlue; }
                    else { p = 1; }
                if (matrz[2,0] == 15) { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            matrz[1, 0] = matrz[1, 0] + 8;
            if (p == 1)
            {
                button17.BackColor = Color.Black;
                if (matrz[1, 0] == 15)
                { panel4.Visible = true; panel4.BackColor = Color.DarkRed; }
                else
                { p = 0;
                }
            }
            else
            {
                button17.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                { panel4.Visible = true; panel4.BackColor = Color.DarkBlue; }
                    else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //quinta casilla
        //
        private void button20_Click(object sender, EventArgs e)
        {
            matrz[1, 1] = matrz[1, 1] + 2;
            matrz[1, 2] = matrz[1, 2] + 8;
            if (p == 1)
            {
                button20.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                {panel5.Visible = true; panel5.BackColor = Color.DarkRed; }
                    else
                    {

                        p = 0;
                    }

                if (matrz[0, 2] == 15 ) { panel6.Visible = true; panel6.BackColor = Color.DarkRed; p = 1; }
             } 
            else
            {
                button20.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                {panel5.Visible = true; panel5.BackColor = Color.DarkBlue; }
                    else { p = 1; }              
               
                if (matrz[1, 2] == 15) { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matrz[1, 1] = matrz[1, 1] + 4;
            matrz[2, 1] = matrz[2, 1] + 1;
            if (p == 1)
            {
                button8.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                { panel5.Visible = true; panel5.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button8.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                { panel5.Visible = true; panel5.BackColor = Color.DarkBlue; }
                else { p = 1; }

                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //Sexta casilla
        //
        private void button23_Click(object sender, EventArgs e)
        {
            matrz[1, 2] = matrz[1, 2] + 2;
            if (p == 1)
            {
                button23.BackColor = Color.Black;
                if (matrz[1,2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
            }
            else
            {
                button23.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            matrz[1, 2] = matrz[1, 2] + 4;
            matrz[2, 2] = matrz[2, 2] + 1;
            if (p == 1)
            {
                button9.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button9.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; }
                else { p = 1; }

                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //Septima casilla
        //
        private void button15_Click(object sender, EventArgs e)
        {
            matrz[2,0] = matrz[2, 0] + 2;
            matrz[2, 1] = matrz[2, 1] + 8;
            if (p == 1)
            {
                button15.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button15.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; }
                else { p = 1; }

                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            matrz[2, 0] = matrz[2, 0] + 4;
            if (p == 1)
            {
                button10.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
            }
            else
            {
                button10.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

 
        private void button16_Click(object sender, EventArgs e)
        {
            matrz[2, 0] = matrz[2, 0] + 8;
            if (p == 1)
            {
                button16.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
            }
            else
            {
                button16.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        //
        //Octava Casilla
        //
        private void button22_Click(object sender, EventArgs e)
        {
            matrz[2, 1] = matrz[2, 1] + 2;
            matrz[2, 2] = matrz[2, 2] + 8;
            if (p == 1)
            {
                button22.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                button22.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; }
                else { p = 1; }

                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; p = 0; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

    

        private void button11_Click(object sender, EventArgs e)
        {
            matrz[2, 1] = matrz[2, 1] + 4;
            if (p == 1)
            {
                button11.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
             }
            else
            {
                button11.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        //
        //novena casilla
        //
        private void button24_Click(object sender, EventArgs e)
        {
            matrz[2, 2] = matrz[2, 2] + 2;
            if (p == 1)
            {
                button24.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
            }
            else
            {
                button24.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BorderStyle = BorderStyle.Fixed3D; }
            else
            {
                JugadorP2.BorderStyle = BorderStyle.Fixed3D;
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

    

        private void button12_Click(object sender, EventArgs e)
        {
            matrz[2, 2] = matrz[2, 2] + 4;
            if (p == 1)
            {
                button12.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkRed; }
                else
                {
                    p = 0;
                }
            }
            else
            {
                button12.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; }
                else { p = 1; }
            }
            if (p == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; } else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }

        }





    }
}
