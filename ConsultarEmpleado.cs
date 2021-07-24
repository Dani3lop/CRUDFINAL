using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using Controlador;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class ConsultarEmpleado : Form
    {
        public ConsultarEmpleado()
        {
            InitializeComponent();
        }

        public DataTable datos;
        void verificarConexion()
        {
            MySqlConnection retorno = ControllerConexion.ObtenerConexion();
            if (retorno != null)
            {
                MessageBox.Show("Conexión establecida con exito",
                                "Conexión completada", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error al establecer conexión con el servidor, verifique su conexión a internet o consulte a su adminsitrador.",
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            InterfazAdmin GoBack = new InterfazAdmin();
            GoBack.Show();
            this.Hide();
        }

        int lx, ly;
        int sw, sh;

        public static void DgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ConsultarEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }


    }
}
