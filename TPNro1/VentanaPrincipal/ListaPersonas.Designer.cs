namespace VentanaPrincipal
{
    partial class ListaPersonas
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
            this.lp_txtApellido = new System.Windows.Forms.TextBox();
            this.lp_txtNombre = new System.Windows.Forms.TextBox();
            this.lp_dtpFechaNac = new System.Windows.Forms.DateTimePicker();
            this.lp_rbxFemenino = new System.Windows.Forms.RadioButton();
            this.lp_gbxSexo = new System.Windows.Forms.GroupBox();
            this.lp_rbxMasculino = new System.Windows.Forms.RadioButton();
            this.lp_cbxMusicaPref1 = new System.Windows.Forms.CheckBox();
            this.lp_cbColorFav = new System.Windows.Forms.ComboBox();
            this.lp_lblApellido = new System.Windows.Forms.Label();
            this.lp_lblNombre = new System.Windows.Forms.Label();
            this.lp_lblFecNac = new System.Windows.Forms.Label();
            this.lp_lblMusicaPref = new System.Windows.Forms.Label();
            this.lp_lblColorFav = new System.Windows.Forms.Label();
            this.lp_cbxMusicaPref2 = new System.Windows.Forms.CheckBox();
            this.lp_cbxMusicaPref4 = new System.Windows.Forms.CheckBox();
            this.lp_cbxMusicaPref3 = new System.Windows.Forms.CheckBox();
            this.lp_cbxMusicaPref6 = new System.Windows.Forms.CheckBox();
            this.lp_cbxMusicaPref5 = new System.Windows.Forms.CheckBox();
            this.lp_btnAgregar = new System.Windows.Forms.Button();
            this.lp_btnCancelar = new System.Windows.Forms.Button();
            this.lp_btnModificar = new System.Windows.Forms.Button();
            this.lp_dgListaPersonas = new System.Windows.Forms.DataGridView();
            this.lp_btnEliminar = new System.Windows.Forms.Button();
            this.lp_gbxSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lp_dgListaPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // lp_txtApellido
            // 
            this.lp_txtApellido.Location = new System.Drawing.Point(37, 42);
            this.lp_txtApellido.Name = "lp_txtApellido";
            this.lp_txtApellido.Size = new System.Drawing.Size(280, 26);
            this.lp_txtApellido.TabIndex = 0;
            // 
            // lp_txtNombre
            // 
            this.lp_txtNombre.Location = new System.Drawing.Point(37, 94);
            this.lp_txtNombre.Name = "lp_txtNombre";
            this.lp_txtNombre.Size = new System.Drawing.Size(280, 26);
            this.lp_txtNombre.TabIndex = 1;
            // 
            // lp_dtpFechaNac
            // 
            this.lp_dtpFechaNac.Location = new System.Drawing.Point(361, 60);
            this.lp_dtpFechaNac.Name = "lp_dtpFechaNac";
            this.lp_dtpFechaNac.Size = new System.Drawing.Size(279, 26);
            this.lp_dtpFechaNac.TabIndex = 2;
            // 
            // lp_rbxFemenino
            // 
            this.lp_rbxFemenino.AutoSize = true;
            this.lp_rbxFemenino.Location = new System.Drawing.Point(30, 25);
            this.lp_rbxFemenino.Name = "lp_rbxFemenino";
            this.lp_rbxFemenino.Size = new System.Drawing.Size(105, 24);
            this.lp_rbxFemenino.TabIndex = 3;
            this.lp_rbxFemenino.TabStop = true;
            this.lp_rbxFemenino.Text = "Femenino";
            this.lp_rbxFemenino.UseVisualStyleBackColor = true;
            // 
            // lp_gbxSexo
            // 
            this.lp_gbxSexo.Controls.Add(this.lp_rbxMasculino);
            this.lp_gbxSexo.Controls.Add(this.lp_rbxFemenino);
            this.lp_gbxSexo.Location = new System.Drawing.Point(361, 116);
            this.lp_gbxSexo.Name = "lp_gbxSexo";
            this.lp_gbxSexo.Size = new System.Drawing.Size(306, 68);
            this.lp_gbxSexo.TabIndex = 4;
            this.lp_gbxSexo.TabStop = false;
            this.lp_gbxSexo.Text = "Sexo";
            // 
            // lp_rbxMasculino
            // 
            this.lp_rbxMasculino.AutoSize = true;
            this.lp_rbxMasculino.Location = new System.Drawing.Point(158, 25);
            this.lp_rbxMasculino.Name = "lp_rbxMasculino";
            this.lp_rbxMasculino.Size = new System.Drawing.Size(105, 24);
            this.lp_rbxMasculino.TabIndex = 4;
            this.lp_rbxMasculino.TabStop = true;
            this.lp_rbxMasculino.Text = "Masculino";
            this.lp_rbxMasculino.UseVisualStyleBackColor = true;
            // 
            // lp_cbxMusicaPref1
            // 
            this.lp_cbxMusicaPref1.AutoSize = true;
            this.lp_cbxMusicaPref1.Location = new System.Drawing.Point(737, 64);
            this.lp_cbxMusicaPref1.Name = "lp_cbxMusicaPref1";
            this.lp_cbxMusicaPref1.Size = new System.Drawing.Size(89, 24);
            this.lp_cbxMusicaPref1.TabIndex = 5;
            this.lp_cbxMusicaPref1.Text = "Popular";
            this.lp_cbxMusicaPref1.UseVisualStyleBackColor = true;
            // 
            // lp_cbColorFav
            // 
            this.lp_cbColorFav.FormattingEnabled = true;
            this.lp_cbColorFav.Items.AddRange(new object[] {
            "Azul",
            "Azul Cielo",
            "Azul Marino",
            "Azul Celeste",
            "Azul Acero",
            "Azul Cian",
            "Azul Klein"});
            this.lp_cbColorFav.Location = new System.Drawing.Point(35, 169);
            this.lp_cbColorFav.Name = "lp_cbColorFav";
            this.lp_cbColorFav.Size = new System.Drawing.Size(121, 28);
            this.lp_cbColorFav.TabIndex = 6;
            // 
            // lp_lblApellido
            // 
            this.lp_lblApellido.AutoSize = true;
            this.lp_lblApellido.Location = new System.Drawing.Point(33, 17);
            this.lp_lblApellido.Name = "lp_lblApellido";
            this.lp_lblApellido.Size = new System.Drawing.Size(65, 20);
            this.lp_lblApellido.TabIndex = 8;
            this.lp_lblApellido.Text = "Apellido";
            // 
            // lp_lblNombre
            // 
            this.lp_lblNombre.AutoSize = true;
            this.lp_lblNombre.Location = new System.Drawing.Point(33, 71);
            this.lp_lblNombre.Name = "lp_lblNombre";
            this.lp_lblNombre.Size = new System.Drawing.Size(65, 20);
            this.lp_lblNombre.TabIndex = 9;
            this.lp_lblNombre.Text = "Nombre";
            // 
            // lp_lblFecNac
            // 
            this.lp_lblFecNac.AutoSize = true;
            this.lp_lblFecNac.Location = new System.Drawing.Point(357, 25);
            this.lp_lblFecNac.Name = "lp_lblFecNac";
            this.lp_lblFecNac.Size = new System.Drawing.Size(159, 20);
            this.lp_lblFecNac.TabIndex = 10;
            this.lp_lblFecNac.Text = "Fecha de Nacimiento";
            // 
            // lp_lblMusicaPref
            // 
            this.lp_lblMusicaPref.AutoSize = true;
            this.lp_lblMusicaPref.Location = new System.Drawing.Point(780, 25);
            this.lp_lblMusicaPref.Name = "lp_lblMusicaPref";
            this.lp_lblMusicaPref.Size = new System.Drawing.Size(127, 20);
            this.lp_lblMusicaPref.TabIndex = 11;
            this.lp_lblMusicaPref.Text = "Musica Preferida";
            // 
            // lp_lblColorFav
            // 
            this.lp_lblColorFav.AutoSize = true;
            this.lp_lblColorFav.Location = new System.Drawing.Point(33, 135);
            this.lp_lblColorFav.Name = "lp_lblColorFav";
            this.lp_lblColorFav.Size = new System.Drawing.Size(107, 20);
            this.lp_lblColorFav.TabIndex = 12;
            this.lp_lblColorFav.Text = "Color Favorito";
            // 
            // lp_cbxMusicaPref2
            // 
            this.lp_cbxMusicaPref2.AutoSize = true;
            this.lp_cbxMusicaPref2.Location = new System.Drawing.Point(737, 103);
            this.lp_cbxMusicaPref2.Name = "lp_cbxMusicaPref2";
            this.lp_cbxMusicaPref2.Size = new System.Drawing.Size(72, 24);
            this.lp_cbxMusicaPref2.TabIndex = 13;
            this.lp_cbxMusicaPref2.Text = "Rock";
            this.lp_cbxMusicaPref2.UseVisualStyleBackColor = true;
            // 
            // lp_cbxMusicaPref4
            // 
            this.lp_cbxMusicaPref4.AutoSize = true;
            this.lp_cbxMusicaPref4.Location = new System.Drawing.Point(875, 64);
            this.lp_cbxMusicaPref4.Name = "lp_cbxMusicaPref4";
            this.lp_cbxMusicaPref4.Size = new System.Drawing.Size(68, 24);
            this.lp_cbxMusicaPref4.TabIndex = 15;
            this.lp_cbxMusicaPref4.Text = "Jazz";
            this.lp_cbxMusicaPref4.UseVisualStyleBackColor = true;
            // 
            // lp_cbxMusicaPref3
            // 
            this.lp_cbxMusicaPref3.AutoSize = true;
            this.lp_cbxMusicaPref3.Location = new System.Drawing.Point(737, 146);
            this.lp_cbxMusicaPref3.Name = "lp_cbxMusicaPref3";
            this.lp_cbxMusicaPref3.Size = new System.Drawing.Size(114, 24);
            this.lp_cbxMusicaPref3.TabIndex = 14;
            this.lp_cbxMusicaPref3.Text = "Academica";
            this.lp_cbxMusicaPref3.UseVisualStyleBackColor = true;
            // 
            // lp_cbxMusicaPref6
            // 
            this.lp_cbxMusicaPref6.AutoSize = true;
            this.lp_cbxMusicaPref6.Location = new System.Drawing.Point(875, 143);
            this.lp_cbxMusicaPref6.Name = "lp_cbxMusicaPref6";
            this.lp_cbxMusicaPref6.Size = new System.Drawing.Size(114, 24);
            this.lp_cbxMusicaPref6.TabIndex = 17;
            this.lp_cbxMusicaPref6.Text = "Electronica";
            this.lp_cbxMusicaPref6.UseVisualStyleBackColor = true;
            // 
            // lp_cbxMusicaPref5
            // 
            this.lp_cbxMusicaPref5.AutoSize = true;
            this.lp_cbxMusicaPref5.Location = new System.Drawing.Point(875, 104);
            this.lp_cbxMusicaPref5.Name = "lp_cbxMusicaPref5";
            this.lp_cbxMusicaPref5.Size = new System.Drawing.Size(89, 24);
            this.lp_cbxMusicaPref5.TabIndex = 16;
            this.lp_cbxMusicaPref5.Text = "Cumbia";
            this.lp_cbxMusicaPref5.UseVisualStyleBackColor = true;
            // 
            // lp_btnAgregar
            // 
            this.lp_btnAgregar.Location = new System.Drawing.Point(187, 479);
            this.lp_btnAgregar.Name = "lp_btnAgregar";
            this.lp_btnAgregar.Size = new System.Drawing.Size(130, 38);
            this.lp_btnAgregar.TabIndex = 18;
            this.lp_btnAgregar.Text = "Agregar";
            this.lp_btnAgregar.UseVisualStyleBackColor = true;
            this.lp_btnAgregar.Click += new System.EventHandler(this.lp_btnAgregar_Click);
            // 
            // lp_btnCancelar
            // 
            this.lp_btnCancelar.Location = new System.Drawing.Point(355, 479);
            this.lp_btnCancelar.Name = "lp_btnCancelar";
            this.lp_btnCancelar.Size = new System.Drawing.Size(132, 38);
            this.lp_btnCancelar.TabIndex = 19;
            this.lp_btnCancelar.Text = "Cancelar";
            this.lp_btnCancelar.UseVisualStyleBackColor = true;
            this.lp_btnCancelar.Click += new System.EventHandler(this.lp_btnCancelar_Click);
            // 
            // lp_btnModificar
            // 
            this.lp_btnModificar.Location = new System.Drawing.Point(534, 479);
            this.lp_btnModificar.Name = "lp_btnModificar";
            this.lp_btnModificar.Size = new System.Drawing.Size(133, 38);
            this.lp_btnModificar.TabIndex = 20;
            this.lp_btnModificar.Text = "Modificar";
            this.lp_btnModificar.UseVisualStyleBackColor = true;
            this.lp_btnModificar.Click += new System.EventHandler(this.lp_btnModificar_Click);
            // 
            // lp_dgListaPersonas
            // 
            this.lp_dgListaPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.lp_dgListaPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.lp_dgListaPersonas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.lp_dgListaPersonas.Location = new System.Drawing.Point(37, 214);
            this.lp_dgListaPersonas.Name = "lp_dgListaPersonas";
            this.lp_dgListaPersonas.RowTemplate.Height = 28;
            this.lp_dgListaPersonas.Size = new System.Drawing.Size(906, 238);
            this.lp_dgListaPersonas.TabIndex = 21;
            this.lp_dgListaPersonas.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.lp_dgListaPersonas_RowHeaderMouseClick);
            // 
            // lp_btnEliminar
            // 
            this.lp_btnEliminar.Location = new System.Drawing.Point(706, 479);
            this.lp_btnEliminar.Name = "lp_btnEliminar";
            this.lp_btnEliminar.Size = new System.Drawing.Size(133, 38);
            this.lp_btnEliminar.TabIndex = 22;
            this.lp_btnEliminar.Text = "Eliminar";
            this.lp_btnEliminar.UseVisualStyleBackColor = true;
            this.lp_btnEliminar.Click += new System.EventHandler(this.lp_btnEliminar_Click);
            // 
            // ListaPersonas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 558);
            this.Controls.Add(this.lp_btnEliminar);
            this.Controls.Add(this.lp_dgListaPersonas);
            this.Controls.Add(this.lp_btnModificar);
            this.Controls.Add(this.lp_btnCancelar);
            this.Controls.Add(this.lp_btnAgregar);
            this.Controls.Add(this.lp_cbxMusicaPref6);
            this.Controls.Add(this.lp_cbxMusicaPref5);
            this.Controls.Add(this.lp_cbxMusicaPref4);
            this.Controls.Add(this.lp_cbxMusicaPref3);
            this.Controls.Add(this.lp_cbxMusicaPref2);
            this.Controls.Add(this.lp_lblColorFav);
            this.Controls.Add(this.lp_lblMusicaPref);
            this.Controls.Add(this.lp_lblFecNac);
            this.Controls.Add(this.lp_lblNombre);
            this.Controls.Add(this.lp_lblApellido);
            this.Controls.Add(this.lp_cbColorFav);
            this.Controls.Add(this.lp_cbxMusicaPref1);
            this.Controls.Add(this.lp_gbxSexo);
            this.Controls.Add(this.lp_dtpFechaNac);
            this.Controls.Add(this.lp_txtNombre);
            this.Controls.Add(this.lp_txtApellido);
            this.Name = "ListaPersonas";
            this.Text = "ListaPersonas";
            this.Load += new System.EventHandler(this.ListaPersonas_Load);
            this.lp_gbxSexo.ResumeLayout(false);
            this.lp_gbxSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lp_dgListaPersonas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox lp_txtApellido;
        private System.Windows.Forms.TextBox lp_txtNombre;
        private System.Windows.Forms.DateTimePicker lp_dtpFechaNac;
        private System.Windows.Forms.RadioButton lp_rbxFemenino;
        private System.Windows.Forms.GroupBox lp_gbxSexo;
        private System.Windows.Forms.RadioButton lp_rbxMasculino;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref1;
        private System.Windows.Forms.ComboBox lp_cbColorFav;
        private System.Windows.Forms.Label lp_lblApellido;
        private System.Windows.Forms.Label lp_lblNombre;
        private System.Windows.Forms.Label lp_lblFecNac;
        private System.Windows.Forms.Label lp_lblMusicaPref;
        private System.Windows.Forms.Label lp_lblColorFav;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref2;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref4;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref3;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref6;
        private System.Windows.Forms.CheckBox lp_cbxMusicaPref5;
        private System.Windows.Forms.Button lp_btnAgregar;
        private System.Windows.Forms.Button lp_btnCancelar;
        private System.Windows.Forms.Button lp_btnModificar;
        public System.Windows.Forms.DataGridView lp_dgListaPersonas;
        private System.Windows.Forms.Button lp_btnEliminar;
    }
}