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


        }
        public void Turno()
        {


        }
      
        private void Form2_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[0, 0] = matrz[0, 0] + 1;
                button1.BackColor = Color.Red;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
            }
            else
            {
                matrz[0, 0] = matrz[0, 0] + 1;
                button1.BackColor = Color.Blue;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }

            }
       
            }
        private void button2_Click(object sender, EventArgs e)
        {
            
            if (p == 1)
            {
                
                matrz[0, 1] = matrz[0, 1] + 1;
                button2.BackColor = Color.Red;
                if (matrz[0, 1] == 7) {
                    if (button13.BackColor == Color.Red || button13.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        P1Score++;
                        p = 0;
                    }
                }
                else
                {
                    P1Score++;
                    p = 0;
                }
            }
            else
            {
                matrz[0, 1] = matrz[0, 1] + 1;
                button2.BackColor = Color.Blue;
                if (matrz[0, 1] == 7) {
                    if (button13.BackColor == Color.Red || button13.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkBlue;
                    }
                    else
                    {
                        P1Score++;
                        p = 1;
                    }
                }
                else
                {
                    P1Score++;
                    p = 1;
                }

            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            
            if (p == 1)
            {
                matrz[0, 0] = matrz[0, 0] + 8;
                button18.BackColor = Color.Red;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
            }
            else
            {
                matrz[0, 0] = matrz[0, 0] + 8;
                button18.BackColor = Color.Blue;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }

            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                
                matrz[0, 0] = matrz[0, 0] + 2;
                button13.BackColor = Color.Red;
                if (matrz[0, 0] == 15) {
                    panel1.Visible = true; panel1.BackColor = Color.DarkRed;
                }
                else
                {
                    P1Score++;
                    p = 0;
                }
                if (matrz[0, 1] == 7) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; p = 1; }


            }
            else
            {
                
                matrz[0, 0] = matrz[0, 0] + 2;
                button13.BackColor = Color.Blue;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[0, 1] == 7) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; p = 0; }

            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[0, 0] = matrz[0, 0] + 4;
                button4.BackColor = Color.Red;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; }
                else
                {
                    P1Score++;
                    p = 0;
                }
                if (matrz[0, 0] == 15 && panel1.Visible != true) { panel1.Visible = true; panel1.BackColor = Color.DarkRed; p = 1; }
               
            }
            else
            {
                matrz[0, 0] = matrz[0, 0] + 4;
                button4.BackColor = Color.Blue;
                if (matrz[0, 0] == 15) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[0, 0] == 15 && panel1.Visible != true) { panel1.Visible = true; panel1.BackColor = Color.DarkBlue; p = 1; }
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
               
                matrz[0, 1] = matrz[0, 1] + 2;
                button19.BackColor = Color.Red;
                if (matrz[0, 1] == 7) {
                    if (button13.BackColor == Color.Red || button13.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkRed;
                    }
                    else
                    {
                        P1Score++;
                        p = 0;
                    }
                }
                
                else
                {
                    P1Score++;
                    p = 0;
                }
                if (matrz[0, 2] == 7) { panel3.Visible = true; panel3.BackColor = Color.DarkRed; p = 1; }
            }
            else
            {
                
                matrz[0, 1] = matrz[0, 1] + 2;
                button19.BackColor = Color.Blue;
                if (matrz[0, 1] == 7) {
                    if (button13.BackColor == Color.Red || button13.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkBlue;
                    }
                    else
                    {
                        P1Score++;
                        p = 1;
                    }
                }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[0, 2] == 7) { panel3.Visible = true; panel3.BackColor = Color.DarkBlue; p = 0; }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[0, 1] = matrz[0, 1] + 4;
                button5.BackColor = Color.Red;
                if (matrz[0, 1] == 7) {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkRed;
                    }
                    else
                    {
                       
                        p = 0;
                    }
                }
                else
                {
                  
                    p = 0;
                }
            }
            else
            {
                matrz[0, 1] = matrz[0, 1] + 4;
                button5.BackColor = Color.Blue;
                if (matrz[0, 1] == 7) {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel2.Visible = true; panel2.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }
                   
                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (p == 1)
            {
                matrz[0, 2] = matrz[0, 2] + 1;
                button3.BackColor = Color.Red;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[0, 2] = matrz[0, 2] + 1;
                button3.BackColor = Color.Blue;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        
    }

        private void button21_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[0, 2] = matrz[0, 2] + 2;
                button21.BackColor = Color.Red;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[0, 2] = matrz[0, 2] + 2;
                button21.BackColor = Color.Blue;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }



        private void button14_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[1,0] = matrz[1,0] + 2;
                button14.BackColor = Color.Red;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[1, 0] = matrz[1, 0] + 2;
                button14.BackColor = Color.Blue;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[1, 0] = matrz[1, 0] + 4;
                button7.BackColor = Color.Red;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[1, 0] = matrz[1, 0] + 4;
                button7.BackColor = Color.Blue;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[1, 0] = matrz[1, 0] + 8;
                button17.BackColor = Color.Red;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[1, 0] = matrz[1, 0] + 8;
                button17.BackColor = Color.Blue;
                if (matrz[1,0] == 14)
                {
                    if (button4.BackColor == Color.Red || button4.BackColor == Color.Blue)
                    {
                        panel4.Visible = true; panel4.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
              
                matrz[1, 1] = matrz[1, 1] + 2;
                button20.BackColor = Color.Red;
                if (matrz[1, 1] == 8)
                {
                    if (button14.BackColor == Color.Red || button14.BackColor == Color.Blue)
                    {
                        panel5.Visible = true; panel5.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
                if (matrz[0, 1] == 7 &&panel2.Visible!=true) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; p = 1; }
                if (matrz[1, 0] == 14 && panel4.Visible!=true) { panel2.Visible = true; panel2.BackColor = Color.DarkRed; p = 1; }
            }
            
            else
            {
                
                matrz[1, 1] = matrz[1, 1] + 2;
                button20.BackColor = Color.Blue;
                if (matrz[1, 1] == 14)
                {
                    if (button14.BackColor == Color.Red || button14.BackColor == Color.Blue)
                    {
                        panel5.Visible = true; panel5.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
                if (matrz[0, 1] == 7 && panel2.Visible != true) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; p = 0; }
                if (matrz[1, 0] == 14 && panel4.Visible != true) { panel2.Visible = true; panel2.BackColor = Color.DarkBlue; p = 0; }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (p == 1)
            {
                matrz[0, 2] = matrz[0, 2] + 4;
                button6.BackColor = Color.Red;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkRed;
                    }
                    else
                    {

                        p = 0;
                    }
                }
                else
                {

                    p = 0;
                }
            }
            else
            {
                matrz[0, 2] = matrz[0, 2] + 4;
                button6.BackColor = Color.Blue;
                if (matrz[0, 2] == 7)
                {
                    if (button19.BackColor == Color.Red || button19.BackColor == Color.Blue)
                    {
                        panel3.Visible = true; panel3.BackColor = Color.DarkBlue;
                    }
                    else { p = 1; }

                }
                else
                {
                    P1Score++;
                    p = 1;
                }
            }
        }

      
    }
}
