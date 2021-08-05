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
    public partial class frmRuta : Form
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

        public frmRuta()
        {
            InitializeComponent();

            /* Codigo para redondear mi panel */
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));

            /* Bloqueando form visible*/
            pnlEstatusR.Visible = false;
            pnlBordeRuta.Visible = false;
            lblRegistrarRuta.Visible = false;
            pnlBordeRegistrarR.Visible = false;
            lblModificarRuta.Visible = false;
            pnlBordeModificarR.Visible = false;
            lblDarBajaRuta.Visible = false;
            pnlCampoIdR.Visible = false;
            pnlCampoInicioR.Visible = false;
            txtBuscarRuta.Visible = false;
            pnlBotonBuscarR.Visible = false;
            pnlBotonGuardarR.Visible = false;
            pnlFinalR.Visible = false;
            pnlEstatusR.Visible = false;
            pnlModificarR.Visible = false;
            pnlDarBajaR.Visible = false;
            pnlActivarR.Visible = false;
            pnlLLenarCamposR.Visible = false;
            pnlLlenarCamposRDB.Visible = false;
            dgvRuta.Visible = false;
            pnlBordeDarBajaR.Visible = false;

        }


        private void frmRuta_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void frmRuta_Load(object sender, EventArgs e)
        {
            
        }

        private void pnlRuta_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal obj = new frmPrincipal();

            obj.Visible = true;

            Visible = false;
        }

        private void lblTituloRuta_Click(object sender, EventArgs e)
        {

        }

        private void lblAbcRuta_MouseClick(object sender, MouseEventArgs e)
        {
            pnlBordeRuta.Visible = true;
            lblRegistrarRuta.Visible = true;
            lblModificarRuta.Visible = true;
            lblDarBajaRuta.Visible = true;
        }

        private void lblRegistrarRuta_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio cargando datos en tabla Ruta */
            Ruta ruta = new Ruta();
            funCargarTabla(null);

            pnlEstatusR.Visible = false;
            pnlBordeRegistrarR.Visible = true;
            pnlBordeModificarR.Visible = false;
            pnlBordeDarBajaR.Visible = false;
            pnlCampoIdR.Visible = true;
            pnlCampoInicioR.Visible = true;
            pnlFinalR.Visible = true;
            pnlBotonGuardarR.Visible = true;
            txtBuscarRuta.Visible = true;
            pnlBotonBuscarR.Visible = true;
            pnlLLenarCamposR.Visible = true;
            pnlLlenarCamposRDB.Visible = false;
            pnlModificarR.Visible = false;
            dgvRuta.Visible = true;

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoIdR.Enabled = true;
            pnlCampoInicioR.Enabled = true;
            txtBuscarRuta.Enabled = true;
            pnlBotonBuscarR.Enabled = true;
            pnlLLenarCamposR.Enabled = true;
            pnlFinalR.Enabled = true;
            pnlEstatusR.Enabled = true;
            funVaciarCampos();
        }

        private void lblRegistrarRuta_Click(object sender, EventArgs e)
        {

        }

        private void lblModificarRuta_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();
            funCargarTabla(null);

            pnlBordeRegistrarR.Visible = false;
            pnlBordeModificarR.Visible = true;
            pnlBordeDarBajaR.Visible = false;
            pnlCampoIdR.Visible = true;
            pnlModificarR.Visible = true;
            pnlCampoInicioR.Visible = true;
            pnlFinalR.Visible = true;
            pnlEstatusR.Visible = true;
            pnlBotonGuardarR.Visible = false;
            txtBuscarRuta.Visible = true;
            pnlBotonBuscarR.Visible = true;
            dgvRuta.Visible = true;
            pnlLLenarCamposR.Visible = true;
            pnlLlenarCamposRDB.Visible = false;

            /*inicio deshabilitando y habilitando contenidos de mi form */
            pnlCampoIdR.Enabled = false;
            pnlCampoInicioR.Enabled = true;
            pnlEstatusR.Enabled = false;
            txtBuscarRuta.Enabled = true;
            pnlBotonBuscarR.Enabled = true;
            dgvRuta.Enabled = true;
            pnlLLenarCamposR.Enabled = true;
            pnlFinalR.Enabled = true;
        }

        private void lblDarBajaRuta_MouseClick(object sender, MouseEventArgs e)
        {
            funVaciarCampos();

            pnlCampoIdR.Visible = true;
            pnlCampoInicioR.Visible = true;
            pnlFinalR.Visible = true;
            pnlEstatusR.Visible = true;
            txtBuscarRuta.Visible = true;
            pnlBotonBuscarR.Visible = true;
            dgvRuta.Visible = true;
            pnlLlenarCamposRDB.Visible = true;
            pnlBordeDarBajaR.Visible = true;
            pnlModificarR.Visible = false;
            pnlLLenarCamposR.Visible = false;
            pnlBordeModificarR.Visible = false;





            pnlCampoIdR.Enabled = false;
            pnlCampoInicioR.Enabled = false;
            pnlEstatusR.Enabled = false;
            pnlFinalR.Enabled = false;
            txtBuscarRuta.Enabled = true;
            pnlBotonBuscarR.Enabled = true;
            dgvRuta.Enabled = true;
            pnlLLenarCamposR.Enabled = false;
            pnlLlenarCamposRDB.Enabled = true;
            

            pnlBotonGuardarR.Visible = false;
            pnlModificarR.Visible = false;

            funCargarTabla(null);
        }

        private void btnCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverRuta;
        }
        public void funVaciarCampos()
        {
            txtIdRuta.Text = "";
            txtInicioRuta.Text = "";
            txtFinalRuta.Text = "";
            txtEstatusR.Text = "";
            txtBuscarRuta.Text = "";
        }

        /* Inicio funcion para cargar mi tabla de ruta */
        private void funCargarTabla(string dato)
        {
            List<Ruta> lista = new List<Ruta>();
            Ruta ruta = new Ruta();

            dgvRuta.DataSource = ruta.consulta(dato);
        }
        /* Final funcion para cargar mi tabla de Ruta */

        public Ruta funObtenerTxt(String estatus)
        {
            /*Inicio obteniedo variables a usar con mi ABC Ruta */
            String pCodigoR = txtIdRuta.Text;
            String pInicioR = txtInicioRuta.Text;
            String pFinalR = txtFinalRuta.Text;
            /*Final obteniedo variables a usar con mi ABC Departamento */

            /* Inicio creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */
            Ruta ruta = new Ruta(pCodigoR, pInicioR, pFinalR, estatus);
            /* Final creamos un objeto de tipo cliente para poder utilizar el metodo de insertar Ruta */

            return ruta;
        }

        private void btnCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalRuta;

        }

        private void lblCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverRuta;
        }

        private void picIconoCliente_MouseHover(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorHoverRuta;
        }

        private void picIconoCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalRuta;
        }

        private void lblCliente_MouseLeave(object sender, EventArgs e)
        {
            btnCliente.BackColor = colorNormalRuta;
        }

        private void btnPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverRuta;
        }

        private void btnPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalRuta;
        }

        private void lblPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverRuta;
        }

        private void lblPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalRuta;
        }

        private void picPuesto_MouseHover(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorHoverRuta;
        }

        private void picPuesto_MouseLeave(object sender, EventArgs e)
        {
            btnPuesto.BackColor = colorNormalRuta;
        }

        private void btnDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverRuta;
        }

        private void btnDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalRuta;
        }

        private void lblDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverRuta;
        }

        private void lblDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalRuta;
        }

        private void picDepartamento_MouseHover(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorHoverRuta;
        }

        private void picDepartamento_MouseLeave(object sender, EventArgs e)
        {
            btnDepartamento.BackColor = colorNormalRuta;
        }

        private void btnUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverRuta;
        }

        private void btnUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalRuta;
        }

        private void lblUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverRuta;
        }

        private void lblUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalRuta;
        }

        private void picIconoUbicacion_MouseHover(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorHoverRuta;
        }

        private void picIconoUbicacion_MouseLeave(object sender, EventArgs e)
        {
            btnUbicacion.BackColor = colorNormalRuta;
        }

        private void pnlRuta_MouseHover(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorHoverRuta;
        }

        private void pnlRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorNormalRuta;
        }

        private void lblRuta_MouseHover(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorHoverRuta;
        }

        private void lblRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorNormalRuta;
        }

        private void picIconoRuta_MouseHover(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorHoverRuta;
        }

        private void picIconoRuta_MouseLeave(object sender, EventArgs e)
        {
            pnlRuta.BackColor = colorNormalRuta;
        }

        private void pnlBotonGuardarR_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio de ejecucion de funcion insertar un Ruta */
            String EstatusRuta = "A";
            Ruta ruta = funObtenerTxt(EstatusRuta);
            ruta.funInsertar();
            /* Final de ejecucion de funcion insertar un Ruta */

            funCargarTabla(null);
            funVaciarCampos();
        }

        private void pnlBotonBuscarR_MouseClick(object sender, MouseEventArgs e)
        {
            /* Inicio buscando el dato ingresado por el usuario y llenando mi tabla */
            String buscarRuta = txtBuscarRuta.Text;
            funCargarTabla(buscarRuta);
            /* Final buscando el dato ingresado por el usuario y llenando mi tabla */

            /* Inicio Vaciando los campos */
            funVaciarCampos();
            pnlDarBajaR.Visible = false;

            pnlActivarR.Visible = false;
            /* Final Vaciando los campos */
        }

        private void pnlLLenarCamposR_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdRuta.Text = dgvRuta.CurrentRow.Cells[0].Value.ToString();
            txtInicioRuta.Text = dgvRuta.CurrentRow.Cells[1].Value.ToString();
            txtFinalRuta.Text = dgvRuta.CurrentRow.Cells[2].Value.ToString();
            txtEstatusR.Text = dgvRuta.CurrentRow.Cells[3].Value.ToString();

        }

        private void rutaBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void pnlModificarR_MouseClick(object sender, MouseEventArgs e)
        {
            String EstatusRuta = "A";
            String idRuta = txtIdRuta.Text;
            Ruta ruta = funObtenerTxt(EstatusRuta);

            ruta.funModificar(idRuta);
            funCargarTabla(null);
            ruta.funBuscarSetearTxt(txtIdRuta, txtInicioRuta, txtFinalRuta,txtEstatusR, idRuta);
        }

        private void pnlLlenarCamposRDB_MouseClick(object sender, MouseEventArgs e)
        {
            txtIdRuta.Text = dgvRuta.CurrentRow.Cells[0].Value.ToString();
            txtInicioRuta.Text = dgvRuta.CurrentRow.Cells[1].Value.ToString();
            txtFinalRuta.Text = dgvRuta.CurrentRow.Cells[2].Value.ToString();
            txtEstatusR.Text = dgvRuta.CurrentRow.Cells[3].Value.ToString();

            Ruta ruta = new Ruta();
            String pIdRuta = txtIdRuta.Text;
            String pEstatusRuta = ruta.funBuscarEstatus(pIdRuta);

            if (pEstatusRuta == "A")
            {
                pnlActivarR.Visible = false;
                pnlDarBajaR.Visible = true;
            }
            else if (pEstatusRuta == "I")
            {
                pnlDarBajaR.Visible = false;
                pnlActivarR.Visible = true;
            }
        }

        private void pnlActivarR_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "I";
            String pIdRuta = txtIdRuta.Text;
            Ruta ruta = funObtenerTxt(estatus);

            ruta.funActivarRuta();
            funCargarTabla(null);

            pnlDarBajaR.Visible = true;
            pnlActivarR.Visible = false;

            ruta.funBuscarSetearTxt(txtIdRuta, txtInicioRuta, txtFinalRuta, txtEstatusR, pIdRuta);

        }

        private void pnlDarBajaR_MouseClick(object sender, MouseEventArgs e)
        {
            String estatus = "A";
            String pIdRuta = txtIdRuta.Text;
            Ruta ruta = funObtenerTxt(estatus);

            ruta.funDarBajaRuta();
            funCargarTabla(null);

            pnlActivarR.Visible = true;
            pnlDarBajaR.Visible = false;

            ruta.funBuscarSetearTxt(txtIdRuta, txtInicioRuta, txtFinalRuta, txtEstatusR, pIdRuta);
        }

        private void btnTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverRuta;
        }

        private void btnTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalRuta;
        }

        private void lblTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverRuta;
        }

        private void picTipoEmpleado_MouseHover(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorHoverRuta;
        }

        private void picTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalRuta;
        }

        private void lblTipoEmpleado_MouseLeave(object sender, EventArgs e)
        {
            btnTipoEmpleado.BackColor = colorNormalRuta;
        }
    }
}