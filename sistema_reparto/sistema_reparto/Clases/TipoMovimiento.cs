using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistema_reparto.Clases
{
    public class TipoMovimiento
    {
        //Atributos
        String idTipoMovimiento;
        String nombreTipoMovimiento;
        String estatusTipoMovimiento;

        //Constructor
        public TipoMovimiento()
        {

        }

        public TipoMovimiento(String idTM, String nombreTM, String estatusTM)
        {
            this.IdTipoMovimiento = idTM;
            this.NombreTipoMovimiento = nombreTM;
            this.EstatusTipoMovimiento = estatusTM;
        }

        //Setter and Getters
        public string IdTipoMovimiento { get => idTipoMovimiento; set => idTipoMovimiento = value; }
        public string NombreTipoMovimiento { get => nombreTipoMovimiento; set => nombreTipoMovimiento = value; }
        public string EstatusTipoMovimiento { get => estatusTipoMovimiento; set => estatusTipoMovimiento = value; }

        //Métodos
        public void funcInsertar()
        {
            String psql = "INSERT INTO tipoMovimiento (idTipoMov, nombreTipoMov, estatusTipoMov) " +
                " VALUES ('" + idTipoMovimiento + "', '" + nombreTipoMovimiento + "', '" + estatusTipoMovimiento + "')";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarTipoMovimiento = new MySqlCommand(psql, conexionBD);
                insertarTipoMovimiento.ExecuteNonQuery();
                MessageBox.Show("Datos Ingresados Correctamente");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos "+ex.Message);
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

            if(dato == null)
            {
                sql = "SELECT * FROM tipoMovimiento";
            }
            else{
                sql = "SELECT * FROM tipoMovimiento WHERE idTipoMov LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarTipoMovimiento = new MySqlCommand(sql, conexionBD);
                reader = buscarTipoMovimiento.ExecuteReader();

                while (reader.Read())
                {
                    TipoMovimiento tipoM = new TipoMovimiento();

                    tipoM.idTipoMovimiento = reader.GetString("idTipoMov");
                    tipoM.nombreTipoMovimiento = reader.GetString("nombreTipoMov");
                    tipoM.estatusTipoMovimiento = reader.GetString("estatusTipoMov");

                    lista.Add(tipoM);
                }
            }catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;
        }


        public void funModificar(String idModificar)
        {
            String sqlModificar = "UPDATE tipoMovimiento SET nombreTipoMov='" + nombreTipoMovimiento + "', estatusTipoMov='" +
                estatusTipoMovimiento + "' WHERE idTipoMov='" + idModificar+"'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarTE = new MySqlCommand(sqlModificar, conexionBD);
                modificarTE.ExecuteNonQuery();
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

        public String funBuscarEstatus(String idEstatus)
        {
            String estatusTipoMovimiento = "";
            MySqlDataReader reader = null;

            String pSqlBuscar = "SELECT estatusTipoMov FROM tipoMovimiento WHERE idTipoMov='" + idEstatus + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarTM = new MySqlCommand(pSqlBuscar, conexionBD);
                reader = buscarTM.ExecuteReader();

                while (reader.Read())
                {
                    estatusTipoMovimiento = reader.GetString("estatusTipoMov");
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

            return estatusTipoMovimiento;
        }


        public void funBuscarSetearTxt(TextBox id, TextBox nombre, TextBox estatus, String idTM)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from tipoMovimiento WHERE idTipoMov='" + idTM + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarTM = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarTM.ExecuteReader();

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

        public void funActivarTipoMov()
        {
            String pSqlModificar = "UPDATE tipoMovimiento SET estatusTipoMov='A' WHERE idTipoMov= '" + IdTipoMovimiento + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand activarTipoMov = new MySqlCommand(pSqlModificar, conexionBD);
                activarTipoMov.ExecuteNonQuery();
                MessageBox.Show("Estatus Modificado Correctamente");
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

        public void funBajaTipoMov()
        {
            String pSqlModificar = "UPDATE tipoMovimiento SET estatusTipoMov='I' WHERE idTipoMov= '" + IdTipoMovimiento + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand bajaTipoMov = new MySqlCommand(pSqlModificar, conexionBD);
                bajaTipoMov.ExecuteNonQuery();
                MessageBox.Show("Estatus Modificado Correctamente");
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
