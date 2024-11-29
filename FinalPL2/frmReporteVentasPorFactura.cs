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
    public partial class frmReporteVentasPorFactura : Form
    {
        public frmReporteVentasPorFactura()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsSalesDetail objSalesDet = new clsSalesDetail();
            objSalesDet.ReporteVentasPorFactura(Convert.ToInt32(txtSalesIDNumber.Text));
        }
    }
}
