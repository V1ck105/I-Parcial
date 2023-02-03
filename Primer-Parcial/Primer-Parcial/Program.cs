using System;
using System.Windows.Forms;

namespace Primer_Parcial
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
#pragma warning disable CS0246 // El nombre del tipo o del espacio de nombres 'Ejercicio1' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
            Application.Run(new Ejercicio1());
#pragma warning restore CS0246 // El nombre del tipo o del espacio de nombres 'Ejercicio1' no se encontró (¿falta una directiva using o una referencia de ensamblado?)
        }
    }

    internal class Ejercicio1 : Form
    {
    }
}
