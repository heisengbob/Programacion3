using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Clases;

namespace VentanaPrincipal
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void listadoDePersonasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ListaPersonas grilla = new ListaPersonas();
            grilla.MdiParent = this;
            grilla.ClientSize = new System.Drawing.Size(1300, 800);
            grilla.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            grilla.Dock = DockStyle.Fill;
            grilla.Show();


        }

        private void listadooDeObjetosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListaObjetos grilla = new ListaObjetos();
            grilla.MdiParent = this;
            grilla.ClientSize = new System.Drawing.Size(1300, 800);
            grilla.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            grilla.Dock = DockStyle.Fill;
            grilla.Show();
        }
    }
}
