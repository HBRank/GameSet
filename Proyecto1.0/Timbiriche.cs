﻿using System;
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
    public partial class Timbiriche : Form
    {
        
        int Turno = 0;//Variable para el control del turno del juagdor.

        int[,] matrz = new int[3, 3];//Matriz que representa los cuadros del juego
               
        int P1Score= 0,P2Score=0;
        public Timbiriche()
        {

            InitializeComponent();
            JugadorP.BackColor = Color.Blue;//Cambiar el color del panel del primer juagador.

        }

        //
        //Primera casilla
        //
        private void button1_Click_1(object sender, EventArgs e)
        {
            

            matrz[0, 0] = matrz[0, 0] + 1;//Se le suma uno a la arista superior
            if (Turno == 1)
            {      
                button1.BackColor = Color.Black;//Cambuia el color del vboton cuando es pulsado
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }//Pone visible el panel y cambiel color dependiedo del jugador
                else
                {
                    Turno = 0;//Cambia el turno
                }
            }
            else
            {
                button1.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else
                {
                    Turno = 1;
                }

            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }//Cambia las apariencias de los paneles dependiendo de la variable del turno
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button13_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 2;
            matrz[0, 1] = matrz[0, 1] + 8;
            if (Turno == 1)
            {
                button13.BackColor = Color.Black;
                if (matrz[0, 0] == 15)
                {
                    panel1.Visible = true; panel1.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score);
                }
                else
                {
                  
                    Turno = 0;
                }
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button13.BackColor = Color.Black;
               
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else
                {
                    
                    Turno = 1;
                }
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button4_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 4;
            matrz[1, 0] = matrz[1, 0] + 1;
            if (Turno == 1)
            {  
                button4.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                   
                    Turno = 0;
                }
                if (matrz[1, 0] == 15) { panel4.Visible = true; panel4.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }

            }
            else
            {
                button4.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else
                {
                   
                    Turno = 1;
                }
                if (matrz[1, 0] == 15 ) { panel4.Visible = true; panel4.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button18_Click(object sender, EventArgs e)
        {
            matrz[0, 0] = matrz[0, 0] + 8;
            if (Turno == 1)
            {
                button18.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                  
                    Turno = 0;
                }
            }
            else
            {
                button18.BackColor = Color.Black;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else
                {
                    Turno = 1;
                }

            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button2.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score);
                }
             
                    else
                    {
                        Turno = 0;
                    }
                }
            else
            {
                button2.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else
                    {
                        Turno = 1;
                    }
                }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {
            matrz[0, 1] = matrz[0, 1] + 2;
            matrz[0, 2] = matrz[0, 2] + 8;
            if (Turno == 1)
            {
                button19.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {
                       
                        Turno = 0;
                    }
                
                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button19.BackColor = Color.Black;
                if (matrz[0, 1] == 15) {panel2.Visible = true; panel2.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else
                    {
                        
                        Turno = 1;
                    }

                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {
            matrz[0, 1] = matrz[0, 1] + 4;
            matrz[1, 1] = matrz[1, 1] + 1;
            if (Turno == 1)
            {
                button5.BackColor = Color.Black;
                if (matrz[0, 1] == 15) {panel2.Visible = true; panel2.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {
                       
                        Turno = 0;
                    }
                if (matrz[1, 1]==15) { panel5.Visible = true;panel5.BackColor = Color.DarkRed;Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                }
            else
            {
                button5.BackColor = Color.Black;
                if (matrz[0, 1] == 15) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkBlue;Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            { 
                button3.BackColor = Color.Black;
                if (matrz[0, 2] == 15) { panel3.Visible = true; panel3.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {
                        Turno = 0;
                    }
            }
            else
            {
                button3.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            matrz[0, 2] = matrz[0, 2] + 2;
            if (Turno == 1)
            {
                button21.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {
                        Turno = 0;
                    }
            }
            else
            {
                button21.BackColor = Color.Black;
                if (matrz[0, 2] == 15) {panel3.Visible = true; panel3.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }

            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            matrz[0, 2] = matrz[0, 2] + 4;
            matrz[1, 2] = matrz[1, 2] + 1;
            if (Turno == 1)
            {
                button6.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                { panel3.Visible = true; panel3.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                { Turno = 0;
                }
                if (matrz[1, 2] == 15) { panel6.Visible = true;panel6.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button6.BackColor = Color.Black;
                if (matrz[0, 2] == 15)
                {
                    panel3.Visible = true; panel3.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score);
                }
                else { Turno = 1; }
                if (matrz[1, 2] == 15) { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button14.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {  panel4.Visible = true; panel4.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {
                        Turno = 0;
                    }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button14.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {   panel4.Visible = true; panel4.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }
                if (matrz[1, 1] == 15) { panel5.Visible = true; panel5.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            matrz[1, 0] = matrz[1, 0] + 4;
            matrz[2, 0] = matrz[2, 0] + 1;
            if (Turno == 1)
            {
                button7.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {    panel4.Visible = true; panel4.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {

                        Turno = 0;
                    }
                if (matrz[2, 0] == 15) { panel7.Visible = true; panel7.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button7.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                {    panel4.Visible = true; panel4.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }
                if (matrz[2,0] == 15) { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            matrz[1, 0] = matrz[1, 0] + 8;
            if (Turno == 1)
            {
                button17.BackColor = Color.Black;
                if (matrz[1, 0] == 15)
                { panel4.Visible = true; panel4.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                { Turno = 0;
                }
            }
            else
            {
                button17.BackColor = Color.Black;
                if (matrz[1,0] == 15)
                { panel4.Visible = true; panel4.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button20.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                {panel5.Visible = true; panel5.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                    else
                    {

                        Turno = 0;
                    }

                if (matrz[0, 2] == 15 ) { panel6.Visible = true; panel6.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
             } 
            else
            {
                button20.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                {panel5.Visible = true; panel5.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                    else { Turno = 1; }              
               
                if (matrz[1, 2] == 15) { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            matrz[1, 1] = matrz[1, 1] + 4;
            matrz[2, 1] = matrz[2, 1] + 1;
            if (Turno == 1)
            {
                button8.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                { panel5.Visible = true; panel5.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button8.BackColor = Color.Black;
                if (matrz[1, 1] == 15)
                { panel5.Visible = true; panel5.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }

                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; Turno = 0; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
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
            if (Turno == 1)
            {
                button23.BackColor = Color.Black;
                if (matrz[1,2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
            }
            else
            {
                button23.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }
        private void button9_Click(object sender, EventArgs e)
        {
            matrz[1, 2] = matrz[1, 2] + 4;
            matrz[2, 2] = matrz[2, 2] + 1;
            if (Turno == 1)
            {
                button9.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button9.BackColor = Color.Black;
                if (matrz[1, 2] == 15)
                { panel6.Visible = true; panel6.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }

                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button15.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button15.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }

                if (matrz[2, 1] == 15) { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }


        private void button10_Click(object sender, EventArgs e)
        {
            matrz[2, 0] = matrz[2, 0] + 4;
            if (Turno == 1)
            {
                button10.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
            }
            else
            {
                button10.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

 
        private void button16_Click(object sender, EventArgs e)
        {
            matrz[2, 0] = matrz[2, 0] + 8;
            if (Turno == 1)
            {
                button16.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
            }
            else
            {
                button16.BackColor = Color.Black;
                if (matrz[2, 0] == 15)
                { panel7.Visible = true; panel7.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button22.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkRed; Turno = 1; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
            }
            else
            {
                button22.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }

                if (matrz[2, 2] == 15) { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; Turno = 0; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

    

        private void button11_Click(object sender, EventArgs e)
        {
            matrz[2, 1] = matrz[2, 1] + 4;
            if (Turno == 1)
            {
                button11.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
             }
            else
            {
                button11.BackColor = Color.Black;
                if (matrz[2, 1] == 15)
                { panel8.Visible = true; panel8.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
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
            if (Turno == 1)
            {
                button24.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkRed; P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
            }
            else
            {
                button24.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkBlue; P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
           
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; }
            else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InstruccionesTim1 instruccionesTim = new InstruccionesTim1();
            instruccionesTim.Show();
                }

        private void button25_Click(object sender, EventArgs e)
        {
            string line1 = File.ReadAllLines("scores.txt")[8];
            string line2 = File.ReadAllLines("scores.txt")[10];
            int sc = Convert.ToInt32(line1);
            int sd = Convert.ToInt32(line2);
            sc = sc + P1Score;
            sd = sd + P2Score;
            string[] lines = File.ReadAllLines("scores.txt");
            string allString = "";
            lines[8] = Convert.ToString(sc);
            lines[10] = Convert.ToString(sd);
            for (int i = 0; i < lines.Length; i++)
            {
                allString += lines[i] + "\n";
            }
            File.WriteAllText("scores.txt", allString);
            this.Close();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            matrz[2, 2] = matrz[2, 2] + 4;
            if (Turno == 1)
            {
                button12.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkRed;P2Score++; label1.Text = string.Format("Jugador 2:{0}", P2Score); }
                else
                {
                    Turno = 0;
                }
            }
            else
            {
                button12.BackColor = Color.Black;
                if (matrz[2, 2] == 15)
                { panel9.Visible = true; panel9.BackColor = Color.DarkBlue;P1Score++; j1.Text = string.Format("Jugador 1:{0}", P1Score); }
                else { Turno = 1; }
            }
            if (Turno == 1) { JugadorP.BackColor = Color.Transparent; JugadorP2.BackColor = Color.Red; } else
            {
                JugadorP.BackColor = Color.Blue; JugadorP2.BackColor = Color.Transparent;
            }

        }

    }
}
