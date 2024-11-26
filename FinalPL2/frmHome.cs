using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalPL2
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void reportePorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePorRol V = new frmReportePorRol();
            V.ShowDialog();
        }

        private void reportePróximosCumpleañosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteCumpleaños V = new frmReporteCumpleaños();
            V.ShowDialog();
        }

        private void modificarDatosDeEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModificarEmpleado V = new frmModificarEmpleado();
            V.ShowDialog();
        }
    }
}
