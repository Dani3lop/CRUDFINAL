using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace Modelo
{
    public class ModelEmpleado
    {
        #region CRUDDaniel
        public static DataTable CargarTipoDoc()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbdocumento";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarTipoDocumentoInnerJoin(int idTipoDocumento)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbdocumento WHERE idDocumento = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idTipoDocumento));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarEstadoCivil()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbestadocivil";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarEstadoCivilInnerJoin(int idEstadoCivil)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbestadocivil WHERE idEstadoCivil = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstadoCivil));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarEstadoEmp()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbestadoempleado";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarEstadoEmpInnerJoin(int idEstadoEmp)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbestadoempleado WHERE idEstadoEmp = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idEstadoEmp));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }


        public static DataTable CargarSucursal()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbsucursal";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarSucursalInnerJoin(int idSucursal)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbsucursal WHERE idSucursal = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idSucursal));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarCargos()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbcargo";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarCargosInnerJoin(int idCargo)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbcargo WHERE idCargo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idCargo));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarTurnos()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbturnos";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarTurnoInnerJoin(int idTurno)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbturnos WHERE idTurno = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idTurno));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarMunicipios()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbmunicipios";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarMunicipioInnerJoin(int idmunicipio)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbmunicipios WHERE idMunicipio = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idmunicipio));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarUsuarios()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbtipousuario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarUsuarioInnerJoin(int idUsuario)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbtipousuario WHERE idTipoUsuario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idUsuario));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarHorarios()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbhorario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarHorarioInnerJoin(int idHorario)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbhorario WHERE idHorario = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idHorario));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarAreasTrabajo()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbareastrabajo";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarAreasTrabajoInnerJoin(int idAreasTrabajo)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbareastrabajo WHERE idAreaTrabajo = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idAreasTrabajo));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarFormasContacto()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbcontacto";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarContactosInnerJoin(int idContacto)
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbcontacto WHERE idContacto = ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idContacto));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable ObtenerListaEmpleados()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbempleados";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static bool RegistrarEmpleado(string nombre, string apellidos, string direccion, int cargo, int estadoemp, int areat, int TipoUsuario, int Documento, int Contacto, int Sucursal, int Horario, int EstadoCivil, int Municipio, int Turno,  string NombreUsuario, string contra)
        {
            bool retorno;
            try
            {
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbempleados(NombreEmp, ApellidoEmp,DireccionEmp,idCargo,idEstadoEmp,idAreaTrabajo,idUsuario,idDocumento,idContacto,idSucursal,idHorario,idEstadoCivil,idMunicipio,idTurno,NombreUsuario,pass) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}','{12}','{13}','{14}','{15}')",nombre,apellidos,direccion,cargo,estadoemp,areat,TipoUsuario,Documento,Contacto,Sucursal,Horario,EstadoCivil,Municipio,Turno,NombreUsuario,contra), Conexion.GetConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static bool ActualizarEmpleado(int idempleado,string nombre, string apellidos, string direccion, int cargo, int estadoemp, int areat, int TipoUsuario, int Documento, int Contacto, int Sucursal, int Horario, int EstadoCivil, int Municipio, int Turno,  string NombreUsuario, string contra)
        {
            bool retorno;

            try
            {
                MySqlCommand cmdupdate = new MySqlCommand(string.Format("UPDATE tbempleados SET NombreEmp='" + nombre + "', ApellidoEmp='" + apellidos + "', DireccionEmp='" + direccion + "', idCargo='" + cargo + "', idEstadoEmp='" + estadoemp + "', idAreaTrabajo='" + areat + "', idUsuario='" + TipoUsuario + "', idDocumento='" + Documento + "', idContacto='" + Contacto + "', idSucursal='" + Sucursal + "', idHorario='" + Horario + "', idEstadoCivil='" + EstadoCivil + "', idMunicipio='" + Municipio + "', idTurno='" + Turno + "', NombreUsuario='" + NombreUsuario + "', pass='" + contra + "' WHERE idEmpleado='"+idempleado+"'"),Conexion.GetConnect());
                retorno = Convert.ToBoolean(cmdupdate.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static int EliminarEmpleado(int id)
        {
            int retorno = 0;

            try
            {
                MySqlCommand cmddel = new MySqlCommand(string.Format("DELETE FROM tbempleados WHERE idEmpleado = '" + id + "'"), Conexion.GetConnect());
                retorno = Convert.ToInt16(cmddel.ExecuteNonQuery());
                if (retorno ==1)
                {
                    retorno = 1;
                }
                else
                {
                    retorno = 2;
                }
                return retorno;
            }
            catch (Exception)
            {

                return retorno = -1;
            }
        }
        #endregion

        #region
        public static DataTable CargarEstadoHorario()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbestadohorario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static bool RegistrarHorarios(string horario,int idEstadoHorario)
        {
            bool retorno;
            try
            {
                
                MySqlCommand cmdinsert = new MySqlCommand(string.Format("INSERT INTO tbhorario(Horario,idEstadoHorario) VALUES ('{0}','{1}')", horario, idEstadoHorario), Conexion.GetConnect());
                retorno = Convert.ToBoolean(cmdinsert.ExecuteNonQuery());
                return retorno;
            }
            catch (Exception)
            {
                return retorno = false;
            }
        }

        public static DataTable ObtenerHorarios()
        {
            DataTable data;

            try
            {
                string query = "SELECT * FROM tbhorario";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
            finally
            {
                Conexion.GetConnect().Close();
            }
        }

        public static DataTable CargarHorariosInnerJoin(int idHorario)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbhorario WHERE idHorario= ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idHorario));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }

        public static DataTable CargarEstadoHorariosInnerJoin(int idHorario)
        {
            DataTable data;
            try
            {
                string query = "SELECT * FROM tbestadohorario WHERE idHorario= ?param1";
                MySqlCommand cmdselect = new MySqlCommand(string.Format(query), Conexion.GetConnect());
                cmdselect.Parameters.Add(new MySqlParameter("param1", idHorario));
                MySqlDataAdapter adp = new MySqlDataAdapter(cmdselect);
                data = new DataTable();
                adp.Fill(data);
                return data;
            }
            catch (Exception)
            {
                return data = null;
            }
        }
        #endregion
    }
}
