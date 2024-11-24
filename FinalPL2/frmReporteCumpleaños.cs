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
    public partial class frmReporteCumpleaños : Form
    {
        public frmReporteCumpleaños()
        {
            InitializeComponent();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsEmployee objEmployee = new clsEmployee();
            objEmployee.GenerarReporteCumpleaños(cmbMeses.SelectedIndex); // paámetro fijo provisorio
        }

        private void frmReporteCumpleaños_Load(object sender, EventArgs e)
        {
            clsEmployee objEmployee = new clsEmployee();
            objEmployee.ListarMesesCB(cmbMeses);
        }
    }
}
