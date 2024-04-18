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
    public partial class Animadores : Form
    {
        public Animadores()
        {
            InitializeComponent();
            dataGridView1.DataSource = SentenciasSQL.DataGridAnimnador();
        }

        SentenciasSQL SentenciasSQL = new SentenciasSQL();

        private void btnoAnimador_Click(object sender, EventArgs e)
        {
            if (txtrut.Text != "" & txtnombre.Text != "" & cbdisfraz.SelectedIndex != -1)
            {
                SentenciasSQL.AgregarAnimador(Convert.ToString(txtrut.Text), txtnombre.Text, Convert.ToInt32(cbdisfraz.SelectedValue));
                MessageBox.Show("Animador ingresado con exito");
                dataGridView1.DataSource = SentenciasSQL.DataGridAnimnador();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");
            }
        }
        private void Animadores_Load(object sender, EventArgs e)
        {
            cbdisfraz.DataSource = SentenciasSQL.ComboDisfraz();
            cbdisfraz.DisplayMember = "personaje";
            cbdisfraz.ValueMember = "cod_disfraz";
            cbdisfraz.SelectedIndex = -1;
        }
    }
}
