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
    public partial class RegistroAula : Form
    {
        private Inicio inicio= Inicio.inicio;
        public RegistroAula()
        {
            InitializeComponent();
        }

        private void RegistroAula_Load(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            inicio.Visible = true;
            Close();
        }

        private void CerrarBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
