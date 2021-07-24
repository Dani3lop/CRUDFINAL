using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Vista
{
    public partial class InterfazEmpleado : Form
    {
        public InterfazEmpleado()
        {
            InitializeComponent();
        }
        #region Funcionalidades del form
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Capturar posiciones y tamaño antes de maximizar para restaurar
        int lx, ly;
        int sw, sh;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Size = new Size(sw,sh);
            this.Location = new Point(lx,ly);
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMaximizar_Click(object sender, EventArgs e)
        {
            lx = this.Location.X;
            ly = this.Location.Y;
            sw = this.Size.Width;
            sh = this.Size.Height;
            BtnMaximizar.Visible = false;
            BtnRestaurar.Visible = true;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
        }

        private void panelBarraTitulo_MouseMove(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle,0x112,0xf012,0);
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        private void button7_Click(object sender, EventArgs e)
        {
            ConfirmacionCerrarSesion CerrarSesion = new ConfirmacionCerrarSesion();
            CerrarSesion.Show();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            HorarioEmpleado HE = new HorarioEmpleado();
            HE.Show();
            this.Hide();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            AsignacionesEmp As = new AsignacionesEmp();
            As.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SucursalesEmp SE = new SucursalesEmp();
            SE.Show();
            this.Hide();
        }

        private void PanelFormularios_Paint(object sender, PaintEventArgs e)
        {

        }

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        #endregion


    }
}
