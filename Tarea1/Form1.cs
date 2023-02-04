using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CalcularButton_Click(object sender, EventArgs e)
        {
            int num;
            num = int.Parse(IngreseTextBox.Text);
            //Esta funcion nos ayudara a determinar si el numero es par o impar positivo o negativo//
            if (num % 2 == 0)
            {
                if (num >= 0) 
                {

                    ResultadoTextBox.Text = "El Numero es Par y es Positivo";
                }
               else
                {
                    ResultadoTextBox.Text = "El Numero es Par y es Negativo";
                }

            }
            else

            if (num >= 0)
            {
                ResultadoTextBox.Text = "El numero es Impar y es positivo";
            }
            else
            {
                ResultadoTextBox.Text = "El numero es Impar y es Negativo";
            }
        }
    }
}
