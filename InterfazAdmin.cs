using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class InterfazAdmin : Form
    {
        public InterfazAdmin()
        {
            InitializeComponent();
            Personalizar();
        }

        private void Personalizar()
        {
            PanelSubMenu.Visible = false;
            MenuAccionesAsig.Visible = false;
            MenuOtros.Visible = false;
        }

        private void EsconderSubMenu()
        {
            if (PanelSubMenu.Visible==true)
            {
                PanelSubMenu.Visible = false;
            }
            else if (MenuAccionesAsig.Visible==true)
            {
                MenuAccionesAsig.Visible = false;
            }
            else if (MenuOtros.Visible==true)
            {
                MenuOtros.Visible = false;
            }
        }

        private void MostrarMenu(Panel subMenu)
        {
            if (subMenu.Visible==false)
            {
                subMenu.Hide();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        int lx, ly;
        int sw, sh;

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

        private void button1_Click_1(object sender, EventArgs e)
        {
            ConfirmacionCerrarSesion SesionAdmin = new ConfirmacionCerrarSesion();
            SesionAdmin.Show();
            this.Hide();
        }

        private void BtnAcciones_Click(object sender, EventArgs e)
        {
            MostrarMenu(PanelSubMenu);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AgregarEmpleado AgEmp = new AgregarEmpleado();
            AgEmp.Show();
            this.Hide();
            PanelSubMenu.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ConsultarEmpleado ConsEmp = new ConsultarEmpleado();
            ConsEmp.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            EditarEmpleado EditEmp = new EditarEmpleado();
            EditEmp.Show();
            this.Hide();
            PanelSubMenu.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EliminarEmpleado ElimEmp = new EliminarEmpleado();
            ElimEmp.Show();
            this.Hide();
            PanelSubMenu.Hide();
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            MostrarMenu(MenuAccionesAsig);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            AgregarAsignacion AgAs = new AgregarAsignacion();
            AgAs.Show();
            this.Hide();
            MenuAccionesAsig.Hide();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            ConsultarAsignacion ConsAsig = new ConsultarAsignacion();
            ConsAsig.Show();
            this.Hide();
            MenuAccionesAsig.Hide();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            EditarAsignaciones EditAsig = new EditarAsignaciones();
            EditAsig.Show();
            this.Hide();
            MenuAccionesAsig.Hide();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            ElimAsig elim = new ElimAsig();
            elim.Show();
            this.Hide();
            MenuAccionesAsig.Hide();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            MostrarMenu(MenuOtros);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //...
            //FormHorarios
            //...
            MenuOtros.Hide();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            //...
            //FormSucursales
            //...
            MenuOtros.Hide();
        }

        public void button1_Click_2(object sender, EventArgs e)
        {
            ConfirmacionCerrarSesion Cerrar = new ConfirmacionCerrarSesion();
            Cerrar.Show();
            this.Hide();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnRestaurar_Click(object sender, EventArgs e)
        {

        }

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void BtnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnCerrar_Click_2(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnMinimizar_Click_2(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;

        }


        private void BtnMaximizar_Click_2(object sender, EventArgs e)
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

        private void BtnRestaurar_Click_2(object sender, EventArgs e)
        {
            this.Size = new Size(sw, sh);
            this.Location = new Point(lx, ly);
            BtnMaximizar.Visible = true;
            BtnRestaurar.Visible = false;
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            ConfirmacionCerrarSesion Cerrar = new ConfirmacionCerrarSesion();
            Cerrar.Show();
            this.Hide();
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Horarios Hrs = new Horarios();
            Hrs.Show();
            this.Hide();
        }

        private void button9_Click_2(object sender, EventArgs e)
        {
            Sucursales s = new Sucursales();
            s.Show();
            this.Hide();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Permisos P = new Permisos();
            P.Show();
            this.Hide();
        }

        private void BtnMaximizar_Click_1(object sender, EventArgs e)
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

        private void PanelContenedorForms_Paint(object sender, PaintEventArgs e)
        {

        }



    }
}
