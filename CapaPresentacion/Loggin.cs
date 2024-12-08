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

            this.Visible = false;
            
            registrarse.Visible = true;

            
        }
    }
}
