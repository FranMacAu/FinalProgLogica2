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
    public partial class frmReporteVentasPorPeriodo : Form
    {
        public frmReporteVentasPorPeriodo()
        {
            InitializeComponent();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsSalesHeader objSalesHeader = new clsSalesHeader();
            objSalesHeader.ReporteVentasEntreFechas(datMinDate.Value, datMaxDate.Value);
        }
    }
}
