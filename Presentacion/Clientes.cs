using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaDominio;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Presentacion
{
    public partial class Clientes : Form
    {
        public Clientes()
        {
            InitializeComponent();
            GridClientes.DataSource = sentencias.DataGridUsuarios();
        }

        DominioSentencias sentencias = new DominioSentencias();
        private void AgregarClientes_Click(object sender, EventArgs e)
        {
            if (txtDomicilio.Text != "" & txtNombre.Text != "" & txtrut.Text != "" & txtTelfono.Text != "")
            {
                sentencias.RegistrarUsuario(Convert.ToString(txtrut.Text), txtNombre.Text, Convert.ToString(txtDomicilio.Text), Convert.ToInt32(txtTelfono.Text));
                MessageBox.Show("Cliente ingresado con exito");
                GridClientes.DataSource = sentencias.DataGridUsuarios();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos solicitados");
            }

        }

        /* ----------------------------- IGNORAR ----------------------------- */
        private void Clientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtTelfono_TextChanged(object sender, EventArgs e)
        {
        }

        private void Clientes_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        /* ----------------------------- IGNORAR ----------------------------- */
        private void txtTelfono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) )
            {
                e.Handled = true; 
            }
        }
    }
}
