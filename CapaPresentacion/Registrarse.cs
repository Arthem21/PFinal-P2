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
    public partial class Registrarse : Form
    {
        public Registrarse()
        {
            InitializeComponent();
        }

        private Loggin login= Loggin.loggin;

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void RegistrarUsuario()
        {
            // Crear una nueva instancia de E_Usuario
            E_Usuario nuevoUsuario = new E_Usuario();

            // Asignar los valores de los campos de texto a las propiedades del usuario
            nuevoUsuario.Nombre = NombreTb.Text;
            nuevoUsuario.Apellido = ApellidoTb.Text;
            nuevoUsuario.Usuario = UsuarioTb.Text;
            nuevoUsuario.Contraseña = ContraseñaTb.Text;
            nuevoUsuario.Fecha = FechaDtp.Value.ToString("yyyy-MM-dd");
            

            if (GeneralRbtn.Checked) 
            {
                nuevoUsuario.Tipo = "General";
            }

            else if (AdminRbtn.Checked)
            {
                nuevoUsuario.Tipo = "Administrador";
            }


            try
            {
                
                N_Usuario.Instance.guardar_Usuario(nuevoUsuario);
                MessageBox.Show("Usuario registrado exitosamente");

                login.Show();
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar el usuario: " + ex.Message);
            }
        }

        


        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            login.Show();
            Close();
        }

        private void bunifuImageButton1_Click1(object sender, EventArgs e)
        {
            RegistrarUsuario();
        }
    }
}
