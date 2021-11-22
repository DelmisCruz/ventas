using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Escuela
{
    public class EstudiantesBL
    {
        Contexto _contexto;
        public BindingList<Estudiante> ListaEstudiantes { get; set; }

        public EstudiantesBL()
        {
            _contexto = new Contexto();
            ListaEstudiantes = new BindingList<Estudiante>();
        }

        public BindingList<Estudiante> ObtenerEstudiantes()
        {
            _contexto.Estudiantes.Load();
            ListaEstudiantes = _contexto.Estudiantes.Local.ToBindingList();

            return ListaEstudiantes;
        }

        public BindingList<Estudiante> ObtenerEstudiantes(string buscar)
        {
            var resultado = _contexto.Estudiantes.Where(r => r.Nombre.Contains(buscar));

            return new BindingList<Estudiante>(resultado.ToList());
        }

        public void CancelarCambios()
        {
            foreach (var item in _contexto.ChangeTracker.Entries())
            {
                item.State = EntityState.Unchanged;
                item.Reload();
            }
        }

        public Resultado GuardarEstudiante(Estudiante estudiante)
        {
            var resultado = Validar(estudiante);
            if (resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges(); // el contexto representa nuestra bd

            resultado.Exitoso = true;
            return resultado;
        }

        public void AgregarEstudiante()
        {
            var nuevoEstudiante = new Estudiante();
            ListaEstudiantes.Add(nuevoEstudiante);
        }

        public bool EliminarEstudiante(int id)
        {
            foreach (var estudiante in ListaEstudiantes)
            {
                if (estudiante.Id == id)
                {
                    ListaEstudiantes.Remove(estudiante);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Estudiante estudiante)
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if (estudiante == null) // agregarla a maestros
            {
                resultado.Mensaje = "Agregue un estudiante valido";
                resultado.Exitoso = false;

                return resultado;
            }

            if (string.IsNullOrEmpty(estudiante.Cedula) == true)
            {
                resultado.Mensaje = "Ingrese un numero de cedula";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Nombre) == true)
            {
                resultado.Mensaje = "Ingrese un Nombre";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Celular) == true)
            {
                resultado.Mensaje = "Ingrese un numero celular";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Correo) == true)
            {
                resultado.Mensaje = "Ingrese un correo valido";
                resultado.Exitoso = false;
            }

            if (estudiante.Edad <= 0)
            {
                resultado.Mensaje = "La edad no debe ser menor que cero";
                resultado.Exitoso = false;
            }
            if (string.IsNullOrEmpty(estudiante.Direccion) == true)
            {
                resultado.Mensaje = "Ingrese una Direccion";
                resultado.Exitoso = false;
            }

            if (estudiante.GradoId == 0)
            {
                resultado.Mensaje = "Seleccione un Grado";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }

    public class Estudiante
    {
        public int Id { get; set; }
        public byte[] Foto { get; set; } //especial
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public string Celular { get; set; }
        public string Correo { get; set; }
        public int GradoId { get; set; }
        public Grado Grado  { get; set; }
        public string Direccion { get; set; }
        public bool Activo { get; set; }

    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}
