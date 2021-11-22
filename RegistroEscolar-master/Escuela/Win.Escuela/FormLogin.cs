using BL.Escuela;
using System;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormLogin : Form
    {
        SeguridadBL _seguridad;

        public FormLogin()
        {
            InitializeComponent();

            _seguridad = new SeguridadBL();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            string usuario;
            string contrasena;
            string usuario1;
            string contrasena1;

            button1.Enabled = false;
            button1.Text = "Verificando...";
            Application.DoEvents();

            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            usuario1 = textBox1.Text;
            contrasena1 = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena, usuario1, contrasena1);

            if (resultado != null)
            {
                Utilidades.NombreUsuario = resultado.Nombre;
                this.Close();
            }
            else
            {
                    MessageBox.Show("Usuario  o contraseña Invalido");
            }
            button1.Enabled = true;
            button1.Text = "Aceptar";
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter) && !string.IsNullOrEmpty(textBox1.Text))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && e.KeyChar == (char)Keys.Enter)
            {
                Login();
            }
        }
    }
}
