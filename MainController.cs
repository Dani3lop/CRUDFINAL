using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Modelo;
using MySql.Data.MySqlClient;



namespace Controlador
{
    public class MainController
    {
        #region CRUDDaniel
        public static MySqlConnection ConnectController()
        {
            return Conexion.GetConnect();
        }

        public static DataTable CargarMunicipios_Controller()
        {
            return ModelEmpleado.CargarMunicipios();
        }

        public DataTable CargarMunicipioInnerJoin(int id)
        {
            return ModelEmpleado.CargarMunicipioInnerJoin(id);
        }

        public static DataTable CargarUsuarios_Controller()
        {
            return ModelEmpleado.CargarUsuarios();
        }

        public DataTable CargarUsuariosInnerJoin(int id)
        {
            return ModelEmpleado.CargarUsuarioInnerJoin(id);
        }

        public static DataTable CargarEstadoCivil_Controller()
        {
            return ModelEmpleado.CargarEstadoCivil();
        }

        public DataTable CargarEstadoCivilInnerJoin(int id)
        {
            return ModelEmpleado.CargarEstadoCivilInnerJoin(id);
        }

        public static DataTable CargarEstadoEmpleado_Controller()
        {
            return ModelEmpleado.CargarEstadoEmp();
        }

        public static DataTable CargarDocumento_Controller()
        {
            return ModelEmpleado.CargarTipoDoc();
        }

        public DataTable CargarTipoDocumento(int id)
        {
            return ModelEmpleado.CargarTipoDocumentoInnerJoin(id);
        }

        public static DataTable CargarSucursal_Controller()
        {
            return ModelEmpleado.CargarSucursal();
        }

        public DataTable CargarSucursalInnerJoin(int id)
        {
            return ModelEmpleado.CargarSucursalInnerJoin(id);
        }

        public static DataTable CargarCargo_Controller()
        {
            return ModelEmpleado.CargarCargos();
        }

        public DataTable CargarCargos(int id)
        {
            return ModelEmpleado.CargarCargosInnerJoin(id);
        }

        public static DataTable CargarTurno_Controller()
        {
            return ModelEmpleado.CargarTurnos();
        }

        public DataTable CargarTurno(int id)
        {
            return ModelEmpleado.CargarTurnoInnerJoin(id);
        }

        public static DataTable CargarHorario_Controller()
        {
            return ModelEmpleado.CargarHorarios();
        }

        public DataTable CargarHorarioInnerJoin(int id)
        {
            return ModelEmpleado.CargarHorarioInnerJoin(id);
        }

        public static DataTable CargarAreasTrabajo_Controller()
        {
            return ModelEmpleado.CargarAreasTrabajo();
        }

        public DataTable AreasTrabajoInnerJoin(int id)
        {
            return ModelEmpleado.CargarAreasTrabajoInnerJoin(id);
        }

        public static DataTable CargarContactos_Controller()
        {
            return ModelEmpleado.CargarFormasContacto();
        }

        public DataTable CargarContactosInnerJoin(int id)
        {
            return ModelEmpleado.CargarContactosInnerJoin(id);
        }

        public static DataTable CargarEmpleados_Controller()
        {
            return ModelEmpleado.ObtenerListaEmpleados();
        }

        public DataTable CargarEstadoEmpInnerJoin(int id)
        {
            return ModelEmpleado.CargarEstadoEmpInnerJoin(id);
        }


        public int idempleado { get; set; }
        public string nombre { get; set; }
        public string apellidos { get; set; }
        public string direccion { get; set; }
        public int cargo { get; set; }
        public int estadoemp { get; set; }
        public int areat { get; set; }
        public int Usuario { get; set; }
        public int Documento { get; set; }
        public int Contacto { get; set; }
        public int Sucursal { get; set; }
        public int Horario { get; set; }
        public int EstadoCivil { get; set; }
        public int Municipio { get; set; }
        public int Turno { get; set; }
        public string NombreUsuario { get; set; }
        public string Contra { get; set; }

        public bool EnviarDatos_Controller()
        {
            return ModelEmpleado.RegistrarEmpleado(nombre, apellidos, direccion, cargo, estadoemp, areat, Usuario, Documento, Contacto, Sucursal, Horario, EstadoCivil, Municipio, Turno, NombreUsuario, Contra);
        }

        public bool ActualizarDatos_Controller()
        {
            return ModelEmpleado.ActualizarEmpleado(idempleado,nombre, apellidos, direccion,  cargo, estadoemp, areat, Usuario, Documento, Contacto, Sucursal, Horario, EstadoCivil, Municipio, Turno, NombreUsuario, Contra);
        }

        public int EliminarEmpleado_Controller()
        {
            return ModelEmpleado.EliminarEmpleado(idempleado);
        }
        #endregion

        #region CRUDEllerbrock
        public static DataTable CargarEstadoHorarios_Controller()
        {
            return ModelEmpleado.CargarEstadoHorario();
        }

        public int idHorario { get; set; }
        public string Horarios { get; set; }
        public int idEstadoHorario { get; set; }

        public MainController() { }

        public bool EnviarHorarios_Controller()
        {
            return ModelEmpleado.RegistrarHorarios(Horarios, idEstadoHorario);
        }

        public DataTable CargarHorariosInner_Controller(int id)
        {
            return ModelEmpleado.CargarHorarioInnerJoin(id);
        }

        public DataTable CargarEstadoHorariosInner_Controller(int id)
        {
            return ModelEmpleado.CargarHorarioInnerJoin(id);
        }

//
        #endregion
    }

}
