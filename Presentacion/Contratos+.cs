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
    public partial class Contratos_ : Form
    {
        public Contratos_()
        {
            InitializeComponent();
            dataGridView1.DataSource = SentenciasSQL.ObtenerContratos();
        }

        SentenciasSQL SentenciasSQL = new SentenciasSQL();
        private void AgregarContrato_Click(object sender, EventArgs e)
        {
            if (cbClientes.SelectedIndex != -1 & cbEventos.SelectedIndex != -1 & txtlugar.Text != "" & txtmetododepago.Text != ""  & txtpreciofinal.Text != "")
            {
                SentenciasSQL.IngresarContrato(Convert.ToString(cbClientes.SelectedValue), Convert.ToInt32(cbEventos.SelectedValue), txtlugar.Text, Convert.ToInt32(txtpreciofinal.Text), txtmetododepago.Text);
                dataGridView1.DataSource = SentenciasSQL.ObtenerContratos();
                MessageBox.Show("Contrato ingresado con exito");

            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");

            }
        }

        private void Contratos__Load(object sender, EventArgs e)
        {
            cbClientes.DataSource = SentenciasSQL.ComboBoxClientes();
            cbClientes.DisplayMember = "nombre_completo";
            cbClientes.ValueMember = "cod_clientes";
            cbClientes.SelectedIndex = -1;

            cbEventos.DataSource = SentenciasSQL.ComboBoxEventos();
            cbEventos.DisplayMember = "descripcion";
            cbEventos.ValueMember = "cod_evento";
            cbEventos.SelectedIndex = -1;
        }
    }
}
