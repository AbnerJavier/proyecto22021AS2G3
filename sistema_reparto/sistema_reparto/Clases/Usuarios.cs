using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_reparto.Clases
{
    public class Usuarios
    {
        //Atributos
        String idUsuario;
        String idPermiso;
        String nombreUsuario;
        String passUsuario;
        String estatus;

        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string IdPermiso { get => idPermiso; set => idPermiso = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string PassUsuario { get => passUsuario; set => passUsuario = value; }
        public string Estatus { get => estatus; set => estatus = value; }

        String codigoPermiso;
        int ingresarUsuario;
        int modificarUsuario;
        int dbUsuario;
        int consultaUsuario;
        int ingresarCliente;
        int modificarCliente;
        int dbCliente;
        int consultarCliente;
        int ingresarDepto;
        int modificarDepto;
        int dbDepto;
        int consultaDepto;
        int ingresarPuesto;
        int modificarPuesto;
        int dbPuesto;
        int consultaPuesto;
        int ingresarPiloto;
        int modificarPiloto;
        int dbPiloto;
        int consultaPiloto;
        int ingresarEmpleado;
        int modificarEmpleado;
        int dbEmpleado;
        int consultarEmpleado;
        int ingresarPaqueteEnc;
        int modificarPaqueteEnc;
        int dbPaqueteEnc;
        int consultarPaqueteEnc;
        int ingresarPaqueteDet;
        int modificarPaqueteDet;
        int dbPaqueteDet;
        int consultarPaqueteDet;
        int ingresarUbicacion;
        int modificarUbicacion;
        int dbUbicacion;
        int consultarUbicacion;
        int ingresarSububicacion;
        int modificarSububcacion;
        int dbSububicacion;
        int consultarSububicacion;
        int ingresarBodega;
        int modificarBodega;
        int dbBodega;
        int consultarBodega;
        int ingresarInventario;
        int modificarInventario;
        int consultarInventario;
        int consultarMovBodega;
        int ingresarTipoTrans;
        int modificarTipoTrans;
        int dbTipoTrans;
        int consultarTipoTrans;
        int ingresarTransporte;
        int modificarTransporte;
        int dbTransporte;
        int consultarTransporte;
        int ingresarRuta;
        int modificarRuta;
        int dbRuta;
        int consultarRuta;
        int ingresarEnvio;
        int modificarEnvio;
        int dbEnvio;
        int consultarEnvio;
        int ingresarBitacoraTrans;
        int modificarBitacoraTrans;
        int consultarBitacoraTrans;
        int consultaBitacoraUsuario;
        int ingresarCalificacion;
        int modificarCalificacion;
        int consultaCalificacion;
        int reportes;

        

        public Usuarios()
        {

        }

        public Usuarios(string idUsuario, string idPermiso, string nombreUsuario, string passUsuario, string estatus, string codigoPermiso, int ingresarUsuario, int modificarUsuario, int dbUsuario, int consultaUsuario, int ingresarCliente, int modificarCliente, int dbCliente, int consultarCliente, int ingresarDepto, int modificarDepto, int dbDepto, int consultaDepto, int ingresarPuesto, int modificarPuesto, int dbPuesto, int consultaPuesto, int ingresarPiloto, int modificarPiloto, int dbPiloto, int consultaPiloto, int ingresarEmpleado, int modificarEmpleado, int dbEmpleado, int consultarEmpleado, int ingresarPaqueteEnc, int modificarPaqueteEnc, int dbPaqueteEnc, int consultarPaqueteEnc, int ingresarPaqueteDet, int modificarPaqueteDet, int dbPaqueteDet, int consultarPaqueteDet, int ingresarUbicacion, int modificarUbicacion, int dbUbicacion, int consultarUbicacion, int ingresarSububicacion, int modificarSububcacion, int dbSububicacion, int consultarSububicacion, int ingresarBodega, int modificarBodega, int dbBodega, int consultarBodega, int ingresarInventario, int modificarInventario, int consultarInventario, int consultarMovBodega, int ingresarTipoTrans, int modificarTipoTrans, int dbTipoTrans, int consultarTipoTrans, int ingresarTransporte, int modificarTransporte, int dbTransporte, int consultarTransporte, int ingresarRuta, int modificarRuta, int dbRuta, int consultarRuta, int ingresarEnvio, int modificarEnvio, int dbEnvio, int consultarEnvio, int ingresarBitacoraTrans, int modificarBitacoraTrans, int consultarBitacoraTrans, int consultaBitacoraUsuario, int ingresarCalificacion, int modificarCalificacion, int consultaCalificacion, int reportes)
        {
            this.idUsuario = idUsuario;
            this.idPermiso = idPermiso;
            this.nombreUsuario = nombreUsuario;
            this.passUsuario = passUsuario;
            this.estatus = estatus;
            this.codigoPermiso = codigoPermiso;
            this.ingresarUsuario = ingresarUsuario;
            this.modificarUsuario = modificarUsuario;
            this.dbUsuario = dbUsuario;
            this.consultaUsuario = consultaUsuario;
            this.ingresarCliente = ingresarCliente;
            this.modificarCliente = modificarCliente;
            this.dbCliente = dbCliente;
            this.consultarCliente = consultarCliente;
            this.ingresarDepto = ingresarDepto;
            this.modificarDepto = modificarDepto;
            this.dbDepto = dbDepto;
            this.consultaDepto = consultaDepto;
            this.ingresarPuesto = ingresarPuesto;
            this.modificarPuesto = modificarPuesto;
            this.dbPuesto = dbPuesto;
            this.consultaPuesto = consultaPuesto;
            this.ingresarPiloto = ingresarPiloto;
            this.modificarPiloto = modificarPiloto;
            this.dbPiloto = dbPiloto;
            this.consultaPiloto = consultaPiloto;
            this.ingresarEmpleado = ingresarEmpleado;
            this.modificarEmpleado = modificarEmpleado;
            this.dbEmpleado = dbEmpleado;
            this.consultarEmpleado = consultarEmpleado;
            this.ingresarPaqueteEnc = ingresarPaqueteEnc;
            this.modificarPaqueteEnc = modificarPaqueteEnc;
            this.dbPaqueteEnc = dbPaqueteEnc;
            this.consultarPaqueteEnc = consultarPaqueteEnc;
            this.ingresarPaqueteDet = ingresarPaqueteDet;
            this.modificarPaqueteDet = modificarPaqueteDet;
            this.dbPaqueteDet = dbPaqueteDet;
            this.consultarPaqueteDet = consultarPaqueteDet;
            this.ingresarUbicacion = ingresarUbicacion;
            this.modificarUbicacion = modificarUbicacion;
            this.dbUbicacion = dbUbicacion;
            this.consultarUbicacion = consultarUbicacion;
            this.ingresarSububicacion = ingresarSububicacion;
            this.modificarSububcacion = modificarSububcacion;
            this.dbSububicacion = dbSububicacion;
            this.consultarSububicacion = consultarSububicacion;
            this.ingresarBodega = ingresarBodega;
            this.modificarBodega = modificarBodega;
            this.dbBodega = dbBodega;
            this.consultarBodega = consultarBodega;
            this.ingresarInventario = ingresarInventario;
            this.modificarInventario = modificarInventario;
            this.consultarInventario = consultarInventario;
            this.consultarMovBodega = consultarMovBodega;
            this.ingresarTipoTrans = ingresarTipoTrans;
            this.modificarTipoTrans = modificarTipoTrans;
            this.dbTipoTrans = dbTipoTrans;
            this.consultarTipoTrans = consultarTipoTrans;
            this.ingresarTransporte = ingresarTransporte;
            this.modificarTransporte = modificarTransporte;
            this.dbTransporte = dbTransporte;
            this.consultarTransporte = consultarTransporte;
            this.ingresarRuta = ingresarRuta;
            this.modificarRuta = modificarRuta;
            this.dbRuta = dbRuta;
            this.consultarRuta = consultarRuta;
            this.ingresarEnvio = ingresarEnvio;
            this.modificarEnvio = modificarEnvio;
            this.dbEnvio = dbEnvio;
            this.consultarEnvio = consultarEnvio;
            this.ingresarBitacoraTrans = ingresarBitacoraTrans;
            this.modificarBitacoraTrans = modificarBitacoraTrans;
            this.consultarBitacoraTrans = consultarBitacoraTrans;
            this.consultaBitacoraUsuario = consultaBitacoraUsuario;
            this.ingresarCalificacion = ingresarCalificacion;
            this.modificarCalificacion = modificarCalificacion;
            this.consultaCalificacion = consultaCalificacion;
            this.reportes = reportes;
        }

        public void funInsertarPermisos()
        {
             String psql = "INSERT INTO permisos(idPermiso,idTipoPermiso,ingresarUser,modificarUser,dbusuario,consultarUser,ingresarCliente,modificarCliente," +
             "dbCliente,consultarCliente,ingresarDepartamento,modificarDepartamento,dbDepartamento,consultarDepartamento,ingresarPuesto,modificarPuesto,dbPuesto," +
             "consultarPuesto,ingresarPiloto,modificarPiloto,dbPiloto,consultarPiloto,ingresarEmpleado,modificarEmpleado,dbEmpleado,consultarEmpleado,ingresarPaqueteEncabezado," +
             "modificarPaqueteEncabezado,dbPaqueteEncabezado,consultarPaqueteEncabezado,ingresarPaqueteDetalle,modificarPaqueteDetalle,dbPaqueteDetalle,consultarPaqueteDetalle," +
             "insertarUbicacion,modificarUbicacion,dbubicacion,consultarUbicacion,insertarSububicacion,modificarSububicacion,dbSububicacion,consultarSububicacion," +
             "insertarBodega,modifcarBodega,dbBodega,consultarBodega,insertarInventario,modificarInventario,consultarInventario,consultarMovBodega,insertarTipoTransp," +
             "modificarTipoTransp,dbTipoTransp,consultarTipoTransp,insertarTransporte,modificarTransporte,dbTransporte,consultarTransporte,ingresarRuta,modificarRuta," +
             "dbRuta,consultarRuta,ingresarEnvio,modificarEnvio,dbEnvio,consultarEnvio,ingresarBT,modificarBT,consultaBT,consultaBU,ingresarCalificacion,modificarCalificacion," +
             "consultaCalificacion,reportes)" +
             " VALUES('" + codigoPermiso + "' , '" + idPermiso + "' , '" + ingresarUsuario + "' , '"+modificarUsuario+"' , '"+dbUsuario+"', '"+consultaUsuario+"'," +
             "'"+ingresarCliente+"', '"+modificarCliente+"' , '"+dbCliente+"', '"+consultarCliente+"' ," +
             "'"+ingresarDepto+"', '"+modificarDepto+"', '"+dbDepto+"', '"+consultaDepto+"'," +
             "'"+ingresarPuesto+"', '"+modificarPuesto+"', '"+dbPuesto+"', '"+consultaPuesto+"' ," +
             "'"+ingresarPiloto+"', '"+modificarPiloto+"' , '"+dbPiloto+"', '"+consultaPiloto+"' ," +
             "'"+ingresarEmpleado+"', '"+modificarEmpleado+"', '"+dbEmpleado+"', '"+consultarEmpleado+"' ," +
             "'"+ingresarPaqueteEnc+"', '"+modificarPaqueteEnc+"', '"+dbPaqueteEnc+"' , '"+consultarPaqueteEnc+"' ," +
             "'"+ingresarPaqueteDet+"', '"+modificarPaqueteDet+"' , '"+dbPaqueteDet+"' , '"+consultarPaqueteDet+"'," +
             "'"+ingresarUbicacion+"', '"+modificarUbicacion+"', '"+dbUbicacion+"', '"+consultarUbicacion+"' ," +
             "'"+ingresarSububicacion+"', '"+modificarSububcacion+"' , '"+dbSububicacion+"', '"+consultarSububicacion+"' ," +
             "'"+ingresarBodega+"', '"+modificarBodega+"', '"+dbBodega+"' , '"+consultarBodega+"'," +
             "'"+ingresarInventario+"' , '"+modificarInventario+"' , '"+consultarInventario+"'," +
             "'"+consultarMovBodega+"'," +
             "'"+ingresarTipoTrans+"' , '"+modificarTipoTrans+"' , '"+dbTipoTrans+"' , '"+consultarTipoTrans+"'," +
             "'"+ingresarTransporte+"' , '"+modificarTransporte+"' , '"+dbTransporte+"' , '"+consultarTransporte+"'," +
             "'"+ingresarRuta+"' , '"+modificarRuta+"' , '"+dbTransporte+"', '"+consultarTransporte+"', " +
             "'"+ingresarEnvio+"', '"+modificarEnvio+"' , '"+dbEnvio+"' , '"+consultarEnvio+"' ," +
             "'"+ingresarBitacoraTrans+"' , '"+modificarBitacoraTrans+"' , '"+consultarBitacoraTrans+"' , " +
             "'"+consultaBitacoraUsuario+"' , " +
             "'"+ingresarCalificacion+"' , '"+modificarCalificacion+"', '"+consultaCalificacion+"' , " +
             "'"+reportes+"')";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarPermisos = new MySqlCommand(psql, conexionBD);
                insertarPermisos.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funInsertarUsuario()
        {
            String psql = "INSERT INTO usuario(idUser,idPermiso,nombreUsuario,passwordUsuario,estatusUsuario)" +
             " VALUES('" + idUsuario + "' , '" + idPermiso + "' , '" + nombreUsuario + "' , '"+passUsuario+"' , '"+estatus+"')";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarUsuarios = new MySqlCommand(psql, conexionBD);
                insertarUsuarios.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM usuario";
            }
            else
            {
                sql = "SELECT * FROM usuario WHERE idUser LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarUsuario = new MySqlCommand(sql, conexionBD);
                reader = buscarUsuario.ExecuteReader();


                while (reader.Read())
                {

                    Usuarios usuario = new Usuarios();

                    usuario.idUsuario = reader.GetString("idUser");
                    usuario.idPermiso = reader.GetString("idPermiso");
                    usuario.nombreUsuario = reader.GetString("nombreUsuario");
                    usuario.passUsuario = reader.GetString("passwordUsuario");
                    usuario.estatus = reader.GetString("estatusUsuario");

                    lista.Add(estatus);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }

        public void funModificarPermisos(String idModificar)
        {
            String pSqlModificar = "UPDATE permisos SET idTipoPermiso='"+idPermiso+"', ingresarUser='" + ingresarUsuario + "', modificarUser='"+modificarUsuario+"'" +
            ", dbusuario='"+dbUsuario+ "', consultarUser='"+consultaUsuario+ "' , ingresarCliente='"+ingresarCliente+"' " +
            ", modificarCliente='"+modificarCliente+ "', dbCliente='"+dbCliente+ "', consultarCliente='"+consultarCliente+"' " +
            ", ingresarDepartamento='"+ingresarDepto+ "', modificarDepartamento='"+modificarDepto+"' " +
            ", dbDepartamento='"+dbDepto+ "' , consultarDepartamento='"+consultaDepto+"' " +
            ", ingresarPuesto='"+ingresarPuesto+ "' , modificarPuesto='"+modificarPuesto+ "' , dbPuesto='"+dbPuesto+ "' , consultarPuesto='"+consultaPuesto+"' " +
            ", ingresarPiloto='"+ingresarPiloto+ "', modificarPiloto='"+modificarPiloto+ "', dbPiloto='"+dbPiloto+ "' , consultarPiloto='"+consultaPiloto+"' " +
            ", ingresarEmpleado='"+ingresarEmpleado+ "' , modificarEmpleado='"+modificarEmpleado+ "' , dbEmpleado='"+dbEmpleado+ "' , consultarEmpleado='"+consultarEmpleado+"' " +
            ", ingresarPaqueteEncabezado='"+ingresarPaqueteEnc+ "' , modificarPaqueteEncabezado='"+modificarPaqueteEnc+ "' , dbPaqueteEncabezado='"+dbPaqueteEnc+"' " +
            ", consultarPaqueteEncabezado='"+consultarPaqueteEnc+ "' , ingresarPaqueteDetalle='"+ingresarPaqueteDet+ "' , modificarPaqueteDetalle='"+modificarPaqueteDet+"' " +
            ", dbPaqueteDetalle='"+dbPaqueteDet+ "' , consultarPaqueteDetalle='"+consultarPaqueteDet+ "' , insertarUbicacion='"+ingresarUbicacion+"' " +
            ", modificarUbicacion='"+modificarUbicacion+ "' , dbubicacion='"+dbUbicacion+ "' , consultarUbicacion='"+consultarUbicacion+"' " +
            ", insertarSububicacion='"+ingresarSububicacion+ "' , modificarSububicacion='"+modificarSububcacion+ "' , dbSububicacion='"+dbSububicacion+"' " +
            ", consultarSububicacion='"+consultarSububicacion+ "' , insertarBodega='"+ingresarBodega+ "' , modifcarBodega='"+modificarBodega+"' " +
            ", dbBodega='"+dbBodega+ "', consultarBodega='"+consultarBodega+ "', insertarInventario='"+ingresarInventario+ "' , modificarInventario='"+modificarInventario+"'" +
            ", consultarInventario='"+consultarInventario+ "' , consultarMovBodega='"+consultarMovBodega+ "' , insertarTipoTransp='"+ingresarTipoTrans+"' " +
            ", modificarTipoTransp='"+modificarTipoTrans+ "' , dbTipoTransp='"+dbTipoTrans+ "' , consultarTipoTransp='"+consultarTipoTrans+"'  " +
            ", insertarTransporte='" + ingresarTransporte+ "' ,  modificarTransporte='"+modificarTransporte+ "' , dbTransporte='"+dbTransporte+"' " +
            ", consultarTransporte='"+consultarTransporte+ "' , ingresarRuta='"+ingresarRuta+ "' , modificarRuta='"+modificarRuta+ "' , dbRuta='"+dbRuta+"'  " +
            ", consultarRuta='"+consultarRuta+ "' , ingresarEnvio='"+ingresarEnvio+ "' , modificarEnvio='"+modificarEnvio+ "' , dbEnvio='"+dbEnvio+"' " +
            ", consultarEnvio='"+consultarEnvio+ "' , ingresarBT='"+ingresarBitacoraTrans+ "' , modificarBT='"+modificarBitacoraTrans+"' " +
            ", consultaBT='"+consultarBitacoraTrans+ "' , consultaBU='"+consultaBitacoraUsuario+ "' , ingresarCalificacion='"+ingresarCalificacion+"' " +
            ", modificarCalificacion='"+modificarCalificacion+ "' , consultaCalificacion='"+consultaCalificacion+ "' reportes='"+reportes+ "'  WHERE idPermiso='" + idModificar + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarPermisos = new MySqlCommand(pSqlModificar, conexionBD);
                modificarPermisos.ExecuteNonQuery();
                MessageBox.Show("Datos Modificados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al modificar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public void funLlenarCombo(ComboBox tipoPermiso)
        {
            tipoPermiso.DataSource = null;
            tipoPermiso.Items.Clear();

            String psql = "SELECT idTipoPermiso,nombreTipoPermiso FROM tipoPermiso";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);

                DataTable dt = new DataTable();
                data.Fill(dt);

                tipoPermiso.ValueMember = "idTipoPermiso";
                tipoPermiso.DisplayMember = "nombreTipoPermiso";
                tipoPermiso.DataSource = dt;
            }
            catch(MySqlException ex)
            {
                MessageBox.Show("Error al leer los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }
    }
}
