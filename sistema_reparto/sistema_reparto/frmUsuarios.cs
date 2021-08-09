using System;
using System.Collections.Generic;
using System.ComponentModel;
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
    public partial class frmUsuarios : Form
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

        Color colorHoverUsuarios = Color.FromArgb(80, 115, 119);
        Color colorNormalUsuarios = Color.FromArgb(59, 102, 107);

        public frmUsuarios()
        {
            InitializeComponent();

            /* Inicio Creando objeto usuario para poder llenar el combobox tipo de permiso*/
            Usuarios usuario = new Usuarios();
            usuario.funLlenarCombo(CboTipoUsuario);
            /* Inicio Creando objeto usuario para poder llenar el combobox tipo de permiso*/

            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
        }

        private void frmUsuarios_Load(object sender, EventArgs e)
        {

        }

        private void frmUsuarios_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal cliente = new frmPrincipal();
            cliente.Visible = true;

            Visible = false;
        }

        private void lblCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal cliente = new frmPrincipal();
            cliente.Visible = true;

            Visible = false;
        }

        private void picIconoCliente_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal cliente = new frmPrincipal();
            cliente.Visible = true;

            Visible = false;
        }

        private void picIconoUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmPrincipal cliente = new frmPrincipal();
            cliente.Visible = true;

            Visible = false;
        }

        private void btnUsuarios_MouseClick(object sender, MouseEventArgs e)
        {
            frmUsuarios usuario = new frmUsuarios();
            usuario.Visible = true;

            Visible = false;
        }

        private void btnPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos puesto = new frmPuestos();
            puesto.Visible = false;
        }

        private void lblPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos puesto = new frmPuestos();
            puesto.Visible = false;
        }

        private void picPuesto_MouseClick(object sender, MouseEventArgs e)
        {
            frmPuestos puesto = new frmPuestos();
            puesto.Visible = false;
        }

        private void CboTipoUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            String valorCombo = CboTipoUsuario.SelectedValue.ToString();


            if (valorCombo == "1")
            {
                /* Inicio Activando Cheques para mi Administrador */
                chkIngresarU.Checked = true;
                chkModificarU.Checked = true;
                chkDarBajaU.Checked = true;
                chkConsultaU.Checked = true;
                chkIngresarC.Checked = true;
                chkModificarC.Checked = true;
                chkDarBajaC.Checked = true;
                chkConsultarC.Checked = true;
                chkIngresarD.Checked = true;
                chkModificarD.Checked = true;
                chkDarBajaD.Checked = true;
                chkConsultarD.Checked = true;
                chkIngresarPu.Checked = true;
                chkModificarPu.Checked = true;
                chkDarBajaPu.Checked = true;
                chkConsultaPu.Checked = true;
                chkIngresarPi.Checked = true;
                chkModificarPi.Checked = true;
                chkDarBajaPi.Checked = true;
                chkConsultaPi.Checked = true;
                chkIngresarEm.Checked = true;
                chkModificarE.Checked = true;
                chkDarBajaE.Checked = true;
                chkConsultaE.Checked = true;
                chkPaqueteEnc.Checked = true;
                chkModificarEnc.Checked = true;
                chkDarBajaPaEnc.Checked = true;
                chkConsultaPaEc.Checked = true;
                chkIngresarPaDe.Checked = true;
                chkModificarPaDet.Checked = true;
                chkDarBajaPaDet.Checked = true;
                chkConsultaDet.Checked = true;
                chkIngresarUb.Checked = true;
                chkModificarUb.Checked = true;
                chkDarBajaUb.Checked = true;
                chkConsultaUb.Checked = true;
                chkIngresarSub.Checked = true;
                chkModificarSub.Checked = true;
                chkDarBajaSub.Checked = true;
                chkConsultaSub.Checked = true;
                chkIngresarBo.Checked = true;
                chkModificarBo.Checked = true;
                chkDarBajaBo.Checked = true;
                chkConsultarBo.Checked = true;
                chkInventario.Checked = true;
                chkModificarIn.Checked = true;
                chkConsultaIn.Checked = true;
                chkConsultarMovBo.Checked = true;
                chkIngresarTipoT.Checked = true;
                chkModificarTiT.Checked = true;
                chkDarBajaTip.Checked = true;
                chkConsultarTip.Checked = true;
                chkIngresarTra.Checked = true;
                chkModificarTra.Checked = true;
                chkDarBajaTra.Checked = true;
                chkConsultarTra.Checked = true;
                chkIngresarRuta.Checked = true;
                chkModificarRu.Checked = true;
                chkDarBajaRu.Checked = true;
                chkConsultarRu.Checked = true;
                chkIngresarEnvio.Checked = true;
                chkModificarEn.Checked = true;
                chkDarBajaEn.Checked = true;
                chkConsultaEn.Checked = true;
                chkInsertarBitaTrans.Checked = true;
                chkModificarBi.Checked = true;
                chkConsultarBTTras.Checked = true;
                chkBitacoraUsuario.Checked = true;
                chkIngresarCalificacion.Checked = true;
                chkModificarCa.Checked = true;
                chkConsultarCa.Checked = true;
                chkReportes.Checked = true;
                /* Final Activando Cheques para mi Administrador */

                /* Inicio deshabilitando checkbox*/
                chkIngresarU.Enabled = false;
                chkModificarU.Enabled = false;
                chkDarBajaU.Enabled = false;
                chkConsultaU.Enabled = false;
                chkIngresarC.Enabled = false;
                chkModificarC.Enabled = false;
                chkDarBajaC.Enabled = false;
                chkConsultarC.Enabled = false;
                chkIngresarD.Enabled = false;
                chkModificarD.Enabled = false;
                chkDarBajaD.Enabled = false;
                chkConsultarD.Enabled = false;
                chkIngresarPu.Enabled = false;
                chkModificarPu.Enabled = false;
                chkDarBajaPu.Enabled = false;
                chkConsultaPu.Enabled = false;
                chkIngresarPi.Enabled = false;
                chkModificarPi.Enabled = false;
                chkDarBajaPi.Enabled = false;
                chkConsultaPi.Enabled = false;
                chkIngresarEm.Enabled = false;
                chkModificarE.Enabled = false;
                chkDarBajaE.Enabled = false;
                chkConsultaE.Enabled = false;
                chkPaqueteEnc.Enabled = false;
                chkModificarEnc.Enabled = false;
                chkDarBajaPaEnc.Enabled = false;
                chkConsultaPaEc.Enabled = false;
                chkIngresarPaDe.Enabled = false;
                chkModificarPaDet.Enabled = false;
                chkDarBajaPaDet.Enabled = false;
                chkConsultaDet.Enabled = false;
                chkIngresarUb.Enabled = false;
                chkModificarUb.Enabled = false;
                chkDarBajaUb.Enabled = false;
                chkConsultaUb.Enabled = false;
                chkIngresarSub.Enabled = false;
                chkModificarSub.Enabled = false;
                chkDarBajaSub.Enabled = false;
                chkConsultaSub.Enabled = false;
                chkIngresarBo.Enabled = false;
                chkModificarBo.Enabled = false;
                chkDarBajaBo.Enabled = false;
                chkConsultarBo.Enabled = false;
                chkInventario.Enabled = false;
                chkModificarIn.Enabled = false;
                chkConsultaIn.Enabled = false;
                chkConsultarMovBo.Enabled = false;
                chkIngresarTipoT.Enabled = false;
                chkModificarTiT.Enabled = false;
                chkDarBajaTip.Enabled = false;
                chkConsultarTip.Enabled = false;
                chkIngresarTra.Enabled = false;
                chkModificarTra.Enabled = false;
                chkDarBajaTra.Enabled = false;
                chkConsultarTra.Enabled = false;
                chkIngresarRuta.Enabled = false;
                chkModificarRu.Enabled = false;
                chkDarBajaRu.Enabled = false;
                chkConsultarRu.Enabled = false;
                chkIngresarEnvio.Enabled = false;
                chkModificarEn.Enabled = false;
                chkDarBajaEn.Enabled = false;
                chkConsultaEn.Enabled = false;
                chkInsertarBitaTrans.Enabled = false;
                chkModificarBi.Enabled = false;
                chkConsultarBTTras.Enabled = false;
                chkBitacoraUsuario.Enabled = false;
                chkIngresarCalificacion.Enabled = false;
                chkModificarCa.Enabled = false;
                chkConsultarCa.Enabled = false;
                chkReportes.Enabled = false;
                /* Final deshabilitando checkbox*/
            }
            else if (valorCombo == "2")
            {
                /* Inicio Activando Cheques para mi Invitado */
                chkIngresarU.Checked = false;
                chkModificarU.Checked = false;
                chkDarBajaU.Checked = false;
                chkConsultaU.Checked = false;
                chkIngresarC.Checked = false;
                chkModificarC.Checked = false;
                chkDarBajaC.Checked = false;
                chkConsultarC.Checked = false;
                chkIngresarD.Checked = false;
                chkModificarD.Checked = false;
                chkDarBajaD.Checked = false;
                chkConsultarD.Checked = false;
                chkIngresarPu.Checked = false;
                chkModificarPu.Checked = false;
                chkDarBajaPu.Checked = false;
                chkConsultaPu.Checked = false;
                chkIngresarPi.Checked = false;
                chkModificarPi.Checked = false;
                chkDarBajaPi.Checked = false;
                chkConsultaPi.Checked = false;
                chkIngresarEm.Checked = false;
                chkModificarE.Checked = false;
                chkDarBajaE.Checked = false;
                chkConsultaE.Checked = false;
                chkPaqueteEnc.Checked = false;
                chkModificarEnc.Checked = false;
                chkDarBajaPaEnc.Checked = false;
                chkConsultaPaEc.Checked = false;
                chkIngresarPaDe.Checked = false;
                chkModificarPaDet.Checked = false;
                chkDarBajaPaDet.Checked = false;
                chkConsultaDet.Checked = false;
                chkIngresarUb.Checked = false;
                chkModificarUb.Checked = false;
                chkDarBajaUb.Checked = false;
                chkConsultaUb.Checked = false;
                chkIngresarSub.Checked = false;
                chkModificarSub.Checked = false;
                chkDarBajaSub.Checked = false;
                chkConsultaSub.Checked = false;
                chkIngresarBo.Checked = false;
                chkModificarBo.Checked = false;
                chkDarBajaBo.Checked = false;
                chkConsultarBo.Checked = false;
                chkInventario.Checked = false;
                chkModificarIn.Checked = false;
                chkConsultaIn.Checked = false;
                chkConsultarMovBo.Checked = false;
                chkIngresarTipoT.Checked = false;
                chkModificarTiT.Checked = false;
                chkDarBajaTip.Checked = false;
                chkConsultarTip.Checked = false;
                chkIngresarTra.Checked = false;
                chkModificarTra.Checked = false;
                chkDarBajaTra.Checked = false;
                chkConsultarTra.Checked = false;
                chkIngresarRuta.Checked = false;
                chkModificarRu.Checked = false;
                chkDarBajaRu.Checked = false;
                chkConsultarRu.Checked = false;
                chkIngresarEnvio.Checked = false;
                chkModificarEn.Checked = false;
                chkDarBajaEn.Checked = false;
                chkConsultaEn.Checked = true;
                chkInsertarBitaTrans.Checked = false;
                chkModificarBi.Checked = false;
                chkConsultarBTTras.Checked = false;
                chkBitacoraUsuario.Checked = false;
                chkIngresarCalificacion.Checked = true;
                chkModificarCa.Checked = true;
                chkConsultarCa.Checked = true;
                chkReportes.Checked = false;
                /* Final Activando Cheques para mi Invitado */

                /* Inicio deshabilitando checkbox*/
                chkIngresarU.Enabled = false;
                chkModificarU.Enabled = false;
                chkDarBajaU.Enabled = false;
                chkConsultaU.Enabled = false;
                chkIngresarC.Enabled = false;
                chkModificarC.Enabled = false;
                chkDarBajaC.Enabled = false;
                chkConsultarC.Enabled = false;
                chkIngresarD.Enabled = false;
                chkModificarD.Enabled = false;
                chkDarBajaD.Enabled = false;
                chkConsultarD.Enabled = false;
                chkIngresarPu.Enabled = false;
                chkModificarPu.Enabled = false;
                chkDarBajaPu.Enabled = false;
                chkConsultaPu.Enabled = false;
                chkIngresarPi.Enabled = false;
                chkModificarPi.Enabled = false;
                chkDarBajaPi.Enabled = false;
                chkConsultaPi.Enabled = false;
                chkIngresarEm.Enabled = false;
                chkModificarE.Enabled = false;
                chkDarBajaE.Enabled = false;
                chkConsultaE.Enabled = false;
                chkPaqueteEnc.Enabled = false;
                chkModificarEnc.Enabled = false;
                chkDarBajaPaEnc.Enabled = false;
                chkConsultaPaEc.Enabled = false;
                chkIngresarPaDe.Enabled = false;
                chkModificarPaDet.Enabled = false;
                chkDarBajaPaDet.Enabled = false;
                chkConsultaDet.Enabled = false;
                chkIngresarUb.Enabled = false;
                chkModificarUb.Enabled = false;
                chkDarBajaUb.Enabled = false;
                chkConsultaUb.Enabled = false;
                chkIngresarSub.Enabled = false;
                chkModificarSub.Enabled = false;
                chkDarBajaSub.Enabled = false;
                chkConsultaSub.Enabled = false;
                chkIngresarBo.Enabled = false;
                chkModificarBo.Enabled = false;
                chkDarBajaBo.Enabled = false;
                chkConsultarBo.Enabled = false;
                chkInventario.Enabled = false;
                chkModificarIn.Enabled = false;
                chkConsultaIn.Enabled = false;
                chkConsultarMovBo.Enabled = false;
                chkIngresarTipoT.Enabled = false;
                chkModificarTiT.Enabled = false;
                chkDarBajaTip.Enabled = false;
                chkConsultarTip.Enabled = false;
                chkIngresarTra.Enabled = false;
                chkModificarTra.Enabled = false;
                chkDarBajaTra.Enabled = false;
                chkConsultarTra.Enabled = false;
                chkIngresarRuta.Enabled = false;
                chkModificarRu.Enabled = false;
                chkDarBajaRu.Enabled = false;
                chkConsultarRu.Enabled = false;
                chkIngresarEnvio.Enabled = false;
                chkModificarEn.Enabled = false;
                chkDarBajaEn.Enabled = false;
                chkConsultaEn.Enabled = false;
                chkInsertarBitaTrans.Enabled = false;
                chkModificarBi.Enabled = false;
                chkConsultarBTTras.Enabled = false;
                chkBitacoraUsuario.Enabled = false;
                chkIngresarCalificacion.Enabled = false;
                chkModificarCa.Enabled = false;
                chkConsultarCa.Enabled = false;
                chkReportes.Enabled = false;
                /* Final deshabilitando checkbox*/
            }
            else if (valorCombo == "3")
            {
                /* Inicio Activando Cheques para mi Piloto */
                chkIngresarU.Checked = false;
                chkModificarU.Checked = false;
                chkDarBajaU.Checked = false;
                chkConsultaU.Checked = false;
                chkIngresarC.Checked = false;
                chkModificarC.Checked = false;
                chkDarBajaC.Checked = false;
                chkConsultarC.Checked = false;
                chkIngresarD.Checked = false;
                chkModificarD.Checked = false;
                chkDarBajaD.Checked = false;
                chkConsultarD.Checked = false;
                chkIngresarPu.Checked = false;
                chkModificarPu.Checked = false;
                chkDarBajaPu.Checked = false;
                chkConsultaPu.Checked = false;
                chkIngresarPi.Checked = false;
                chkModificarPi.Checked = false;
                chkDarBajaPi.Checked = false;
                chkConsultaPi.Checked = false;
                chkIngresarEm.Checked = false;
                chkModificarE.Checked = false;
                chkDarBajaE.Checked = false;
                chkConsultaE.Checked = false;
                chkPaqueteEnc.Checked = false;
                chkModificarEnc.Checked = false;
                chkDarBajaPaEnc.Checked = false;
                chkConsultaPaEc.Checked = false;
                chkIngresarPaDe.Checked = false;
                chkModificarPaDet.Checked = false;
                chkDarBajaPaDet.Checked = false;
                chkConsultaDet.Checked = false;
                chkIngresarUb.Checked = false;
                chkModificarUb.Checked = false;
                chkDarBajaUb.Checked = false;
                chkConsultaUb.Checked = false;
                chkIngresarSub.Checked = false;
                chkModificarSub.Checked = false;
                chkDarBajaSub.Checked = false;
                chkConsultaSub.Checked = false;
                chkIngresarBo.Checked = false;
                chkModificarBo.Checked = false;
                chkDarBajaBo.Checked = false;
                chkConsultarBo.Checked = false;
                chkInventario.Checked = false;
                chkModificarIn.Checked = false;
                chkConsultaIn.Checked = false;
                chkConsultarMovBo.Checked = false;
                chkIngresarTipoT.Checked = false;
                chkModificarTiT.Checked = false;
                chkDarBajaTip.Checked = false;
                chkConsultarTip.Checked = false;
                chkIngresarTra.Checked = false;
                chkModificarTra.Checked = false;
                chkDarBajaTra.Checked = false;
                chkConsultarTra.Checked = true;
                chkIngresarRuta.Checked = false;
                chkModificarRu.Checked = false;
                chkDarBajaRu.Checked = false;
                chkConsultarRu.Checked = true;
                chkIngresarEnvio.Checked = false;
                chkModificarEn.Checked = true;
                chkDarBajaEn.Checked = false;
                chkConsultaEn.Checked = true;
                chkInsertarBitaTrans.Checked = true;
                chkModificarBi.Checked = true;
                chkConsultarBTTras.Checked = true;
                chkBitacoraUsuario.Checked = false;
                chkIngresarCalificacion.Checked = false;
                chkModificarCa.Checked = false;
                chkConsultarCa.Checked = false;
                chkReportes.Checked = false;
                /* Final Activando Cheques para mi Piloto */

                /* Inicio deshabilitando checkbox*/
                chkIngresarU.Enabled = false;
                chkModificarU.Enabled = false;
                chkDarBajaU.Enabled = false;
                chkConsultaU.Enabled = false;
                chkIngresarC.Enabled = false;
                chkModificarC.Enabled = false;
                chkDarBajaC.Enabled = false;
                chkConsultarC.Enabled = false;
                chkIngresarD.Enabled = false;
                chkModificarD.Enabled = false;
                chkDarBajaD.Enabled = false;
                chkConsultarD.Enabled = false;
                chkIngresarPu.Enabled = false;
                chkModificarPu.Enabled = false;
                chkDarBajaPu.Enabled = false;
                chkConsultaPu.Enabled = false;
                chkIngresarPi.Enabled = false;
                chkModificarPi.Enabled = false;
                chkDarBajaPi.Enabled = false;
                chkConsultaPi.Enabled = false;
                chkIngresarEm.Enabled = false;
                chkModificarE.Enabled = false;
                chkDarBajaE.Enabled = false;
                chkConsultaE.Enabled = false;
                chkPaqueteEnc.Enabled = false;
                chkModificarEnc.Enabled = false;
                chkDarBajaPaEnc.Enabled = false;
                chkConsultaPaEc.Enabled = false;
                chkIngresarPaDe.Enabled = false;
                chkModificarPaDet.Enabled = false;
                chkDarBajaPaDet.Enabled = false;
                chkConsultaDet.Enabled = false;
                chkIngresarUb.Enabled = false;
                chkModificarUb.Enabled = false;
                chkDarBajaUb.Enabled = false;
                chkConsultaUb.Enabled = false;
                chkIngresarSub.Enabled = false;
                chkModificarSub.Enabled = false;
                chkDarBajaSub.Enabled = false;
                chkConsultaSub.Enabled = false;
                chkIngresarBo.Enabled = false;
                chkModificarBo.Enabled = false;
                chkDarBajaBo.Enabled = false;
                chkConsultarBo.Enabled = false;
                chkInventario.Enabled = false;
                chkModificarIn.Enabled = false;
                chkConsultaIn.Enabled = false;
                chkConsultarMovBo.Enabled = false;
                chkIngresarTipoT.Enabled = false;
                chkModificarTiT.Enabled = false;
                chkDarBajaTip.Enabled = false;
                chkConsultarTip.Enabled = false;
                chkIngresarTra.Enabled = false;
                chkModificarTra.Enabled = false;
                chkDarBajaTra.Enabled = false;
                chkConsultarTra.Enabled = false;
                chkIngresarRuta.Enabled = false;
                chkModificarRu.Enabled = false;
                chkDarBajaRu.Enabled = false;
                chkConsultarRu.Enabled = false;
                chkIngresarEnvio.Enabled = false;
                chkModificarEn.Enabled = false;
                chkDarBajaEn.Enabled = false;
                chkConsultaEn.Enabled = false;
                chkInsertarBitaTrans.Enabled = false;
                chkModificarBi.Enabled = false;
                chkConsultarBTTras.Enabled = false;
                chkBitacoraUsuario.Enabled = false;
                chkIngresarCalificacion.Enabled = false;
                chkModificarCa.Enabled = false;
                chkConsultarCa.Enabled = false;
                chkReportes.Enabled = false;
                /* Final deshabilitando checkbox*/
            }
            else if (valorCombo == "4")
            {
                /* Inicio Activando Cheques para tipo usuario especifico */
                chkIngresarU.Checked = false;
                chkModificarU.Checked = false;
                chkDarBajaU.Checked = false;
                chkConsultaU.Checked = false;
                chkIngresarC.Checked = false;
                chkModificarC.Checked = false;
                chkDarBajaC.Checked = false;
                chkConsultarC.Checked = false;
                chkIngresarD.Checked = false;
                chkModificarD.Checked = false;
                chkDarBajaD.Checked = false;
                chkConsultarD.Checked = false;
                chkIngresarPu.Checked = false;
                chkModificarPu.Checked = false;
                chkDarBajaPu.Checked = false;
                chkConsultaPu.Checked = false;
                chkIngresarPi.Checked = false;
                chkModificarPi.Checked = false;
                chkDarBajaPi.Checked = false;
                chkConsultaPi.Checked = false;
                chkIngresarEm.Checked = false;
                chkModificarE.Checked = false;
                chkDarBajaE.Checked = false;
                chkConsultaE.Checked = false;
                chkPaqueteEnc.Checked = false;
                chkModificarEnc.Checked = false;
                chkDarBajaPaEnc.Checked = false;
                chkConsultaPaEc.Checked = false;
                chkIngresarPaDe.Checked = false;
                chkModificarPaDet.Checked = false;
                chkDarBajaPaDet.Checked = false;
                chkConsultaDet.Checked = false;
                chkIngresarUb.Checked = false;
                chkModificarUb.Checked = false;
                chkDarBajaUb.Checked = false;
                chkConsultaUb.Checked = false;
                chkIngresarSub.Checked = false;
                chkModificarSub.Checked = false;
                chkDarBajaSub.Checked = false;
                chkConsultaSub.Checked = false;
                chkIngresarBo.Checked = false;
                chkModificarBo.Checked = false;
                chkDarBajaBo.Checked = false;
                chkConsultarBo.Checked = false;
                chkInventario.Checked = false;
                chkModificarIn.Checked = false;
                chkConsultaIn.Checked = false;
                chkConsultarMovBo.Checked = false;
                chkIngresarTipoT.Checked = false;
                chkModificarTiT.Checked = false;
                chkDarBajaTip.Checked = false;
                chkConsultarTip.Checked = false;
                chkIngresarTra.Checked = false;
                chkModificarTra.Checked = false;
                chkDarBajaTra.Checked = false;
                chkConsultarTra.Checked = false;
                chkIngresarRuta.Checked = false;
                chkModificarRu.Checked = false;
                chkDarBajaRu.Checked = false;
                chkConsultarRu.Checked = false;
                chkIngresarEnvio.Checked = false;
                chkModificarEn.Checked = false;
                chkDarBajaEn.Checked = false;
                chkConsultaEn.Checked = false;
                chkInsertarBitaTrans.Checked = false;
                chkModificarBi.Checked = false;
                chkConsultarBTTras.Checked = false;
                chkBitacoraUsuario.Checked = false;
                chkIngresarCalificacion.Checked = false;
                chkModificarCa.Checked = false;
                chkConsultarCa.Checked = false;
                chkReportes.Checked = false;
                /* Final Activando Cheques para tipo usuario especifico */

                /* Inicio habilitando checkbox*/
                chkIngresarU.Enabled = true;
                chkModificarU.Enabled = true;
                chkDarBajaU.Enabled = true;
                chkConsultaU.Enabled = true;
                chkIngresarC.Enabled = true;
                chkModificarC.Enabled = true;
                chkDarBajaC.Enabled = true;
                chkConsultarC.Enabled = true;
                chkIngresarD.Enabled = true;
                chkModificarD.Enabled = true;
                chkDarBajaD.Enabled = true;
                chkConsultarD.Enabled = true;
                chkIngresarPu.Enabled = true;
                chkModificarPu.Enabled = true;
                chkDarBajaPu.Enabled = true;
                chkConsultaPu.Enabled = true;
                chkIngresarPi.Enabled = true;
                chkModificarPi.Enabled = true;
                chkDarBajaPi.Enabled = true;
                chkConsultaPi.Enabled = true;
                chkIngresarEm.Enabled = true;
                chkModificarE.Enabled = true;
                chkDarBajaE.Enabled = true;
                chkConsultaE.Enabled = true;
                chkPaqueteEnc.Enabled = true;
                chkModificarEnc.Enabled = true;
                chkDarBajaPaEnc.Enabled = true;
                chkConsultaPaEc.Enabled = true;
                chkIngresarPaDe.Enabled = true;
                chkModificarPaDet.Enabled = true;
                chkDarBajaPaDet.Enabled = true;
                chkConsultaDet.Enabled = true;
                chkIngresarUb.Enabled = true;
                chkModificarUb.Enabled = true;
                chkDarBajaUb.Enabled = true;
                chkConsultaUb.Enabled = true;
                chkIngresarSub.Enabled = true;
                chkModificarSub.Enabled = true;
                chkDarBajaSub.Enabled = true;
                chkConsultaSub.Enabled = true;
                chkIngresarBo.Enabled = true;
                chkModificarBo.Enabled = true;
                chkDarBajaBo.Enabled = true;
                chkConsultarBo.Enabled = true;
                chkInventario.Enabled = true;
                chkModificarIn.Enabled = true;
                chkConsultaIn.Enabled = true;
                chkConsultarMovBo.Enabled = true;
                chkIngresarTipoT.Enabled = true;
                chkModificarTiT.Enabled = true;
                chkDarBajaTip.Enabled = true;
                chkConsultarTip.Enabled = true;
                chkIngresarTra.Enabled = true;
                chkModificarTra.Enabled = true;
                chkDarBajaTra.Enabled = true;
                chkConsultarTra.Enabled = true;
                chkIngresarRuta.Enabled = true;
                chkModificarRu.Enabled = true;
                chkDarBajaRu.Enabled = true;
                chkConsultarRu.Enabled = true;
                chkIngresarEnvio.Enabled = true;
                chkModificarEn.Enabled = true;
                chkDarBajaEn.Enabled = true;
                chkConsultaEn.Enabled = true;
                chkInsertarBitaTrans.Enabled = true;
                chkModificarBi.Enabled = true;
                chkConsultarBTTras.Enabled = true;
                chkBitacoraUsuario.Enabled = true;
                chkIngresarCalificacion.Enabled = true;
                chkModificarCa.Enabled = true;
                chkConsultarCa.Enabled = true;
                chkReportes.Enabled = true;
                /* Final habiidatando checkbox*/
            }

        }

        private void pnlBotonGuardarUS_MouseClick(object sender, MouseEventArgs e)
        {
            String idUsuario = txtCodigoUsuario.Text;
            String idTipoOermiso = CboTipoUsuario.SelectedValue.ToString();
            String codigoPermiso = txtCodigoP.Text;
            String nombreUsuario = txtUsuario.Text;
            String passUsuario = txtContraseñaU.Text;
            String estatusUsuario = "A";

            int ingresarUsuario = funBoolCheck(chkIngresarU);
            int modificarUsuario = funBoolCheck(chkModificarU);
            int dbUsuario = funBoolCheck(chkDarBajaU);
            int consultaUsuario = funBoolCheck(chkConsultaU);
            int ingresarCliente = funBoolCheck(chkIngresarC);
            int modificarCliente = funBoolCheck(chkModificarC);
            int dbCliente = funBoolCheck(chkDarBajaC);
            int consultaCliente = funBoolCheck(chkConsultarC);
            int ingresarDep = funBoolCheck(chkIngresarD);
            int modificarDep = funBoolCheck(chkModificarD);
            int dbDep = funBoolCheck(chkDarBajaD);
            int consultarDep = funBoolCheck(chkConsultarD);
            int ingresarPuesto = funBoolCheck(chkIngresarPu);
            int modificarPuesto = funBoolCheck(chkModificarPu);
            int dbPuesto = funBoolCheck(chkDarBajaPu);
            int consultarPuesto = funBoolCheck(chkConsultaPu);
            int ingresarPiloto = funBoolCheck(chkIngresarPi);
            int modificarPiloto = funBoolCheck(chkModificarPi);
            int dbPiloto = funBoolCheck(chkDarBajaPi);
            int consultaPiloto = funBoolCheck(chkConsultaPi);
            int ingresarEmpleado = funBoolCheck(chkIngresarEm);
            int modificarEmpleado = funBoolCheck(chkModificarE);
            int dbEmpleado = funBoolCheck(chkDarBajaE);
            int consultarEmpleado = funBoolCheck(chkConsultaE);
            int ingresarPaqueteEnc = funBoolCheck(chkPaqueteEnc);
            int modificarPaqueteEnc = funBoolCheck(chkModificarEnc);
            int dbpaqueteEnc = funBoolCheck(chkDarBajaPaEnc);
            int consultaPaqueteEnc = funBoolCheck(chkConsultaPaEc);
            int ingresarPaqueteDet = funBoolCheck(chkIngresarPaDe);
            int modificarPaqueteDet = funBoolCheck(chkModificarPaDet);
            int dbPaqueteDet = funBoolCheck(chkDarBajaPaDet);
            int consultaPaqueteDet = funBoolCheck(chkConsultaDet);
            int ingresarUbicacion = funBoolCheck(chkIngresarUb);
            int modificarUbicacion = funBoolCheck(chkModificarUb);
            int dbUbicacion = funBoolCheck(chkDarBajaUb);
            int consultaUbicacion = funBoolCheck(chkConsultaUb);
            int ingresarSububicacion = funBoolCheck(chkIngresarSub);
            int modificarSububicacion = funBoolCheck(chkModificarSub);
            int dbSububicacion = funBoolCheck(chkDarBajaSub);
            int consultaSububicion = funBoolCheck(chkConsultaSub);
            int ingresarBodega = funBoolCheck(chkIngresarBo);
            int modificarBodega = funBoolCheck(chkModificarBo);
            int dbBodega = funBoolCheck(chkDarBajaBo);
            int consultarBodega = funBoolCheck(chkConsultarBo);
            int ingresarInven = funBoolCheck(chkInventario);
            int modificarInven = funBoolCheck(chkModificarIn);
            int consultarInven = funBoolCheck(chkConsultaIn);
            int consultarMovBo = funBoolCheck(chkConsultarMovBo);
            int ingresarTipoTrans = funBoolCheck(chkIngresarTipoT);
            int modificarTipoTrans = funBoolCheck(chkModificarTiT);
            int dbTipoTrans = funBoolCheck(chkDarBajaTip);
            int consultaTipoTrans = funBoolCheck(chkConsultarTip);
            int ingresarTrans = funBoolCheck(chkIngresarTra);
            int modificarTrans = funBoolCheck(chkModificarTra);
            int dbTrans = funBoolCheck(chkDarBajaTra);
            int consultarTrans = funBoolCheck(chkConsultarTra);
            int ingresarRuta = funBoolCheck(chkIngresarRuta);
            int modificarRuta = funBoolCheck(chkModificarRu);
            int dbRuta = funBoolCheck(chkDarBajaRu);
            int consultaRuta = funBoolCheck(chkConsultarRu);
            int ingresarEnvio = funBoolCheck(chkIngresarEnvio);
            int modificarEnvio = funBoolCheck(chkModificarEn);
            int dbEnvio = funBoolCheck(chkDarBajaEn);
            int consultaEnvio = funBoolCheck(chkConsultaEn);
            int ingresarBitacoraTrans = funBoolCheck(chkInsertarBitaTrans);
            int modificarBitacoraTrans = funBoolCheck(chkModificarBi);
            int consultarBitacoraTrans = funBoolCheck(chkConsultarBTTras);
            int BitacoraUS = funBoolCheck(chkBitacoraUsuario);
            int ingresarCalificacion = funBoolCheck(chkIngresarCalificacion);
            int modificarCalificacion = funBoolCheck(chkModificarCa);
            int consultarCalificacion = funBoolCheck(chkConsultarCa);
            int reportes = funBoolCheck(chkReportes);


            Usuarios usuario = new Usuarios(idUsuario, idTipoOermiso, nombreUsuario, passUsuario, estatusUsuario, codigoPermiso, ingresarUsuario, modificarUsuario, dbUsuario,
            consultaUsuario, ingresarCliente, modificarCliente, dbCliente, consultaCliente, ingresarDep, modificarDep, dbDep, consultarDep, ingresarPuesto,
            modificarPuesto, dbPuesto, consultarPuesto, ingresarPiloto, modificarPiloto, dbPiloto, consultaPiloto, ingresarEmpleado, modificarEmpleado,
            dbEmpleado, consultarEmpleado, ingresarPaqueteEnc, modificarPaqueteEnc, dbpaqueteEnc, consultaPaqueteEnc, ingresarPaqueteDet, modificarPaqueteDet,
            dbPaqueteDet, consultaPaqueteDet, ingresarUbicacion, modificarUbicacion, dbUbicacion, consultaUbicacion, ingresarSububicacion, modificarSububicacion,
            dbSububicacion, consultaSububicion, ingresarBodega, modificarBodega, dbBodega, consultarBodega, ingresarInven, modificarInven, consultarInven,
            consultarMovBo, ingresarTipoTrans, modificarTipoTrans, dbTipoTrans, consultaTipoTrans, ingresarTrans, modificarTrans, dbTrans, consultarTrans,
            ingresarRuta, modificarRuta, dbRuta, consultaRuta, ingresarEnvio, modificarEnvio, dbEnvio, consultaEnvio, ingresarBitacoraTrans, modificarBitacoraTrans,
            consultarBitacoraTrans, BitacoraUS, ingresarCalificacion, modificarCalificacion, consultarCalificacion, reportes);

            usuario.funInsertarPermisos();
            usuario.funInsertarUsuario();
        }

        public int funBoolCheck(CheckBox check)
        {
            int estadoBolean = 0;

            if(check.Checked == true)
            {
                estadoBolean = 1;
            }
            else if(check.Checked == false)
            {
                estadoBolean = 0;
            }

            return estadoBolean;
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
            btnPaqueteEncabezado.BackColor = colorHoverUsuarios;
        }

        private void lblPaqueteEncabezado_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverUsuarios;
        }

        private void picIconoPaqueteE_MouseHover(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorHoverUsuarios;
        }

        private void btnPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUsuarios;
        }

        private void lblPaqueteEncabezado_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUsuarios;
        }

        private void picIconoPaqueteE_MouseLeave(object sender, EventArgs e)
        {
            btnPaqueteEncabezado.BackColor = colorNormalUsuarios;
        }

        private void pnlEmpleado_MouseClick(object sender, MouseEventArgs e)
        {
            frmEmpleado obj = new frmEmpleado();

            obj.Visible = true;

            Visible = false;
        }
    }
}
