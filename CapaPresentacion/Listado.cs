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
    public partial class Listado : Form
    {
        private Inicio inicio= Inicio.inicio;

        public Listado()
        {
            InitializeComponent();
        }

        private void Listado_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void refrescar()
        {
            N_Visita objNegocio = N_Visita.Instance;
            N_Edificio objNegocioE = N_Edificio.Instance;

            VisitasT.DataSource = objNegocio.ListarVisitas("");

            EdificioCb.Items.Clear();
            

            HashSet<string> edificiosSet = new HashSet<string>();
            

            foreach (var x in objNegocioE.ListarEdificios(""))
            {
                
                    if (edificiosSet.Add(x.Edificio))
                    {
                        EdificioCb.Items.Add(x.Edificio);
                    }
                
            }

            if (EdificioCb.Items.Count > 0) EdificioCb.SelectedIndex = 0;

            
            if (objNegocioE.ListarEdificios("").Count < 1) { EdificioCb.Items.Add("Ninguno"); }


            if (EdificioCb.Items.Count > 0)
            {
                EdificioCb.SelectedIndex = 0;
            }

        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            inicio.Visible = true;
            Close();
        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BuscarVisitasBtn_Click(object sender, EventArgs e)
        {
            mostrarBusqueda(EdificioCb.Text);

        }

        private void mostrarBusqueda(string x)
        {
            N_Visita objNegocio = N_Visita.Instance;
            VisitasT.DataSource = objNegocio.BuscarVisitasPorEdificio(x);
            
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            refrescar();
        }
    }
}
