namespace VentanaPrincipal
{
    partial class Principal
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
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menu1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePersonasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadooDeObjetosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menu1ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1278, 33);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // menu1ToolStripMenuItem
            // 
            this.menu1ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDePersonasToolStripMenuItem,
            this.listadooDeObjetosToolStripMenuItem});
            this.menu1ToolStripMenuItem.Name = "menu1ToolStripMenuItem";
            this.menu1ToolStripMenuItem.Size = new System.Drawing.Size(84, 29);
            this.menu1ToolStripMenuItem.Text = "Menu 1";
            // 
            // listadoDePersonasToolStripMenuItem
            // 
            this.listadoDePersonasToolStripMenuItem.Name = "listadoDePersonasToolStripMenuItem";
            this.listadoDePersonasToolStripMenuItem.Size = new System.Drawing.Size(257, 30);
            this.listadoDePersonasToolStripMenuItem.Text = "Listado de Personas";
            this.listadoDePersonasToolStripMenuItem.Click += new System.EventHandler(this.listadoDePersonasToolStripMenuItem_Click);
            // 
            // listadooDeObjetosToolStripMenuItem
            // 
            this.listadooDeObjetosToolStripMenuItem.Name = "listadooDeObjetosToolStripMenuItem";
            this.listadooDeObjetosToolStripMenuItem.Size = new System.Drawing.Size(253, 30);
            this.listadooDeObjetosToolStripMenuItem.Text = "Listado de Objetos";
            this.listadooDeObjetosToolStripMenuItem.Click += new System.EventHandler(this.listadooDeObjetosToolStripMenuItem_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1278, 744);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.Text = "Form1";
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem menu1ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePersonasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadooDeObjetosToolStripMenuItem;
    }
}

