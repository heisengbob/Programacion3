namespace VentanaPrincipal
{
    partial class ListaObjetos
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
            this.lo_lbxListaDer = new System.Windows.Forms.ListBox();
            this.lo_lbxListaIzq = new System.Windows.Forms.ListBox();
            this.lo_btnMoveAll = new System.Windows.Forms.Button();
            this.lo_btnMoveRight = new System.Windows.Forms.Button();
            this.lo_btnMoveLeft = new System.Windows.Forms.Button();
            this.lo_btnBorrar = new System.Windows.Forms.Button();
            this.lo_btnAgregar = new System.Windows.Forms.Button();
            this.lo_txtDato = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lo_lbxListaDer
            // 
            this.lo_lbxListaDer.FormattingEnabled = true;
            this.lo_lbxListaDer.ItemHeight = 20;
            this.lo_lbxListaDer.Location = new System.Drawing.Point(461, 68);
            this.lo_lbxListaDer.Name = "lo_lbxListaDer";
            this.lo_lbxListaDer.Size = new System.Drawing.Size(216, 304);
            this.lo_lbxListaDer.TabIndex = 0;
            // 
            // lo_lbxListaIzq
            // 
            this.lo_lbxListaIzq.FormattingEnabled = true;
            this.lo_lbxListaIzq.ItemHeight = 20;
            this.lo_lbxListaIzq.Location = new System.Drawing.Point(111, 68);
            this.lo_lbxListaIzq.Name = "lo_lbxListaIzq";
            this.lo_lbxListaIzq.Size = new System.Drawing.Size(216, 304);
            this.lo_lbxListaIzq.TabIndex = 1;
            // 
            // lo_btnMoveAll
            // 
            this.lo_btnMoveAll.Location = new System.Drawing.Point(360, 68);
            this.lo_btnMoveAll.Name = "lo_btnMoveAll";
            this.lo_btnMoveAll.Size = new System.Drawing.Size(75, 40);
            this.lo_btnMoveAll.TabIndex = 2;
            this.lo_btnMoveAll.Text = ">>";
            this.lo_btnMoveAll.UseVisualStyleBackColor = true;
            this.lo_btnMoveAll.Click += new System.EventHandler(this.lo_btnMoveAll_Click);
            // 
            // lo_btnMoveRight
            // 
            this.lo_btnMoveRight.Location = new System.Drawing.Point(360, 114);
            this.lo_btnMoveRight.Name = "lo_btnMoveRight";
            this.lo_btnMoveRight.Size = new System.Drawing.Size(75, 34);
            this.lo_btnMoveRight.TabIndex = 3;
            this.lo_btnMoveRight.Text = ">";
            this.lo_btnMoveRight.UseVisualStyleBackColor = true;
            this.lo_btnMoveRight.Click += new System.EventHandler(this.lo_btnMoveRight_Click);
            // 
            // lo_btnMoveLeft
            // 
            this.lo_btnMoveLeft.Location = new System.Drawing.Point(360, 154);
            this.lo_btnMoveLeft.Name = "lo_btnMoveLeft";
            this.lo_btnMoveLeft.Size = new System.Drawing.Size(75, 35);
            this.lo_btnMoveLeft.TabIndex = 4;
            this.lo_btnMoveLeft.Text = "<";
            this.lo_btnMoveLeft.UseVisualStyleBackColor = true;
            this.lo_btnMoveLeft.Click += new System.EventHandler(this.lo_btnMoveLeft_Click);
            // 
            // lo_btnBorrar
            // 
            this.lo_btnBorrar.Location = new System.Drawing.Point(360, 195);
            this.lo_btnBorrar.Name = "lo_btnBorrar";
            this.lo_btnBorrar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lo_btnBorrar.Size = new System.Drawing.Size(75, 35);
            this.lo_btnBorrar.TabIndex = 5;
            this.lo_btnBorrar.Text = "...";
            this.lo_btnBorrar.UseVisualStyleBackColor = true;
            this.lo_btnBorrar.Click += new System.EventHandler(this.lo_btnBorrar_Click);
            // 
            // lo_btnAgregar
            // 
            this.lo_btnAgregar.Location = new System.Drawing.Point(347, 396);
            this.lo_btnAgregar.Name = "lo_btnAgregar";
            this.lo_btnAgregar.Size = new System.Drawing.Size(88, 37);
            this.lo_btnAgregar.TabIndex = 6;
            this.lo_btnAgregar.Text = "Agregar";
            this.lo_btnAgregar.UseVisualStyleBackColor = true;
            this.lo_btnAgregar.Click += new System.EventHandler(this.lo_btnAgregar_Click);
            // 
            // lo_txtDato
            // 
            this.lo_txtDato.Location = new System.Drawing.Point(111, 401);
            this.lo_txtDato.Name = "lo_txtDato";
            this.lo_txtDato.Size = new System.Drawing.Size(216, 26);
            this.lo_txtDato.TabIndex = 7;
            this.lo_txtDato.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lo_txtDato_KeyDown);
            // 
            // ListaObjetos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lo_txtDato);
            this.Controls.Add(this.lo_btnAgregar);
            this.Controls.Add(this.lo_btnBorrar);
            this.Controls.Add(this.lo_btnMoveLeft);
            this.Controls.Add(this.lo_btnMoveRight);
            this.Controls.Add(this.lo_btnMoveAll);
            this.Controls.Add(this.lo_lbxListaIzq);
            this.Controls.Add(this.lo_lbxListaDer);
            this.Name = "ListaObjetos";
            this.Text = "ListaObjetos";
            this.Load += new System.EventHandler(this.ListaObjetos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lo_lbxListaDer;
        private System.Windows.Forms.ListBox lo_lbxListaIzq;
        private System.Windows.Forms.Button lo_btnMoveAll;
        private System.Windows.Forms.Button lo_btnMoveRight;
        private System.Windows.Forms.Button lo_btnMoveLeft;
        private System.Windows.Forms.Button lo_btnBorrar;
        private System.Windows.Forms.Button lo_btnAgregar;
        private System.Windows.Forms.TextBox lo_txtDato;
    }
}