using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FORMULARIOS
{
    public partial class FRMPORTADA : Form
    {
        public FRMPORTADA()
        {
            InitializeComponent();
        }
        public static void Main()
        {
            FORMULARIOS.FRMPORTADA PORTADA = new FORMULARIOS.FRMPORTADA();
            PORTADA.ShowDialog();

        }

        private void BtnCliente_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMCLIENTES CLIENTES = new FORMULARIOS.FRMCLIENTES();
            CLIENTES.Show();
        }

        private void BtnEmpleado_Click(object sender, EventArgs e)
        {
            FORMULARIOS.FRMEMPLEADOS EMPLEADOS = new FORMULARIOS.FRMEMPLEADOS();
            EMPLEADOS.Show();
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
