﻿using System;
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
    public partial class frmPuestos : Form
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

        Color colorHoverPuesto = Color.FromArgb(80, 115, 119);
        Color colorNormalPuesto = Color.FromArgb(59, 102, 107);

        public frmPuestos()
        {
            InitializeComponent();

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /*Inicio Esconder contenidos de mi form puestos */
            pnlBordePuesto.Visible = false;
            lblRegistrarPuesto.Visible = false;
            pnlBordeRegistrarP.Visible = false;
            lblModificarPuesto.Visible = false;
            pnlBordeModificarP.Visible = false;
            lblDarBajaP.Visible = false;
            pnlBordeDarBajaP.Visible = false;
            pnlCampoIdP.Visible = false;
            pnlCampoNombreP.Visible = false;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = false;
            pnlBotonBuscarP.Visible = false;
            dgvPuesto.Visible = false;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = false;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = false;
            /*Final Esconder contenidos de mi form puestos */
        }

        private void frmPuestos_Load(object sender, EventArgs e)
        {

        }

        private void frmPuestos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverPuesto;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalPuesto;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverPuesto;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalPuesto;
        }

        private void btnDepartamento_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverPuesto;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalPuesto;
        }

        private void lblAbcPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio haciedno visibles mis labels y bordes */
            pnlBordePuesto.Visible = true;
            lblRegistrarPuesto.Visible = true;
            lblModificarPuesto.Visible = true;
            lblDarBajaP.Visible = true;
            /* Final haciedno visibles mis labels y bordes */
        }

        private void lblRegistrarPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Puestos */
            Puesto puesto = new Puesto();
            funCargarTabla(null);

            pnlBordeDarBajaP.Visible = false;
            pnlBordeModificarP.Visible = false;
            pnlBordeRegistrarP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = true;
            pnlModificarP.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = true;
            pnlCampoNombreP.Enabled = true;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

            funVaciarCampos();
        }

        private void lblModificarPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeDarBajaP.Visible = false;
            pnlBordeRegistrarP.Visible = false;
            pnlBordeModificarP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = false;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = false;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = true;

            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = false;
            pnlCampoNombreP.Enabled = true;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

        }

        private void lblDarBajaP_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            pnlBordeRegistrarP.Visible = false;
            pnlBordeModificarP.Visible = false;
            pnlBordeDarBajaP.Visible = true;

            /*Inicio Esconder y mostrando contenidos de mi form puestos */
            pnlCampoIdP.Visible = true;
            pnlCampoNombreP.Visible = true;
            pnlContenidoEP.Visible = true;
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            txtBuscarPuesto.Visible = true;
            pnlBotonBuscarP.Visible = true;
            dgvPuesto.Visible = true;
            pnlLlenarCamposPDB.Visible = true;
            pnlLLenarCamposP.Visible = true;
            pnlBotonGuardarP.Visible = false;
            pnlModificarP.Visible = false;
            pnlLLenarCamposP.Visible = false;
            /*Final Esconder y mostrando contenidos de mi form puestos */

            /*Inicio deshabilitando y habilitando contenidos de mi form puestos */
            pnlCampoIdP.Enabled = false;
            pnlCampoNombreP.Enabled = false;
            txtEstatusPuesto.Enabled = false;
            txtBuscarPuesto.Enabled = true;
            pnlBotonBuscarP.Enabled = true;
            dgvPuesto.Enabled = true;
            pnlLLenarCamposP.Enabled = true;
            /*Final deshabilitando y habilitando contenidos de mi form puestos */

            funCargarTabla(null);
        }

        private void pnlBotonGuardarP_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un Puestp */
            String estatusPuesto = "A";
            Puesto puesto = funObtenerTxt(estatusPuesto);
            puesto.funInsertar();
            /* Final de ejecucion de funcion insertar un Puesto */

            funCargarTabla(null);
            funVaciarCampos();
        }

        public Puesto funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Puesto */
            String pCodigoP = txtIdPuesto.Text;
            String pNombreP = txtNombrePuesto.Text;
            /*Final obteniedo variables a usar con mi ABC Puesto */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */
            Puesto puesto = new Puesto(pCodigoP,pNombreP,estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar cliente */

            return puesto;
        }
        /* Final de funcion para evitar el uso de recursivo de tantas variables */

        /* Inicio funcion para cargar mi tabla de Puesto */
        private void funCargarTabla(string dato)
        {
            List<Puesto> lista = new List<Puesto>();
            Puesto puesto = new Puesto();

            dgvPuesto.DataSource = puesto.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de Puesto */

        /* Inicio de funcion para vaciar mis campos de Puesto */
        public void funVaciarCampos()
        {
            txtIdPuesto.Text = "";
            txtNombrePuesto.Text = "";
            txtEstatusPuesto.Text = "";
            txtBuscarPuesto.Text = "";
        }

        private void pnlBotonBuscarP_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarPuesto = txtBuscarPuesto.Text;
            funCargarTabla(buscarPuesto);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaP.Visible = false;
            pnlActivarP.Visible = false;
            /* Final Vaciando los campos */
        }

        /* Inicio Llenando campos de mi busqueda en la tabla */
        private void pnlLLenarCamposP_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPuesto.Text = dgvPuesto.CurrentRow.Cells[0].Value.ToString();
            txtNombrePuesto.Text = dgvPuesto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusPuesto.Text = dgvPuesto.CurrentRow.Cells[2].Value.ToString();
        }

        private void pnlModificarP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatusPuesto = "A";
            String idPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatusPuesto);

            puesto.funModificar(idPuesto);
            funCargarTabla(null);
            puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, idPuesto);
        }

        private void pnlLlenarCamposPDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdPuesto.Text = dgvPuesto.CurrentRow.Cells[0].Value.ToString();
            txtNombrePuesto.Text = dgvPuesto.CurrentRow.Cells[1].Value.ToString();
            txtEstatusPuesto.Text = dgvPuesto.CurrentRow.Cells[2].Value.ToString();

            Puesto puesto = new Puesto();
            String pidPuesto = txtIdPuesto.Text;
            String pestatusPuesto = puesto.funBuscarEstatus(pidPuesto);

            if (pestatusPuesto == "A")
            {
                pnlActivarP.Visible = false;
                pnlDarBajaP.Visible = true;
            }
            else if (pestatusPuesto == "I")
            {
                pnlDarBajaP.Visible = false;
                pnlActivarP.Visible = true;
            }
        }

        private void pnlActivarP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatus);

            puesto.funActivarPuesto();
            funCargarTabla(null);

            pnlDarBajaP.Visible = true;
            pnlActivarP.Visible = false;

           puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, pIdPuesto);
        }

        private void pnlDarBajaP_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdPuesto = txtIdPuesto.Text;
            Puesto puesto = funObtenerTxt(estatus);

            puesto.funDarBajaPuesto();
            funCargarTabla(null);

            pnlActivarP.Visible = true;
            pnlDarBajaP.Visible = false;

            puesto.funBuscarSetearTxt(txtIdPuesto, txtNombrePuesto, txtEstatusPuesto, pIdPuesto);
        }

        private void lblPuesto_Click(object sender, EventArgs e)
        {

        }

        private void lblCliente_Click(object sender, EventArgs e)
        {

        }

        private void btnCliente_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverPuesto;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalPuesto;
        }
        /* Final Llenando campos de mi busqueda en la tabla */

    }
}
