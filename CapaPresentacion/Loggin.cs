using CapaEntidad;
using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class Loggin : Form
    {

        private static Loggin _loggin;

        public static Loggin loggin
        {
            get
            {
                if (_loggin == null)
                {
                    _loggin = new Loggin();
                }
                return _loggin;
            }

            set
            {
                if (_loggin == null)
                {
                    _loggin = value;
                }
            }
        }


        public Loggin()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RegistrarseBtn_Click(object sender, EventArgs e)
        {
            Registrarse registrarse = new Registrarse();

            this.Hide();
            
            registrarse.Show();

            
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string usuario = UsuarioLogin.Text;
            string contraseña = ContraseñaLogin.Text;

            N_Usuario objNegocio = N_Usuario.Instance;
            E_Usuario usuarioEncontrado = objNegocio.ListarUsuarios("").FirstOrDefault(u => u.Usuario == usuario && u.Contraseña == contraseña);

            if (usuarioEncontrado != null)
            {
                MessageBox.Show("Inicio de sesión exitoso");
                
                this.Hide();

                E_Usuario.Instacia = usuarioEncontrado;

                Inicio Inicio = Inicio.inicio;
                Inicio.Show();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos");
            }
        }


    }
}


