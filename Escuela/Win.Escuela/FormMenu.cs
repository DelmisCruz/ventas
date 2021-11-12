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

        private void facturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFactura = new FormFactura();
            formFactura.MdiParent = this;
            formFactura.Show();
        }

        private void facturaMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formFacturaMaestro = new FormFacturaMaestro();
            formFacturaMaestro.MdiParent = this;
            formFacturaMaestro.Show();
        }

        private void reporteDeEstudianteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteEstudiantes = new FormReporteEstudiantes();
            formReporteEstudiantes.MdiParent = this;
            formReporteEstudiantes.Show();
        }

        private void reporteDeFacturaDeEstudiantesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturasEstudiantes = new FormReporteFacturasEstudiantes();
            formReporteFacturasEstudiantes.MdiParent = this;
            formReporteFacturasEstudiantes.Show();
        }

        private void reporteDeFacturasDeMaestrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteFacturasMaestros = new FormReporteFacturasMaestros();
            formReporteFacturasMaestros.MdiParent = this;
            formReporteFacturasMaestros.Show();
        }

        private void reporteDeMaestroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var formReporteMaestros = new FormReporteMaestros();
            formReporteMaestros.MdiParent = this;
            formReporteMaestros.Show();
        }
    }

}
