using System;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using sistema_reparto.Clases;

namespace sistema_reparto
{
    public partial class frmEmpleado : Form
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

        /* Codigo para mover mi panel */
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        /* Varibles para cambiar color de mi Boton */
        Color colorHoverRuta = Color.FromArgb(80, 115, 119);
        Color colorNormalRuta = Color.FromArgb(59, 102, 107);



        public frmEmpleado()
        {
            InitializeComponent();
            Empleado empleado = new Empleado();
            empleado.funLlenarComboTE(cbxIdPuestoEmpleado, "puesto", "idPuesto", "nombrePuesto");
            empleado.funLlenarComboTE(cbxIdDepEmpleado, "departamento", "idDepartamento", "nombreDepartamentos");

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            lblRegistrarEmpleado.Visible = false;
            lblModificarEmpleado.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            pnlCampoIDE.Visible = false;
            pnlCampoDpiEmpleado.Visible = false;
            pnlCampoIdUsuario.Visible = false;
            pnlCampoNombreEmpleado.Visible = false;
            pnlCampoApellidoEmpleado.Visible = false;
            pnlCampoTelEmpleado.Visible = false;
            pnlDirEmpleado.Visible = false;
            pnlSueldoEmpleado.Visible = false;
            pnlCampoIdDepEmpleado.Visible = false;
            pnlCampoIdPuestoEmpleado.Visible = false;
            pnlBotonGuardarE.Visible = false;
            pnlBotonBuscarE.Visible = false;
            pnlModificarE.Visible = false;
            pnlDarBajaE.Visible = false;
            pnlActivarE.Visible = false;
            dgvEmpleado.Visible = false;
            pnlLLenarCamposE.Visible = false;
            pnlLlenarCamposEDB.Visible = false;
            txtBuscarEmpleado.Visible = false;
            pnlEstatusEmpleado.Visible = false;
            pnlEstatusEmpleado.Visible = false;
            pnlBotonBuscarE.Visible = false;
            pnlBordeEmpleado.Visible = false;

        }

        private void frmEmpleado_Load(object sender, EventArgs e)
        {

        }

        private void frmEmpleado_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTelefonoC_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void lblAbcEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            lblRegistrarEmpleado.Visible = true;
            lblModificarEmpleado.Visible = true;
            lblDarBaja.Visible = true;
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = true;
            pnlBotonBuscarE.Visible = false;
            pnlBordeEmpleado.Visible = true;

        }

        private void lblRegistrarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Ruta */
            Empleado empleado = new Empleado();
            funCargarTabla(null);

            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            pnlCampoIDE.Visible = true;
            pnlCampoNombreEmpleado.Visible = true;
            pnlCampoApellidoEmpleado.Visible = true;
            pnlCampoDpiEmpleado.Visible = true;
            pnlCampoIdUsuario.Visible = true;
            pnlCampoTelEmpleado.Visible = true;
            pnlDirEmpleado.Visible = true;
            pnlSueldoEmpleado.Visible = true;
            pnlCampoIdPuestoEmpleado.Visible = true;
            pnlCampoIdDepEmpleado.Visible = true;
            pnlEstatusEmpleado.Visible = false;
            txtBuscarEmpleado.Visible = true;
            dgvEmpleado.Visible = true;
            pnlBotonGuardarE.Visible = true;
            pnlDarBajaE.Visible = false;
            pnlActivarE.Visible = false;
            pnlLLenarCamposE.Visible = true;
            pnlEstatusEmpleado.Visible = true;
            pnlBotonBuscarE.Visible = true;
            pnlModificarE.Visible = false;



            /*inicio deshabilitando y habilitando contenidos de mi form */
            //pnlCampoIdR.Enabled = true;
            //pnlCampoInicioR.Enabled = true;
            //txtBuscarRuta.Enabled = true;
            //pnlBotonBuscarR.Enabled = true;
            //pnlLLenarCamposR.Enabled = true;
            //pnlFinalR.Enabled = true;
            //pnlEstatusR.Enabled = true;
            //funVaciarCampos();
        }

        public void funVaciarCampos()
        {
            txtApellidoEmpleado.Text = "";
            txtIdUserEmp.Text = "";
            txtDirEmpleado.Text = "";
            txtDpiEmpleado.Text = "";
            txtEstatusEmpleado.Text = "";
            txtIdEmpleado.Text = "";
            txtNombreEmpleado.Text = "";
            txtSueldoEmpleado.Text = "";
            txtTelEmpleado.Text = "";
            txtBuscarEmpleado.Text = "";
            cbxIdDepEmpleado.SelectedItem = "";
            
        }
        

        /* Inicio funcion para cargar mi tabla de ruta */
        private void funCargarTabla(string dato)
        {
            List<Ruta> lista = new List<Ruta>();
            Empleado empleado = new Empleado();

            dgvEmpleado.DataSource = empleado.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de Ruta */


        private void pnlBotonGuardarE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un empleado */
            String EstatusEmpleado = "A";
            Empleado empleado = funObtenerTxt(EstatusEmpleado);
            empleado.funInsertar();
            /* Final de ejecucion de funcion insertar un empleado */
            funCargarTabla(null);
            funVaciarCampos();
        }
        public Empleado funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC empleado */
            String pIdEmp = txtIdEmpleado.Text;
            String pDpiEmp = txtDpiEmpleado.Text;
            String pIdUserEmp = txtIdUserEmp.Text;
            String pNombreEmp = txtNombreEmpleado.Text;
            String pApellidoEmp = txtApellidoEmpleado.Text;
            String pTelefonoEmp = txtTelEmpleado.Text;
            String pDireccionEmp = txtDirEmpleado.Text;
            String pSueldoEmp = txtSueldoEmpleado.Text;
            String pIdDepEmp = cbxIdDepEmpleado.SelectedValue.ToString();
            String pIdPuesEmp = cbxIdPuestoEmpleado.SelectedValue.ToString();

            /*Final obteniedo variables a usar con mi ABC Departamento */

            /* Inicio creamos un objeto de tipo empleado para poder utilizar el metodo de insertar Ruta */
            Empleado empleado = new Empleado(pIdEmp, pDpiEmp, pIdUserEmp, pNombreEmp, pApellidoEmp, pTelefonoEmp, pDireccionEmp, pSueldoEmp, pIdDepEmp, pIdPuesEmp, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */

            return empleado;
        }

        private void pnlModificarE_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusEmpleado = "A";
            String idEmpleado = txtIdEmpleado.Text;
            Empleado empleado = funObtenerTxt(EstatusEmpleado);

            empleado.funModificar(idEmpleado);
            funCargarTabla(null);
            empleado.funBuscarSetearTxt(txtIdEmpleado, txtDpiEmpleado, txtIdUserEmp,txtNombreEmpleado, txtApellidoEmpleado, txtTelEmpleado, txtDirEmpleado, txtSueldoEmpleado, cbxIdDepEmpleado, cbxIdPuestoEmpleado, txtEstatusEmpleado, idEmpleado);
        }

        private void pnlLLenarCamposE_MouseClick(object sender, MouseEventArgs e)
        {
            Empleado empleado = new Empleado();
            
            txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtDpiEmpleado.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtIdUserEmp.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtNombreEmpleado.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtApellidoEmpleado.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtTelEmpleado.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtDirEmpleado.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
            txtSueldoEmpleado.Text = dgvEmpleado.CurrentRow.Cells[7].Value.ToString();
            txtEstatusEmpleado.Text = dgvEmpleado.CurrentRow.Cells[10].Value.ToString();

            String idDep = dgvEmpleado.CurrentRow.Cells[8].Value.ToString();
            String idPuesto = dgvEmpleado.CurrentRow.Cells[9].Value.ToString();

            empleado.obtenerNombreDep(idDep);
            cbxIdDepEmpleado.SelectedValue = idDep;

            empleado.obtenerNombrePuesto(idPuesto);
            cbxIdPuestoEmpleado.SelectedValue = idPuesto;
        }

        private void dgvEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void lblModificarEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;
            pnlCampoIDE.Visible = true;
            pnlModificarE.Visible = true;
            pnlCampoDpiEmpleado.Visible = true;
            pnlCampoIdUsuario.Visible = true;
            pnlCampoNombreEmpleado.Visible = true;
            pnlCampoApellidoEmpleado.Visible = true;
            pnlCampoTelEmpleado.Visible = true;
            pnlDirEmpleado.Visible = true;
            pnlSueldoEmpleado.Visible = true;
            dgvEmpleado.Visible = true;
            pnlCampoIdPuestoEmpleado.Visible = true;
            pnlEstatusEmpleado.Visible = true;
            pnlCampoIdDepEmpleado.Visible = true;
            pnlModificarE.Visible = true;
            pnlBotonGuardarE.Visible = false;
            pnlDarBajaE.Visible = false;
            pnlActivarE.Visible = false;
            pnlLlenarCamposEDB.Visible = false;
            pnlLLenarCamposE.Visible = true;
            txtBuscarEmpleado.Visible = true;
            pnlBotonBuscarE.Visible = true;



        }

        private void pnlModificarE_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlBotonBuscarE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarEmpleado = txtBuscarEmpleado.Text;
            funCargarTabla(buscarEmpleado);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaE.Visible = false;

            pnlActivarE.Visible = false;
            /* Final Vaciando los campos */
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            pnlCampoIDE.Visible = true;
            pnlCampoDpiEmpleado.Visible = true;
            pnlCampoIdUsuario.Visible = true;
            pnlCampoNombreEmpleado.Visible = true;
            pnlCampoApellidoEmpleado.Visible = true;
            pnlCampoTelEmpleado.Visible = true;
            pnlDirEmpleado.Visible = true;
            pnlSueldoEmpleado.Visible = true;
            pnlCampoIdPuestoEmpleado.Visible = true;
            pnlCampoIdDepEmpleado.Visible = true;
            pnlEstatusEmpleado.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeDarBaja.Visible = true;
            dgvEmpleado.Visible = true;
            pnlLlenarCamposEDB.Visible = true;
            pnlEstatusEmpleado.Enabled = false;
            pnlBotonBuscarE.Visible = true;
            txtBuscarEmpleado.Visible = true;
            pnlLLenarCamposE.Visible = false;



            pnlCampoIDE.Enabled = false;
            pnlCampoDpiEmpleado.Enabled = false;
            pnlCampoIdUsuario.Enabled = false;
            pnlCampoNombreEmpleado.Enabled = false;
            pnlCampoApellidoEmpleado.Enabled = false;
            pnlCampoTelEmpleado.Enabled = false;
            pnlDirEmpleado.Enabled = false;
            pnlSueldoEmpleado.Enabled = false;
            pnlCampoIdPuestoEmpleado.Enabled = false;
            pnlCampoIdDepEmpleado.Enabled = false;

            pnlBotonGuardarE.Visible = false;
            pnlModificarE.Visible = false;

            funCargarTabla(null);
        }

        private void pnlLlenarCamposEDB_MouseClick(object sender, MouseEventArgs e)
        {
            Empleado empleado = new Empleado();
            txtIdEmpleado.Text = dgvEmpleado.CurrentRow.Cells[0].Value.ToString();
            txtDpiEmpleado.Text = dgvEmpleado.CurrentRow.Cells[1].Value.ToString();
            txtIdUserEmp.Text = dgvEmpleado.CurrentRow.Cells[2].Value.ToString();
            txtNombreEmpleado.Text = dgvEmpleado.CurrentRow.Cells[3].Value.ToString();
            txtApellidoEmpleado.Text = dgvEmpleado.CurrentRow.Cells[4].Value.ToString();
            txtTelEmpleado.Text = dgvEmpleado.CurrentRow.Cells[5].Value.ToString();
            txtDirEmpleado.Text = dgvEmpleado.CurrentRow.Cells[6].Value.ToString();
            txtSueldoEmpleado.Text = dgvEmpleado.CurrentRow.Cells[7].Value.ToString();
            txtEstatusEmpleado.Text = dgvEmpleado.CurrentRow.Cells[10].Value.ToString();

            String idDep = dgvEmpleado.CurrentRow.Cells[8].Value.ToString();
            String idPuesto = dgvEmpleado.CurrentRow.Cells[9].Value.ToString();

            empleado.obtenerNombreDep(idDep);
            cbxIdDepEmpleado.SelectedValue = idDep;

            empleado.obtenerNombrePuesto(idPuesto);
            cbxIdPuestoEmpleado.SelectedValue = idPuesto;

            String pIdEmpleadao = txtIdEmpleado.Text;
            String pEstatusEmpleado = empleado.funBuscarEstatus(pIdEmpleadao);

            if (pEstatusEmpleado == "A")
            {
                pnlActivarE.Visible = false;
                pnlDarBajaE.Visible = true;
            }
            else if (pEstatusEmpleado == "I")
            {
                pnlDarBajaE.Visible = false;
                pnlActivarE.Visible = true;
            }
        }

        private void pnlDarBajaE_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdEmpleado = txtIdEmpleado.Text;
            Empleado empleado = funObtenerTxt(estatus);

            empleado.funDarBajaRuta();
            funCargarTabla(null);

            pnlActivarE.Visible = true;
            pnlDarBajaE.Visible = false;

            empleado.funBuscarSetearTxt(txtIdEmpleado, txtDpiEmpleado, txtIdUserEmp, txtNombreEmpleado, txtApellidoEmpleado, txtTelEmpleado, txtDirEmpleado, txtSueldoEmpleado, cbxIdDepEmpleado, cbxIdPuestoEmpleado,txtEstatusEmpleado, pIdEmpleado);
        }

        private void pnlActivarE_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdEmpleado = txtIdEmpleado.Text;
            Empleado empleado = funObtenerTxt(estatus);

            empleado.funActivarEmpleado();
            funCargarTabla(null);

            pnlDarBajaE.Visible = true;
            pnlActivarE.Visible = false;

            empleado.funBuscarSetearTxt(txtIdEmpleado, txtDpiEmpleado, txtIdUserEmp, txtNombreEmpleado, txtApellidoEmpleado, txtTelEmpleado, txtDirEmpleado, txtSueldoEmpleado, cbxIdDepEmpleado, cbxIdPuestoEmpleado, txtEstatusEmpleado, pIdEmpleado);
        }

        private void panel1_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverRuta;
        }

        private void pnlEmpleado_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void label12_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverRuta;
        }

        private void label12_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void pnlEmpleado_MouseLeave_1(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void pictureBox3_MouseHover(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverRuta;
        }

        private void pictureBox3_MouseLeave(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void label12_MouseHover_1(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorHoverRuta;
        }

        private void label12_MouseLeave_1(object sender, EventArgs e)
        {
            pnlEmpleado.BackColor = colorNormalRuta;
        }

        private void panel11_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void panel10_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();

            obj.Visible = true;

            Visible = false;
        }

        private void panel9_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();

            obj.Visible = true;

            Visible = false;
        }

        private void panel8_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void panel7_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void panel6_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();

            obj.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();

            obj.Visible = true;

            Visible = false;
        }

        private void panel11_MouseHover(object sender, EventArgs e)
        {
            panel11.BackColor = colorHoverRuta;

        }

        private void panel10_MouseHover(object sender, EventArgs e)
        {
            panel10.BackColor = colorHoverRuta;

        }

        private void panel9_MouseHover(object sender, EventArgs e)
        {
            panel9.BackColor = colorHoverRuta;

        }

        private void panel8_MouseHover(object sender, EventArgs e)
        {
            panel8.BackColor = colorHoverRuta;

        }

        private void panel7_MouseHover(object sender, EventArgs e)
        {
            panel7.BackColor = colorHoverRuta;

        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverRuta;

        }

        private void panel6_MouseHover(object sender, EventArgs e)
        {
            panel6.BackColor = colorHoverRuta;

        }

        private void panel11_MouseLeave(object sender, EventArgs e)
        {
            panel11.BackColor = colorNormalRuta;
        }

        private void panel10_MouseLeave(object sender, EventArgs e)
        {
            panel10.BackColor = colorNormalRuta;

        }

        private void panel9_MouseLeave(object sender, EventArgs e)
        {
            panel9.BackColor = colorNormalRuta;

        }

        private void panel8_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void panel8_MouseLeave(object sender, EventArgs e)
        {
            panel8.BackColor = colorNormalRuta;

        }

        private void panel7_MouseLeave(object sender, EventArgs e)
        {
            panel7.BackColor = colorNormalRuta;

        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalRuta;

        }

        private void panel6_MouseLeave(object sender, EventArgs e)
        {
            panel6.BackColor = colorNormalRuta;

        }

        private void label24_MouseHover(object sender, EventArgs e)
        {

        }
    }
}
