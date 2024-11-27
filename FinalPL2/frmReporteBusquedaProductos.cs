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
    public partial class frmReporteBusquedaProductos : Form
    {
        public frmReporteBusquedaProductos()
        {
            InitializeComponent();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsProduct objProd = new clsProduct();
            objProd.ReporteResultadosBusqueda(txtBusqueda.Text);
        }

        
    }
}
