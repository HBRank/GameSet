using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto1._0
{
    partial class InstruccionesSopa : Form
    {
        public InstruccionesSopa()
        {
            InitializeComponent();
            this.Text = String.Format("Instrucciones");
         
     
        }

        

        private void labelProductName_Click(object sender, EventArgs e)
        {

        }

        private void okButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
