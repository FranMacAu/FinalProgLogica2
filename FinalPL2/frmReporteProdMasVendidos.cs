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
    public partial class frmReporteProdMasVendidos : Form
    {
        public frmReporteProdMasVendidos()
        {
            InitializeComponent();
        }

        private void cmdGenerarReporte_Click(object sender, EventArgs e)
        {
            clsSalesDetail objSalessDetail = new clsSalesDetail();
            objSalessDetail.ReporteCompradoresProdMasVendidos(txtProdNumber.Text);
        }
    }
}
