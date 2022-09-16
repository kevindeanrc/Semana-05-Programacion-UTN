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
    public partial class FormPila : Form
    {
        private ListaColeccion coleccion;
        public FormPila()
        {
            InitializeComponent();
            coleccion = new Pila(20);
            
        }

        private void btnAniadir_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtPilas.Text))
            {
                object pila = txtPilas.Text;
                if (coleccion.Aniadir(pila))
                {
                    lstPilas.Items.Add((string)pila);
                    MessageBox.Show("Se agrego la pila a la coleccion", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Lista Llena", "Pila", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            txtPilas.Text = " ";
            txtPilas.Focus();
        }

        private void FormPila_Load(object sender, EventArgs e)
        {

        }

        private void btnPrimero_Click(object sender, EventArgs e)
        {
            if (!coleccion.Vacia())
            {
                MessageBox.Show("El Primer Elemento es " + coleccion.Primero());
            }
        }

        private void btnVacia_Click(object sender, EventArgs e)
        {
            string Mensaje = coleccion.Vacia() ? "Pila Vacia" : "Pila Con Elementos";
            MessageBox.Show(Mensaje, "Elemento", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnExtraer_Click(object sender, EventArgs e)
        {
            object Pila = coleccion.Extraer();
            lstPilas.Items.Remove(Pila);
        }
    }
}
