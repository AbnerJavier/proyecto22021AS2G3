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
    public class PaqueteEncabezado
    {
        //Atributos
        String idPaqueteEncabezado;
        String idCliente;
        String fechaRecepcion;
        String fechaClienteEntrega;
        String nombreRemitente;
        String direccionRemitente;
        String telefonoRemitente;
        String idEmpleado;
        String estatusPaqEncabezado;

        public PaqueteEncabezado()
        {

        }

        public PaqueteEncabezado(string idPaqueteEncabezado, string idCliente, string fechaRecepcion, string fechaClienteEntrega, string nombreRemitente, string direccionRemitente, string telefonoRemitente, string idEmpleado, string estatusPaqEncabezado)
        {
            this.idPaqueteEncabezado = idPaqueteEncabezado;
            this.idCliente = idCliente;
            this.FechaRecepcion = fechaRecepcion;
            this.FechaClienteEntrega = fechaClienteEntrega;
            this.nombreRemitente = nombreRemitente;
            this.direccionRemitente = direccionRemitente;
            this.telefonoRemitente = telefonoRemitente;
            this.idEmpleado = idEmpleado;
            this.estatusPaqEncabezado = estatusPaqEncabezado;
        }

        public string IdPaqueteEncabezado { get => idPaqueteEncabezado; set => idPaqueteEncabezado = value; }
        public string IdCliente { get => idCliente; set => idCliente = value; }
        public string FechaRecepcion { get => fechaRecepcion; set => fechaRecepcion = value; }
        public string FechaClienteEntrega { get => fechaClienteEntrega; set => fechaClienteEntrega = value; }
        public string NombreRemitente { get => nombreRemitente; set => nombreRemitente = value; }
        public string DireccionRemitente { get => direccionRemitente; set => direccionRemitente = value; }
        public string TelefonoRemitente { get => telefonoRemitente; set => telefonoRemitente = value; }
        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string EstatusPaqEncabezado { get => estatusPaqEncabezado; set => estatusPaqEncabezado = value; }


        //Metodos

        public void funInsertar()
        {
            String psql = "INSERT INTO paqueteEncabezado(idPaqueteEncabezado,idCliente,fechaRecepcion,fechaClienteEntrega,NombreRemitente," +
                "direccionRemitente,telefonoRemitente, idEmpleado,estatusPaqEncabezado)" +
                " VALUES ('" + idPaqueteEncabezado + "' , '" + idCliente + "' , '" + FechaRecepcion + "' , '"
                + FechaClienteEntrega + "' , '" + nombreRemitente + "', '" + direccionRemitente + "', '" + telefonoRemitente
                + "', '" + idEmpleado + "', '" + estatusPaqEncabezado + "')";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand insertarPE = new MySqlCommand(psql, conexionBD);
                insertarPE.ExecuteNonQuery();
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

        
        
        public void cargarCombobox(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();

            String sql = "SELECT * FROM " + tabla;
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand cargarCombobox = new MySqlCommand(sql, conexionBD);
                /*Guarda la consulta en este objeto*/
                MySqlDataAdapter data = new MySqlDataAdapter(cargarCombobox);
                DataTable dt = new DataTable();
                /*Los datos de una consulta los agregamos a un combobox*/
                data.Fill(dt);

                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                /*Se llena el combobox*/
                combobox.DataSource = dt;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al cargar datos del combobox " + ex.Message);
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
                sql = "SELECT * FROM paqueteEncabezado";
            }
            else
            {
                sql = "SELECT * FROM paqueteEncabezado WHERE idPaqueteEncabezado LIKE '%" + dato + "%'";
            }

            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarPaqueteE = new MySqlCommand(sql, conexionBD);
                reader = buscarPaqueteE.ExecuteReader();


                while (reader.Read())
                {

                    PaqueteEncabezado paqueteE = new PaqueteEncabezado();

                    paqueteE.idPaqueteEncabezado = reader.GetString("idPaqueteEncabezado");
                    paqueteE.IdCliente = reader.GetString("idCliente");

                    paqueteE.fechaRecepcion = reader.GetString("fechaRecepcion");
                    paqueteE.FechaClienteEntrega = reader.GetString("fechaClienteEntrega");
                    paqueteE.nombreRemitente = reader.GetString("NombreRemitente");
                    paqueteE.direccionRemitente = reader.GetString("direccionRemitente");
                    paqueteE.telefonoRemitente = reader.GetString("telefonoRemitente");
                    paqueteE.idEmpleado = reader.GetString("idEmpleado");
                    paqueteE.estatusPaqEncabezado = reader.GetString("estatusPaqEncabezado");

                    lista.Add(paqueteE);
                }
            }
            catch(MySqlException ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }

            return lista;
            
        }


        public void obtenerNombre(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombreCliente from cliente WHERE idCliente='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombreCliente");
                }
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

        public void obtenerNombreEmpleado(String codigo)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombreEmpleado from empleado WHERE idEmpleado='" + codigo + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscar = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscar.ExecuteReader();

                while (leer.Read())
                {
                    codigo = leer.GetString("nombreEmpleado");
                }
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

        public void funModificar(String idModificar)
        {
            String pSqlModificar = "UPDATE paqueteEncabezado SET idCliente='" + idCliente + "'," +
            " fechaRecepcion='" + fechaRecepcion + "', fechaClienteEntrega='" + fechaClienteEntrega + "',"+
            " NombreRemitente='" + nombreRemitente + "', direccionRemitente='" + direccionRemitente + "',"+
            " telefonoRemitente = '" + telefonoRemitente + "', idEmpleado = '" + idEmpleado + "',"+
            " estatusPaqEncabezado='"+estatusPaqEncabezado+"'"+
            " WHERE idPaqueteEncabezado='" + IdPaqueteEncabezado + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarCliente = new MySqlCommand(pSqlModificar, conexionBD);
                modificarCliente.ExecuteNonQuery();
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

        public void funBuscarSetearTxt(TextBox idPE, ComboBox idCliente, DateTimePicker fechaRecepcion, DateTimePicker fechaClienteEntrega, TextBox nombreRemitente, TextBox direccionRemitente, TextBox telefonoRemitente,ComboBox idEmpleado, TextBox estatus, String idPaqueteEncabezado)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from paqueteEncabezado WHERE idPaqueteEncabezado='" + idPaqueteEncabezado + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand busqueda = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = busqueda.ExecuteReader();

                while (leer.Read())
                {
                    idPE.Text = leer.GetString(0);
                    idCliente.Text = leer.GetString(1);
                    fechaRecepcion.Text = leer.GetString(2);
                    fechaClienteEntrega.Text = leer.GetString(3);
                    nombreRemitente.Text = leer.GetString(4);
                    direccionRemitente.Text = leer.GetString(5);
                    telefonoRemitente.Text = leer.GetString(6);
                    idEmpleado.Text = leer.GetString(7);
                    estatus.Text = leer.GetString(8);
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

            String estatusPE = "";
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT estatusPaqEncabezado from paqueteEncabezado WHERE idPaqueteEncabezado='" + idEstatus + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarEstatus = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarEstatus.ExecuteReader();

                while (leer.Read())
                {
                    estatusPE = leer.GetString("estatusPaqEncabezado");
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

            return estatusPE;
        }


        public void funDarBajaCliente()
        {
            String pSqlModificar = "UPDATE paqueteEncabezado SET estatusPaqEncabezado='I' WHERE idPaqueteEncabezado='" + idPaqueteEncabezado + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarEstatus = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEstatus.ExecuteNonQuery();
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

        public void funActivarCliente()
        {
            String pSqlModificar = "UPDATE paqueteEncabezado SET estatusPaqEncabezado='A' WHERE idPaqueteEncabezado='" + idPaqueteEncabezado + "'";

            //Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarEstatus = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEstatus.ExecuteNonQuery();
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
