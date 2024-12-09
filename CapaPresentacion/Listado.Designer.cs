namespace CapaPresentacion
{
    partial class Listado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Listado));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Cerrar = new Bunifu.Framework.UI.BunifuImageButton();
            this.VolverBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.Refrescar = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.BuscarVisitasBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EdificioCb = new System.Windows.Forms.ComboBox();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.VisitasT = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolverBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarVisitasBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitasT)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.VisitasT);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.White;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Magenta;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.IndianRed;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.Cerrar);
            this.panel1.Controls.Add(this.VolverBtn);
            this.panel1.Controls.Add(this.Refrescar);
            this.panel1.Controls.Add(this.bunifuCustomLabel3);
            this.panel1.Controls.Add(this.BuscarVisitasBtn);
            this.panel1.Controls.Add(this.EdificioCb);
            this.panel1.Controls.Add(this.bunifuCustomLabel4);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 162);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.Color.Transparent;
            this.Cerrar.Image = ((System.Drawing.Image)(resources.GetObject("Cerrar.Image")));
            this.Cerrar.ImageActive = null;
            this.Cerrar.Location = new System.Drawing.Point(732, 12);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(56, 41);
            this.Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar.TabIndex = 51;
            this.Cerrar.TabStop = false;
            this.Cerrar.Zoom = 10;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // VolverBtn
            // 
            this.VolverBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolverBtn.Image = ((System.Drawing.Image)(resources.GetObject("VolverBtn.Image")));
            this.VolverBtn.ImageActive = null;
            this.VolverBtn.Location = new System.Drawing.Point(665, 12);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(51, 41);
            this.VolverBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolverBtn.TabIndex = 49;
            this.VolverBtn.TabStop = false;
            this.VolverBtn.Zoom = 10;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // Refrescar
            // 
            this.Refrescar.BackColor = System.Drawing.Color.Transparent;
            this.Refrescar.Image = ((System.Drawing.Image)(resources.GetObject("Refrescar.Image")));
            this.Refrescar.ImageActive = null;
            this.Refrescar.Location = new System.Drawing.Point(12, 12);
            this.Refrescar.Name = "Refrescar";
            this.Refrescar.Size = new System.Drawing.Size(51, 41);
            this.Refrescar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Refrescar.TabIndex = 50;
            this.Refrescar.TabStop = false;
            this.Refrescar.Zoom = 10;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(145, 12);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(504, 47);
            this.bunifuCustomLabel3.TabIndex = 48;
            this.bunifuCustomLabel3.Text = "Listado de Visitas por edificio";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel3_Click);
            // 
            // BuscarVisitasBtn
            // 
            this.BuscarVisitasBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuscarVisitasBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarVisitasBtn.Image")));
            this.BuscarVisitasBtn.ImageActive = null;
            this.BuscarVisitasBtn.Location = new System.Drawing.Point(537, 99);
            this.BuscarVisitasBtn.Name = "BuscarVisitasBtn";
            this.BuscarVisitasBtn.Size = new System.Drawing.Size(32, 33);
            this.BuscarVisitasBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuscarVisitasBtn.TabIndex = 47;
            this.BuscarVisitasBtn.TabStop = false;
            this.BuscarVisitasBtn.Zoom = 10;
            this.BuscarVisitasBtn.Click += new System.EventHandler(this.BuscarVisitasBtn_Click);
            // 
            // EdificioCb
            // 
            this.EdificioCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdificioCb.FormattingEnabled = true;
            this.EdificioCb.Location = new System.Drawing.Point(262, 99);
            this.EdificioCb.Name = "EdificioCb";
            this.EdificioCb.Size = new System.Drawing.Size(269, 33);
            this.EdificioCb.TabIndex = 46;
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(168, 102);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 25);
            this.bunifuCustomLabel4.TabIndex = 45;
            this.bunifuCustomLabel4.Text = "Edificio:";
            // 
            // VisitasT
            // 
            this.VisitasT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.VisitasT.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VisitasT.Location = new System.Drawing.Point(0, 162);
            this.VisitasT.Name = "VisitasT";
            this.VisitasT.Size = new System.Drawing.Size(800, 288);
            this.VisitasT.TabIndex = 1;
            // 
            // Listado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Listado";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Listado_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolverBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarVisitasBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VisitasT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox EdificioCb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuImageButton BuscarVisitasBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuImageButton VolverBtn;
        private Bunifu.Framework.UI.BunifuImageButton Refrescar;
        private Bunifu.Framework.UI.BunifuImageButton Cerrar;
        private System.Windows.Forms.DataGridView VisitasT;
    }
}