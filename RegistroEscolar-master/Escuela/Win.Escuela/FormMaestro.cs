using BL.Escuela;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Escuela
{
    public partial class FormMaestro : Form
    {
        MaestrosBL _maestros;
        ClasesBL _clases;
        GradosBL _gradosBL;

        public FormMaestro()
        {
            InitializeComponent();

            _maestros = new MaestrosBL();
            listaMaestrosBindingSource.DataSource = _maestros.ObtenerMaestros();

            _clases = new ClasesBL();
            listaClasesBindingSource.DataSource = _clases.ObtenerClases();

            _gradosBL = new GradosBL();
            listaGradosBindingSource.DataSource = _gradosBL.ObtenerGrados();
        }

        private void listaMaestrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaMaestrosBindingSource.EndEdit();
            var maestro = (Maestro)listaMaestrosBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                maestro.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                maestro.Foto = null;
            }

            var resultado1 = _maestros.GuardarMaestro(maestro);

            if (resultado1.Exitoso == true)
            {
                listaMaestrosBindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Maestro Guardado");
            }
            else
            {
                MessageBox.Show(resultado1.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _maestros.AgregarMaestro();
            listaMaestrosBindingSource.MoveLast();

            DeshabilitarHabilitarBotones(false);
        }

        private void DeshabilitarHabilitarBotones(bool valor)
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButtonCancelar.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado1 = MessageBox.Show("Desea eliminar este Maestro?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado1 == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }
            }
        }

        private void Eliminar(int id)
        {
            var resultado1 = _maestros.EliminarMaestro(id);

            if (resultado1 == true)
            {
                listaMaestrosBindingSource.ResetBindings(false);
            }
            else
            {
                MessageBox.Show("Ocurrio un error al eliminar el Maestro");
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            _maestros.CancelarCambios();
            DeshabilitarHabilitarBotones(true);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var maestro = (Maestro)listaMaestrosBindingSource.Current;

            if (maestro != null)
            {
                openFileDialog1.ShowDialog();
                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo); //obtener info del archivo(es una ruta)
                    var fileStream = fileInfo.OpenRead(); // lee el archivo 

                    fotoPictureBox.Image = Image.FromStream(fileStream);// se le asigna al picturebox
                }
            }
            else
            {
                MessageBox.Show("Cree un registro de maestro antes de asignar una imagen");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string buscar = textBox1.Text;

            if (buscar != "")
            {
                listaMaestrosBindingSource.DataSource = _maestros.ObtenerMaestros(buscar);
            }
            else
            {
                listaMaestrosBindingSource.DataSource = _maestros.ObtenerMaestros();
            }

            listaMaestrosBindingSource.ResetBindings(false);
        }
    }
}
