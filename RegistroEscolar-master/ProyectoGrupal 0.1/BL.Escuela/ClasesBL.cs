using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class ClasesBL
    {
        Contexto _contexto;
        public BindingList<Clase> ListaClases { get; set; }

        public ClasesBL()
        {
            _contexto = new Contexto();
            ListaClases = new BindingList<Clase>();
        }

        public BindingList<Clase> ObtenerClases()
        {
            _contexto.Clases.Load();
            ListaClases = _contexto.Clases.Local.ToBindingList();

            return ListaClases;
        }
    }
    public class Clase
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public double Pago { get; set; }
    }
}
