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
    public partial class frmReportePorRol : Form
    {
        public frmReportePorRol()
        {
            InitializeComponent();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsEmployee objEmpleado = new clsEmployee();
            objEmpleado.GenerarReporte(cmbRoles.SelectedItem.ToString());
        }

        private void frmReportePorRol_Load(object sender, EventArgs e)
        {
            clsEmployee objEmpleado = new clsEmployee();
            objEmpleado.ListarRolesCB(cmbRoles);
        }

        private void cmbRoles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedIndex != -1 && cmbRoles.SelectedIndex != 0)
            {
                cmdGenerarReporte.Enabled = true;
            } 
        }
    }
}
