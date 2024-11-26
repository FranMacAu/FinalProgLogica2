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
    public partial class frmModificarEmpleado : Form
    {
        public frmModificarEmpleado()
        {
            InitializeComponent();
        }

        private void cmdBuscar_Click(object sender, EventArgs e)
        {
            clsEmployee objEmployee = new clsEmployee();
            objEmployee.BuscarPorNationalIDNumber(Convert.ToInt32(txtNationalIDNumber.Text), txtJobTitle, txtMaritalStatus, txtVacationHours, cmdModificar);
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            clsEmployee objEmployee = new clsEmployee();
            objEmployee.ModificarPorNationalIDNumber(Convert.ToInt32(txtNationalIDNumber.Text), txtJobTitle, txtMaritalStatus, txtVacationHours);
            
        }
    }
}
