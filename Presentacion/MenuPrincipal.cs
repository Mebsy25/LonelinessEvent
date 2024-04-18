namespace Presentacion
{
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
            btnCerrarform.Visible = false;
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Clientes";
            // Crear instancia del formu;lario
            Clientes formulario = new Clientes();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void btnCerrarform_Click(object sender, EventArgs e)
        {
            btnCerrarform.Visible = false;
            panelForms.Controls.Clear();
            panelForms.Controls.Add(logopanel);
            logopanel.Visible = true;
            labeltitulo.Text = "HOME";
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pbCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPresentadores_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Presentadores";

            // Crear instancia del formu;lario
            Presentadores formulario = new Presentadores();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void btnAnimadores_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Animadores";

            // Crear instancia del formu;lario
            Animadores formulario = new Animadores();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void btnDisfraz_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Disfraces";

            // Crear instancia del formu;lario
            Disfraces formulario = new Disfraces();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void labeltitulo_Click(object sender, EventArgs e)
        {

        }

        private void btnEvento_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Eventos";

            // Crear instancia del formu;lario
            Eventos formulario = new Eventos();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }

        private void btnContrato_Click(object sender, EventArgs e)
        {
            panelForms.Controls.Clear();
            btnCerrarform.Visible = true;
            logopanel.Visible = false;
            labeltitulo.Text = "Administrar Contratos";

            // Crear instancia del formu;lario
            Contratos_ formulario = new Contratos_();

            // Establecer el panel como control principal del formulario
            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None;
            formulario.Dock = DockStyle.Fill;

            // Agregar el formulario al panel
            panelForms.Controls.Add(formulario);
            panelForms.Tag = formulario;

            // Mostrar el formulario
            formulario.Show();
        }
    }
}
