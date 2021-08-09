using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_reparto.Clases
{
    public class TipoTransporte
    {
        // Atributos
        String IdTipoTransporte;
        String NombreTipoTransporte;
        String EstatusTipoTransporte;

        public string IdTipoTransporte1 { get => IdTipoTransporte; set => IdTipoTransporte = value; }
        public string NombreTipoTransporte1 { get => NombreTipoTransporte; set => NombreTipoTransporte = value; }
        public string EstatusTipoTransporte1 { get => EstatusTipoTransporte; set => EstatusTipoTransporte = value; }

        public TipoTransporte(String id, String nombre, String estatus)
        {
            this.IdTipoTransporte = id;
            this.NombreTipoTransporte = nombre;
            this.EstatusTipoTransporte = estatus;
        }

        public TipoTransporte()
        {

        }

        /*Funcion para insertar*/
        public void funInsertar()
        {
            if (IdTipoTransporte == "" && NombreTipoTransporte == "") {

                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            } else { String psql = "INSERT INTO tipoTransporte(idTipoTransporte,nombreTipoTransporte,estatusTipoTransporte)" +
               " VALUES('" + IdTipoTransporte + "' , '" + NombreTipoTransporte + "' , '" + EstatusTipoTransporte + "')";

                //Console.WriteLine(psql);
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand insertarTipoTransporte = new MySqlCommand(psql, conexionBD);
                    insertarTipoTransporte.ExecuteNonQuery();
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
        }


        public List<Object> consulta(String dato)
        {
            MySqlDataReader reader = null;
            List<Object> lista = new List<Object>();
            String sql;

            if (dato == null)
            {
                sql = "SELECT * FROM tipoTransporte";
            }
            else
            {
                sql = "SELECT * FROM tipoTransporte WHERE idTipoTransporte LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarTipoReparto = new MySqlCommand(sql, conexionBD);
                reader = buscarTipoReparto.ExecuteReader();


                while (reader.Read())
                {

                    TipoTransporte tiporeparto = new TipoTransporte();

                    tiporeparto.IdTipoTransporte = reader.GetString("idTipoTransporte");
                    tiporeparto.NombreTipoTransporte = reader.GetString("nombreTipoTransporte");
                    tiporeparto.EstatusTipoTransporte = reader.GetString("estatusTipoTransporte");

                    lista.Add(tiporeparto);
                }
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;

        }



        /*Funcion para modificar */
        public void funModificar(String idModificar)
        {
            String pSqlModificar = "UPDATE tipoTransporte SET nombreTipoTransporte='" + NombreTipoTransporte + "' WHERE idTipoTransporte='" + idModificar + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarTipoTransporte = new MySqlCommand(pSqlModificar, conexionBD);
                modificarTipoTransporte.ExecuteNonQuery();
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

        public void funBuscarSetearTxt(TextBox id, TextBox nombre, TextBox estatus, String idDepartamento)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from tipoTransporte WHERE idTipoTransporte='" + idDepartamento + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarTipoTransporte = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarTipoTransporte.ExecuteReader();

                while (leer.Read())
                {
                    id.Text = leer.GetString(0);
                    nombre.Text = leer.GetString(1);
                    estatus.Text = leer.GetString(2);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar los datos " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }
        }


        public String funBuscarEstatus(String idEstatus)
        {

            String estatusTipoTransporte = "";
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT estatusTipoTransporte from tipoTransporte WHERE idTipoTransporte='" + idEstatus + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarTipoTransporte = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarTipoTransporte.ExecuteReader();

                while (leer.Read())
                {
                    estatusTipoTransporte = leer.GetString("estatusTipoTransporte");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar el estatus " + ex.Message);
            }
            finally
            {
                conexionBD.Close();
            }

            return estatusTipoTransporte;
        }

        public void funActivarTipoTransporte()
        {
            String pSqlModificar = "UPDATE tipoTransporte SET estatusTipoTransporte='A' WHERE idTipoTransporte='" + IdTipoTransporte + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarTipoTransporte = new MySqlCommand(pSqlModificar, conexionBD);
                modificarTipoTransporte.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
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

        /*Funcion que permite dar de baja un Tipo Transporte*/
        public void funDarBajaTipoTransporte()
        {
            String pSqlModificar = "UPDATE tipoTransporte SET estatusTipoTransporte='I' WHERE idTipoTransporte='" + IdTipoTransporte + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarTipoTransporte = new MySqlCommand(pSqlModificar, conexionBD);
                modificarTipoTransporte.ExecuteNonQuery();
                MessageBox.Show("Estatus modificado Correctamente");
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
    }
}
