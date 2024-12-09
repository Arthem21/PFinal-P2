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
    public partial class RegistroAula : Form
    {
        private Inicio inicio= Inicio.inicio;
        public RegistroAula()
        {
            InitializeComponent();
        }

        private void RegistroAula_Load(object sender, EventArgs e)
        {
            refrescar();
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

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void refrescar()
        {
            N_Aula objNegocio = N_Aula.Instance;
            AulaT.DataSource = objNegocio.ListarAulas("");

            N_Edificio objNegocioE = N_Edificio.Instance;

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
            cancelarselect();
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            E_Aula aula = new E_Aula();
            aula.Aula = NombreTb.Text;
            N_Edificio objNegocio = N_Edificio.Instance;

            aula.Edificio = Convert.ToInt32(EdificioCb.SelectedValue);

            foreach (var edificio in objNegocio.ListarEdificios(""))
            {

                if (EdificioCb.Text.Equals(edificio.Edificio))
                {

                    aula.Edificio = edificio.Id;
                    
                }
            }

            int id = 0;

            try
            {
                if (!string.IsNullOrEmpty(IDTb.Text))
                {
                    id = Convert.ToInt32(IDTb.Text);
                }

                if (id < 1)
                {
                    N_Aula.Instance.guardar_Aula(aula);
                }
                else
                {
                    aula.Id = id;
                    N_Aula.Instance.editar_Aula(aula);
                }

                Console.WriteLine(aula.Aula);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }

            refrescar();
        }

        private void mostrarBusqueda(string x)
        {
            N_Aula objNegocio = N_Aula.Instance;
            AulaT.DataSource = objNegocio.ListarAulas(x);
            cancelarselect();
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (AulaT.SelectedRows.Count > 1)
            {
                MessageBox.Show("Error al seleccionar: Por favor, seleccione un único elemento");
            }
            else
            {
                IDTb.Text = Convert.ToString(AulaT.CurrentRow.Cells["ID"].Value);
                NombreTb.Text = Convert.ToString(AulaT.CurrentRow.Cells["Aula"].Value);
                EdificioCb.SelectedValue = Convert.ToInt32(AulaT.CurrentRow.Cells["Edificio"].Value);

                if (!string.IsNullOrEmpty(IDTb.Text))
                {
                    BorrarBtn.Enabled = true;
                    BorrarBtn.Visible = true;
                    GuardarBtn.Image = Image.FromFile("C:\\Users\\maxim\\OneDrive\\Documentos\\tareas\\cuatrimestre #4\\P2\\Multicapa\\CapaPresentacion\\imagen\\icons8-modificar-50.png");
                }
            }
        }

        private void Deseleccionar_Click(object sender, EventArgs e)
        {
            cancelarselect();
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Desea eliminar este registro", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            try
            {
                if (confirmacion == DialogResult.OK)
                {
                    E_Aula aula = new E_Aula();
                    aula.Id = Convert.ToInt32(AulaT.CurrentRow.Cells["ID"].Value);
                    N_Aula.Instance.borrar_Aula(aula);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar");
            }

            refrescar();
            cancelarselect();
        }

        private void cancelarselect()
        {
            AulaT.CurrentCell = null;
            NombreTb.Clear();

           

            IDTb.Clear();
            BorrarBtn.Enabled = false;
            BorrarBtn.Visible = false;
            GuardarBtn.Image = Image.FromFile("C:\\Users\\maxim\\OneDrive\\Documentos\\tareas\\cuatrimestre #4\\P2\\Multicapa\\CapaPresentacion\\imagen\\icons8-documento-50.png");
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void BuscarEdificiosBtn_Click(object sender, EventArgs e)
        {
            mostrarBusqueda(BuscarAulasTb.text);
        }


    }
}
