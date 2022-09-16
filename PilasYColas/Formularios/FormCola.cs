using PilasYColas.Clases;
using PilasYColas.Interfaz;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PilasYColas.Formularios
{
    public partial class FormCola : Form
    {
        private ListaColeccion coleccion;
        public FormCola()
        {
            InitializeComponent();
            coleccion = new Cola(20);
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtCola.Text))
            {
                object cola = txtCola.Text;
                if (coleccion.Aniadir(cola))
                {
                    lstColas.Items.Add((string)cola);
                    MessageBox.Show("Se agrego la cola exitosamente a la coleccion!!!", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("LISTA LLENA!", "cola", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtCola.Text = " ";
            txtCola.Focus();
        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!coleccion.Vacia())
            {
                MessageBox.Show("El Primer Elemento es " + coleccion.Primero());
            }
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            object cola = coleccion.Extraer();
            lstColas.Items.Remove(cola);
        }

        private void btnVacia_Click(object sender, EventArgs e)
        {
            string Mensaje = coleccion.Vacia() ? "COLA VACIA" : "COLA CON ELEMENTOS";
            MessageBox.Show(Mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void FormCola_Load(object sender, EventArgs e)
        {

        }
    }
}
