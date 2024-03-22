using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vistas
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            openChildForm(new FrmDashboard());
        }

        private void btnAdministracion_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdministracion());
            mostrarSubMenu(pnlAdministracion);            
        }
        private Form activeForm = null;       
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlVistas.Controls.Add(childForm);
            childForm.Show();

        }
        private void btnInicio_Click(object sender, EventArgs e)
        {            
             openChildForm(new FrmDashboard());
             ocultarSubMenu();
            
        }
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void ocultarSubMenu()
        {

            if (pnlAdministracion.Visible == true)
                pnlAdministracion.Visible = false;            
        }
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdministracionCRUD());            
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            openChildForm(new FrmAdministracionCRUD());
        }
        
    }
}
