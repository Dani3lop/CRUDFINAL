using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Controlador;
using System.Windows.Forms;

namespace Vista
{
    public partial class Horarios : Form
    {
        public Horarios()
        {
            InitializeComponent();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            int lx, ly;
            int sw, sh;

            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            InterfazAdmin Ad = new InterfazAdmin();
            Ad.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            envioHorarios();
            CargarHorarios();
        }

        void envioHorarios()
        {
            MainController agregar = new MainController();
            agregar.Horario = Convert.ToInt16(CmbHorarios.SelectedValue);
            agregar.idEstadoHorario = Convert.ToInt16(CmbEstadoHorario.SelectedValue);
            agregar.EnviarHorarios_Controller();

            if (agregar.EnviarHorarios_Controller()==false)
            {
                MessageBox.Show("El horario no pudo ser ingresado","Error de Insercion",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Horarios_Load(object sender, EventArgs e)
        {
            CargarHorarios();
        }
        void CargarHorarios()
        {
            try
            {
                CmbHorarios.DataSource = MainController.CargarHorario_Controller();
                CmbHorarios.ValueMember = "idHorario";
                CmbHorarios.DisplayMember = "Horario";

                CmbEstadoHorario.DataSource = MainController.CargarEstadoHorarios_Controller();
                CmbEstadoHorario.ValueMember = "idEstadoHorario";
                CmbEstadoHorario.DisplayMember = "EstadoHorario";

                DgvHorarios.DataSource = MainController.CargarHorario_Controller();
            }
            catch (Exception)
            {

            }
        }

        private void DgvHorarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainController objselect = new MainController();
            int posicion;
            posicion = DgvHorarios.CurrentRow.Index;
            txtid.Text = DgvHorarios[0, posicion].Value.ToString();
            int Horario = Convert.ToInt16(DgvHorarios[1, posicion].Value.ToString());
            CmbHorarios.DataSource = objselect.CargarHorariosInner_Controller(Horario);
            CmbHorarios.ValueMember = "idHorario";
            CmbHorarios.DisplayMember = "Horario";
            int EstadoHorario = Convert.ToInt16(DgvHorarios[2, posicion].Value.ToString());
            CmbEstadoHorario.DataSource = objselect.CargarEstadoHorariosInner_Controller(EstadoHorario);
            CmbEstadoHorario.ValueMember = "idEstadoHorario";
            CmbEstadoHorario.DisplayMember = "EstadoHorario";
        }
    }
}
