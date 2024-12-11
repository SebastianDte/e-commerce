using System;
using System.Windows.Forms;

namespace Vistas
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Cambia `Form1` por el nombre de tu formulario principal
            Application.Run(new Loguin());
        }
    }
}
