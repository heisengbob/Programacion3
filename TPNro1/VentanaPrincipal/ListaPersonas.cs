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
    public partial class ListaPersonas : Form
    {
        List<Persona> listapersonas = new List<Persona>();
        BindingList<Persona> listaBindeable;

        public ListaPersonas()
        {
            InitializeComponent();
        }

        private bool CampoVacio()
        {
            if (lp_txtApellido.Text == null) return true;
            if (lp_txtNombre.Text == null) return true;
            if (lp_cbColorFav.SelectedIndex == -1) return true;
            if (!lp_rbxFemenino.Checked && !lp_rbxMasculino.Checked) return true;
            return false;
        }

        private Persona CargarDatos()
        {
            Persona nuepersona = new Persona();
            nuepersona.Apellido = lp_txtApellido.Text;
            nuepersona.Nombre = lp_txtNombre.Text;
            nuepersona.Sexo = lp_rbxFemenino.Checked ? 'F' : 'M';
            nuepersona.Fnac = lp_dtpFechaNac.Value;
            List<string> Musicas = new List<string>();
            if (lp_cbxMusicaPref1.Checked) Musicas.Add("Popular");
            if (lp_cbxMusicaPref2.Checked) Musicas.Add("Rock");
            if (lp_cbxMusicaPref3.Checked) Musicas.Add("Academica");
            if (lp_cbxMusicaPref4.Checked) Musicas.Add("Jazz");
            if (lp_cbxMusicaPref5.Checked) Musicas.Add("Cumbia");
            if (lp_cbxMusicaPref6.Checked) Musicas.Add("Electronica");
            nuepersona.MusicaFav = Musicas;
            nuepersona.ColorFav = lp_cbColorFav.SelectedIndex;
            return nuepersona;   
        }

        private void lp_btnAgregar_Click(object sender, EventArgs e)
        {
            if (CampoVacio())
            {
                MessageBox.Show("COMPLETAR CAMPOS", "ERROR");
                return;
            }
            listapersonas.Add(CargarDatos());
            listaBindeable.ResetBindings();
        }

        private void ListaPersonas_Load(object sender, EventArgs e)
        {
            listaBindeable = new BindingList<Persona>(listapersonas);
            lp_dgListaPersonas.DataSource = listaBindeable;
            
        }

        private void lp_btnEliminar_Click(object sender, EventArgs e)
        {
            listapersonas.RemoveAt(lp_dgListaPersonas.SelectedRows[0].Index);
            listaBindeable.ResetBindings();
        }

        private void lp_dgListaPersonas_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Persona aux = new Persona();
            aux = listapersonas.ElementAt(lp_dgListaPersonas.SelectedRows[0].Index);

            lp_cbxMusicaPref1.Checked = false;
            lp_cbxMusicaPref2.Checked = false;
            lp_cbxMusicaPref3.Checked = false;
            lp_cbxMusicaPref4.Checked = false;
            lp_cbxMusicaPref5.Checked = false;
            lp_cbxMusicaPref6.Checked = false;

            lp_txtApellido.Text = aux.Apellido;
            lp_txtNombre.Text = aux.Nombre;
            lp_rbxMasculino.Checked = true;
            if (aux.Sexo == 'F')
            {
                lp_rbxFemenino.Checked = true;
            }
            lp_cbColorFav.SelectedIndex = aux.ColorFav;
            lp_dtpFechaNac.Value = aux.Fnac;

            if (aux.MusicaFav.Contains(lp_cbxMusicaPref1.Text)) lp_cbxMusicaPref1.Checked = true;
            if (aux.MusicaFav.Contains(lp_cbxMusicaPref2.Text)) lp_cbxMusicaPref2.Checked = true;
            if (aux.MusicaFav.Contains(lp_cbxMusicaPref3.Text)) lp_cbxMusicaPref3.Checked = true;
            if (aux.MusicaFav.Contains(lp_cbxMusicaPref4.Text)) lp_cbxMusicaPref4.Checked = true;
            if (aux.MusicaFav.Contains(lp_cbxMusicaPref5.Text)) lp_cbxMusicaPref5.Checked = true;
            if (aux.MusicaFav.Contains(lp_cbxMusicaPref6.Text)) lp_cbxMusicaPref6.Checked = true;
            
        }

        private void lp_btnModificar_Click(object sender, EventArgs e)
        {
            if (CampoVacio())
            {
                MessageBox.Show("COMPLETAR CAMPOS", "ERROR");
                return;
            }
            listapersonas.Insert(lp_dgListaPersonas.SelectedRows[0].Index, CargarDatos());
            listapersonas.RemoveAt(lp_dgListaPersonas.SelectedRows[0].Index + 1);
            listaBindeable.ResetBindings();
        }

        private void lp_btnCancelar_Click(object sender, EventArgs e)
        {
            lp_txtApellido.Text = "";
            lp_txtNombre.Text = "";
            lp_dtpFechaNac.ResetText();
            lp_cbColorFav.SelectedIndex = -1;
            lp_rbxFemenino.Checked = false;
            lp_rbxMasculino.Checked = false;
            lp_cbxMusicaPref1.Checked = false;
            lp_cbxMusicaPref2.Checked = false;
            lp_cbxMusicaPref3.Checked = false;
            lp_cbxMusicaPref4.Checked = false;
            lp_cbxMusicaPref5.Checked = false;
            lp_cbxMusicaPref6.Checked = false;
        }

        private void lp_dtpFechaNac_ValueChanged(object sender, EventArgs e)
        {
            System.TimeSpan diff = DateTime.Now.Subtract(lp_dtpFechaNac.Value);
            lp_lblEdad.Text = "Edad : " + diff.Days / 365;
        }
    }
}
