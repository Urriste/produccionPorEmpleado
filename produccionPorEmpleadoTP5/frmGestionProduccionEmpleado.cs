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
    public partial class frmGestionProduccionEmpleado : Form
    {

        Random random = new Random();
        public frmGestionProduccionEmpleado()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAcercaDe ventanaAcercaDe = new frmAcercaDe();
            ventanaAcercaDe.ShowDialog();
        }

        private void cargaAutomáticaDeDatosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           cargaDeDatos();
        }



        private void cargaDeDatos()
        {
            cargarMatrices();

            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 3; j++)
                {
                    MatrizEmpleados.cantidadProducida[i, j] = random.Next(1, 101);
                }
            }


            MessageBox.Show("Datos cargados correctamente 👍");

        }

        private void cargarMatrices()
        {
            cargarMatrizEmpleados();
            cargarMatrizMaquinas();
        }

        private void cargarMatrizEmpleados()
        {
            MatrizEmpleados.empleados[0] = "Garcia, Leonardo";
            MatrizEmpleados.empleados[1] = "Perez, David";
            MatrizEmpleados.empleados[2] = "Fernández, Franco";
            MatrizEmpleados.empleados[3] = "Carrizo, Alejandra";
            MatrizEmpleados.empleados[4] = "Ortega, Marina";
        }

        private void cargarMatrizMaquinas()
        {
            MatrizEmpleados.maquinas[0] = "GH-156";
            MatrizEmpleados.maquinas[1] = "JM-25-80";
            MatrizEmpleados.maquinas[2] = "ZK-1900";
        }

        private void agregarNuevosClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultarCantidadProducidaPorEmpleado ventanaConsultaCantidad = new frmConsultarCantidadProducidaPorEmpleado();
            ventanaConsultaCantidad.ShowDialog();  
        }

        private void listadoDeEmpleadosDeUnaCategoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTotalProducidoDeUnEmpleado ventanaTotalProducido = new frmTotalProducidoDeUnEmpleado();
            ventanaTotalProducido.ShowDialog();
        }
    }
}
