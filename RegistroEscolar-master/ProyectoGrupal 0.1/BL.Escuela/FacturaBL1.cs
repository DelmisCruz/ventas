using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class FacturaBL1
    {
        Contexto _contexto;

        public BindingList<Factura1> ListaFacturas1 { get; set; }

        public FacturaBL1()
        {
            _contexto = new Contexto();
        }

        public BindingList<Factura1> ObtenerFacturas()
        {
            _contexto.Facturas1.Include("FacturaDetalle1").Load();
            ListaFacturas1 = _contexto.Facturas1.Local.ToBindingList();

            return ListaFacturas1;
        }

        public void AgregarFactura()
        {
            var nuevaFactura1 = new Factura1();
            _contexto.Facturas1.Add(nuevaFactura1);
        }

        public void AgregarFacturaDetalle(Factura1 factura1)
        {
            if (factura1 != null)
             {
                  var nuevoDetalle = new FacturaDetalle1();
                  factura1.FacturaDetalle1.Add(nuevoDetalle);
             }
        }

        public void RemoverFacturaDetalle(Factura1 factura1, FacturaDetalle1 facturaDetalle1)
        {
            if (factura1 != null && facturaDetalle1 != null)
            {
                factura1.FacturaDetalle1.Remove(facturaDetalle1);
            }
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarFactura(Factura1 factura1)
        {
            var resultado = Validar(factura1);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }
            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        private Resultado Validar(Factura1 factura1)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (factura1 == null)
            {
                resultado.Mensaje = "Agregue una factura para poderla salvar";
                resultado.Exitoso = false;

                return resultado;
            }

            if (factura1.Id != 0 && factura1.Activo == true)
            {
                resultado.Mensaje = "La factura ya fue emitida y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (factura1.Activo == false)
            {
                resultado.Mensaje = "La factura esta anulada y no se pueden realizar cambios en ella";
                resultado.Exitoso = false;
            }

            if (factura1.MaestroId == 0)
            {
                resultado.Mensaje = "Seleccione un Maestro";
                resultado.Exitoso = false;
            }

            if (factura1.FacturaDetalle1.Count == 0)
            {
                resultado.Mensaje = "Agregue detalles a la factura";
                resultado.Exitoso = false;
            }

            foreach (var detalle in factura1.FacturaDetalle1)
            {
                if (detalle.ClaseId == 0)
                {
                    resultado.Mensaje = "Seleccione una clase valida";
                    resultado.Exitoso = false;
                }
            }

            return resultado;

        }

        public void CalcularFactura(Factura1 factura1)
        {
            if (factura1 != null)
            {
                double subtotal = 0;

                foreach (var detalle in factura1.FacturaDetalle1)
                {
                    var clase = _contexto.Clases.Find(detalle.ClaseId);
                    if (clase != null)
                    {
                        detalle.Pago = clase.Pago;
                        detalle.Total = detalle.Cantidad * clase.Pago + detalle.Extra;

                        subtotal += detalle.Total;
                    }
                }
                factura1.Subtotal = subtotal;
                factura1.Impuesto = subtotal * 0.15;
                factura1.Total = subtotal + factura1.Impuesto;
            }
        }

        public bool AnularFactura1(int id)
        {
            foreach (var factura1 in ListaFacturas1)
            {
                if (factura1.Id == id)
                {
                    factura1.Activo = false;
                    _contexto.SaveChanges();
                    return true;
                }
            }

            return false;
        }
    }

    public class Factura1
    {
        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public int MaestroId { get; set; }
        public Maestro Maestro { get; set; }
        public BindingList<FacturaDetalle1> FacturaDetalle1 { get; set; }
        public double Subtotal { get; set; }
        public double Impuesto { get; set; }
        public double Total { get; set; }
        public bool Activo { get; set; }

        public Factura1()
        {
            Fecha = DateTime.Now;
            FacturaDetalle1 = new BindingList<FacturaDetalle1>();
            Activo = true;
        }
    }

    public class FacturaDetalle1
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
        public int ClaseId { get; set; }
        public Clase Clase { get; set; }
        public int Cantidad { get; set; }
        public double Pago { get; set; }
        public double Extra { get; set; }
        public double Total { get; set; }

        public FacturaDetalle1()
        {
            Cantidad = 1;
        }
    }
}
