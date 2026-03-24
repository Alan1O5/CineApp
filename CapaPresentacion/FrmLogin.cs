using System; 
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; 
using System.Drawing; 
using System.Linq; 
using System.Text; 

using System.Threading.Tasks; 
using System.Windows.Forms; 
using CapaDatos;
using CapaNegocio; 
namespace CapaPresentacion 
{ 
    public partial class FrmLogin : Form 
    { 
        public FrmLogin() 
        { 
            InitializeComponent(); 
        } 
        
        
        private void FrmLogin_Load(object sender, EventArgs e) 
        { 
            this.AcceptButton = btnsiguiente; 

        }

        private void txtuser_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void btnsiguiente_Click_1(object sender, EventArgs e)
        {
            if (txtuser.Text == "" || txtclave.Text == "")
            {
                MessageBox.Show("Ingrese usuario y contraseña");
                return;
            }

            DataTable dt = CNUsuarios.Login(txtuser.Text.Trim(), txtclave.Text.Trim());

            if (dt.Rows.Count > 0)
            {

                string usuario = dt.Rows[0]["nombre"].ToString();
                Session.UsuarioActual = usuario;

            
                Session.IdEmpleado = Convert.ToInt32(dt.Rows[0]["idusuario"]);

                int loginId = CNUsuarios.RegistrarLogin(usuario);
                Session.LoginId = loginId;

                FrmMenu menu = new FrmMenu();
                menu.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtclave.Clear();
                txtclave.Focus();
            }
        }

        private void btnsalir_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelLogin_Paint(object sender, PaintEventArgs e)
        {

        }
    }
} 