namespace CapaPresentacion
{
    partial class Loggin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loggin));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Login = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.UsuarioLogin = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.ContraseñaLogin = new WindowsFormsControlLibrary1.BunifuCustomTextbox();
            this.IniciarSesionBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.RegistrarseBtn = new Bunifu.Framework.UI.BunifuImageButton();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.performanceCounter1 = new System.Diagnostics.PerformanceCounter();
            this.Login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IniciarSesionBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarseBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Login
            // 
            this.Login.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Login.BackgroundImage")));
            this.Login.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Login.Controls.Add(this.UsuarioLogin);
            this.Login.Controls.Add(this.ContraseñaLogin);
            this.Login.Controls.Add(this.IniciarSesionBtn);
            this.Login.Controls.Add(this.RegistrarseBtn);
            this.Login.Controls.Add(this.bunifuCustomLabel1);
            this.Login.Controls.Add(this.bunifuCustomLabel3);
            this.Login.Controls.Add(this.bunifuCustomLabel2);
            this.Login.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Login.GradientBottomLeft = System.Drawing.Color.White;
            this.Login.GradientBottomRight = System.Drawing.Color.Red;
            this.Login.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.Login.GradientTopRight = System.Drawing.Color.Blue;
            this.Login.Location = new System.Drawing.Point(0, 0);
            this.Login.Name = "Login";
            this.Login.Quality = 10;
            this.Login.Size = new System.Drawing.Size(800, 450);
            this.Login.TabIndex = 4;
            // 
            // UsuarioLogin
            // 
            this.UsuarioLogin.BorderColor = System.Drawing.Color.SeaGreen;
            this.UsuarioLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsuarioLogin.Location = new System.Drawing.Point(297, 185);
            this.UsuarioLogin.Name = "UsuarioLogin";
            this.UsuarioLogin.Size = new System.Drawing.Size(251, 31);
            this.UsuarioLogin.TabIndex = 1;
            // 
            // ContraseñaLogin
            // 
            this.ContraseñaLogin.BorderColor = System.Drawing.Color.SeaGreen;
            this.ContraseñaLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContraseñaLogin.Location = new System.Drawing.Point(297, 225);
            this.ContraseñaLogin.Name = "ContraseñaLogin";
            this.ContraseñaLogin.Size = new System.Drawing.Size(251, 31);
            this.ContraseñaLogin.TabIndex = 1;
            // 
            // IniciarSesionBtn
            // 
            this.IniciarSesionBtn.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.IniciarSesionBtn.Image = ((System.Drawing.Image)(resources.GetObject("IniciarSesionBtn.Image")));
            this.IniciarSesionBtn.ImageActive = null;
            this.IniciarSesionBtn.Location = new System.Drawing.Point(428, 303);
            this.IniciarSesionBtn.Name = "IniciarSesionBtn";
            this.IniciarSesionBtn.Size = new System.Drawing.Size(120, 40);
            this.IniciarSesionBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.IniciarSesionBtn.TabIndex = 2;
            this.IniciarSesionBtn.TabStop = false;
            this.IniciarSesionBtn.Zoom = 10;
            this.IniciarSesionBtn.Click += new System.EventHandler(this.RegistrarseBtn_Click);
            // 
            // RegistrarseBtn
            // 
            this.RegistrarseBtn.BackColor = System.Drawing.Color.Crimson;
            this.RegistrarseBtn.Image = ((System.Drawing.Image)(resources.GetObject("RegistrarseBtn.Image")));
            this.RegistrarseBtn.ImageActive = null;
            this.RegistrarseBtn.Location = new System.Drawing.Point(297, 303);
            this.RegistrarseBtn.Name = "RegistrarseBtn";
            this.RegistrarseBtn.Size = new System.Drawing.Size(120, 40);
            this.RegistrarseBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.RegistrarseBtn.TabIndex = 2;
            this.RegistrarseBtn.TabStop = false;
            this.RegistrarseBtn.Zoom = 10;
            this.RegistrarseBtn.Click += new System.EventHandler(this.RegistrarseBtn_Click);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(199, 188);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(92, 25);
            this.bunifuCustomLabel1.TabIndex = 3;
            this.bunifuCustomLabel1.Text = "Usuario:";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel3
            // 
            this.bunifuCustomLabel3.AutoSize = true;
            this.bunifuCustomLabel3.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel3.Font = new System.Drawing.Font("Segoe UI Symbol", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel3.Location = new System.Drawing.Point(237, 59);
            this.bunifuCustomLabel3.Name = "bunifuCustomLabel3";
            this.bunifuCustomLabel3.Size = new System.Drawing.Size(369, 65);
            this.bunifuCustomLabel3.TabIndex = 3;
            this.bunifuCustomLabel3.Text = "Inicio de sesion";
            this.bunifuCustomLabel3.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(162, 228);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(129, 25);
            this.bunifuCustomLabel2.TabIndex = 3;
            this.bunifuCustomLabel2.Text = "Contraseña:";
            this.bunifuCustomLabel2.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // performanceCounter1
            // 
            this.performanceCounter1.CategoryName = "Processor";
            this.performanceCounter1.CounterName = "% Processor Time";
            this.performanceCounter1.InstanceName = "_Total";
            // 
            // Loggin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Login);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loggin";
            this.Text = "Form1";
            this.Login.ResumeLayout(false);
            this.Login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IniciarSesionBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrarseBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.performanceCounter1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.Framework.UI.BunifuGradientPanel Login;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox ContraseñaLogin;
        private Bunifu.Framework.UI.BunifuImageButton RegistrarseBtn;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Diagnostics.PerformanceCounter performanceCounter1;
        private WindowsFormsControlLibrary1.BunifuCustomTextbox UsuarioLogin;
        private Bunifu.Framework.UI.BunifuImageButton IniciarSesionBtn;
    }
}
