using System;
using System.Windows.Forms;

namespace Primer_Parcial
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void FechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void EjecutarButton_Click(object sender, EventArgs e)
        {
            DateTime fecha = FechaDateTimePicker.Value;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
