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
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea salir de la aplicación?",
                           "SALIENDO",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormPila formVentana = new FormPila();
            formVentana.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormCola formVentana = new FormCola();
            formVentana.ShowDialog();
        }
    }
}
