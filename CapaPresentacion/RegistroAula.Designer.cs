namespace CapaPresentacion
{
    partial class RegistroAula
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroAula));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.VolverBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.EdificioCb = new System.Windows.Forms.ComboBox();
            this.Deseleccionar = new Bunifu.Framework.UI.BunifuImageButton();
            this.BorrarBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.GuardarBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.BuscarAulasBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.BuscarAulasTb = new Bunifu.Framework.UI.BunifuTextbox();
            this.bunifuCustomLabel11 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.Refrescar = new Bunifu.Framework.UI.BunifuImageButton();
            this.CerrarBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel4 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.IDTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.NombreTb = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.AulaT = new System.Windows.Forms.DataGridView();
            this.bunifuGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolverBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deseleccionar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarAulasBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AulaT)).BeginInit();
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
            this.bunifuGradientPanel1.Controls.Add(this.AulaT);
            this.bunifuGradientPanel1.Controls.Add(this.VolverBtn);
            this.bunifuGradientPanel1.Controls.Add(this.EdificioCb);
            this.bunifuGradientPanel1.Controls.Add(this.Deseleccionar);
            this.bunifuGradientPanel1.Controls.Add(this.BorrarBtn);
            this.bunifuGradientPanel1.Controls.Add(this.GuardarBtn);
            this.bunifuGradientPanel1.Controls.Add(this.BuscarAulasBtn);
            this.bunifuGradientPanel1.Controls.Add(this.BuscarAulasTb);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel11);
            this.bunifuGradientPanel1.Controls.Add(this.Refrescar);
            this.bunifuGradientPanel1.Controls.Add(this.CerrarBtn);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel3);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel4);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel1);
            this.bunifuGradientPanel1.Controls.Add(this.IDTb);
            this.bunifuGradientPanel1.Controls.Add(this.NombreTb);
            this.bunifuGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.Red;
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.Blue;
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(800, 450);
            this.bunifuGradientPanel1.TabIndex = 0;
            this.bunifuGradientPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.bunifuGradientPanel1_Paint);
            // 
            // VolverBtn
            // 
            this.VolverBtn.BackColor = System.Drawing.Color.Transparent;
            this.VolverBtn.Image = ((System.Drawing.Image)(resources.GetObject("VolverBtn.Image")));
            this.VolverBtn.ImageActive = null;
            this.VolverBtn.Location = new System.Drawing.Point(652, 15);
            this.VolverBtn.Name = "VolverBtn";
            this.VolverBtn.Size = new System.Drawing.Size(57, 47);
            this.VolverBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.VolverBtn.TabIndex = 45;
            this.VolverBtn.TabStop = false;
            this.VolverBtn.Zoom = 10;
            this.VolverBtn.Click += new System.EventHandler(this.VolverBtn_Click);
            // 
            // EdificioCb
            // 
            this.EdificioCb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EdificioCb.FormattingEnabled = true;
            this.EdificioCb.Location = new System.Drawing.Point(148, 263);
            this.EdificioCb.Name = "EdificioCb";
            this.EdificioCb.Size = new System.Drawing.Size(196, 33);
            this.EdificioCb.TabIndex = 44;
            // 
            // Deseleccionar
            // 
            this.Deseleccionar.BackColor = System.Drawing.Color.Transparent;
            this.Deseleccionar.Image = ((System.Drawing.Image)(resources.GetObject("Deseleccionar.Image")));
            this.Deseleccionar.ImageActive = null;
            this.Deseleccionar.Location = new System.Drawing.Point(715, 130);
            this.Deseleccionar.Name = "Deseleccionar";
            this.Deseleccionar.Size = new System.Drawing.Size(85, 33);
            this.Deseleccionar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Deseleccionar.TabIndex = 43;
            this.Deseleccionar.TabStop = false;
            this.Deseleccionar.Zoom = 10;
            this.Deseleccionar.Click += new System.EventHandler(this.Deseleccionar_Click);
            // 
            // BorrarBtn
            // 
            this.BorrarBtn.BackColor = System.Drawing.Color.Transparent;
            this.BorrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("BorrarBtn.Image")));
            this.BorrarBtn.ImageActive = null;
            this.BorrarBtn.Location = new System.Drawing.Point(59, 323);
            this.BorrarBtn.Name = "BorrarBtn";
            this.BorrarBtn.Size = new System.Drawing.Size(111, 69);
            this.BorrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BorrarBtn.TabIndex = 41;
            this.BorrarBtn.TabStop = false;
            this.BorrarBtn.Zoom = 10;
            this.BorrarBtn.Click += new System.EventHandler(this.BorrarBtn_Click);
            // 
            // GuardarBtn
            // 
            this.GuardarBtn.BackColor = System.Drawing.Color.Transparent;
            this.GuardarBtn.Image = ((System.Drawing.Image)(resources.GetObject("GuardarBtn.Image")));
            this.GuardarBtn.ImageActive = null;
            this.GuardarBtn.Location = new System.Drawing.Point(229, 323);
            this.GuardarBtn.Name = "GuardarBtn";
            this.GuardarBtn.Size = new System.Drawing.Size(115, 74);
            this.GuardarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.GuardarBtn.TabIndex = 40;
            this.GuardarBtn.TabStop = false;
            this.GuardarBtn.Zoom = 10;
            this.GuardarBtn.Click += new System.EventHandler(this.GuardarBtn_Click);
            // 
            // BuscarAulasBtn
            // 
            this.BuscarAulasBtn.BackColor = System.Drawing.Color.Transparent;
            this.BuscarAulasBtn.Image = ((System.Drawing.Image)(resources.GetObject("BuscarAulasBtn.Image")));
            this.BuscarAulasBtn.ImageActive = null;
            this.BuscarAulasBtn.Location = new System.Drawing.Point(557, 82);
            this.BuscarAulasBtn.Name = "BuscarAulasBtn";
            this.BuscarAulasBtn.Size = new System.Drawing.Size(32, 33);
            this.BuscarAulasBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BuscarAulasBtn.TabIndex = 37;
            this.BuscarAulasBtn.TabStop = false;
            this.BuscarAulasBtn.Zoom = 10;
            this.BuscarAulasBtn.Click += new System.EventHandler(this.BuscarEdificiosBtn_Click);
            // 
            // BuscarAulasTb
            // 
            this.BuscarAulasTb.BackColor = System.Drawing.Color.White;
            this.BuscarAulasTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BuscarAulasTb.BackgroundImage")));
            this.BuscarAulasTb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BuscarAulasTb.ForeColor = System.Drawing.Color.Black;
            this.BuscarAulasTb.Icon = ((System.Drawing.Image)(resources.GetObject("BuscarAulasTb.Icon")));
            this.BuscarAulasTb.Location = new System.Drawing.Point(269, 82);
            this.BuscarAulasTb.Name = "BuscarAulasTb";
            this.BuscarAulasTb.Size = new System.Drawing.Size(320, 33);
            this.BuscarAulasTb.TabIndex = 39;
            this.BuscarAulasTb.text = "";
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(181, 82);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(79, 25);
            this.bunifuCustomLabel11.TabIndex = 38;
            this.bunifuCustomLabel11.Text = "Buscar";
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
            this.Refrescar.TabIndex = 36;
            this.Refrescar.TabStop = false;
            this.Refrescar.Zoom = 10;
            this.Refrescar.Click += new System.EventHandler(this.Refrescar_Click);
            // 
            // CerrarBtn
            // 
            this.CerrarBtn.BackColor = System.Drawing.Color.Transparent;
            this.CerrarBtn.Image = ((System.Drawing.Image)(resources.GetObject("CerrarBtn.Image")));
            this.CerrarBtn.ImageActive = null;
            this.CerrarBtn.Location = new System.Drawing.Point(728, 14);
            this.CerrarBtn.Name = "CerrarBtn";
            this.CerrarBtn.Size = new System.Drawing.Size(59, 48);
            this.CerrarBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CerrarBtn.TabIndex = 35;
            this.CerrarBtn.TabStop = false;
            this.CerrarBtn.Zoom = 10;
            this.CerrarBtn.Click += new System.EventHandler(this.CerrarBtn_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(262, 15);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(294, 42);
            this.bunifuCustomLabel2.TabIndex = 34;
            this.bunifuCustomLabel2.Text = "Registro de Aula";
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(54, 172);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(38, 25);
            this.bunifuCustomLabel3.TabIndex = 32;
            this.bunifuCustomLabel3.Text = "ID:";
            // 
            // bunifuCustomLabel4
            // 
            this.bunifuCustomLabel4.AutoSize = true;
            this.bunifuCustomLabel4.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel4.Location = new System.Drawing.Point(54, 266);
            this.bunifuCustomLabel4.Name = "bunifuCustomLabel4";
            this.bunifuCustomLabel4.Size = new System.Drawing.Size(88, 25);
            this.bunifuCustomLabel4.TabIndex = 33;
            this.bunifuCustomLabel4.Text = "Edificio:";
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(54, 223);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(61, 25);
            this.bunifuCustomLabel1.TabIndex = 33;
            this.bunifuCustomLabel1.Text = "Aula:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // IDTb
            // 
            this.IDTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.IDTb.Enabled = false;
            this.IDTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDTb.Location = new System.Drawing.Point(148, 169);
            this.IDTb.Name = "IDTb";
            this.IDTb.Size = new System.Drawing.Size(196, 31);
            this.IDTb.TabIndex = 30;
            // 
            // NombreTb
            // 
            this.NombreTb.BorderColor = System.Drawing.Color.SeaGreen;
            this.NombreTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombreTb.Location = new System.Drawing.Point(148, 217);
            this.NombreTb.Name = "NombreTb";
            this.NombreTb.Size = new System.Drawing.Size(196, 31);
            this.NombreTb.TabIndex = 31;
            // 
            // AulaT
            // 
            this.AulaT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AulaT.Location = new System.Drawing.Point(388, 160);
            this.AulaT.Name = "AulaT";
            this.AulaT.Size = new System.Drawing.Size(412, 220);
            this.AulaT.TabIndex = 46;
            this.AulaT.SelectionChanged += new System.EventHandler(this.Tabla_SelectionChanged);
            // 
            // RegistroAula
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistroAula";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.RegistroAula_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VolverBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Deseleccionar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BorrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GuardarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarAulasBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Refrescar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CerrarBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AulaT)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuImageButton BuscarAulasBtn;
        private Bunifu.Framework.UI.BunifuTextbox BuscarAulasTb;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel11;
        private Bunifu.Framework.UI.BunifuImageButton Refrescar;
        private Bunifu.Framework.UI.BunifuImageButton CerrarBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel4;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox IDTb;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox NombreTb;
        private Bunifu.Framework.UI.BunifuImageButton BorrarBtn;
        private Bunifu.Framework.UI.BunifuImageButton GuardarBtn;
        private Bunifu.Framework.UI.BunifuImageButton Deseleccionar;
        private System.Windows.Forms.ComboBox EdificioCb;
        private Bunifu.Framework.UI.BunifuImageButton VolverBtn;
        private System.Windows.Forms.DataGridView AulaT;
    }
}