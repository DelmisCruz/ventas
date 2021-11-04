using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class MaestrosBL
    {
        Contexto _contexto;
        public BindingList<Maestro> ListaMaestros { get; set; }

        public MaestrosBL()
        {
            _contexto = new Contexto();
            ListaMaestros = new BindingList<Maestro>();
        }
        public BindingList<Maestro> ObtenerMaestros()
        {
            _contexto.Maestros.Load();
            ListaMaestros = _contexto.Maestros.Local.ToBindingList();

            return ListaMaestros;
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado1 GuardarMaestro(Maestro maestro)
        {
            var resultado1 = validar(maestro);
            if (resultado1.Exitoso == false)
            {
                return resultado1;
            }

            _contexto.SaveChanges();

            resultado1.Exitoso = true;
            return resultado1;
        }

        public void AgregarMaestro()
        {
            var nuevoMaestro = new Maestro();
            ListaMaestros.Add(nuevoMaestro);
        }

        public bool EliminarMaestro(int id)
        {
            foreach (var maestro in ListaMaestros)
            {
                if (maestro.Id == id)
                {
                    ListaMaestros.Remove(maestro);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado1 validar(Maestro maestro)
        {
            var resultado1 = new Resultado1();
            resultado1.Exitoso = true;

            if (maestro == null) 
            {
                resultado1.Mensaje = "Agregue un maestro valido";
                resultado1.Exitoso = false;

                return resultado1;
            }

            if (string.IsNullOrEmpty(maestro.Cedula) == true)
            {
                resultado1.Mensaje = "Ingrese un numero de cedula";
                resultado1.Exitoso = false;
            }
            if (string.IsNullOrEmpty(maestro.Nombre) == true)
            {
                resultado1.Mensaje = "Ingrese un Nombre";
                resultado1.Exitoso = false;
            }
            if (string.IsNullOrEmpty(maestro.Direccion) == true)
            {
                resultado1.Mensaje = "Ingrese una Direccion";
                resultado1.Exitoso = false;
            }
            if (string.IsNullOrEmpty(maestro.Celular) == true)
            {
                resultado1.Mensaje = "Ingrese un numero celular";
                resultado1.Exitoso = false;
            }
            if (string.IsNullOrEmpty(maestro.Correo) == true)
            {
                resultado1.Mensaje = "Ingrese un correo valido";
                resultado1.Exitoso = false;
            }

            if (maestro.Edad <= 0)
            {
                resultado1.Mensaje = "La edad no debe ser menor que cero";
                resultado1.Exitoso = false;
            }
            if (maestro.ClaseId <= 0)
            {
                resultado1.Mensaje = "Seleccione una Clase";
                resultado1.Exitoso = false;
           }

            if (maestro.GradoId == 0)
            {
                resultado1.Mensaje = "Seleccione un Grado";
                resultado1.Exitoso = false;
            }

            return resultado1;
        }
    }
    
    public class Maestro
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; } //especial
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int GradoId { get; set; }
        public Grado Grado { get; set; }
        public int ClaseId { get; set; }
        public Clase Clase { get; set; }
        public bool Activo { get; set; }
    }

    public class Resultado1
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
