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
        
        private void lp_btnAgregar_Click(object sender, EventArgs e)
        {
            Persona nuepersona = new Persona();
            
            nuepersona.Apellido = lp_txtApellido.Text;
            nuepersona.Nombre = lp_txtNombre.Text;
            nuepersona.Sexo = lp_rbxFemenino.Checked ? 'F' : 'M';
            nuepersona.Fnac = lp_dtpFechaNac.Text;

            //List<int> Musicas = new List<int>();

            //if (lp_cbxMusicaPref1.Checked) Musicas.Add(1);
            //if (lp_cbxMusicaPref2.Checked) Musicas.Add(2);
            //if (lp_cbxMusicaPref3.Checked) Musicas.Add(3);
            //if (lp_cbxMusicaPref4.Checked) Musicas.Add(4);
            //if (lp_cbxMusicaPref5.Checked) Musicas.Add(5);
            //if (lp_cbxMusicaPref6.Checked) Musicas.Add(6);
            //nuepersona.MusicaFav = Musicas;
            nuepersona.ColorFav = lp_cbColorFav.Text;


            listapersonas.Add(nuepersona);
            listaBindeable.ResetBindings();
        }

        private void ListaPersonas_Load(object sender, EventArgs e)
        {
            listaBindeable = new BindingList<Persona>(listapersonas);
            lp_dgListaPersonas.DataSource = listaBindeable;
            
        }

    }
}
