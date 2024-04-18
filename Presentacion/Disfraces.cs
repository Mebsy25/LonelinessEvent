using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDatos;


namespace Presentacion
{
    public partial class Disfraces : Form
    {
        public Disfraces()
        {
            InitializeComponent();
            gridisfraz.DataSource = SentenciasSQL.DataGridDisfraz();

        }

        SentenciasSQL SentenciasSQL = new SentenciasSQL();

        private void AgregarClientes_Click(object sender, EventArgs e)
        {
            if (txtpersonaje.Text != "" & txtprecio.Text != "")
            {
                SentenciasSQL.AgregarDisfraz(txtpersonaje.Text, Convert.ToInt32(txtprecio.Text));
                MessageBox.Show("Disfraz ingresado con exito");
                gridisfraz.DataSource = SentenciasSQL.DataGridDisfraz();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");

            }

        }
    }
}