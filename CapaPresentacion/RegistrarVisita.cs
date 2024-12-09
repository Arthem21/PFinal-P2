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
    public partial class RegistrarVisita : Form
    {
        public RegistrarVisita()
        {
            InitializeComponent();
            AulaCb.SelectedIndexChanged += AulaCb_SelectedIndexChanged_1;
            EdificioCb.SelectedIndexChanged += EdificioCb_SelectedIndexChanged;
        }


        private Inicio inicio = Inicio.inicio;

        private void RegistrarVisita_Load(object sender, EventArgs e)
        {
            refrescar();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel3_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

       

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            E_Visita visita = new E_Visita();
            visita.Nombre = NombreTb.Text;
            visita.Apellido = ApellidoTb.Text;
            visita.Carrera = CarreraTb.Text;
            visita.Correo = CorreoTb.Text;
            visita.Edificio = Convert.ToInt32(EdificioCb.SelectedValue);

            N_Edificio objNegocioE = N_Edificio.Instance;

            foreach (var edificio in objNegocioE.ListarEdificios(""))
            {

                if (EdificioCb.Text.Equals(edificio.Edificio))
                {

                    visita.Edificio = edificio.Id;

                }
            }

            visita.HoraE = HoraEnTb.Text;
            visita.HoraS = HoraSaTb.Text;
            visita.Motivo = MotivoTb.Text;
            visita.Foto = FotoTb.Text;
            visita.Aula = Convert.ToInt32(AulaCb.SelectedValue);

            N_Aula objNegocioA = N_Aula.Instance;

            foreach (var aula in objNegocioA.ListarAulas(""))
            {

                if (AulaCb.Text.Equals(aula.Aula))
                {

                    visita.Aula = aula.Id;
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
                    N_Visita.Instance.guardar_Visita(visita);
                }
                else
                {
                    visita.Id = id;
                    N_Visita.Instance.editar_Visita(visita);
                }

                Console.WriteLine(visita.Nombre);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar");
            }

            refrescar();
            
        }

        private void bunifuCustomTextbox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void UsuarioLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void VolverBtn_Click(object sender, EventArgs e)
        {
            inicio.Visible = true;
            Close();
        }

        private void BuscarVisitasBtn_Click(object sender, EventArgs e)
        {
            mostrarBusqueda(BuscarVisitasTb.Text);
        }

        private void mostrarBusqueda(string x)
        {
            N_Visita objNegocio = N_Visita.Instance;
            RegistrosT.DataSource = objNegocio.ListarVisitas(x);
            cancelarselect();
        }

        private void refrescar()
        {
            N_Visita objNegocio = N_Visita.Instance;
            RegistrosT.DataSource = objNegocio.ListarVisitas("");

            N_Edificio objNegocioE = N_Edificio.Instance;

            EdificioCb.Items.Clear();
            AulaCb.Items.Clear();

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

            N_Aula objNegocioA = N_Aula.Instance;

            
            HashSet<string> aulasSet = new HashSet<string>();


            foreach (var x in objNegocioA.ListarAulas(""))
            {

                if (aulasSet.Add(x.Aula))
                {
                    AulaCb.Items.Add(x.Aula);
                }

            }

            if (AulaCb.Items.Count > 0) AulaCb.SelectedIndex = 0;


            if (objNegocioA.ListarAulas("").Count < 1) { AulaCb.Items.Add("Ninguno"); }


            if (AulaCb.Items.Count > 0)
            {
                AulaCb.SelectedIndex = 0;
            }

                cancelarselect();
        }

        private void cancelarselect()
        {
            RegistrosT.CurrentCell = null;
            EdificioCb.Refresh();
            AulaCb.Refresh();
            NombreTb.Clear();
            ApellidoTb.Clear();
            CarreraTb.Clear();
            CorreoTb.Clear();
            HoraEnTb.Refresh();
            HoraSaTb.Refresh();
            MotivoTb.Clear();
            FotoTb.Clear();
            IDTb.Clear();
            BorrarBtn.Enabled = false;
            BorrarBtn.Visible = false;
            GuardarBtn.Image = Image.FromFile("C:\\Users\\maxim\\OneDrive\\Documentos\\tareas\\cuatrimestre #4\\P2\\Multicapa\\CapaPresentacion\\imagen\\icons8-documento-50.png");
        }

        private void Tabla_SelectionChanged(object sender, EventArgs e)
        {
            if (RegistrosT.SelectedRows.Count > 1)
            {
                MessageBox.Show("Error al seleccionar: Por favor, seleccione un único elemento");
            }
            else
            {
                IDTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["ID"].Value);
                NombreTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Nombre"].Value);
                ApellidoTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Apellido"].Value);
                CorreoTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Correo"].Value);
                CarreraTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Carrera"].Value);
                EdificioCb.SelectedValue = Convert.ToInt32(RegistrosT.CurrentRow.Cells["Edificio"].Value);
                HoraEnTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["HoraE"].Value);
                HoraSaTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["HoraS"].Value);
                MotivoTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Motivo"].Value);
                FotoTb.Text = Convert.ToString(RegistrosT.CurrentRow.Cells["Foto"].Value);
                AulaCb.SelectedValue = Convert.ToInt32(RegistrosT.CurrentRow.Cells["Aula"].Value);

                if (!string.IsNullOrEmpty(IDTb.Text))
                {
                    BorrarBtn.Enabled = true;
                    BorrarBtn.Visible = true;
                    GuardarBtn.Image = Image.FromFile("C:\\Users\\maxim\\OneDrive\\Documentos\\tareas\\cuatrimestre #4\\P2\\Multicapa\\CapaPresentacion\\imagen\\icons8-modificar-50.png");
                }
            }
        }

        private void BorrarBtn_Click(object sender, EventArgs e)
        {
            DialogResult confirmacion = MessageBox.Show("Desea eliminar este registro", "Confirmación",
                MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
            try
            {
                if (confirmacion == DialogResult.OK)
                {
                    E_Visita visita = new E_Visita();
                    visita.Id = Convert.ToInt32(RegistrosT.CurrentRow.Cells["ID"].Value);
                    N_Visita.Instance.borrar_Visita(visita);
                }
            }
            catch
            {
                MessageBox.Show("Error al eliminar");
            }

            refrescar();
            cancelarselect();
        }

        private void Refrescar_Click(object sender, EventArgs e)
        {
            refrescar();
        }

        private void Deseleccionar_Click(object sender, EventArgs e)
        {
            cancelarselect();
        }

        private void EdificioCb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (EdificioCb.SelectedItem != null)
            {
                N_Edificio objNegocioE = N_Edificio.Instance;
                var edificioSeleccionado = objNegocioE.ListarEdificios("").FirstOrDefault(ed => ed.Edificio == EdificioCb.Text);

                if (edificioSeleccionado != null)
                {
                    N_Aula objNegocioA = N_Aula.Instance;
                    var aulasCorrespondientes = objNegocioA.ListarAulas("").Where(a => a.Edificio == edificioSeleccionado.Id).ToList();

                    AulaCb.Items.Clear();
                    foreach (var aula in aulasCorrespondientes)
                    {
                        AulaCb.Items.Add(aula.Aula);
                    }

                    if (AulaCb.Items.Count > 0)
                    {
                        AulaCb.SelectedIndex = 0;
                    }
                }
            }
        }


        private void AulaCb_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (AulaCb.SelectedItem != null)
            {
                N_Aula objNegocioA = N_Aula.Instance;
                var aulaSeleccionada = objNegocioA.ListarAulas("").FirstOrDefault(a => a.Aula == AulaCb.Text);

                if (aulaSeleccionada != null)
                {
                    N_Edificio objNegocioE = N_Edificio.Instance;
                    var edificioCorrespondiente = objNegocioE.ListarEdificios("").FirstOrDefault(ed => ed.Id == aulaSeleccionada.Edificio);

                    if (edificioCorrespondiente != null)
                    {
                        EdificioCb.SelectedItem = edificioCorrespondiente.Edificio;
                    }
                }
            }
        }

        
    }
}
