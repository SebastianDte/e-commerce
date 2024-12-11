using System;
using System.Drawing;
using System.Windows.Forms;

namespace Vistas
{
    public class LineaControl : Control
    {
        public LineaControl()
        {
            // Configuración inicial
            BackColor = Color.FromArgb(15, 15, 15); // Fondo 15;15;15
            ForeColor = Color.DimGray; // Color de la línea
            Height = 1; // Grosor predeterminado de la línea
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (Pen pen = new Pen(ForeColor, Height)) // Usar el ForeColor como color de la línea
            {
                // Dibuja la línea horizontal en el centro del control
                e.Graphics.DrawLine(pen, 0, Height / 2, Width, Height / 2);
            }
        }

        protected override void OnPaintBackground(PaintEventArgs pevent)
        {
            // Pintamos el fondo con el color especificado en BackColor
            pevent.Graphics.Clear(BackColor);
        }
    }
}
