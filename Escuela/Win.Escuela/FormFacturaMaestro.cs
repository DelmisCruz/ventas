using BL.Escuela;
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
    public partial class FormFacturaMaestro : Form
    {
        FacturaBL1 _facturaBL1;
        MaestrosBL _maestrosBL;
        ClasesBL _clasesBL;


        public FormFacturaMaestro()
        {
            InitializeComponent();

            _facturaBL1 = new FacturaBL1();
            listaFacturas1BindingSource.DataSource = _facturaBL1.ObtenerFacturas();

            _maestrosBL = new MaestrosBL();
            listaMaestrosBindingSource.DataSource = _maestrosBL.ObtenerMaestros();

            _clasesBL = new ClasesBL();
            listaClasesBindingSource.DataSource = _clasesBL.ObtenerClases();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            _facturaBL1.AgregarFactura();
            listaFacturas1BindingSource.MoveLast();

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

        private void listaFacturas1BindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            listaFacturas1BindingSource.EndEdit();

            var factura1 = (Factura1)listaFacturas1BindingSource.Current;
            var resultado = _facturaBL1.GuardarFactura(factura1);

            if (resultado.Exitoso == true)
            {
                listaFacturas1BindingSource.ResetBindings(false);
                DeshabilitarHabilitarBotones(true);
                MessageBox.Show("Factura Guardada");
            }
            else
            {
                MessageBox.Show(resultado.Mensaje);
            }
        }

        private void toolStripButtonCancelar_Click(object sender, EventArgs e)
        {
            DeshabilitarHabilitarBotones(true);
            _facturaBL1.CancelarCambios();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var factura1 = (Factura1)listaFacturas1BindingSource.Current;

            _facturaBL1.AgregarFacturaDetalle(factura1);

            DeshabilitarHabilitarBotones(false);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var factura1 = (Factura1)listaFacturas1BindingSource.Current;
            var facturaDetalle1 = (FacturaDetalle1)facturaDetalle1BindingSource.Current;

            _facturaBL1.RemoverFacturaDetalle(factura1, facturaDetalle1);

            DeshabilitarHabilitarBotones(false);
        }

        private void facturaDetalle1DataGridView_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.ThrowException = false; // para que no genere error
        }

        private void facturaDetalle1DataGridView_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            var factura1 = (Factura1)listaFacturas1BindingSource.Current;
            _facturaBL1.CalcularFactura(factura1);

            listaFacturas1BindingSource.ResetBindings(false);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("Desea anular esta factura?", "Anular", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Anular(id);
                }
            }
        }

        private void Anular(int id)
        {
            var resultado = _facturaBL1.AnularFactura1(id);

            if (resultado == true)
            {
                listaFacturas1BindingSource.ResetBindings(false);
            }

            else
            {
                MessageBox.Show("Ocurrio un error al anular la factura");
            }
        }

        private void listaFacturas1BindingSource_CurrentChanged(object sender, EventArgs e)
        {
            var factura1 = (Factura1)listaFacturas1BindingSource.Current;

            if (factura1 != null && factura1.Id != 0 && factura1.Activo == false)
            {
                label1.Visible = true;
            }
            else
            {
                label1.Visible = false;
            }
        }
    }
}
