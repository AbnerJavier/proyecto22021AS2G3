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
    public class Empleado
    {

        String idEmpleado;
        String dpiEmpleado;
        String idUsuario;
        String nombreEmpleado;
        String apellidoEmpleado;
        String telefonoEmpleado;
        String direccionEmpleado;
        String sueldoEmpleado;
        String idDepartamentoEmpleado;
        String idPuestoEmpleado;
        String estatusEmpleado;

        public string IdEmpleado { get => idEmpleado; set => idEmpleado = value; }
        public string DpiEmpleado { get => dpiEmpleado; set => dpiEmpleado = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public string NombreEmpleado { get => nombreEmpleado; set => nombreEmpleado = value; }
        public string ApellidoEmpleado { get => apellidoEmpleado; set => apellidoEmpleado = value; }
        public string TelefonoEmpleado { get => telefonoEmpleado; set => telefonoEmpleado = value; }
        public string DireccionEmpleado { get => direccionEmpleado; set => direccionEmpleado = value; }
        public string SueldoEmpleado { get => sueldoEmpleado; set => sueldoEmpleado = value; }
        public string IdDepartamentoEmpleado { get => idDepartamentoEmpleado; set => idDepartamentoEmpleado = value; }
        public string IdPuestoEmpleado { get => idPuestoEmpleado; set => idPuestoEmpleado = value; }
        public string EstatusEmpleado { get => estatusEmpleado; set => estatusEmpleado = value; }

        public Empleado()
        {
        }

        public Empleado(string idEmpleado, string dpiEmpleado, string idUsuario, string nombreEmpleado, string apellidoEmpleado, string telefonoEmpleado, string direccionEmpleado, string sueldoEmpleado, string idDepartamentoEmpleado, string idPuestoEmpleado, string estatusEmpleado)
        {
            this.idEmpleado = idEmpleado;
            this.dpiEmpleado = dpiEmpleado;
            this.idUsuario = idUsuario;
            this.nombreEmpleado = nombreEmpleado;
            this.apellidoEmpleado = apellidoEmpleado;
            this.telefonoEmpleado = telefonoEmpleado;
            this.direccionEmpleado = direccionEmpleado;
            this.sueldoEmpleado = sueldoEmpleado;
            this.idDepartamentoEmpleado = idDepartamentoEmpleado;
            this.idPuestoEmpleado = idPuestoEmpleado;
            this.estatusEmpleado = estatusEmpleado;
        }

        public void funInsertar()
        {
            if (IdEmpleado == "" && DpiEmpleado == "" && IdUsuario == "" && NombreEmpleado == "" && ApellidoEmpleado == "" && TelefonoEmpleado == "" && DireccionEmpleado == "" && SueldoEmpleado == "")
            {
                MessageBox.Show("No se pueden dejar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String psql = "INSERT INTO empleado(idEmpleado,dpiEmpleado,idUser,nombreEmpleado, apellidoEmpleado, telefonoEmpleado, direccionEmpledo, sueldoEmpleado, idDepartamentoEmpleado, idPuestoEmpleado, estatusEmpleado)" +
             " VALUES('" + IdEmpleado + "' , '" + DpiEmpleado + "' , '" + IdUsuario + "', '" + NombreEmpleado + "', '" + ApellidoEmpleado + "', '" + TelefonoEmpleado + "', '" + DireccionEmpleado + "', '" + SueldoEmpleado + "', '" + IdDepartamentoEmpleado + "', '" + IdPuestoEmpleado + "', '" + EstatusEmpleado + "')";

                //Console.WriteLine(psql);
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                try
                {
                    MySqlCommand insertarRuta = new MySqlCommand(psql, conexionBD);
                    insertarRuta.ExecuteNonQuery();
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
                sql = "SELECT * FROM empleado";
            }
            else
            {
                sql = "SELECT * FROM empleado WHERE idEmpleado LIKE '%" + dato + "%'";
            }
            try
            {
                MySqlConnection conexionBD = Conexion.conexion();
                conexionBD.Open();

                MySqlCommand buscarEmpleado = new MySqlCommand(sql, conexionBD);
                reader = buscarEmpleado.ExecuteReader();


                while (reader.Read())
                {
                    Empleado empleado = new Empleado();

                    empleado.IdEmpleado = reader.GetString("idEmpleado");
                    empleado.DpiEmpleado = reader.GetString("dpiEmpleado");
                    empleado.IdUsuario = reader.GetString("idUser");
                    empleado.NombreEmpleado = reader.GetString("nombreEmpleado");
                    empleado.ApellidoEmpleado = reader.GetString("apellidoEmpleado");
                    empleado.TelefonoEmpleado = reader.GetString("telefonoEmpleado");
                    empleado.DireccionEmpleado = reader.GetString("direccionEmpledo");
                    empleado.SueldoEmpleado = reader.GetString("sueldoEmpleado");
                    empleado.IdDepartamentoEmpleado = reader.GetString("idDepartamentoEmpleado");
                    empleado.IdPuestoEmpleado = reader.GetString("idPuestoEmpleado");
                    empleado.EstatusEmpleado = reader.GetString("estatusEmpleado");

                    lista.Add(empleado);
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
            Console.WriteLine(IdDepartamentoEmpleado);
            String pSqlModificar = "UPDATE empleado SET dpiEmpleado='" + DpiEmpleado + "', idUser='" + idUsuario + "', nombreEmpleado='" + nombreEmpleado + "', apellidoEmpleado='" + apellidoEmpleado + "', telefonoEmpleado='" + telefonoEmpleado + "', direccionEmpledo='" + direccionEmpleado + "', sueldoEmpleado='" + sueldoEmpleado + "', idDepartamentoEmpleado='" + IdDepartamentoEmpleado + "', idPuestoEmpleado='" + idPuestoEmpleado + "', estatusEmpleado= '" + estatusEmpleado + "' WHERE idEmpleado='" + idModificar + "'";
            //Console.WriteLine(pSqlModificar);
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
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


        public void funBuscarSetearTxt(TextBox id, TextBox dpi, TextBox iduser, TextBox nombre, TextBox apellido, TextBox telefono, TextBox direccion, TextBox sueldo, ComboBox iddep, ComboBox idpuesto, TextBox estatus, String idEmpleado)
        {
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT * from empleado WHERE idEmpleado='" + idEmpleado + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarEmpleado = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarEmpleado.ExecuteReader();

                while (leer.Read())
                {
                    id.Text = leer.GetString(0);
                    dpi.Text = leer.GetString(1);
                    iduser.Text = leer.GetString(2);
                    nombre.Text = leer.GetString(3);
                    apellido.Text = leer.GetString(4);
                    telefono.Text = leer.GetString(5);
                    direccion.Text = leer.GetString(6);
                    sueldo.Text = leer.GetString(7);
                    iddep.Text = leer.GetString(8);
                    idpuesto.Text = leer.GetString(9);
                    estatus.Text = leer.GetString(10);
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

            String estatusEmpleado = "";
            MySqlDataReader leer = null;

            String pSqlBuscar = "SELECT estatusEmpleado from empleado WHERE idEmpleado='" + idEstatus + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand buscarEmpleado = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarEmpleado.ExecuteReader();

                while (leer.Read())
                {
                    estatusEmpleado = leer.GetString("estatusEmpleado");
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

            return estatusEmpleado;
        }

        public void funActivarEmpleado()
        {
            String pSqlModificar = "UPDATE empleado SET estatusEmpleado='A' WHERE idEmpleado='" + IdEmpleado + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
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


        public void funDarBajaRuta()
        {
            String pSqlModificar = "UPDATE empleado SET estatusEmpleado='I' WHERE idEmpleado='" + IdEmpleado + "'";

            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();

            try
            {
                MySqlCommand modificarEmpleado = new MySqlCommand(pSqlModificar, conexionBD);
                modificarEmpleado.ExecuteNonQuery();
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
        public void funLlenarComboTE(ComboBox combobox, String tabla, String id, String nombre)
        {
            combobox.DataSource = null;
            combobox.Items.Clear();
            String psql = "Select * FROM " + tabla;
            Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);
                DataTable dt = new DataTable();
                data.Fill(dt);
                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                combobox.DataSource = dt;
                
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }

        //public void obtenerNombreCbxDep(ComboBox combobox)
        //{
        //    MySqlDataReader leer = null;
        //    String ejemplo = combobox.Text;

        //    String pSqlBuscar = "SELECT nombreDepartamentos from departamento WHERE idDepartamento='" + ejemplo + "'";
        //    MySqlConnection conexionBD = Conexion.conexion();
        //    conexionBD.Open();

        //    try
        //    {
        //        MySqlCommand buscarRuta = new MySqlCommand(pSqlBuscar, conexionBD);
        //        leer = buscarRuta.ExecuteReader();

        //        while (leer.Read())
        //        {
        //            combobox.Text = leer.GetString("nombreDepartamentos");
        //        }

        //    }
        //    catch (MySqlException ex)
        //    {
        //        MessageBox.Show("Error al guardar los datos " + ex.Message);
        //    }
        //}

        public void obtenerNombreDep(String idDepartamento)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombreDepartamentos from departamento WHERE idDepartamento='" + idDepartamento + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscarDepartamento = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarDepartamento.ExecuteReader();
                while (leer.Read())
                {
                    idDepartamento = leer.GetString("nombreDepartamentos");
                }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error al guardar los datos " + ex.Message);
                }
        }

        public void obtenerNombrePuesto(String idPuesto)
        {
            MySqlDataReader leer = null;
            String pSqlBuscar = "SELECT nombrePuesto from puesto WHERE idPuesto='" + idPuesto + "'";
            MySqlConnection conexionBD = Conexion.conexion();
            conexionBD.Open();
            try
            {
                MySqlCommand buscarDepartamento = new MySqlCommand(pSqlBuscar, conexionBD);
                leer = buscarDepartamento.ExecuteReader();
                while (leer.Read())
                {
                    idPuesto = leer.GetString("nombrePuesto");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }










        /*public void funLlenarCombo(ComboBox combobox)
        {
            String id = combobox.SelectedValue.ToString();
            combobox.DataSource = null;
            combobox.Items.Clear();
            String psql = "Select * FROM departamento";
            Console.WriteLine(psql);
            MySqlConnection conexionBD = Conexion.conexion();
            try
            {
                MySqlCommand llenarCombo = new MySqlCommand(psql, conexionBD);
                MySqlDataAdapter data = new MySqlDataAdapter(llenarCombo);
                DataTable dt = new DataTable();
                data.Fill(dt);
                combobox.ValueMember = id;
                combobox.DisplayMember = nombre;
                combobox.DataSource = dt;

            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error al guardar los datos " + ex.Message);
            }
        }*/

    }

}
