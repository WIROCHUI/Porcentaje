namespace ConvertirBase64
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.archiboB = new System.Windows.Forms.Button();
            this.Byarchivo = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtNombre = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnGuardaCodigo = new System.Windows.Forms.Button();
            this.btnLimpiar = new iTalk.iTalk_Button_1();
            this.btn_AbrirNuevoArchivo = new iTalk.iTalk_Button_1();
            this.txt_ruta = new iTalk.iTalk_TextBox_Small();
            this.txtbusqueda = new iTalk.iTalk_TextBox_Small();
            this.btnBuscar = new iTalk.iTalk_Button_2();
            this.lblCopy = new iTalk.iTalk_Label();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.BackColor = System.Drawing.Color.White;
            this.progressBar1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.progressBar1.Location = new System.Drawing.Point(-2, 1);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(885, 10);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.AllowDrop = true;
            this.txtResultado.Location = new System.Drawing.Point(9, 17);
            this.txtResultado.MaxLength = 99999;
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResultado.Size = new System.Drawing.Size(630, 268);
            this.txtResultado.TabIndex = 6;
            this.txtResultado.WordWrap = false;
            // 
            // archiboB
            // 
            this.archiboB.BackColor = System.Drawing.Color.Black;
            this.archiboB.FlatAppearance.BorderSize = 0;
            this.archiboB.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.archiboB.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiboB.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.archiboB.Location = new System.Drawing.Point(666, 55);
            this.archiboB.Name = "archiboB";
            this.archiboB.Size = new System.Drawing.Size(78, 36);
            this.archiboB.TabIndex = 7;
            this.archiboB.Text = "Codificar";
            this.archiboB.UseVisualStyleBackColor = false;
            this.archiboB.Click += new System.EventHandler(this.archiboB_Click);
            // 
            // Byarchivo
            // 
            this.Byarchivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Byarchivo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.Byarchivo.FlatAppearance.BorderSize = 0;
            this.Byarchivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Byarchivo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Byarchivo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Byarchivo.Location = new System.Drawing.Point(750, 55);
            this.Byarchivo.Name = "Byarchivo";
            this.Byarchivo.Size = new System.Drawing.Size(82, 36);
            this.Byarchivo.TabIndex = 8;
            this.Byarchivo.Text = "Decodificar";
            this.Byarchivo.UseVisualStyleBackColor = false;
            this.Byarchivo.Click += new System.EventHandler(this.Byarchivo_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txtNombre
            // 
            this.txtNombre.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txtNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtNombre.HintForeColor = System.Drawing.Color.Empty;
            this.txtNombre.HintText = "";
            this.txtNombre.isPassword = false;
            this.txtNombre.LineFocusedColor = System.Drawing.Color.DodgerBlue;
            this.txtNombre.LineIdleColor = System.Drawing.Color.Gray;
            this.txtNombre.LineMouseHoverColor = System.Drawing.Color.DodgerBlue;
            this.txtNombre.LineThickness = 3;
            this.txtNombre.Location = new System.Drawing.Point(666, 210);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(166, 25);
            this.txtNombre.TabIndex = 16;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombre.OnValueChanged += new System.EventHandler(this.txtNombre_OnValueChanged);
            // 
            // btnGuardaCodigo
            // 
            this.btnGuardaCodigo.BackColor = System.Drawing.Color.Teal;
            this.btnGuardaCodigo.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnGuardaCodigo.FlatAppearance.BorderSize = 0;
            this.btnGuardaCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardaCodigo.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardaCodigo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGuardaCodigo.Location = new System.Drawing.Point(666, 178);
            this.btnGuardaCodigo.Name = "btnGuardaCodigo";
            this.btnGuardaCodigo.Size = new System.Drawing.Size(166, 32);
            this.btnGuardaCodigo.TabIndex = 17;
            this.btnGuardaCodigo.Text = "Guardar";
            this.btnGuardaCodigo.UseVisualStyleBackColor = false;
            this.btnGuardaCodigo.Click += new System.EventHandler(this.btnGuardaCodigo_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.Transparent;
            this.btnLimpiar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnLimpiar.Location = new System.Drawing.Point(666, 242);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(42, 32);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btn_AbrirNuevoArchivo
            // 
            this.btn_AbrirNuevoArchivo.BackColor = System.Drawing.Color.Transparent;
            this.btn_AbrirNuevoArchivo.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_AbrirNuevoArchivo.Image = null;
            this.btn_AbrirNuevoArchivo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_AbrirNuevoArchivo.Location = new System.Drawing.Point(720, 290);
            this.btn_AbrirNuevoArchivo.Name = "btn_AbrirNuevoArchivo";
            this.btn_AbrirNuevoArchivo.Size = new System.Drawing.Size(127, 29);
            this.btn_AbrirNuevoArchivo.TabIndex = 12;
            this.btn_AbrirNuevoArchivo.Text = "Abrir RUTA";
            this.btn_AbrirNuevoArchivo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btn_AbrirNuevoArchivo.Click += new System.EventHandler(this.btn_AbrirNuevoArchivo_Click);
            // 
            // txt_ruta
            // 
            this.txt_ruta.BackColor = System.Drawing.Color.Transparent;
            this.txt_ruta.Font = new System.Drawing.Font("Tahoma", 11F);
            this.txt_ruta.ForeColor = System.Drawing.Color.DimGray;
            this.txt_ruta.Location = new System.Drawing.Point(12, 291);
            this.txt_ruta.MaxLength = 32767;
            this.txt_ruta.Multiline = false;
            this.txt_ruta.Name = "txt_ruta";
            this.txt_ruta.ReadOnly = false;
            this.txt_ruta.Size = new System.Drawing.Size(702, 28);
            this.txt_ruta.TabIndex = 13;
            this.txt_ruta.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt_ruta.UseSystemPasswordChar = false;
            // 
            // txtbusqueda
            // 
            this.txtbusqueda.BackColor = System.Drawing.Color.Transparent;
            this.txtbusqueda.Font = new System.Drawing.Font("Tahoma", 10F);
            this.txtbusqueda.ForeColor = System.Drawing.Color.Black;
            this.txtbusqueda.Location = new System.Drawing.Point(666, 145);
            this.txtbusqueda.MaxLength = 32767;
            this.txtbusqueda.Multiline = false;
            this.txtbusqueda.Name = "txtbusqueda";
            this.txtbusqueda.ReadOnly = false;
            this.txtbusqueda.Size = new System.Drawing.Size(166, 27);
            this.txtbusqueda.TabIndex = 11;
            this.txtbusqueda.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtbusqueda.UseSystemPasswordChar = false;
            this.txtbusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtbusqueda_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.Transparent;
            this.btnBuscar.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Image = null;
            this.btnBuscar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuscar.Location = new System.Drawing.Point(666, 107);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(166, 32);
            this.btnBuscar.TabIndex = 10;
            this.btnBuscar.Text = "Generar Archivo";
            this.btnBuscar.TextAlignment = System.Drawing.StringAlignment.Center;
            this.btnBuscar.Click += new System.EventHandler(this.btnDecoDesdeTxt_Click);
            // 
            // lblCopy
            // 
            this.lblCopy.AutoSize = true;
            this.lblCopy.BackColor = System.Drawing.Color.Transparent;
            this.lblCopy.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.lblCopy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.lblCopy.Location = new System.Drawing.Point(269, 331);
            this.lblCopy.Name = "lblCopy";
            this.lblCopy.Size = new System.Drawing.Size(341, 13);
            this.lblCopy.TabIndex = 9;
            this.lblCopy.Text = "Copyright © WIRO Todos los derechos reservados  | version 2.4M";
            // 
            // Form1
            // 
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(862, 353);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnGuardaCodigo);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.btn_AbrirNuevoArchivo);
            this.Controls.Add(this.txt_ruta);
            this.Controls.Add(this.txtbusqueda);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.lblCopy);
            this.Controls.Add(this.Byarchivo);
            this.Controls.Add(this.archiboB);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.progressBar1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Convertir Base64";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Button archiboB;
        private System.Windows.Forms.Button Byarchivo;
        private System.Windows.Forms.Timer timer1;
        private iTalk.iTalk_Label lblCopy;
        private iTalk.iTalk_Button_2 btnBuscar;
        private iTalk.iTalk_TextBox_Small txtbusqueda;
        private iTalk.iTalk_Button_1 btn_AbrirNuevoArchivo;
        private iTalk.iTalk_TextBox_Small txt_ruta;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtNombre;
        private System.Windows.Forms.Button btnGuardaCodigo;
        private iTalk.iTalk_Button_1 btnLimpiar;
    }
}

