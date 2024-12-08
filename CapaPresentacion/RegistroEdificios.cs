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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace CapaPresentacion
{
    public partial class RegistroEdificios : Form
    {
        private Inicio inicio= Inicio.inicio;
        public RegistroEdificios()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            E_Edificio edificio = new E_Edificio();
            edificio.Edificio = NombreTb.Text;

            int id = 0;

            try
            {
                if (!string.IsNullOrEmpty(IDTb.Text))
                {
                    id = Convert.ToInt32(IDTb.Text);
                }

                if (id < 1)
                {
                    N_Edificio.Instance.guardar_Edificio(edificio);
                }
                else
                {
                    edificio.Id = id;
                    N_Edificio.Instance.editar_Edificio(edificio);
                }

                Console.WriteLine(edificio.Edificio);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }

            refrescar();
        }

        private void refrescar()
        {
            N_Edificio objNegocio = N_Edificio.Instance;
            EdificiosT.DataSource = objNegocio.ListarEdificios("");
            //cancelarselect();
        }

        private void mostrarBusqueda(string x)
        {
            N_Edificio objNegocio = N_Edificio.Instance;
            EdificiosT.DataSource = objNegocio.ListarEdificios(x);
            //cancelarselect();
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (EdificiosT.SelectedRows.Count > 1)
            {
                MessageBox.Show("Error al seleccionar: Por favor, seleccione un único elemento");
            }
            else
            {
                IDTb.Text = Convert.ToString(EdificiosT.CurrentRow.Cells["ID"].Value);
                EdificiosT.Text = Convert.ToString(EdificiosT.CurrentRow.Cells["Edificio"].Value);

                if (!string.IsNullOrEmpty(IDTb.Text))
                {
                    BorrarBtn.Enabled = true;
                    BorrarBtn.Visible = true;
                    GuardarBtn.Image = Image.FromFile("C:\\Users\\maxim\\OneDrive\\Documentos\\tareas\\cuatrimestre #4\\P2\\ProyectoFinalP2\\CapaPresentacion\\Iconos\\icons8-modificar-50.png");
                }
            }
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

        private void EdificiosT_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Desea eliminar este registro", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            try
            {
                if (confirmacion == DialogResult.OK)
                {
                    E_Edificio edificio = new E_Edificio();
                    edificio.Id = Convert.ToInt32(EdificiosT.CurrentRow.Cells["ID"].Value);
                    N_Edificio.Instance.borrar_Edificio(edificio);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar");
            }

            refrescar();
            //cancelarselect();
        }

    }
}
