using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Primer_Parcial
{
    public partial class Tarea1 : Form
    {
        public Tarea1()
        {
            InitializeComponent();
        }

        private void CalcularButton1_Click(object sender, EventArgs e)
        {

            int num;
            num = int.Parse(IngreseTextBox.Text);
           

            if(num % 2 == 0)
            {
                ResultadoTextBox.Text = "Numero Par";
            }
            else
            {
                ResultadoTextBox.Text = "Numero es Par";
            }
        }
    }
}
