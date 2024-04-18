using CapaDominio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "")
            {
                if (txtPass.Text != "")
                {
                    DominioAdministrador user = new DominioAdministrador();
                    var LoginValido = user.LoginUser(txtUsuario.Text, txtPass.Text);
                    if (LoginValido == true)
                    {
                        MenuPrincipal Menu = new MenuPrincipal();
                        Menu.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Contraseña incorrectos. ");
                        txtPass.Clear();
                        txtUsuario.Focus();
                    }
                }
                else CampoIncompleto("Contraseña");
            }
            else CampoIncompleto("usuario");
        }
        private void CampoIncompleto(string msg)
        {
            MessageBox.Show("Campo " + msg + " Incompleto");
        }
    }
}