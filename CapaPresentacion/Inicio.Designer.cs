namespace CapaPresentacion
{
    partial class Inicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicio));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.AbrirRegistroEdificio = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuImageButton6 = new Bunifu.Framework.UI.BunifuImageButton();
            this.AbrirRegistroAula = new Bunifu.Framework.UI.BunifuImageButton();
            this.AbrirListado = new Bunifu.Framework.UI.BunifuImageButton();
            this.AbrirRegistroVisita = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroEdificio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroAula)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirListado)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroVisita)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.AbrirRegistroEdificio);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuImageButton6);
            this.bunifuGradientPanel1.Controls.Add(this.AbrirRegistroAula);
            this.bunifuGradientPanel1.Controls.Add(this.AbrirListado);
            this.bunifuGradientPanel1.Controls.Add(this.AbrirRegistroVisita);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.LawnGreen;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(262, 33);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(273, 65);
            this.bunifuCustomLabel3.TabIndex = 4;
            this.bunifuCustomLabel3.Text = "Bienvenido";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // AbrirRegistroEdificio
            // 
            this.AbrirRegistroEdificio.BackColor = System.Drawing.Color.LimeGreen;
            this.AbrirRegistroEdificio.Image = ((System.Drawing.Image)(resources.GetObject("AbrirRegistroEdificio.Image")));
            this.AbrirRegistroEdificio.ImageActive = null;
            this.AbrirRegistroEdificio.Location = new System.Drawing.Point(99, 181);
            this.AbrirRegistroEdificio.Name = "AbrirRegistroEdificio";
            this.AbrirRegistroEdificio.Size = new System.Drawing.Size(124, 75);
            this.AbrirRegistroEdificio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AbrirRegistroEdificio.TabIndex = 0;
            this.AbrirRegistroEdificio.TabStop = false;
            this.AbrirRegistroEdificio.Visible = false;
            this.AbrirRegistroEdificio.Zoom = 10;
            this.AbrirRegistroEdificio.Click += new System.EventHandler(this.AbrirRegistroEdificio_Click);
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.Transparent;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(729, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Size = new System.Drawing.Size(59, 48);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 0;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 10;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // AbrirRegistroAula
            // 
            this.AbrirRegistroAula.BackColor = System.Drawing.Color.LimeGreen;
            this.AbrirRegistroAula.Image = ((System.Drawing.Image)(resources.GetObject("AbrirRegistroAula.Image")));
            this.AbrirRegistroAula.ImageActive = null;
            this.AbrirRegistroAula.Location = new System.Drawing.Point(541, 181);
            this.AbrirRegistroAula.Name = "AbrirRegistroAula";
            this.AbrirRegistroAula.Size = new System.Drawing.Size(132, 75);
            this.AbrirRegistroAula.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AbrirRegistroAula.TabIndex = 0;
            this.AbrirRegistroAula.TabStop = false;
            this.AbrirRegistroAula.Visible = false;
            this.AbrirRegistroAula.Zoom = 10;
            this.AbrirRegistroAula.Click += new System.EventHandler(this.AbrirRegistroAula_Click);
            // 
            // AbrirListado
            // 
            this.AbrirListado.BackColor = System.Drawing.Color.LimeGreen;
            this.AbrirListado.Image = ((System.Drawing.Image)(resources.GetObject("AbrirListado.Image")));
            this.AbrirListado.ImageActive = null;
            this.AbrirListado.Location = new System.Drawing.Point(335, 319);
            this.AbrirListado.Name = "AbrirListado";
            this.AbrirListado.Size = new System.Drawing.Size(124, 72);
            this.AbrirListado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AbrirListado.TabIndex = 0;
            this.AbrirListado.TabStop = false;
            this.AbrirListado.Visible = false;
            this.AbrirListado.Zoom = 10;
            this.AbrirListado.Click += new System.EventHandler(this.bunifuImageButton2_Click);
            // 
            // AbrirRegistroVisita
            // 
            this.AbrirRegistroVisita.BackColor = System.Drawing.Color.LimeGreen;
            this.AbrirRegistroVisita.Image = ((System.Drawing.Image)(resources.GetObject("AbrirRegistroVisita.Image")));
            this.AbrirRegistroVisita.ImageActive = null;
            this.AbrirRegistroVisita.Location = new System.Drawing.Point(314, 168);
            this.AbrirRegistroVisita.Name = "AbrirRegistroVisita";
            this.AbrirRegistroVisita.Size = new System.Drawing.Size(167, 98);
            this.AbrirRegistroVisita.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.AbrirRegistroVisita.TabIndex = 0;
            this.AbrirRegistroVisita.TabStop = false;
            this.AbrirRegistroVisita.Zoom = 10;
            this.AbrirRegistroVisita.Click += new System.EventHandler(this.bunifuImageButton1_Click);
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Inicio";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Inicio_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroEdificio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroAula)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirListado)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AbrirRegistroVisita)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton AbrirRegistroEdificio;
        private Bunifu.Framework.UI.BunifuImageButton bunifuImageButton6;
        private Bunifu.Framework.UI.BunifuImageButton AbrirRegistroAula;
        private Bunifu.Framework.UI.BunifuImageButton AbrirRegistroVisita;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton AbrirListado;
    }
}