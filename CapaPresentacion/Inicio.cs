using CapaEntidad;
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
    public partial class Inicio : Form
    {
        private static Inicio _inicio;

        

        public static Inicio inicio
        {
            get
            {
                if (_inicio == null)
                {
                    _inicio = new Inicio();
                }
                return _inicio;
            }

            set
            {
                if (_inicio == null)
                {
                    _inicio = value;
                }
            }
        }


        public Inicio()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            RegistrarVisita registrarVisita = new RegistrarVisita();

            this.Visible = false;

            registrarVisita.ShowDialog();
            
            
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            Listado listado = new Listado();

            this.Visible = false;

            listado.ShowDialog();


        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            E_Usuario usuario = E_Usuario.Instacia;

            if (usuario.Tipo == "Administrador")
            {
                AbrirListado.Visible = true;
                AbrirRegistroAula.Visible = true;
                AbrirRegistroEdificio.Visible = true;
            }

            else
            {

            }
        }

        private void AbrirRegistroAula_Click(object sender, EventArgs e)
        {
            RegistroAula registroAula = new RegistroAula();

            this.Visible = false;

            registroAula.ShowDialog();
        }

        private void AbrirRegistroEdificio_Click(object sender, EventArgs e)
        {
            RegistroEdificios registroEdificios = new RegistroEdificios();

            this.Visible = false;

            registroEdificios.ShowDialog();
        }

        private void bunifuImageButton6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
