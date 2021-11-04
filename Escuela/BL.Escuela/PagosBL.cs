using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class PagosBL
    {
        Contexto _contexto;
        public BindingList<Pago> ListaPagos { get; set; }

        public PagosBL()
        {
            _contexto = new Contexto();
            ListaPagos = new BindingList<Pago>();
        }

        public BindingList<Pago> ObtenerPagos()
        {
            _contexto.Pagos.Load();
            ListaPagos = _contexto.Pagos.Local.ToBindingList();

            return ListaPagos;
        }
    }
    public class Pago
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int Precio { get; set; }
    }
}

