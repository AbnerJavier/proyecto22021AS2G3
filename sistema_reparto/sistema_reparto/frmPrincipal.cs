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


namespace sistema_reparto
{
    public partial class frmPrincipal : Form
    {
        /* Codigo para redondear mi panel */
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );

        /* Varibles para cambiar color de mi Boton */
        Color colorHoverCliente = Color.FromArgb(80, 115, 119);
        Color colorNormalCliente = Color.FromArgb(59, 102, 107);

        //public static Cliente cliente = new Cliente(pCodigoC, pNombreC, pApellidoC, pTelefonoC, pCorreoC, pDireccion);

        public frmPrincipal()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            pnlBordeCliente.Visible = false;

            lblAbcCliente.Visible = true;
            pnlMantenimientoC.Visible= true;

            /* Inicio Haciendo no visibles a mis botones de registro,modificar y dar de baja*/
            lblRegistrarCliente.Visible = false;
            lblModificarCliente.Visible = false;
            lblDarBaja.Visible = false;

            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            /* Final Haciendo no visibles a mis botones de registro,modificar y dar de baja*/

            /* Inicio para esconder los contenidos de mi panel de mantenimiento Clientes */
            lblAbcCliente.Visible = true;
            pnlCampoIDC.Visible = false;
            pnlCampoNombreC.Visible = false;
            pnlCampoApellidoC.Visible = false;
            pnlCampoTelefonoC.Visible = false;
            pnlCampoCorreoC.Visible = false;
            pnlCampoDireccion.Visible = false;
            pnlBotonBuscarC.Visible = false;
            pnlEstatusCliente.Visible = false;
            txtBuscarCliente.Visible = false;
            dgvClientes.Visible = false;
            pnlLLenarCamposC.Visible = false;
            pnlActivarC.Visible = false;
            pnlDarBajaC.Visible = false;
            pnlLlenarCamposCDB.Visible = false;
            /* Final para esconder los contenidos de mi panel de mantenimiento Clientes */

            /* Inicio para esconder mis iconos de guardar,modificar y dar de baja */
            pnlModificarC.Visible = false;
            pnlBotonGuardarC.Visible = false;

            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String pCodigoC = txtIdCliente.Text;
            String pNombreC = txtNombreCliente.Text;
            String pApellidoC = txtCampoApellidoC.Text;
            String pTelefonoC = txtCampoApellidoC.Text;
            String pCorreoC = txtCorreoC.Text;
            String pDireccion = richCliente.Text;
            /*Final obteniedo variables a usar con mi ABC cliente */

            pnlMantenimientoC.Visible = false;


        }

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Form2 obj = new Form2();

            obj.Visible = true;

            Visible = false;*/
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = true;
         
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCliente;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCliente;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalCliente;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalCliente;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalCliente;
        }

        private void lbnAbcCliente_MouseHover(object sender, EventArgs e)
        {

        }

        private void lbnAbcCliente_MouseLeave(object sender, EventArgs e)
        {

        }

        private void lbnAbcCliente_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeCliente.Visible = true;
            lblRegistrarCliente.Visible = true;
            lblModificarCliente.Visible = true;
            lblDarBaja.Visible = true;
        }

        private void lbnAbcCliente_Click(object sender, EventArgs e)
        {

        }

        private void lbnRegistrarCliente_MouseClick(object sender, MouseEventArgs e)
        {

            /* Inicio cargando datos en tabla clientes */
            Cliente cliente = new Cliente();
            //cliente.funBuscar(dgvClientes);
            funCargarTabla(null);


            /* Inicio haciendo visible mi borde de registrar */
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            pnlBordeRegistrar.Visible = true;
            /* Final haciendo visible mi borde de registrar */

            /* Inicio para hacer visibles los contenidos de mi panel de mantenimiento Clientes */
            pnlCampoIDC.Visible = true;
            pnlCampoIDC.Enabled = true;
            pnlCampoNombreC.Visible = true;
            pnlCampoApellidoC.Visible = true;
            pnlCampoTelefonoC.Visible = true;
            pnlCampoCorreoC.Visible = true;
            pnlCampoDireccion.Visible = true;
            pnlBotonGuardarC.Visible = true;
            pnlBotonBuscarC.Visible = true;
            txtBuscarCliente.Visible = true;
            dgvClientes.Visible = true;
            pnlLLenarCamposC.Visible = true;
            pnlEstatusCliente.Visible = false;
            pnlLlenarCamposCDB.Visible = false;
            pnlLlenarCamposCDB.Visible = false;
            pnlDarBajaC.Visible = false;
            pnlActivarC.Visible = false;
            /* Final para hacer visibles los contenidos de mi panel de mantenimiento Clientes */

            /* Inicio Inhabilitando o habilitando campos de mi cliente */
            pnlCampoIDC.Enabled = true;
            pnlCampoNombreC.Enabled = true;
            pnlCampoApellidoC.Enabled = true;
            pnlCampoTelefonoC.Enabled = true;
            pnlCampoCorreoC.Enabled = true;
            pnlCampoDireccion.Enabled = true;
            pnlBotonBuscarC.Enabled = true;
            txtBuscarCliente.Enabled = true;
            dgvClientes.Visible = true;
            pnlLLenarCamposC.Visible = true;
            /* Final Inhabilitando o habilitando campos de mi cliente */

            /* Inicio escondiendo Iconos de modificar y dar de baja */
            pnlModificarC.Visible = false;

            funVaciarCampos();
        }

        private void lbnModificarCliente_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio haciendo visible mi borde de modificar */
            pnlBordeDarBaja.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            /* Final haciendo visible mi borde de modificar */

            /* Inicio para esconder los contenidos de mi panel de mantenimiento Clientes */
            pnlCampoIDC.Visible = true;
            pnlCampoNombreC.Visible = true;
            pnlCampoApellidoC.Visible = true;
            pnlCampoTelefonoC.Visible = true;
            pnlCampoCorreoC.Visible = true;
            pnlCampoDireccion.Visible = true;
            pnlBotonBuscarC.Visible = true;
            txtBuscarCliente.Visible = true;
            pnlLLenarCamposC.Visible = true;
            dgvClientes.Visible = true;
            pnlEstatusCliente.Visible = false;
            pnlLlenarCamposCDB.Visible = false;
            pnlDarBajaC.Visible = false;
            pnlActivarC.Visible = false;

            funVaciarCampos();
            funCargarTabla(null);
            /* Final para esconder los contenidos de mi panel de mantenimiento Clientes */

            /* Inicio Inhabilitando o habilitando campos de mi cliente */
            pnlCampoIDC.Enabled = false;
            pnlCampoNombreC.Enabled = true;
            pnlCampoApellidoC.Enabled = true;
            pnlCampoTelefonoC.Enabled = true;
            pnlCampoCorreoC.Enabled = true;
            pnlCampoDireccion.Enabled = true;
            pnlBotonBuscarC.Enabled = true;
            txtBuscarCliente.Enabled = true;
            dgvClientes.Visible = true;
            pnlLLenarCamposC.Visible = true;
            txtEstatusC.Enabled = true;
            /* Final Inhabilitando o habilitando campos de mi cliente */

            /* Inicio esconder le boton guardar, dar de baja un cliente  y haciendo visible el de modificar */
            pnlBotonGuardarC.Visible = false;
            pnlModificarC.Visible = true;
            /* Final esconder le boton guardar, dar de baja un cliente  y haciendo visible el de modificar */
        }

        private void lbnDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            /* Inicio haciendo visible mi borde de dar baja */
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = true;
            /* Final haciendo visible mi borde de dar baja */

            /* Inicio para esconder los contenidos de mi panel de mantenimiento Clientes */
            pnlCampoIDC.Visible = true;
            pnlCampoNombreC.Visible = true;
            pnlCampoApellidoC.Visible = true;
            pnlCampoTelefonoC.Visible = true;
            pnlCampoCorreoC.Visible = true;
            pnlCampoDireccion.Visible = true;
            pnlBotonBuscarC.Visible = true;
            txtBuscarCliente.Visible = true;
            dgvClientes.Visible = true;
            pnlEstatusCliente.Visible = true;
            pnlLlenarCamposCDB.Visible = true;
            pnlLLenarCamposC.Visible = false;
            /* Final para esconder los contenidos de mi panel de mantenimiento Clientes */

            /* Inicio Inhabilitando campos de mi cliente */
            pnlCampoIDC.Enabled = false;
            pnlCampoNombreC.Enabled = false;
            pnlCampoApellidoC.Enabled = false;
            pnlCampoTelefonoC.Enabled = false;
            pnlCampoCorreoC.Enabled = false;
            pnlCampoDireccion.Enabled = false;
            pnlBotonBuscarC.Enabled = true;
            txtBuscarCliente.Enabled = true;
            dgvClientes.Visible = true;
            txtEstatusC.Enabled = false;
            /* Inicio Inhabilitando campos de mi cliente */

            /* Inicio esconder le boton guardar, dar de baja un cliente  y haciendo visible el de modificar */
            pnlBotonGuardarC.Visible = false;
            pnlModificarC.Visible = false;
            /* Final esconder le boton guardar, dar de baja un cliente  y haciendo visible el de modificar */

            funCargarTabla(null);

        }

        private void pnlMantenimientoC_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnlBotonGuardarC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBotonGuardarC_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un cliente */

            if(txtIdCliente.Text=="" && txtNombreCliente.Text == "" && txtCampoApellidoC.Text =="" && txtTelefonoC.Text =="" && txtCorreoC.Text == "" && richCliente.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusCliente = "A";
                Cliente cliente = funObtenerTxt(estatusCliente);
                cliente.funInsertar();
                /* Final de ejecucion de funcion insertar un cliente */

                funCargarTabla(null);
                funVaciarCampos();
            }
            
        }

        private void pnlBotonBuscarC_MouseClick(object sender, MouseEventArgs e)
        {

            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarCliente = txtBuscarCliente.Text;
            funCargarTabla(buscarCliente);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaC.Visible = false;
            pnlActivarC.Visible = false;
            /* Final Vaciando los campos */
        }


        private void pnlModificarC_MouseClick(object sender, MouseEventArgs e)
        {
            String estatuCliente = "A";
            String idCliente = txtIdCliente.Text;
            Cliente cliente = funObtenerTxt(estatuCliente);

            cliente.funModificar(idCliente);
            funCargarTabla(null);
            cliente.funBuscarSetearTxt(txtIdCliente, txtNombreCliente, txtCampoApellidoC, txtTelefonoC, txtCorreoC, richCliente, txtEstatusC, idCliente);


        }

        /* Inicio de funcion para evitar el uso de recursivo de tantas variables */
        public Cliente funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String pCodigoC = txtIdCliente.Text;
            String pNombreC = txtNombreCliente.Text;
            String pApellidoC = txtCampoApellidoC.Text;
            String pTelefonoC = txtTelefonoC.Text;
            String pCorreoC = txtCorreoC.Text;
            String pDireccion = richCliente.Text;
            /*Final obteniedo variables a usar con mi ABC cliente */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */
            Cliente cliente = new Cliente(pCodigoC, pNombreC, pApellidoC, pTelefonoC, pCorreoC, pDireccion, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return cliente;
        }
        /* Final de funcion para evitar el uso de recursivo de tantas variables */

        private void pnlLLenarCamposC_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombreCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtCampoApellidoC.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoC.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCorreoC.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            richCliente.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtEstatusC.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();
        }

        public void funVaciarCampos()
        {
            txtIdCliente.Text = "";
            txtNombreCliente.Text = "";
            txtCampoApellidoC.Text = "";
            txtTelefonoC.Text = "";
            txtCorreoC.Text = "";
            richCliente.Text = "";
            txtBuscarCliente.Text = "";
            txtEstatusC.Text = "";
        }

        /* Inicio funcion para cargar mi tabla de clientes */
        private void funCargarTabla(string dato)
        {
            List<Cliente> lista = new List<Cliente>();
            Cliente cliente = new Cliente();

            dgvClientes.DataSource = cliente.consulta(dato);
        }

        private void pnlMantenimientoC_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDarBaja_Click(object sender, EventArgs e)
        {

        }

        private void pnlLlenarCamposCDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdCliente.Text = dgvClientes.CurrentRow.Cells[0].Value.ToString();
            txtNombreCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
            txtCampoApellidoC.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
            txtTelefonoC.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
            txtCorreoC.Text = dgvClientes.CurrentRow.Cells[4].Value.ToString();
            richCliente.Text = dgvClientes.CurrentRow.Cells[5].Value.ToString();
            txtEstatusC.Text = dgvClientes.CurrentRow.Cells[6].Value.ToString();

            Cliente cliente = new Cliente();
            String pidCliente = txtIdCliente.Text;
            String pestatusCliente = cliente.funBuscarEstatus(pidCliente);

            if (pestatusCliente == "A")
            {
                pnlActivarC.Visible = false;
                pnlDarBajaC.Visible = true;
            }
            else if (pestatusCliente == "I")
            {
                pnlDarBajaC.Visible = false;
                pnlActivarC.Visible = true;
            }
        }

        private void pnlDarBajaC_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdCliente = txtIdCliente.Text;
            Cliente cliente = funObtenerTxt(estatus);

            cliente.funDarBajaCliente();
            funCargarTabla(null);

            pnlActivarC.Visible = true;
            pnlDarBajaC.Visible = false;

            cliente.funBuscarSetearTxt(txtIdCliente, txtNombreCliente, txtCampoApellidoC, txtTelefonoC, txtCorreoC, richCliente, txtEstatusC, pIdCliente);
        }

        private void pnlActivarC_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdCliente = txtIdCliente.Text;
            Cliente cliente = funObtenerTxt(estatus);

            cliente.funActivarCliente();
            funCargarTabla(null);

            pnlDarBajaC.Visible = true;
            pnlActivarC.Visible = false;

            cliente.funBuscarSetearTxt(txtIdCliente, txtNombreCliente, txtCampoApellidoC, txtTelefonoC, txtCorreoC, richCliente, txtEstatusC, pIdCliente);

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlPuestos_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void label3_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;
        }

        private void picIconoPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCliente;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCliente;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCliente;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCliente;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCliente;
        }

        private void btnPuesto_MouseLeave_1(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCliente;
        }

        private void btnDepartamento_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverCliente;
        }

        private void lblPuesto_MouseHover_1(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCliente;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverCliente;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverCliente;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCliente;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCliente;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCliente;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCliente;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverCliente;
            /* Final funcion para cargar mi tabla de clientes */
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalCliente;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCliente;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalCliente;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCliente;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalCliente;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = true;
        }

        private void pnlTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmtipoEmpleado obj = new frmtipoEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmtipoEmpleado obj = new frmtipoEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmtipoEmpleado obj = new frmtipoEmpleado();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverCliente;
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverCliente;
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverCliente;
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalCliente;
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalCliente;
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalCliente;
        }

        private void panel3_MouseClick_1(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void picSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion objSubUbicacion = new frmSubUbicacion();

            objSubUbicacion.Visible = true;
            Visible = false;
        }

        private void pnlSidebar_MouseHover(object sender, EventArgs e)
        {

        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverCliente;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalCliente;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverCliente;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalCliente;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverCliente;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalCliente;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmTipoMovimiento obj = new frmTipoMovimiento();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmTipoMovimiento obj = new frmTipoMovimiento();

            obj.Visible = true;

            Visible = false;
        }

        private void picTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmTipoMovimiento obj = new frmTipoMovimiento();

            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverCliente;
        }

        private void lblTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverCliente;
        }

        private void picTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverCliente;
        }

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalCliente;
        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalCliente;
        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalCliente;
        }

        private void panel3_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCliente;
        }

        private void label9_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCliente;
        }

        private void pictureBox2_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverCliente;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalCliente;
        }

        private void label9_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalCliente;
        }

        private void pictureBox2_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalCliente;
        }

        private void label9_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            pnlMantenimientoC.Visible = false;

            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;

        }

        private void lblTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;
        }

        private void picIconoTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte objTipoT = new frmTipoTransporte();

            objTipoT.Visible = true;
            Visible = false;
        }

        private void btnTipoTransporte_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCliente;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCliente;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCliente;
        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCliente;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverCliente;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalCliente;
        }

        private void lblUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void btnUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void picIconoUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void btnPaqueteEncabezado_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void btnPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoPaqueteE_MouseClick(object sender, MouseEventArgs e)
        {
            frmPaqueteEncabezado obj = new frmPaqueteEncabezado();
            obj.Visible = true;

            Visible = false;
        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCliente;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCliente;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCliente;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalCliente;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCliente;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverCliente;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }
    }
}