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
    public partial class frmConsultarCantidadProducidaPorEmpleado : Form
    {
        public frmConsultarCantidadProducidaPorEmpleado()
        {
            InitializeComponent();
        }

        private void frmConsultarCantidadProducidaPorEmpleado_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                cmxEmpleados.Items.Add(MatrizEmpleados.empleados[i]);
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Int32 empleadoSeleccionado = cmxEmpleados.SelectedIndex;

            dgvEmpleados.Rows.Clear();

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if(empleadoSeleccionado == i)
                    {
                        dgvEmpleados.Rows.Add(MatrizEmpleados.maquinas[j], MatrizEmpleados.cantidadProducida[i,j]);
                    }
                 
                }
            }

        }

        private void cmxEmpleados_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
