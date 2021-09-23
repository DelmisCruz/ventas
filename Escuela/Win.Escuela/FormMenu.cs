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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login();
        }

        private void Login()
        {
            var formLogin = new FormLogin();
            formLogin.ShowDialog();
        }

        private void estudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formEstudiante = new FormEstudiante();
            formEstudiante.MdiParent = this;
            formEstudiante.Show();
        }

        private void maestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMaestro = new FormMaestro();
            formMaestro.MdiParent = this;
            formMaestro.Show();
        }

        private void matriculaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formMatricula = new FormMatricula();
            formMatricula.MdiParent = this;
            formMatricula.Show();
        }

        private void FormMenu_Load(object sender, EventArgs e)
       {
           Login();
       }
    }
}
