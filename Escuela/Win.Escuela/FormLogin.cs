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
            string usuario;
            string contrasena;
            string usuario1;
            string contrasena1;

            usuario = textBox1.Text;
            contrasena = textBox2.Text;
            usuario1 = textBox1.Text;
            contrasena1 = textBox2.Text;

            var resultado = _seguridad.Autorizar(usuario, contrasena, usuario1, contrasena1);

            if (resultado == true)
            {
                this.Close();
            }
            else
            {
                if (resultado == true)
                {
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario  o contraseña Invalido");
                }
              
            }
 
        }
    }
}
