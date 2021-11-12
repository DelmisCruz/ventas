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
    public partial class FormReporteFacturasMaestros : Form
    {
        public FormReporteFacturasMaestros()
        {
            InitializeComponent();

            var _facturas1BL = new FacturaBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _facturas1BL.ObtenerFacturas();

            var reporte = new ReporteFacturasMaestros();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
