using CapaDatos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Eventos : Form
    {
        public Eventos()
        {
            InitializeComponent();
            cbAnimador.Enabled = false;
            dataGridView1.DataSource = SentenciasSQL.DataGrideEventos();
        }

        SentenciasSQL SentenciasSQL = new SentenciasSQL();

        private void AgregarEvento_Click(object sender, EventArgs e)
        {
            if (txtInfo.Text != "" & txtprecio.Text != "" & txthorario.Text != "" & cbPresentador.SelectedIndex != -1 )
            {
                if (checkBox1.Checked & cbAnimador.SelectedIndex != -1)
                {
                    SentenciasSQL.IngresarEvento(txtInfo.Text, Convert.ToInt32(txtprecio.Text), txthorario.Text, Convert.ToInt32(cbPresentador.SelectedValue), Convert.ToInt32(cbAnimador.SelectedValue));
                    MessageBox.Show("Evento ingresado con exito");
                    dataGridView1.DataSource = SentenciasSQL.DataGrideEventos();

                }
                else
                {
                    SentenciasSQL.IngresarEvento2(txtInfo.Text, Convert.ToInt32(txtprecio.Text), txthorario.Text, Convert.ToInt32(cbPresentador.SelectedValue));
                    MessageBox.Show("Evento ingresado con exito");
                    dataGridView1.DataSource = SentenciasSQL.DataGrideEventos();

                }
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");
            }

        }

        private void Eventos_Load(object sender, EventArgs e)
        {
            cbAnimador.DataSource = SentenciasSQL.ComboAnimador();
            cbAnimador.DisplayMember = "apellidos";
            cbAnimador.ValueMember = "cod_animador";
            cbAnimador.SelectedIndex = -1;

            cbPresentador.DataSource = SentenciasSQL.ComboPresentador();
            cbPresentador.DisplayMember = "apellidos";
            cbPresentador.ValueMember = "cod_presentador";
            cbPresentador.SelectedIndex = -1;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            cbAnimador.Enabled = checkBox1.Checked;
        }
    }
}
