using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace produccionPorEmpleadoTP5
{
    public partial class frmTotalProducidoDeUnEmpleado : Form
    {
        public frmTotalProducidoDeUnEmpleado()
        {
            InitializeComponent();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                Int32 empleadoActual = 0;
                Int32 produccionTotal = 0;

                for (int j = 0; j < 3; j++)
                {
                    empleadoActual = j;
                    produccionTotal = produccionTotal + MatrizEmpleados.cantidadProducida[i, j];


                }
                dgvEmpleados.Rows.Add(MatrizEmpleados.empleados[i], produccionTotal);
            }
        }
    }
}
