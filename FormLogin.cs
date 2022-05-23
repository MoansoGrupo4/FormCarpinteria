using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica;
using CapaEntidad;
namespace FormCarpinteria
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        LogEmpleado User = new LogEmpleado();
       
        private void LoginUsuario_Load(object sender, EventArgs e)
        {
        }

        private void NomEmpresa_Click(object sender, EventArgs e)
        {
            NomEmpresa.BackColor = Color.Transparent;
        }

   
        private void msgError(string msg)
        {
            labelSMSError.Text = "    " + msg;
            labelSMSError.Visible = true;
        }
        private void textBoxUsuario_TextChanged(object sender, EventArgs e){
            
        }
        private void labelSMSError_Click(object sender, EventArgs e)
        {

        }

        private void textBoxContra_TextChanged(object sender, EventArgs e)
        {

        }
        private void labelUsuario_Click(object sender, EventArgs e)
        {

        }
        private void btnAcceso_Click(object sender, EventArgs e)
        {
            if (textBoxUsuario.Text != "")
            {
                if (textBoxContra.Text != "")
                {
                    var validarLogin = User.loginUser(textBoxUsuario.Text, textBoxContra.Text);
                    if(validarLogin == true)
                    {
                        FormPrincipal mainMenu = new FormPrincipal();
                        mainMenu.Show();
                        mainMenu.FormClosed += CerrarSesion;
                        this.Hide();//ocultar formulario login
                    }
                    else
                    {
                        msgError("Nombre de usuario o contraseña ingresados\nincorrectamente. Vuelva a intentarlo.");
                        textBoxUsuario.Clear();
                        textBoxContra.Clear();
                    }
                }
                else msgError("Por favor, Ingrese Contraseña");
            }
            else msgError("Por favor, Ingrese Nombre de Usuario");

        }

       private void CerrarSesion(object sender,FormClosedEventArgs e)
        {
            textBoxUsuario.Clear();
            textBoxContra.Clear();
            labelSMSError.Visible = true;
            this.Show();//mostrar formulario loginn
            textBoxUsuario.Focus();
        }
    }
}
