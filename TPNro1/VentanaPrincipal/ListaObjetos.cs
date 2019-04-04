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
    public partial class ListaObjetos : Form
    {
        List<string> listaobjetosIzq = new List<string>();
        private BindingList<string> listaBindeable;
        List<string> listaobjetosDer = new List<string>();
        private BindingList<string> listaBindeable2;

        public ListaObjetos()
        {
            InitializeComponent();
        }
        private void lo_btnAgregar_Click(object sender, EventArgs e)
        {
            listaobjetosIzq.Add(lo_txtDato.Text);
            listaBindeable.ResetBindings();
            lo_txtDato.Text = "";
        }
        private bool ExisteDuplicado()
        { 
            foreach(string item in listaobjetosIzq)
            {
                foreach(string item2 in listaobjetosDer)
                {
                    if (item == item2) return true;
                }
            }
            return false;

        }
        private bool ExisteDuplicado(string valor)
        {
            foreach(string itemizq in listaobjetosIzq)
            {
                foreach (string itemder in listaobjetosDer)
                {
                    if (itemizq.ToString() == itemder.ToString() && itemder.ToString() == valor)
                        return true;
                }
            }
            return false;
        }
        private void lo_btnMoveAll_Click(object sender, EventArgs e)
        {
            if(listaobjetosIzq.Count == 0)
            {
                MessageBox.Show("NO SE ENCUENTRA NINGUN ITEM PARA TRANSFERIR");
                return;
            }
            if (!ExisteDuplicado())
            {
                listaobjetosDer.Clear();
                foreach (string item in listaobjetosIzq)
                {
                    listaobjetosDer.Add(item.ToString());
                }
                listaBindeable2.ResetBindings();
                listaobjetosIzq.Clear();
                listaBindeable.ResetBindings();
            }
            else
            {
                MessageBox.Show("AL MENOS UN ITEM EN LA LISTA DE LA IZQUIERDA YA EXISTE EN LA DE LA DERECHA","Error");
            }
        }
        private void lo_btnMoveRight_Click(object sender, EventArgs e)
        {
            if (lo_lbxListaIzq.SelectedIndex != -1 && !ExisteDuplicado(listaobjetosIzq[lo_lbxListaIzq.SelectedIndex].ToString()))
            {
                listaobjetosDer.Add(lo_lbxListaIzq.SelectedItem.ToString());
                listaBindeable2.ResetBindings();
                listaobjetosIzq.RemoveAt(lo_lbxListaIzq.SelectedIndex);
                listaBindeable.ResetBindings();
            }
            else
            {
                MessageBox.Show("ITEM INEXISTENTE EN TABLA A EXTRAER O YA EXISTENTE EN TABLA A ENVIAR", "ERROR");
            }
        }
        private void lo_btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (lo_lbxListaDer.SelectedIndex != -1 && !ExisteDuplicado(listaobjetosDer[lo_lbxListaDer.SelectedIndex].ToString()))
            {
                listaobjetosIzq.Add(lo_lbxListaDer.SelectedItem.ToString());
                listaBindeable.ResetBindings();
                listaobjetosDer.RemoveAt(lo_lbxListaDer.SelectedIndex);
                listaBindeable2.ResetBindings();
            }
            else
            {
                MessageBox.Show("ITEM INEXISTENTE EN TABLA A EXTRAER O YA EXISTENTE EN TABLA A ENVIAR","ERROR");
            }
        }
        private void lo_btnBorrar_Click(object sender, EventArgs e)
        {
            listaobjetosDer.RemoveAt(lo_lbxListaDer.SelectedIndex);
            listaBindeable2.ResetBindings();
        }
        private void ListaObjetos_Load(object sender, EventArgs e) //Enlazo los DataSource a su respectiva lista
        {
            listaBindeable = new BindingList<string>(listaobjetosIzq);
            listaBindeable2 = new BindingList<string>(listaobjetosDer);
            lo_lbxListaIzq.DataSource = listaBindeable;
            lo_lbxListaDer.DataSource = listaBindeable2;
        }
        private void lo_txtDato_KeyDown(object sender, KeyEventArgs e) //Detalle para poder ingresar datos con Enter
        {
            if (e.KeyCode == Keys.Enter)
            {
                lo_btnAgregar_Click(sender, e);
            }
        }
        
    }
}
