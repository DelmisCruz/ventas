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
    public partial class FormReporteMaestros : Form
    {
        public FormReporteMaestros()
        {
            InitializeComponent();

            var _maestrosBL = new MaestrosBL();
            var bindingSource = new BindingSource();
            bindingSource.DataSource = _maestrosBL.ObtenerMaestros();

            var reporte = new ReporteMaestros();
            reporte.SetDataSource(bindingSource);

            crystalReportViewer1.ReportSource = reporte;
            crystalReportViewer1.RefreshReport();
        }
    }
}
