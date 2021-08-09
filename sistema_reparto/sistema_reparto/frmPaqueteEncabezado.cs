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
using sistema_reparto.Clases;

namespace sistema_reparto
{
    public partial class frmPaqueteEncabezado : Form
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

        Color colorHoverPE = Color.FromArgb(80, 115, 119);
        Color colorNormalPE = Color.FromArgb(59, 102, 107);
        public frmPaqueteEncabezado()
        {
            InitializeComponent();
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Llamando Combobox*/
            PaqueteEncabezado paqueteEncabezado = new PaqueteEncabezado();
            paqueteEncabezado.cargarCombobox(cbxCliente, "cliente", "idCliente", "nombreCliente");
            paqueteEncabezado.cargarCombobox(cbxEmpleado, "empleado", "idEmpleado", "nombreEmpleado");

            lblTituloPaqueteEncabezado.Visible = true;
            lblAbcPaqueteEncabezado.Visible = true;
            pnlBordePE.Visible = false;
            //encabezados
            lblRegistrarPE.Visible = false;
            lblModificarPE.Visible = false;
            lblDarBaja.Visible = false;
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;
            //fin encabezados

            /*Habilitando componentes*/
            pnlCampoIDPE.Visible = false;
            pnlCampoIDCliente.Visible = false;
            pnlCampoFechaRecPE.Visible = false;
            pnlFechaPE.Visible = false;
            pnlNombreRemPE.Visible = false;
            pnlCampoDireccionRemitente.Visible = false;
            pnlCampoTelRem.Visible = false;
            pnlCampoIdEmpleado.Visible = false;
            pnlEstatusPE.Visible = false;
            txtBuscarPE.Visible = false;
            pnlBotonBuscarPE.Visible = false;
            dgvPaqueteEncabezado.Visible = false;
            pnlLlenarCamposPEDB.Visible = false;
            pnlLLenarCamposPE.Visible = false;
            pnlBotonGuardarPE.Visible = false;
            pnlModificarPE.Visible = false;
            pnlDarBajaPE.Visible = false;
            pnlActivarPE.Visible = false;
            /*Habilitando componentes*/
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();
            obj.Visible = true;

            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos obj = new frmPuestos();
            obj.Visible = true;

            Visible = false;
        }

        private void btnDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void lblDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void picDepartamento_MouseClick(object sender, MouseEventArgs e)
        {
            frmDepartamento obj = new frmDepartamento();
            obj.Visible = true;

            Visible = false;
        }

        private void btnUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void lblUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmUbicacion obj = new frmUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado obj = new frmtipoEmpleado();
            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado obj = new frmtipoEmpleado();
            obj.Visible = true;

            Visible = false;
        }

        private void picTipoEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmtipoEmpleado obj = new frmtipoEmpleado();
            obj.Visible = true;

            Visible = false;
        }

        private void btnRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void lblRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void picRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmRuta obj = new frmRuta();
            obj.Visible = true;

            Visible = false;
        }

        private void pnlSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void lblSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void picSubUbicacion_MouseClick(object sender, MouseEventArgs e)
        {
            frmSubUbicacion obj = new frmSubUbicacion();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void picTipoMovimiento_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoMovimiento obj = new frmTipoMovimiento();
            obj.Visible = true;

            Visible = false;
        }

        private void btnTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void lblTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoTipoTransporte_MouseClick(object sender, MouseEventArgs e)
        {
            frmTipoTransporte obj = new frmTipoTransporte();
            obj.Visible = true;

            Visible = false;
        }

        private void lblPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void frmPaqueteEncabezado_Load(object sender, EventArgs e)
        {

        }

        private void btnPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPE;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPE;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverPE;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPE;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPE;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalPE;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPE;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPE;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPE;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPE;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPE;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPE;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPE;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPE;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPE;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPE;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPE;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPE;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPE;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPE;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPE;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPE;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPE;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPE;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPE;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPE;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPE;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPE;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPE;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPE;
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {

        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverPE;
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverPE;
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverPE;
        }

        private void btnTipoEmpleado_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalPE;
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalPE;
        }

        private void btnRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPE;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPE;
        }

        private void picRuta_MouseHover(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorHoverPE;
        }

        private void btnRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPE;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPE;
        }

        private void picRuta_MouseLeave(object sender, EventArgs e)
        {
            btnRuta.BackColor = colorNormalPE;
        }

        private void pnlSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPE;
        }

        private void lblSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPE;
        }

        private void picSubUbicacion_MouseHover(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorHoverPE;
        }

        private void pnlSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPE;
        }

        private void lblSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPE;
        }

        private void picSubUbicacion_MouseLeave(object sender, EventArgs e)
        {
            pnlSubUbicacion.BackColor = colorNormalPE;
        }

        private void btnTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverPE;
        }

        private void lblTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverPE;
        }

        private void picTipoMovimiento_MouseHover(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorHoverPE;
        }

        private void btnTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalPE;
        }

        private void lblTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalPE;
        }

        private void picTipoMovimiento_MouseLeave(object sender, EventArgs e)
        {
            btnTipoMovimiento.BackColor = colorNormalPE;
        }

        private void btnTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPE;
        }

        private void lblTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPE;
        }

        private void picIconoTipoTransporte_MouseHover(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorHoverPE;
        }

        private void btnTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPE;
        }

        private void lblTipoTransporte_Click(object sender, EventArgs e)
        {

        }

        private void lblTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPE;
        }

        private void picIconoTipoTransporte_MouseLeave(object sender, EventArgs e)
        {
            btnTipoTransporte.BackColor = colorNormalPE;
        }

        private void lblRegistrarPE_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = true;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Habilitando componentes*/
            pnlCampoIDPE.Visible = true;
            pnlCampoIDCliente.Visible = true;
            pnlCampoFechaRecPE.Visible = true;
            pnlFechaPE.Visible = true;
            pnlNombreRemPE.Visible = true;
            pnlCampoDireccionRemitente.Visible = true;
            pnlCampoTelRem.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlEstatusPE.Visible = false;
            txtBuscarPE.Visible = true;
            pnlBotonBuscarPE.Visible = true;
            dgvPaqueteEncabezado.Visible = true;
            pnlLlenarCamposPEDB.Visible = false;
            pnlLLenarCamposPE.Visible = true;
            pnlBotonGuardarPE.Visible = true;
            pnlModificarPE.Visible = false;
            pnlDarBajaPE.Visible = false;
            pnlActivarPE.Visible = false;
            /*Habilitando componentes*/

            /*Habilitando elementos permitidos*/
            pnlCampoIDPE.Enabled = true;
            pnlCampoIDCliente.Enabled = true;
            pnlCampoFechaRecPE.Enabled = true;
            pnlFechaPE.Enabled = true;
            pnlNombreRemPE.Enabled = true;
            pnlCampoDireccionRemitente.Enabled = true;
            pnlCampoTelRem.Enabled = true;
            pnlCampoIdEmpleado.Enabled = true;
            pnlEstatusPE.Enabled = false;
            txtBuscarPE.Enabled = true;
            pnlBotonBuscarPE.Enabled = true;
            dgvPaqueteEncabezado.Enabled = true;
            
            /*Habilitando componentes*/
        }

        private void lblModificarPE_Click(object sender, EventArgs e)
        {
           
        }

        private void lblDarBaja_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = false;
            pnlBordeDarBaja.Visible = true;

            funCargarTabla(null);
            funVaciarCampos();

            /*Habilitando componentes*/
            pnlCampoIDPE.Visible = true;
            pnlCampoIDCliente.Visible = true;
            pnlCampoFechaRecPE.Visible = true;
            pnlFechaPE.Visible = true;
            pnlNombreRemPE.Visible = true;
            pnlCampoDireccionRemitente.Visible = true;
            pnlCampoTelRem.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlEstatusPE.Visible = true;
            txtBuscarPE.Visible = true;
            pnlBotonBuscarPE.Visible = true;
            dgvPaqueteEncabezado.Visible = true;
            pnlLlenarCamposPEDB.Visible = true;
            pnlLLenarCamposPE.Visible = false;
            pnlBotonGuardarPE.Visible = false;
            pnlModificarPE.Visible = false;
            pnlDarBajaPE.Visible = false;
            pnlActivarPE.Visible = false;
            /*Habilitando componentes*/

            /*Habilitando elementos permitidos*/
            pnlCampoIDPE.Enabled = false;
            pnlCampoIDCliente.Enabled = false;
            pnlCampoFechaRecPE.Enabled = false;
            pnlFechaPE.Enabled = false;
            pnlNombreRemPE.Enabled = false;
            pnlCampoDireccionRemitente.Enabled = false;
            pnlCampoTelRem.Enabled= false;
            pnlCampoIdEmpleado.Enabled = false;
            pnlEstatusPE.Enabled = false;
            txtBuscarPE.Enabled = true;
            pnlBotonBuscarPE.Enabled = true;
            dgvPaqueteEncabezado.Enabled = true;
            /*Habilitando componentes*/
        }

        private void lblAbcPaqueteEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void lblAbcPaqueteEncabezado_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordePE.Visible = true;
            lblRegistrarPE.Visible = true;
            lblModificarPE.Visible = true;
            lblDarBaja.Visible = true;
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblModificarPE_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRegistrar.Visible = false;
            pnlBordeModificar.Visible = true;
            pnlBordeDarBaja.Visible = false;

            funCargarTabla(null);
            funVaciarCampos();

            /*Habilitando componentes*/
            pnlCampoIDPE.Visible = true;
            pnlCampoIDCliente.Visible = true;
            pnlCampoFechaRecPE.Visible = true;
            pnlFechaPE.Visible = true;
            pnlNombreRemPE.Visible = true;
            pnlCampoDireccionRemitente.Visible = true;
            pnlCampoTelRem.Visible = true;
            pnlCampoIdEmpleado.Visible = true;
            pnlEstatusPE.Visible = false;
            txtBuscarPE.Visible = true;
            pnlBotonBuscarPE.Visible = true;
            dgvPaqueteEncabezado.Visible = true;
            pnlLlenarCamposPEDB.Visible = false;
            pnlLLenarCamposPE.Visible = true;
            pnlBotonGuardarPE.Visible = false;
            pnlModificarPE.Visible = true;
            pnlDarBajaPE.Visible = false;
            pnlActivarPE.Visible = false;
            /*Habilitando componentes*/

            /*Habilitando elementos permitidos*/
            pnlCampoIDPE.Enabled = false;
            pnlCampoIDCliente.Enabled = true;
            pnlCampoFechaRecPE.Enabled = true;
            pnlFechaPE.Enabled = true;
            pnlNombreRemPE.Enabled = true;
            pnlCampoDireccionRemitente.Enabled = true;
            pnlCampoTelRem.Enabled = true;
            pnlCampoIdEmpleado.Enabled = true;
            pnlEstatusPE.Enabled = false;
            txtBuscarPE.Enabled = true;
            pnlBotonBuscarPE.Enabled = true;
            dgvPaqueteEncabezado.Enabled = true;

            /*Habilitando componentes*/
        }

        private void btnPiloto_MouseClick(object sender, MouseEventArgs e)
        {
 
        }

        private void lblPiloto_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void picIconoPiloto_MouseClick(object sender, MouseEventArgs e)
        {
   
        }

        private void btnPiloto_MouseHover(object sender, EventArgs e)
        {
           
        }

        private void lblPiloto_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void picIconoPiloto_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void btnPiloto_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void lblPiloto_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void picIconoPiloto_MouseLeave(object sender, EventArgs e)
        {
          
        }

        private void btnUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

            Visible = false;
        }

        private void lblUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

            Visible = false;
        }

        private void picIconoUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios obj = new frmUsuarios();
            obj.Visible = true;

            Visible = false;
        }

        private void pnlBotonGuardarPE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un cliente */

            if (txtIdPE.Text == "" && txtNombreRemPE.Text == "" && txtDireccionRemitente.Text == "" && txtTelefonoRemitente.Text == "" && txtEstatusPE.Text == "")
            {
                MessageBox.Show("No se pueden ingresar campos vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String estatusPaqEncabezado = "A";
                PaqueteEncabezado paqueteEnc = funObtenerTxt(estatusPaqEncabezado);
                paqueteEnc.funInsertar();
                /* Final de ejecucion de funcion insertar un cliente */

                funCargarTabla(null);
                funVaciarCampos();
            }

        }

        public PaqueteEncabezado funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC cliente */
            String codigoPE = txtIdPE.Text;
            String clientePE = cbxCliente.SelectedValue.ToString();
            String fechaRecep = txtFechaRecPE.Value.ToString("yyyy-MM-dd");
            String fechaCliente = txtFechaClienteEntPE.Value.ToString("yyyy-MM-dd");
            String nombreRem = txtNombreRemPE.Text;
            String direccionRem = txtDireccionRemitente.Text;
            String telefonoRem = txtTelefonoRemitente.Text;
            String idEmpleado = cbxEmpleado.SelectedValue.ToString();

            String estatusPE = estatus;

            /*Final obteniedo variables a usar con mi ABC */

            /* Inicio creamos un objeto de tipo paqueteEncabezado para poder utilizar el metodo de insertar */
            PaqueteEncabezado paqueteEmpleado = new PaqueteEncabezado(codigoPE, clientePE, fechaRecep, fechaCliente, nombreRem, direccionRem, telefonoRem, idEmpleado, estatusPE);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return paqueteEmpleado;
        }

        private void funCargarTabla(string dato)
        {
            List<PaqueteEncabezado> lista = new List<PaqueteEncabezado>();
            PaqueteEncabezado paqueteEnc = new PaqueteEncabezado();

            dgvPaqueteEncabezado.DataSource = paqueteEnc.consulta(dato);
        }

        public void funVaciarCampos()
        {
            txtIdPE.Text = "";
            txtNombreRemPE.Text = "";
            txtDireccionRemitente.Text = "";
            txtTelefonoRemitente.Text = "";
            txtEstatusPE.Text = "";
            txtBuscarPE.Text = "";
        }

        private void pnlModificarPE_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusPaqueteEncabezado = "A";
            String idPaqueteEncabezado = txtIdPE.Text;
            PaqueteEncabezado paqueteEnc = funObtenerTxt(estatusPaqueteEncabezado);

            paqueteEnc.funModificar(idPaqueteEncabezado);
            funCargarTabla(null);

            paqueteEnc.funBuscarSetearTxt(txtIdPE, cbxCliente, txtFechaRecPE, txtFechaClienteEntPE, txtNombreRemPE, txtDireccionRemitente, txtTelefonoRemitente, cbxEmpleado, txtEstatusPE, idPaqueteEncabezado);

        }

        private void pnlBotonBuscarPE_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPE = txtBuscarPE.Text;
            funCargarTabla(buscarPE);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlActivarPE.Visible = false;
            pnlDarBajaPE.Visible = false;
            /* Final Vaciando los campos */
        }

        private void pnlLLenarCamposPE_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[0].Value.ToString();

            String idCliente = dgvPaqueteEncabezado.CurrentRow.Cells[1].Value.ToString();

            PaqueteEncabezado paqueteEn = new PaqueteEncabezado();
            paqueteEn.obtenerNombre(idCliente);
            //en la funcion idCliente se le asigna el nombre que existe en la BD y se le coloca al combobox
            cbxCliente.SelectedValue = idCliente;

            // De string a dateTime
            txtFechaRecPE.Value = Convert.ToDateTime(dgvPaqueteEncabezado.CurrentRow.Cells[2].Value.ToString());
            txtFechaClienteEntPE.Value = Convert.ToDateTime(dgvPaqueteEncabezado.CurrentRow.Cells[3].Value.ToString());

            txtNombreRemPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[4].Value.ToString();
            txtDireccionRemitente.Text = dgvPaqueteEncabezado.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoRemitente.Text = dgvPaqueteEncabezado.CurrentRow.Cells[6].Value.ToString();

            String idEmpleado = dgvPaqueteEncabezado.CurrentRow.Cells[7].Value.ToString();
            PaqueteEncabezado paqueteEncabezado = new PaqueteEncabezado();
            paqueteEncabezado.obtenerNombreEmpleado(idEmpleado);
            cbxEmpleado.SelectedValue = idEmpleado;

            txtEstatusPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[8].Value.ToString();

        }

        private void pnlDarBajaPE_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdPE = txtIdPE.Text;
            PaqueteEncabezado paqueteEnc = funObtenerTxt(estatus);

            paqueteEnc.funDarBajaCliente();
            funCargarTabla(null);

            pnlActivarPE.Visible = true;
            pnlDarBajaPE.Visible = false;

            paqueteEnc.funBuscarSetearTxt(txtIdPE, cbxCliente, txtFechaRecPE, txtFechaClienteEntPE, txtNombreRemPE, txtDireccionRemitente, txtTelefonoRemitente, cbxEmpleado, txtEstatusPE, pIdPE);

        }

        private void pnlLlenarCamposPEDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[0].Value.ToString();

            String idCliente = dgvPaqueteEncabezado.CurrentRow.Cells[1].Value.ToString();

            PaqueteEncabezado paqueteEn = new PaqueteEncabezado();
            paqueteEn.obtenerNombre(idCliente);
            cbxCliente.SelectedValue = idCliente;

            // De string a dateTime
            txtFechaRecPE.Value = Convert.ToDateTime(dgvPaqueteEncabezado.CurrentRow.Cells[2].Value.ToString());
            txtFechaClienteEntPE.Value = Convert.ToDateTime(dgvPaqueteEncabezado.CurrentRow.Cells[3].Value.ToString());

            txtNombreRemPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[4].Value.ToString();
            txtDireccionRemitente.Text = dgvPaqueteEncabezado.CurrentRow.Cells[5].Value.ToString();
            txtTelefonoRemitente.Text = dgvPaqueteEncabezado.CurrentRow.Cells[6].Value.ToString();

            String idEmpleado = dgvPaqueteEncabezado.CurrentRow.Cells[7].Value.ToString();
            PaqueteEncabezado paqueteEncabezado = new PaqueteEncabezado();
            paqueteEncabezado.obtenerNombreEmpleado(idEmpleado);
            cbxEmpleado.SelectedValue = idEmpleado;

            txtEstatusPE.Text = dgvPaqueteEncabezado.CurrentRow.Cells[8].Value.ToString();


            PaqueteEncabezado paqueteEnc = new PaqueteEncabezado();
            String pidPE = txtIdPE.Text;
            String pEstatusPE = paqueteEnc.funBuscarEstatus(pidPE);

            if (pEstatusPE == "A")
            {
                pnlActivarPE.Visible = false;
                pnlDarBajaPE.Visible = true;
            }
            else if (pEstatusPE == "I")
            {
                pnlDarBajaPE.Visible = false;
                pnlActivarPE.Visible = true;
            }
        }

        private void pnlActivarPE_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdPE = txtIdPE.Text;
            PaqueteEncabezado paqueteEnc = funObtenerTxt(estatus);

            paqueteEnc.funActivarCliente();
            funCargarTabla(null);

            pnlDarBajaPE.Visible = true;
            pnlActivarPE.Visible = false;

            paqueteEnc.funBuscarSetearTxt(txtIdPE, cbxCliente, txtFechaRecPE, txtFechaClienteEntPE, txtNombreRemPE, txtDireccionRemitente, txtTelefonoRemitente, cbxEmpleado, txtEstatusPE, pIdPE);
        }
    }

}
