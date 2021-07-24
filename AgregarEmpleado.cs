using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using Controlador;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vista
{
    public partial class AgregarEmpleado : Form
    {
        #region CRUDDaniel

        public AgregarEmpleado()
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
            InterfazAdmin InterAd = new InterfazAdmin();
            InterAd.Show();
            this.Hide();
        }

        void enviodatos()
        {
            if (TxtNombres.Text.Trim() == "" || TxtApellidos.Text.Trim()=="" || TxtNombreUsuario.Text.Trim()=="" || TxtContra.Text.Trim()==""|| TxtDireccion.Text.Trim()=="")
            {
                MessageBox.Show("No puede dejar campos vacios, esto impide un buen registro en la base de datos", "Error al realizar el proceso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MainController agregar = new MainController();
                agregar.idempleado = Convert.ToInt16(txtId.Text);
                agregar.nombre = TxtNombres.Text;
                agregar.apellidos = TxtApellidos.Text;
                agregar.direccion = TxtDireccion.Text;
                agregar.Usuario = Convert.ToInt16(CmbUsuario.SelectedValue);
                agregar.Documento = Convert.ToInt16(CmbDocumento.SelectedValue);
                agregar.cargo = Convert.ToInt16(CmbCargo.SelectedValue);
                agregar.estadoemp = Convert.ToInt16(CmbEstadoEmpleado.SelectedValue);
                agregar.areat = Convert.ToInt16(CmbAreaTrabajo.SelectedValue);
                agregar.Contacto = Convert.ToInt16(CmbContacto.SelectedValue);
                agregar.Sucursal = Convert.ToInt16(CmbSucursal.SelectedValue);
                agregar.Horario = Convert.ToInt16(CmbHorario.SelectedValue);
                agregar.EstadoCivil = Convert.ToInt16(CmbEstadoCivil.SelectedValue);
                agregar.Municipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
                agregar.Turno = Convert.ToInt16(CmbTurno.SelectedValue);
                agregar.NombreUsuario = TxtNombreUsuario.Text;
                agregar.Contra = TxtContra.Text;
                agregar.EnviarDatos_Controller();

                if (agregar.EnviarDatos_Controller() == false)
                {
                    MessageBox.Show("Usuario no pudo ser ingresado", "Error de insercion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    LimpiarCampos();

                    Confirmacion Confirm = new Confirmacion();
                    Confirm.Show();
                    this.Hide();
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            enviodatos();
            CargarLista();
        }

        void LimpiarCampos()
        {
            txtId.Clear();
            TxtNombres.Clear();
            TxtApellidos.Clear();
            TxtDireccion.Clear();
            TxtNombreUsuario.Clear();
            TxtContra.Clear();
        }


        private void AgregarEmpleado_Load(object sender, EventArgs e)
        {
            CargarLista();
        }

        public void CargarLista()
        {
            try
            {
                CargarAreaT();
                CargarCargos();
                CargarContactos();
                CargarDoc();
                CargarEstadoCivil();
                CargarEstadoEmp();
                CargarHorarios();
                CargarMunicipios();
                CargarSucursales();
                CargarTurnos();
                CargarUsuarios();

                DgvEmpleados.DataSource = MainController.CargarEmpleados_Controller();
            }
            catch (Exception)
            {
                MessageBox.Show("Error al cargar almenos una de las listas, consulte con el administrador", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MainController objselect = new MainController();
            int posicion;
            posicion = DgvEmpleados.CurrentRow.Index;
            txtId.Text = DgvEmpleados[0, posicion].Value.ToString();
            TxtNombres.Text = DgvEmpleados[1, posicion].Value.ToString();
            TxtApellidos.Text = DgvEmpleados[2, posicion].Value.ToString();
            TxtDireccion.Text = DgvEmpleados[3, posicion].Value.ToString();

            int idCargo = Convert.ToInt16(DgvEmpleados[4, posicion].Value.ToString());
            CmbCargo.DataSource = objselect.CargarCargos(idCargo);
            CmbCargo.DisplayMember = "NombreCargo";
            CmbCargo.ValueMember = "idCargo";

            int idEstadoEmp = Convert.ToInt16(DgvEmpleados[5, posicion].Value.ToString());
            CmbEstadoEmpleado.DataSource = objselect.CargarEstadoEmpInnerJoin(idEstadoEmp);
            CmbEstadoEmpleado.DisplayMember = "EstadoEmplado";
            CmbEstadoEmpleado.ValueMember = "idEstadoEmp";

            int idAreaTrabajo = Convert.ToInt16(DgvEmpleados[6, posicion].Value.ToString());
            CmbAreaTrabajo.DataSource = objselect.AreasTrabajoInnerJoin(idAreaTrabajo);
            CmbAreaTrabajo.DisplayMember = "NombreAreaTrabajo";
            CmbAreaTrabajo.ValueMember = "idAreaTrabajo";

            int idUsuario = Convert.ToInt16(DgvEmpleados[7, posicion].Value.ToString());
            CmbUsuario.DataSource = objselect.CargarUsuariosInnerJoin(idUsuario);
            CmbUsuario.DisplayMember = "NombreTipoUsuario";
            CmbUsuario.ValueMember = "idTipoUsuario";


            int idTipoDocumento = Convert.ToInt16(DgvEmpleados[8,posicion].Value.ToString());
            CmbDocumento.DataSource = objselect.CargarTipoDocumento(idTipoDocumento);
            CmbDocumento.DisplayMember = "Documento";
            CmbDocumento.ValueMember = "idDocumento";

            int idContacto = Convert.ToInt16(DgvEmpleados[9, posicion].Value.ToString());
            CmbContacto.DataSource = objselect.CargarContactosInnerJoin(idContacto);
            CmbContacto.DisplayMember = "Contacto";
            CmbContacto.ValueMember = "idContacto";

            int idSucursal = Convert.ToInt16(DgvEmpleados[10, posicion].Value.ToString());
            CmbSucursal.DataSource = objselect.CargarSucursalInnerJoin(idSucursal);
            CmbSucursal.DisplayMember = "NombreSucursal";
            CmbSucursal.ValueMember = "idSucursal";

            int idHorario = Convert.ToInt16(DgvEmpleados[11, posicion].Value.ToString());
            CmbHorario.DataSource = objselect.CargarHorarioInnerJoin(idHorario);
            CmbHorario.DisplayMember = "Horario";
            CmbHorario.ValueMember = "idHorario";

            int idEstadoCivil = Convert.ToInt16(DgvEmpleados[13, posicion].Value.ToString());
            CmbEstadoCivil.DataSource = objselect.CargarEstadoCivilInnerJoin(idEstadoCivil);
            CmbEstadoCivil.DisplayMember = "EstadoCivil";
            CmbEstadoCivil.ValueMember = "idEstadoCivil";

            int idMunicipio = Convert.ToInt16(DgvEmpleados[14, posicion].Value.ToString());
            CmbMunicipio.DataSource = objselect.CargarMunicipioInnerJoin(idMunicipio);
            CmbMunicipio.DisplayMember = "NombreMunicipio";
            CmbMunicipio.ValueMember = "idMunicipio";

            int idTurno = Convert.ToInt16(DgvEmpleados[15, posicion].Value.ToString());
            CmbTurno.DataSource = objselect.CargarTurno(idTurno);
            CmbTurno.DisplayMember = "NombreTurno";
            CmbTurno.ValueMember = "idTurno";

            TxtNombreUsuario.Text = DgvEmpleados[16, posicion].Value.ToString();
            TxtContra.Text = DgvEmpleados[17, posicion].Value.ToString();
        }

        void CargarMunicipios()
        {
            CmbMunicipio.DataSource = MainController.CargarMunicipios_Controller();
            CmbMunicipio.ValueMember = "idMunicipio";
            CmbMunicipio.DisplayMember = "NombreMunicipio";
        }

        void CargarDoc()
        {
            CmbDocumento.DataSource = MainController.CargarDocumento_Controller();
            CmbDocumento.ValueMember = "idDocumento";
            CmbDocumento.DisplayMember = "Documento";
        }

        void CargarEstadoCivil()
        {
            CmbEstadoCivil.DataSource = MainController.CargarEstadoCivil_Controller();
            CmbEstadoCivil.ValueMember = "idEstadoCivil";
            CmbEstadoCivil.DisplayMember = "EstadoCivil";
        }

        void CargarContactos()
        {
            CmbContacto.DataSource = MainController.CargarContactos_Controller();
            CmbContacto.ValueMember = "idContacto";
            CmbContacto.DisplayMember = "Contacto";
        }

        void CargarHorarios()
        {
            CmbHorario.DataSource = MainController.CargarHorario_Controller();
            CmbHorario.ValueMember = "Horario";
            CmbHorario.ValueMember = "idHorario";
        }

        void CargarUsuarios()
        {
            CmbUsuario.DataSource = MainController.CargarUsuarios_Controller();
            CmbUsuario.ValueMember = "idTipoUsuario";
            CmbUsuario.DisplayMember = "NombreTipoUsuario";
        }

        void CargarTurnos()
        {
            CmbTurno.DataSource = MainController.CargarTurno_Controller();
            CmbTurno.ValueMember = "idTurno";
            CmbTurno.DisplayMember = "NombreTurno";
        }

        void CargarCargos()
        {
            CmbCargo.DataSource = MainController.CargarCargo_Controller();
            CmbCargo.ValueMember = "idCargo";
            CmbCargo.DisplayMember = "NombreCargo";
        }

        void CargarEstadoEmp()
        {
            CmbEstadoEmpleado.DataSource = MainController.CargarEstadoEmpleado_Controller();
            CmbEstadoEmpleado.ValueMember = "idEstadoEmp";
            CmbEstadoEmpleado.DisplayMember = "EstadoEmplado";
        }

        void CargarSucursales()
        {
            CmbSucursal.DataSource = MainController.CargarSucursal_Controller();
            CmbSucursal.ValueMember = "idSucursal";
            CmbSucursal.DisplayMember = "NombreSucursal";
        }

        void CargarAreaT()
        {
            CmbAreaTrabajo.DataSource = MainController.CargarAreasTrabajo_Controller();
            CmbAreaTrabajo.ValueMember = "idAreaTrabajo";
            CmbAreaTrabajo.DisplayMember = "NombreAreaTrabajo";
        }

        private void CmbEstadoCivil_Click(object sender, EventArgs e)
        {
            CargarEstadoCivil();
        }

        private void CmbEstadoEmpleado_Click(object sender, EventArgs e)
        {
            CargarEstadoEmp();
        }

        private void CmbAreaTrabajo_Click(object sender, EventArgs e)
        {
            CargarAreaT();
        }

        private void CmbDocumento_Click(object sender, EventArgs e)
        {
            CargarDoc();
        }

        private void CmbContacto_Click(object sender, EventArgs e)
        {
            CargarContactos();
        }

        private void CmbSucursal_Click(object sender, EventArgs e)
        {
            CargarSucursales();
        }

        private void CmbUsuario_Click(object sender, EventArgs e)
        {
            CargarUsuarios();
        }

        private void CmbHorario_Click(object sender, EventArgs e)
        {
            CargarHorarios();
        }

        private void CmbCargo_Click(object sender, EventArgs e)
        {
            CargarCargos();
        }

        private void CmbMunicipio_Click(object sender, EventArgs e)
        {
            CargarMunicipios();
        }

        private void CmbTurno_Click(object sender, EventArgs e)
        {
            CargarTurnos();
        }

        void ActualizarDatos()
        {
            MainController objactualizar = new MainController();
            objactualizar.idempleado = Convert.ToInt16(txtId.Text);
            objactualizar.nombre = TxtNombres.Text;
            objactualizar.apellidos = TxtApellidos.Text;
            objactualizar.direccion = TxtDireccion.Text;
            objactualizar.cargo = Convert.ToInt16(CmbCargo.SelectedValue);
            objactualizar.estadoemp = Convert.ToInt16(CmbEstadoEmpleado.SelectedValue);
            objactualizar.areat = Convert.ToInt16(CmbAreaTrabajo.SelectedValue);
            objactualizar.Usuario = Convert.ToInt16(CmbUsuario.SelectedValue);
            objactualizar.Documento = Convert.ToInt16(CmbDocumento.SelectedValue);
            objactualizar.Contacto = Convert.ToInt16(CmbContacto.SelectedValue);
            objactualizar.Sucursal = Convert.ToInt16(CmbSucursal.SelectedValue);
            objactualizar.Horario = Convert.ToInt16(CmbHorario.SelectedValue);
            objactualizar.EstadoCivil = Convert.ToInt16(CmbEstadoCivil.SelectedValue);
            objactualizar.Municipio = Convert.ToInt16(CmbMunicipio.SelectedValue);
            objactualizar.Turno = Convert.ToInt16(CmbTurno.SelectedValue);
            objactualizar.NombreUsuario = TxtNombreUsuario.Text;
            objactualizar.Contra = TxtContra.Text;

            if (objactualizar.ActualizarDatos_Controller()==false)
            {
                MessageBox.Show("Usuario no pudo ser actualizado", "Error de Insercion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                LimpiarCampos();
            }
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            ActualizarDatos();
            CargarLista();
        }

        void EliminarDatos()
        {
            MainController objdel = new MainController();
            objdel.idempleado = Convert.ToInt16(txtId.Text);
            int valor = objdel.EliminarEmpleado_Controller();
            switch (valor)
            {
                case -1:
                    MessageBox.Show("Ocurrio un error al establecer conexion con la base de datos, verifique su acceso a internet o que los servicios del servidor esten activos.", "Error Critico", MessageBoxButtons.OK,MessageBoxIcon.Error);
                    break;
                case 1:
                    MessageBox.Show("Usuario Eliminado Correctamente", "Proceso Completado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case 2:
                    MessageBox.Show("Empleado no pudo ser eliminado, debido a que existen datos pendientes.", "Proceso Interrumpido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                default:
                    break;
            }
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Estas seguro de querer eliminar a: " + TxtNombres.Text + " " + TxtApellidos.Text, "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dr == DialogResult.Yes)
            {
                EliminarDatos();
                CargarLista();
                LimpiarCampos();

            }
        }
        #endregion
    }

}
