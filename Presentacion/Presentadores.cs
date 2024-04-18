using System;
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
    public partial class Presentadores : Form
    {
        public Presentadores()
        {
            InitializeComponent();
            GridPresentadores.DataSource = query.DataGridPresentadores();
        }
        SentenciasSQL query = new SentenciasSQL();

        private void AgregarClientes_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text != "" & txtrut.Text != "")
            {
                query.AgregarPresentador(Convert.ToString(txtrut.Text), txtNombre.Text, dateTimePicker1.Value);
                MessageBox.Show("Presentador ingresado con exito");
                GridPresentadores.DataSource = query.DataGridPresentadores();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
