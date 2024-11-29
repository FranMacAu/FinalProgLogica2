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

        private void reporteDeTodosLosProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsProduct objProduct = new clsProduct();
            objProduct.ReporteProductosOrdenados();
        }

        private void unoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteBusquedaProductos V = new frmReporteBusquedaProductos();
            V.ShowDialog();
        }

        private void reporteDeVentasPorPeriodoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentasPorPeriodo V = new frmReporteVentasPorPeriodo();
            V.ShowDialog();
        }

        private void reporteDeVentasPorFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteVentasPorFactura V = new frmReporteVentasPorFactura();
            V.ShowDialog();
        }

        private void reporteDeProductosMásVendidosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteProdMasVendidos V = new frmReporteProdMasVendidos();
            V.ShowDialog();
        }
    }
}
