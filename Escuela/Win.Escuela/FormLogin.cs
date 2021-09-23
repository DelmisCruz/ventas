using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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

            if (usuario == "master" && contrasena == "123")
            {
                this.Close();
            }
            else
            {
                if (usuario1 == "estu" && contrasena1 == "456")
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
