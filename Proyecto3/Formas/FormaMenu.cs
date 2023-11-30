using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto3.Formas
{
    public partial class FormaMenu : Form
    {
        public FormaMenu()
        {
            InitializeComponent();
        }

        private void tiendaCelularesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaTienda tienda = new FormaTienda();
            tienda.Show();
            Close();
        }

        private void tiendaEmpleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaEmpleados emplleaods = new FormaEmpleados();
            emplleaods.Show();


            Close();
        }

        private void agregarUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormaUsuario usuario = new FormaUsuario();
            usuario.Show();
            Close();
        }
    }
}
